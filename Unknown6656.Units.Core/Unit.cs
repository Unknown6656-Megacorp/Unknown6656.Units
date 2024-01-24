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


public enum UnitDisplay
    : uint
{
    MetricUseSIPrefixes,
    MetricUseSIPrefixesOnlyOnMultiples,
    MetricUseSIPrefixesOnlyOnSubmultiples,
    MetricNoSIPrefixes,
    MetricSI_Shifted_k,
    MetricSI_Shifted_M,
    MetricSI_Shifted_m,
    MetricSI_Shifted_μ,

    Imperial,
    ImperialWithSIPrefixes,

    PrefixedUnitNotation,
    UseFormatStrings,
    UseInverseFormatStrings,
}

public interface IUnit
{
    public static abstract string UnitSymbol { get; }
    public static abstract UnitDisplay UnitDisplay { get; }
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

public static partial class Unit
{
    public static IReadOnlyList<string> MetricSIPrefixesMultiple { get; } = ["k", "M", "G", "T", "P", "E", "Z", "Y", "R", "Q"];
    public static IReadOnlyList<string> MetricSIPrefixesSubmultiple { get; } = ["m", "μ", "n", "p", "f", "a", "z", "y", "r", "q"];
    public static NumberFormatInfo DefaultNumberFormat { get; set; } = new()
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


    public static bool IsMetric(this UnitDisplay display) => display is UnitDisplay.MetricUseSIPrefixes
                                                                     or UnitDisplay.MetricUseSIPrefixesOnlyOnMultiples
                                                                     or UnitDisplay.MetricUseSIPrefixesOnlyOnSubmultiples
                                                                     or UnitDisplay.MetricNoSIPrefixes
                                                                     or UnitDisplay.MetricSI_Shifted_k
                                                                     or UnitDisplay.MetricSI_Shifted_M
                                                                     or UnitDisplay.MetricSI_Shifted_m
                                                                     or UnitDisplay.MetricSI_Shifted_μ;

    public static bool IsImperial(this UnitDisplay display) => display is UnitDisplay.Imperial or UnitDisplay.ImperialWithSIPrefixes;

    public static bool IsSI(this UnitDisplay display) => display is UnitDisplay.MetricUseSIPrefixes
                                                                 or UnitDisplay.MetricUseSIPrefixesOnlyOnMultiples
                                                                 or UnitDisplay.MetricUseSIPrefixesOnlyOnSubmultiples
                                                                 or UnitDisplay.MetricSI_Shifted_k
                                                                 or UnitDisplay.MetricSI_Shifted_M
                                                                 or UnitDisplay.MetricSI_Shifted_m
                                                                 or UnitDisplay.MetricSI_Shifted_μ
                                                                 or UnitDisplay.UseFormatStrings
                                                                 or UnitDisplay.UseInverseFormatStrings
                                                                 or UnitDisplay.ImperialWithSIPrefixes;

    private static string FormatImperial<TScalar>(TScalar scalar, string? unit_symbol, string? format, IFormatProvider? format_provider, UnitDisplay display)
        where TScalar : INumber<TScalar>
    {
        string formatted = TScalar.IsNaN(scalar) ? "[NaN]"
                         : TScalar.IsPositiveInfinity(scalar) ? "∞"
                         : TScalar.IsNegativeInfinity(scalar) ? "-∞"
                         : scalar?.ToString(format ?? "N", format_provider ?? DefaultNumberFormat) ?? "0";

        if (string.IsNullOrWhiteSpace(unit_symbol))
            return formatted;
        else if (display is UnitDisplay.PrefixedUnitNotation)
            return $"{unit_symbol} {formatted}";
        else if (display is UnitDisplay.UseFormatStrings or UnitDisplay.UseInverseFormatStrings)
            return string.Format(format_provider, unit_symbol, formatted);
        else
            return $"{formatted} {unit_symbol}";
    }

    public static string Format<TScalar>(TScalar value, string? unit_symbol, string? format, IFormatProvider? format_provider, UnitDisplay display, SIUnitScale scale = SIUnitScale.Base_1000)
        where TScalar : INumber<TScalar>
    {
        unit_symbol = unit_symbol?.Trim();

        if (unit_symbol is null || !display.IsSI())
            return FormatImperial(value, unit_symbol, format, format_provider, display);

        TScalar @base = TScalar.CreateChecked((int)scale);
        bool? inverse_formatted = null;
        bool negative = value < TScalar.Zero;
        int order = -1;

        value = TScalar.Abs(value);

        if (display is UnitDisplay.MetricSI_Shifted_k && unit_symbol is ['k' or 'K', ..string suffixk])
        {
            value *= @base;
            unit_symbol = suffixk;
            display = UnitDisplay.MetricUseSIPrefixes;
        }
        else if (display is UnitDisplay.MetricSI_Shifted_M && unit_symbol is ['M', ..string suffixM])
        {
            value *= @base * @base;
            unit_symbol = suffixM;
            display = UnitDisplay.MetricUseSIPrefixes;
        }
        else if (display is UnitDisplay.MetricSI_Shifted_m && unit_symbol is ['m', .. string suffixm])
        {
            value /= @base;
            unit_symbol = suffixm;
            display = UnitDisplay.MetricUseSIPrefixes;
        }
        else if (display is UnitDisplay.MetricSI_Shifted_μ && unit_symbol is ['μ' or 'u', ..string suffixμ])
        {
            value /= @base * @base;
            unit_symbol = suffixμ;
            display = UnitDisplay.MetricUseSIPrefixes;
        }
        else if (display is UnitDisplay.UseFormatStrings or UnitDisplay.UseInverseFormatStrings)
        {
            inverse_formatted = display is UnitDisplay.UseInverseFormatStrings;
            display = UnitDisplay.MetricUseSIPrefixes;
        }

        bool submultiple = value < TScalar.One;
        IReadOnlyList<string> prefixes = (inverse_formatted ?? false) ^ submultiple ? MetricSIPrefixesSubmultiple : MetricSIPrefixesMultiple;

        if (display is UnitDisplay.MetricUseSIPrefixes or UnitDisplay.ImperialWithSIPrefixes
            || (submultiple ? display is UnitDisplay.MetricUseSIPrefixesOnlyOnSubmultiples
                            : display is UnitDisplay.MetricUseSIPrefixesOnlyOnMultiples))
            while (TScalar.IsFinite(value) && value != TScalar.Zero && (submultiple ? value < TScalar.One : value >= @base) && order < prefixes.Count - 1)
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
            format_provider,
            inverse_formatted is null ? display : UnitDisplay.UseFormatStrings
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

        NumberFormatInfo parser = provider?.GetFormat(typeof(NumberFormatInfo)) as NumberFormatInfo ?? CultureInfo.CurrentCulture.NumberFormat;

        value = value.Trim()
                     .Replace("'", "")
                     .Replace(" ", "")
                     .Replace(parser.CurrencyGroupSeparator, "")
                     .Replace(parser.NumberGroupSeparator, "")
                     .Replace(parser.PercentGroupSeparator, "")
                     .Replace(parser.CurrencyDecimalSeparator, ".")
                     .Replace(parser.NumberDecimalSeparator, ".")
                     .Replace(parser.PercentDecimalSeparator, ".");

        parser = new();

        if (TScalar.TryParse(value, parser, out scalar))
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

    public static bool IsMetric => TUnit.UnitDisplay.IsMetric();

    public static bool IsSI => TUnit.UnitDisplay.IsSI();

    public static bool IsImperial => TUnit.UnitDisplay.IsImperial();

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

    public string ToString(string? format, IFormatProvider? formatProvider, SIUnitScale scale) => Unit.Format(Value, TUnit.UnitSymbol, format, formatProvider, TUnit.UnitDisplay, scale);

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

public interface ILinearUnit<TScalar>
    : IAffineUnit<TScalar>
    where TScalar : INumber<TScalar>
{
    static TScalar IAffineUnit<TScalar>.PreScalingOffset { get; } = TScalar.Zero;

    static TScalar IAffineUnit<TScalar>.PostScalingOffset { get; } = TScalar.Zero;
}

public interface IArbitraryUnit<TScalar>
    where TScalar : INumber<TScalar>
{
    public static abstract TScalar FromBaseUnit(TScalar value);

    public TScalar ToBaseUnit(TScalar value);
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
    public static UnitDisplay UnitDisplay { get; } = TBaseUnit.UnitDisplay;

    public new TBaseUnit Value;


    private Quantity(TScalar value)
        : base(value) => Value = BaseUnit<TQuantity, TBaseUnit, TScalar>.FromScalar(value);

    public Quantity(TBaseUnit value)
        : base(value.Value) => Value = value;

    public sealed override TBaseUnit ToBaseUnit() => Value;

    public static TQuantity FromBaseUnit(TBaseUnit base_unit) => throw new NotImplementedException(); // TODO

    public static explicit operator Quantity<TQuantity, TBaseUnit, TScalar>(TScalar value) => new(value);

    public static explicit operator TScalar(Quantity<TQuantity, TBaseUnit, TScalar> quantity) => quantity.Value.Value;


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

    public abstract record ArbitraryUnit<TUnit>(TScalar Value)
        : Unit<TUnit>(Value)
        where TUnit : ArbitraryUnit<TUnit>
                    , IUnit<TUnit, TBaseUnit, TScalar>
                    , IArbitraryUnit<TScalar>
                    , IUnit
    {
        public abstract TScalar ToBaseUnit(TScalar value);

        public override TBaseUnit ToBaseUnit()
        {
            if (this is TBaseUnit base_unit)
                return base_unit;
            else
                return BaseUnit<TQuantity, TBaseUnit, TScalar>.FromScalar(ToBaseUnit(Value));
        }

        public static TUnit FromBaseUnit(TBaseUnit base_unit)
        {
            if (base_unit is TUnit unit)
                return unit;
            else
                return FromScalar(TUnit.FromBaseUnit(base_unit.Value));
        }
    }
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
