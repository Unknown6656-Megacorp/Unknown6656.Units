using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Numerics;
using System;

namespace Unknown6656.Units;


public interface IUnit<TUnit>
    where TUnit : class, IUnit<TUnit>
{
    public static abstract string Name { get; }
    public static abstract string UnitSymbol { get; }
}

public abstract record Unit<TUnit, TScalar>(TScalar Value)
    : IAdditionOperators<TUnit, TUnit, TUnit>
    , ISubtractionOperators<TUnit, TUnit, TUnit>
    , IDivisionOperators<TUnit, TUnit, TScalar>
    , IFormattable
    , IParsable<TUnit>
    where TUnit : Unit<TUnit, TScalar>, IUnit<TUnit>
    where TScalar : notnull, INumberBase<TScalar>, new()
{
    private static readonly InvalidProgramException _exception = new($"Type '{typeof(TUnit)}' does not have a constructor with a single parameter of type '{typeof(TScalar)}'.");
    private static readonly ConstructorInfo _constructor;


    static Unit() => _constructor = typeof(TUnit).GetConstructor([typeof(TScalar)]) ?? throw _exception;

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

    public static TUnit FromScalar(TScalar value) => _constructor.Invoke(null, [value]) as TUnit ?? throw _exception;

    public static implicit operator Unit<TUnit, TScalar>(TScalar value) => FromScalar(value);

    public static implicit operator TUnit(Unit<TUnit, TScalar> unit) => unit as TUnit ?? FromScalar(unit.Value);

    public static explicit operator TScalar(Unit<TUnit, TScalar> unit) => unit.Value;


    public static TUnit operator +(Unit<TUnit, TScalar> left, TUnit right) => FromScalar(left.Value + right.Value);

    static TUnit IAdditionOperators<TUnit, TUnit, TUnit>.operator +(TUnit left, TUnit right) => left + right;

    public static TUnit operator -(Unit<TUnit, TScalar> left, TUnit right) => FromScalar(left.Value - right.Value);

    static TUnit ISubtractionOperators<TUnit, TUnit, TUnit>.operator -(TUnit left, TUnit right) => left - right;

    public static TScalar operator /(Unit<TUnit, TScalar> left, TUnit right) => left.Value / right.Value;

    static TScalar IDivisionOperators<TUnit, TUnit, TScalar>.operator /(TUnit left, TUnit right) => left / right;
}



