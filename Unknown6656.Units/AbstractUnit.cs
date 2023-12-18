// #define IGNORE_CS0695

using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Numerics;
using System;

namespace Unknown6656.Units;


public interface IUnit<TUnit, TBaseUnit, TScalar>
    where TUnit : class, IUnit<TUnit, TBaseUnit, TScalar>
    where TBaseUnit : class, IBaseUnit<TBaseUnit, TScalar>
    where TScalar : notnull, INumberBase<TScalar>, new()
{
    public static abstract string Name { get; }
    public static abstract string UnitSymbol { get; }


    public TBaseUnit ToBaseUnit();
}

public interface IBaseUnit<TBaseUnit, TScalar>
    : IUnit<TBaseUnit, TBaseUnit, TScalar>
    where TBaseUnit : class, IBaseUnit<TBaseUnit, TScalar>
    where TScalar : notnull, INumberBase<TScalar>, new()
{
    // TODO : overrides


    public TUnit ToUnit<TUnit>() where TUnit : class, IUnit<TUnit, TBaseUnit, TScalar>;
}


public abstract record AbstractUnit<TUnit, TScalar>(TScalar Value)
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
    where TUnit : AbstractUnit<TUnit, TScalar>, IBaseUnit<TUnit, TScalar>
    where TScalar : notnull, INumberBase<TScalar>, new()
{
    private static readonly InvalidProgramException _exception = new($"Type '{typeof(TUnit)}' does not have a constructor with a single parameter of type '{typeof(TScalar)}'.");
    private static readonly ConstructorInfo _constructor;


    public static TUnit Zero { get; } = (TUnit)TScalar.Zero;

    public static TUnit One { get; } = (TUnit)TScalar.One;


    static AbstractUnit() => _constructor = typeof(TUnit).GetConstructor([typeof(TScalar)]) ?? throw _exception;

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

    public static TUnit FromScalar(TScalar value) => _constructor.Invoke([value]) as TUnit ?? throw _exception;

    public static explicit operator AbstractUnit<TUnit, TScalar>(TScalar value) => FromScalar(value);

    public static implicit operator TUnit(AbstractUnit<TUnit, TScalar> unit) => unit as TUnit ?? FromScalar(unit.Value);

    public static explicit operator TScalar(AbstractUnit<TUnit, TScalar> unit) => unit.Value;


    public static TUnit operator +(AbstractUnit<TUnit, TScalar> left, AbstractUnit<TUnit, TScalar> right) => FromScalar(left.Value + right.Value);

    public static TUnit operator -(AbstractUnit<TUnit, TScalar> left, AbstractUnit<TUnit, TScalar> right) => FromScalar(left.Value - right.Value);

    public static TUnit operator *(AbstractUnit<TUnit, TScalar> left, TScalar right) => FromScalar(left.Value * right);

    public static TUnit operator *(TScalar left, AbstractUnit<TUnit, TScalar> right) => FromScalar(left * right.Value);

    public static TUnit operator /(AbstractUnit<TUnit, TScalar> left, TScalar right) => FromScalar(left.Value / right);

    public static TScalar operator /(AbstractUnit<TUnit, TScalar> left, AbstractUnit<TUnit, TScalar> right) => left.Value / right.Value;

    public static TUnit operator +(AbstractUnit<TUnit, TScalar> value) => value;

    public static TUnit operator -(AbstractUnit<TUnit, TScalar> value) => value;

    public static TUnit operator ++(AbstractUnit<TUnit, TScalar> value) => value + One;

    public static TUnit operator --(AbstractUnit<TUnit, TScalar> value) => value - One;

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
}
