// #define IGNORE_CS0695

using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Reflection;
using System.Numerics;
using System;

namespace Unknown6656.Units;


public interface IUnit<TUnit, TBaseUnit, TScalar>
    where TUnit : class, IUnit<TUnit, TBaseUnit, TScalar>
    where TBaseUnit : class, IBaseUnit<TBaseUnit, TScalar>
    where TScalar : notnull, INumberBase<TScalar>, new()
{
    public static abstract string UnitSymbol { get; }


    public TBaseUnit ToBaseUnit();

    public static abstract TUnit FromBaseUnit(TBaseUnit base_unit);
}

public interface IBaseUnit<TBaseUnit, TScalar>
    : IUnit<TBaseUnit, TBaseUnit, TScalar>
    where TBaseUnit : class, IBaseUnit<TBaseUnit, TScalar>
    where TScalar : notnull, INumberBase<TScalar>, new()
{
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
              //, IBaseUnit<TUnit, TScalar>
    where TBaseUnit : class, IBaseUnit<TBaseUnit, TScalar>
    where TScalar : notnull, INumberBase<TScalar>, new()
{
    private static readonly InvalidProgramException _exception = new($"Type '{typeof(TUnit)}' does not have a constructor with a single parameter of type '{typeof(TScalar)}'.");
    private static readonly ConstructorInfo _constructor = typeof(TUnit).GetConstructor([typeof(TScalar)]) ?? throw _exception;


    public static TUnit Zero { get; } = (TUnit)TScalar.Zero;

    public static TUnit One { get; } = (TUnit)TScalar.One;


    #region TOSTRING / PARSING

    public sealed override string ToString() => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider) => $"{Value.ToString(format, formatProvider)} {TUnit.UnitSymbol}";

    public static TUnit Parse(string s, IFormatProvider? provider) =>
        TryParse(s, provider, out TUnit? result) ? result : throw new FormatException($"The string '{s}' ({s.Length} char(s)) could not be parsed to a valid instance of {typeof(TUnit)} or {typeof(TScalar)}.");

    public static bool TryParse(string? s, IFormatProvider? provider, [MaybeNullWhen(false), NotNullWhen(true)] out TUnit? result)
    {
        if (TScalar.TryParse(s, provider, out TScalar? scalar))
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

    public static explicit operator AbstractUnit<TUnit, TBaseUnit, TScalar>(TScalar value) => FromScalar(value);

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

public abstract class Measurement<TMeasurement, TScalar>
    where TMeasurement : Measurement<TMeasurement, TScalar>
    where TScalar : notnull, INumberBase<TScalar>, new()
{
    private static readonly Dictionary<Type, MethodInfo> _from_baseunit = [];
    private static Type? _baseunit = null;

    // TODO : public abstract static TBaseUnit BaseUnit { get; }
    // TODO : conversion between measurements


    public abstract record Unit<TUnit, TBaseUnit>(TScalar Value)
        : AbstractUnit<TUnit, TBaseUnit, TScalar>(Value)
        where TUnit : Unit<TUnit, TBaseUnit>, IUnit<TUnit, TBaseUnit, TScalar>
        where TBaseUnit : BaseUnit<TBaseUnit>, IBaseUnit<TBaseUnit, TScalar>
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

    public record AffineUnit<TUnit, TBaseUnit>(TScalar Value)
        : Unit<TUnit, TBaseUnit>(Value)
        where TUnit : AffineUnit<TUnit, TBaseUnit>
                    , IUnit<TUnit, TBaseUnit, TScalar>
                    , IAffineUnit
        where TBaseUnit : BaseUnit<TBaseUnit>
                        , IBaseUnit<TBaseUnit, TScalar>
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

                return (TBaseUnit)value;
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

    public abstract record BaseUnit<TBaseUnit>(TScalar Value)
        : AffineUnit<TBaseUnit, TBaseUnit>(Value)
        , IAffineUnit
        where TBaseUnit : BaseUnit<TBaseUnit>, IBaseUnit<TBaseUnit, TScalar>
    {
        static TScalar Measurement<TMeasurement, TScalar>.IAffineUnit.ScalingFactor { get; } = TScalar.One;

        static TScalar Measurement<TMeasurement, TScalar>.IAffineUnit.PreScalingOffset { get; } = TScalar.Zero;

        static TScalar Measurement<TMeasurement, TScalar>.IAffineUnit.PostScalingOffset { get; } = TScalar.Zero;


        static BaseUnit()
        {
            if (_baseunit is null)
                _baseunit = typeof(TBaseUnit);
            else
                throw new InvalidProgramException($"The type '{typeof(TBaseUnit)}' cannot be used as base unit type for the measurement '{typeof(TMeasurement)}', as '{_baseunit}' has already been registered.");
        }
    }
}


// TODO : build source generators using attributes such as:
//
// [AttributeUsage(AttributeTargets.Class)]
// public sealed class MeasurementAttribute<TScalar>() : Attribute() where TScalar : notnull, INumberBase<TScalar>, new();
