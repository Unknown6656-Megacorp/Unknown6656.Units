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
    Imperial
}

public interface IUnit<TUnit, TBaseUnit, TScalar>
    where TUnit : class, IUnit<TUnit, TBaseUnit, TScalar>
    where TBaseUnit : class, IBaseUnit<TBaseUnit, TScalar>
    where TScalar : INumber<TScalar>
{
    public static abstract string UnitSymbol { get; }
    public static abstract UnitSystem UnitSystem { get; }


    public TBaseUnit ToBaseUnit();

    public static abstract TUnit FromBaseUnit(TBaseUnit base_unit);
}

public interface IBaseUnit<TBaseUnit, TScalar>
    : IUnit<TBaseUnit, TBaseUnit, TScalar>
    where TBaseUnit : class, IBaseUnit<TBaseUnit, TScalar>
    where TScalar : INumber<TScalar>
{
}

public enum SIUnitScale
    : int
{
    _1000 = 1000,
    _1024 = 1024,
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


    public static string FormatImperial<TScalar>(TScalar scalar, string unit_symbol, string? format, IFormatProvider? format_provider)
        where TScalar : INumber<TScalar> => $"{scalar?.ToString(format ?? "N", format_provider ?? DefaultNumberFormat) ?? "0"} {unit_symbol}";

    public static string FormatMetricSIPrefix<TScalar>(TScalar value, string unit_symbol, string? format, IFormatProvider? format_provider, SIUnitScale scale = SIUnitScale._1000)
        where TScalar : INumber<TScalar>
    {
        TScalar @base = TScalar.CreateChecked((int)scale);
        bool negative = value < TScalar.Zero;
        int order = -1;

        value = TScalar.Abs(value);

        bool submultiple = value < TScalar.One;
        IReadOnlyList<string> prefixes = submultiple ? MetricSIPrefixesSubmultiple : MetricSIPrefixesMultiple;

        while ((submultiple ? value < TScalar.One : value >= @base) && order < prefixes.Count - 1)
        {
            ++order;

            if (submultiple)
                value *= @base;
            else
                value /= @base;
        }

        if (negative)
            value = -value;

        return $"{value.ToString(format ?? "N", format_provider ?? DefaultNumberFormat) ?? "0"} {(order < 0 ? "" : prefixes[order])}{(scale == SIUnitScale._1024 ? "i" : "")}{unit_symbol}";
    }

    public static bool TryParse<TScalar>(string? value, IFormatProvider? provider, [MaybeNullWhen(false), NotNullWhen(true)] out TScalar? scalar, SIUnitScale scale = SIUnitScale._1000)
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
    where TBaseUnit : class, IBaseUnit<TBaseUnit, TScalar>
    where TScalar : INumber<TScalar>
{
    private static readonly InvalidProgramException _exception = new($"Type '{typeof(TUnit)}' does not have a constructor with a single parameter of type '{typeof(TScalar)}'.");
    private static readonly ConstructorInfo _constructor = typeof(TUnit).GetConstructor([typeof(TScalar)]) ?? throw _exception;


    public static TUnit Zero { get; } = (TUnit)TScalar.Zero;

    public static TUnit One { get; } = (TUnit)TScalar.One;


    #region TOSTRING / PARSING

    public sealed override string ToString() => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider) => ToString(format, formatProvider, SIUnitScale._1000);

    public string ToString(string? format, IFormatProvider? formatProvider, SIUnitScale scale)
    {
        if (TUnit.UnitSystem is UnitSystem.Metric)
            return Unit.FormatMetricSIPrefix(Value, TUnit.UnitSymbol, format, formatProvider, scale);
        else
            return Unit.FormatImperial(Value, TUnit.UnitSymbol, format, formatProvider);
    }

    public static TUnit Parse(string s, IFormatProvider? provider) => Parse(s, provider, SIUnitScale._1000);

    public static TUnit Parse(string s, IFormatProvider? provider, SIUnitScale scale) =>
        TryParse(s, provider, out TUnit? result, scale) ? result : throw new FormatException($"The string '{s}' ({s.Length} char(s)) could not be parsed to a valid instance of {typeof(TUnit)} or {typeof(TScalar)}.");

    public static bool TryParse(string? s, IFormatProvider? provider, [MaybeNullWhen(false), NotNullWhen(true)] out TUnit? result) =>
        TryParse(s, provider, out result, SIUnitScale._1000);

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

    public static TUnit FromScalar(TScalar value) => _constructor.Invoke([value]) as TUnit ?? throw _exception;

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




public interface IQuantity
{
    public static abstract string BaseUnitSymbol { get; }
    public static abstract UnitSystem BaseUnitSystem { get; }
}

public abstract record Quantity<TQuantity, TScalar>(TScalar Value)
    : AbstractUnit<TQuantity, TQuantity, TScalar>(Value)
    //: Quantity<TQuantity, TScalar>.Unit<TQuantity>(Value)
    , IBaseUnit<TQuantity, TScalar>
    where TQuantity : Quantity<TQuantity, TScalar>
                    , IBaseUnit<TQuantity, TScalar>
                    , IQuantity
    where TScalar : INumber<TScalar>
{
    static string IUnit<TQuantity, TQuantity, TScalar>.UnitSymbol { get; } = TQuantity.BaseUnitSymbol;
    static UnitSystem IUnit<TQuantity, TQuantity, TScalar>.UnitSystem { get; } = TQuantity.BaseUnitSystem;

    public override TQuantity ToBaseUnit() => (TQuantity)this; // TODO
    static TQuantity IUnit<TQuantity, TQuantity, TScalar>.FromBaseUnit(TQuantity base_unit) => base_unit;



    public abstract record Unit<TUnit>(TScalar Value)
        : AbstractUnit<TUnit, TQuantity, TScalar>(Value)
        where TUnit : Unit<TUnit>, IUnit<TUnit, TQuantity, TScalar>
    {
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
    public interface IAffineUnit
    {
        /// <summary>
        /// Scaling factor multiplied with the base unit to get the unit.
        /// </summary>
        public abstract static TScalar ScalingFactor { get; }

        public abstract static TScalar PreScalingOffset { get; }

        public abstract static TScalar PostScalingOffset { get; }
    }

    public record AffineUnit<TUnit>(TScalar Value)
        : Unit<TUnit>(Value)
        where TUnit : AffineUnit<TUnit>
                    , IUnit<TUnit, TQuantity, TScalar>
                    , IAffineUnit
    {
        public override TQuantity ToBaseUnit()
        {
            if (this is TQuantity base_unit)
                return base_unit;
            else
            {
                TScalar value = Value;

                value -= TUnit.PostScalingOffset;
                value /= TUnit.ScalingFactor;
                value -= TUnit.PreScalingOffset;

                return (TQuantity)value;
            }
        }

        public static TUnit FromBaseUnit(TQuantity base_unit)
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
}


// TODO : build source generators using attributes such as:
//
//[AttributeUsage(AttributeTargets.Class)]
// public sealed class MeasurementAttribute<TScalar>() : Attribute() where TScalar : INumber<TScalar>();
