// #define IGNORE_CS0695
#define IMPLICT_SCALAR_TO_UNIT

using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Numerics;
using System;

namespace Unknown6656.Units;


////////////////////////////////////////////////////////////////////////////////////////////////
///                                                                                          ///
/// THIS ENTIRE CODE BASE WILL ENORMOUSLY BENEFIT FROM C# 13 "SHAPES AND EXTENSIONS" FEATURE ///
///                                                                                          ///
////////////////////////////////////////////////////////////////////////////////////////////////


public enum UnitSystem
{
    Metric,
    MetricNoPrefixes,
    Imperial,
}

public interface IUnit
{
    public static abstract string UnitSymbol { get; }
    public static abstract UnitSystem UnitSystem { get; }
}

public interface IUnit<TUnit, TBaseUnit, TScalar>
    where TUnit : class, IUnit<TUnit, TBaseUnit, TScalar>, IUnit
    where TBaseUnit : class, IBaseUnit<TBaseUnit, TScalar>, IUnit
    where TScalar : INumber<TScalar>
{
    public TBaseUnit ToBaseUnit();

    public static abstract TUnit FromBaseUnit(TBaseUnit base_unit);
}

public interface IBaseUnit<TBaseUnit, TScalar>
    : IUnit<TBaseUnit, TBaseUnit, TScalar>
    where TBaseUnit : class, IBaseUnit<TBaseUnit, TScalar>, IUnit
    where TScalar : INumber<TScalar>
{
}

public enum SIUnitScale
    : int
{
    Base_1000 = 1000,
    Base_1024 = 1024,
}

internal static class Unit
{
    public static IReadOnlyList<string> MetricSIPrefixesMultiple { get; } = ["k", "M", "G", "T", "P", "E", "Z", "Y", "R", "Q"];
    public static IReadOnlyList<string> MetricSIPrefixesSubmultiple { get; } = ["m", "μ", "n", "p", "f", "a", "z", "y", "r", "q"];
    public static NumberFormatInfo DefaultNumberFormat => new()
    {
        CurrencyDecimalSeparator = ".",
        NumberDecimalSeparator = ".",
        PercentDecimalSeparator = ".",
        CurrencyGroupSeparator = "'",
        NumberGroupSeparator = "'",
        PercentGroupSeparator = "'",
        CurrencyDecimalDigits = 2,
        PercentDecimalDigits = 2,
        NumberDecimalDigits = 3,
        PercentSymbol = "%",
        PerMilleSymbol = "‰",
        NaNSymbol = "NaN",
    };


    public static string FormatImperial<TScalar>(TScalar scalar, string? unit_symbol, string? format, IFormatProvider? format_provider)
        where TScalar : INumber<TScalar>
    {
        string formatted = scalar?.ToString(format ?? "N", format_provider ?? DefaultNumberFormat) ?? "0";

        return !string.IsNullOrWhiteSpace(unit_symbol) ? $"{formatted} {unit_symbol}" : formatted;
    }

    public static string FormatMetricSIPrefix<TScalar>(TScalar value, string? unit_symbol, string? format, IFormatProvider? format_provider, SIUnitScale scale = SIUnitScale.Base_1000)
        where TScalar : INumber<TScalar>
    {
        if (string.IsNullOrWhiteSpace(unit_symbol))
            return FormatImperial(value, null, format, format_provider);

        TScalar @base = TScalar.CreateChecked((int)scale);
        bool negative = value < TScalar.Zero;
        int order = -1;

        value = TScalar.Abs(value);

        bool submultiple = value < TScalar.One;
        IReadOnlyList<string> prefixes = submultiple ? MetricSIPrefixesSubmultiple : MetricSIPrefixesMultiple;

        while (value != TScalar.Zero && (submultiple ? value < TScalar.One : value >= @base) && order < prefixes.Count - 1)
        {
            ++order;

            if (submultiple)
                value *= @base;
            else
                value /= @base;
        }

        if (negative)
            value = -value;

        return FormatImperial(
            value,
            (order < 0 ? "" : prefixes[order]) + (scale == SIUnitScale.Base_1024 ? "i" : "") + unit_symbol,
            format,
            format_provider
        );
    }

    public static bool TryParse<TScalar>(string? value, IFormatProvider? provider, [MaybeNullWhen(false), NotNullWhen(true)] out TScalar? scalar, SIUnitScale scale = SIUnitScale.Base_1000)
        where TScalar : INumber<TScalar>
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            scalar = TScalar.Zero;

            return true;
        }
        else if (TScalar.TryParse(value, provider, out scalar))
            return true;
        else
        {
#warning TODO : parse prefixes (e.g. "1.5 kV" -> 1500 V, "200 MiB" -> 209'715'200 B)
        }

        return false;
    }
}

public abstract record AbstractUnit<TUnit, TBaseUnit, TScalar>(TScalar Value)
    : IAdditionOperators<TUnit, TUnit, TUnit>
    , ISubtractionOperators<TUnit, TUnit, TUnit>
    , IDivisionOperators<TUnit, TUnit, TScalar>
    , IMultiplyOperators<TUnit, TScalar, TUnit>
#if IGNORE_CS0695
    , IMultiplyOperators<TScalar, TUnit, TUnit>
    , IDivisionOperators<TUnit, TScalar, TUnit>
#endif
    , IUnaryNegationOperators<TUnit, TUnit>
    , IUnaryPlusOperators<TUnit, TUnit>
    , IIncrementOperators<TUnit>
    , IDecrementOperators<TUnit>
    , IFormattable
    , IParsable<TUnit>
    where TUnit : AbstractUnit<TUnit, TBaseUnit, TScalar>
                , IUnit<TUnit, TBaseUnit, TScalar>
                , IUnit
    where TBaseUnit : AbstractUnit<TBaseUnit, TBaseUnit, TScalar>
                    , IBaseUnit<TBaseUnit, TScalar>
                    , IUnit
    where TScalar : INumber<TScalar>
{
    private static readonly Func<TScalar, TUnit> _constructor;

    public static TUnit Zero { get; }

    public static TUnit One { get; }


    static AbstractUnit()
    {
        Type @this = typeof(TUnit);
        bool is_quantity = @this.IsAssignableTo(typeof(IQuantity));
        ConstructorInfo? constructor = @this.GetConstructor([is_quantity ? typeof(TBaseUnit) : typeof(TScalar)]);
        InvalidProgramException ex = new(
            is_quantity ? $"The unit type '{@this}' does not have a constructor with a single parameter of type '{typeof(TScalar)}'."
                        : $"The quantity '{@this}' does not have a constructor with a single parameter of type '{typeof(TBaseUnit)}'."
        );

        if (constructor is null)
            throw ex;

        _constructor = s => constructor.Invoke([is_quantity ? AbstractUnit<TBaseUnit, TBaseUnit, TScalar>.FromScalar(s) : s]) as TUnit ?? throw ex;
        Zero = _constructor(TScalar.Zero);
        One = _constructor(TScalar.One);
    }

    #region TOSTRING / PARSING

    public sealed override string ToString() => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider) => ToString(format, formatProvider, SIUnitScale.Base_1000);

    public string ToString(string? format, IFormatProvider? formatProvider, SIUnitScale scale)
    {
        if (TUnit.UnitSystem is UnitSystem.Metric)
            return Unit.FormatMetricSIPrefix(Value, TUnit.UnitSymbol, format, formatProvider, scale);
        else
            return Unit.FormatImperial(Value, TUnit.UnitSymbol, format, formatProvider);
    }

    public static TUnit Parse(string s, IFormatProvider? provider) => Parse(s, provider, SIUnitScale.Base_1000);

    public static TUnit Parse(string s, IFormatProvider? provider, SIUnitScale scale) =>
        TryParse(s, provider, out TUnit? result, scale) ? result : throw new FormatException($"The string '{s}' ({s.Length} char(s)) could not be parsed to a valid instance of {typeof(TUnit)} or {typeof(TScalar)}.");

    public static bool TryParse(string? s, IFormatProvider? provider, [MaybeNullWhen(false), NotNullWhen(true)] out TUnit? result) =>
        TryParse(s, provider, out result, SIUnitScale.Base_1000);

    public static bool TryParse(string? s, IFormatProvider? provider, [MaybeNullWhen(false), NotNullWhen(true)] out TUnit? result, SIUnitScale scale)
    {
        if (Unit.TryParse(s, provider, out TScalar? scalar, scale))
        {
            result = FromScalar(scalar);

            return true;
        }
        else
        {
            result = null;

            return false;
        }
    }

    #endregion

    public abstract TBaseUnit ToBaseUnit();

    public static TUnit FromScalar(TScalar value) => _constructor(value);

    #region CASTING / CONVERSION OPERATORS

    public static implicit operator TBaseUnit(AbstractUnit<TUnit, TBaseUnit, TScalar> unit) => unit.ToBaseUnit();

    public static implicit operator AbstractUnit<TUnit, TBaseUnit, TScalar>(TBaseUnit base_unit) => TUnit.FromBaseUnit(base_unit);

#if IMPLICT_SCALAR_TO_UNIT
    public static implicit
#else
    public static explicit
#endif
        operator AbstractUnit<TUnit, TBaseUnit, TScalar>(TScalar value) => FromScalar(value);

    public static implicit operator TUnit(AbstractUnit<TUnit, TBaseUnit, TScalar> unit) => unit as TUnit ?? FromScalar(unit.Value);

    public static explicit operator TScalar(AbstractUnit<TUnit, TBaseUnit, TScalar> unit) => unit.Value;

    #endregion
    #region ARITHMETIC OPERATORS

    public static TUnit operator +(AbstractUnit<TUnit, TBaseUnit, TScalar> left, AbstractUnit<TUnit, TBaseUnit, TScalar> right) => FromScalar(left.Value + right.Value);

    public static TUnit operator -(AbstractUnit<TUnit, TBaseUnit, TScalar> left, AbstractUnit<TUnit, TBaseUnit, TScalar> right) => FromScalar(left.Value - right.Value);

    public static TUnit operator *(AbstractUnit<TUnit, TBaseUnit, TScalar> left, TScalar right) => FromScalar(left.Value * right);

    public static TUnit operator *(TScalar left, AbstractUnit<TUnit, TBaseUnit, TScalar> right) => FromScalar(left * right.Value);

    public static TUnit operator /(AbstractUnit<TUnit, TBaseUnit, TScalar> left, TScalar right) => FromScalar(left.Value / right);

    public static TScalar operator /(AbstractUnit<TUnit, TBaseUnit, TScalar> left, AbstractUnit<TUnit, TBaseUnit, TScalar> right) => left.Value / right.Value;

    public static TUnit operator +(AbstractUnit<TUnit, TBaseUnit, TScalar> value) => value;

    public static TUnit operator -(AbstractUnit<TUnit, TBaseUnit, TScalar> value) => value;

    public static TUnit operator ++(AbstractUnit<TUnit, TBaseUnit, TScalar> value) => value + One;

    public static TUnit operator --(AbstractUnit<TUnit, TBaseUnit, TScalar> value) => value - One;

    static TUnit IAdditionOperators<TUnit, TUnit, TUnit>.operator +(TUnit left, TUnit right) => left + right;

    static TUnit ISubtractionOperators<TUnit, TUnit, TUnit>.operator -(TUnit left, TUnit right) => left - right;

    static TUnit IMultiplyOperators<TUnit, TScalar, TUnit>.operator *(TUnit left, TScalar right) => left * right;
#if IGNORE_CS0695
    static TUnit IMultiplyOperators<TScalar, TUnit, TUnit>.operator *(TScalar left, TUnit right) => left * right;

    static TUnit IDivisionOperators<TUnit, TScalar, TUnit>.operator /(TUnit left, TScalar right) => left / right;
#endif
    static TScalar IDivisionOperators<TUnit, TUnit, TScalar>.operator /(TUnit left, TUnit right) => left / right;

    static TUnit IUnaryPlusOperators<TUnit, TUnit>.operator +(TUnit value) => value;

    static TUnit IUnaryNegationOperators<TUnit, TUnit>.operator -(TUnit value) => value;

    static TUnit IIncrementOperators<TUnit>.operator ++(TUnit value) => ++value;

    static TUnit IDecrementOperators<TUnit>.operator --(TUnit value) => --value;

    #endregion
}

/// <summary>
/// Conversion between unit and base unit:
/// <para/>
/// <c>
///     <see langword="this"/> = (<see langword="base"/> + <see cref="PreScalingOffset"/>) * <see cref="ScalingFactor"/> + <see cref="PostScalingOffset"/>
///     <br/>
///     <see langword="base"/> = (<see langword="this"/> - <see cref="PostScalingOffset"/>) / <see cref="ScalingFactor"/> - <see cref="PreScalingOffset"/>
/// </c>
/// </summary>
public interface IAffineUnit<TScalar>
    where TScalar : INumber<TScalar>
{
    /// <summary>
    /// Scaling factor multiplied with the base unit to get the unit.
    /// </summary>
    public abstract static TScalar ScalingFactor { get; }

    public abstract static TScalar PreScalingOffset { get; }

    public abstract static TScalar PostScalingOffset { get; }
}

internal interface IQuantity;

public record Quantity<TQuantity, TBaseUnit, TScalar>
    : AbstractUnit<TQuantity, TBaseUnit, TScalar>
    , IUnit<TQuantity, TBaseUnit, TScalar>
    , IUnit
    , IQuantity
    where TQuantity : Quantity<TQuantity, TBaseUnit, TScalar>
    where TBaseUnit : BaseUnit<TQuantity, TBaseUnit, TScalar>
                    , IBaseUnit<TBaseUnit, TScalar>
                    , IUnit<TBaseUnit, TBaseUnit, TScalar>
                    , IAffineUnit<TScalar>
                    , IUnit
    where TScalar : INumber<TScalar>
{
    public static string UnitSymbol { get; } = TBaseUnit.UnitSymbol;
    public static UnitSystem UnitSystem { get; } = TBaseUnit.UnitSystem;

    public new TBaseUnit Value;


    private Quantity(TScalar value)
        : base(value) => Value = BaseUnit<TQuantity, TBaseUnit, TScalar>.FromScalar(value);

    public Quantity(TBaseUnit value)
        : base(value.Value) => Value = value;

    public sealed override TBaseUnit ToBaseUnit() => Value;

    public static implicit operator Quantity<TQuantity, TBaseUnit, TScalar>(TScalar value) => new(value);

    public static implicit operator TScalar(Quantity<TQuantity, TBaseUnit, TScalar> quantity) => quantity.Value.Value;


    public abstract record Unit<TUnit>(TScalar Value)
        : AbstractUnit<TUnit, TBaseUnit, TScalar>(Value)
        where TUnit : Unit<TUnit>
                    , IUnit<TUnit, TBaseUnit, TScalar>
                    , IUnit
    {
        public static implicit operator TQuantity(Unit<TUnit> unit) => new Quantity<TQuantity, TBaseUnit, TScalar>(unit.ToBaseUnit());

        public static implicit operator Unit<TUnit>(Quantity<TQuantity, TBaseUnit, TScalar> quantity) => TUnit.FromBaseUnit(quantity.Value);
    }

    public abstract record AffineUnit<TUnit>(TScalar Value)
        : Unit<TUnit>(Value)
        where TUnit : AffineUnit<TUnit>
                    , IUnit<TUnit, TBaseUnit, TScalar>
                    , IAffineUnit<TScalar>
                    , IUnit
    {
        public override TBaseUnit ToBaseUnit()
        {
            if (this is TBaseUnit base_unit)
                return base_unit;
            else
            {
                TScalar value = Value;

                value -= TUnit.PostScalingOffset;
                value /= TUnit.ScalingFactor;
                value -= TUnit.PreScalingOffset;

                return BaseUnit<TQuantity, TBaseUnit, TScalar>.FromScalar(value);
            }
        }

        public static TUnit FromBaseUnit(TBaseUnit base_unit)
        {
            if (base_unit is TUnit unit)
                return unit;
            else
            {
                TScalar value = base_unit.Value;

                value += TUnit.PreScalingOffset;
                value *= TUnit.ScalingFactor;
                value += TUnit.PostScalingOffset;

                return (TUnit)value;
            }
        }
    }

    public static TQuantity FromBaseUnit(TBaseUnit base_unit) => throw new NotImplementedException();
}

public abstract record BaseUnit<TQuantity, TBaseUnit, TScalar>(TScalar Value)
    : Quantity<TQuantity, TBaseUnit, TScalar>.AffineUnit<TBaseUnit>(Value)
    , IAffineUnit<TScalar>
    , IUnit<TBaseUnit, TBaseUnit, TScalar>
    where TQuantity : Quantity<TQuantity, TBaseUnit, TScalar>
    where TBaseUnit : BaseUnit<TQuantity, TBaseUnit, TScalar>
                    , IBaseUnit<TBaseUnit, TScalar>
                    , IUnit<TBaseUnit, TBaseUnit, TScalar>
                    , IUnit
                    , IAffineUnit<TScalar>
    where TScalar : INumber<TScalar>
{
    public static TScalar ScalingFactor { get; } = TScalar.One;
    public static TScalar PreScalingOffset { get; } = TScalar.Zero;
    public static TScalar PostScalingOffset { get; } = TScalar.Zero;
}


[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
public class QuantityDependency<TQuantityA, TQuantityB, TQuantityC, TBaseUnitA, TBaseUnitB, TBaseUnitC, TScalar>
    : Attribute
    where TQuantityA : Quantity<TQuantityA, TBaseUnitA, TScalar>
    where TQuantityB : Quantity<TQuantityB, TBaseUnitB, TScalar>
    where TQuantityC : Quantity<TQuantityC, TBaseUnitC, TScalar>
    where TBaseUnitA : BaseUnit<TQuantityA, TBaseUnitA, TScalar>
                     , IBaseUnit<TBaseUnitA, TScalar>
                     , IUnit
    where TBaseUnitB : BaseUnit<TQuantityB, TBaseUnitB, TScalar>
                     , IBaseUnit<TBaseUnitB, TScalar>
                     , IUnit
    where TBaseUnitC : BaseUnit<TQuantityC, TBaseUnitC, TScalar>
                     , IBaseUnit<TBaseUnitC, TScalar>
                     , IUnit
    where TScalar : INumber<TScalar>;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
public class QuantityDependency<TQuantityA, TQuantityB, TBaseUnitA, TBaseUnitB, TScalar>
    : QuantityDependency<TQuantityA, TQuantityA, TQuantityB, TBaseUnitA, TBaseUnitA, TBaseUnitB, TScalar>
    where TQuantityA : Quantity<TQuantityA, TBaseUnitA, TScalar>
    where TQuantityB : Quantity<TQuantityB, TBaseUnitB, TScalar>
    where TBaseUnitA : BaseUnit<TQuantityA, TBaseUnitA, TScalar>
                     , IBaseUnit<TBaseUnitA, TScalar>
                     , IUnit
    where TBaseUnitB : BaseUnit<TQuantityB, TBaseUnitB, TScalar>
                     , IBaseUnit<TBaseUnitB, TScalar>
                     , IUnit
    where TScalar : INumber<TScalar>;

