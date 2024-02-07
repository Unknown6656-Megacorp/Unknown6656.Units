using System.Runtime.CompilerServices;
using System.Numerics;
using System.Diagnostics.CodeAnalysis;
using System;

namespace Unknown6656.Units.Experimental;


// TODO: verify this shit. [SpecialName] does not seem to work.....
public record __Test__<T>(T value)
{
    public override string ToString() => $"[{typeof(T)}] {value}";

    [SpecialName]
    public static string op_Implicit(__Test__<T> value) => value.ToString();

    [SpecialName]
    public static string op_Addition<U>(__Test__<T> first, __Test__<U> second) => $"[{typeof(T)}|{typeof(U)}] {first.value}|{second.value}";
}




static class Composite
{
    //public static Per<Unit1, Unit2> Per<Unit1, Unit2, TScalar>(TScalar value)
}

public record CompositeQuantity<TQuantity1, TQuantity2, TBaseUnit1, TBaseUnit2, TScalar>(CompositeQuantity<TQuantity1, TQuantity2, TBaseUnit1, TBaseUnit2, TScalar>.CompositeBaseUnit value)
    : Quantity<CompositeQuantity<TQuantity1, TQuantity2, TBaseUnit1, TBaseUnit2, TScalar>,
               CompositeQuantity<TQuantity1, TQuantity2, TBaseUnit1, TBaseUnit2, TScalar>.CompositeBaseUnit,
               TScalar>(value)
    , IQuantity<CompositeQuantity<TQuantity1, TQuantity2, TBaseUnit1, TBaseUnit2, TScalar>>
    where TQuantity1 : Quantity<TQuantity1, TBaseUnit1, TScalar>
                     , IQuantity<TQuantity1>
    where TBaseUnit1 : BaseUnit<TQuantity1, TBaseUnit1, TScalar>
                     , IBaseUnit<TBaseUnit1, TScalar>
                     , IUnit<TBaseUnit1, TBaseUnit1, TScalar>
                     , IUnit
    where TQuantity2 : Quantity<TQuantity2, TBaseUnit2, TScalar>
                     , IQuantity<TQuantity2>
    where TBaseUnit2 : BaseUnit<TQuantity2, TBaseUnit2, TScalar>
                     , IBaseUnit<TBaseUnit2, TScalar>
                     , IUnit<TBaseUnit2, TBaseUnit2, TScalar>
                     , IUnit
    where TScalar : INumber<TScalar>
{
    public static string QuantitySymbol { get; } = $"{TQuantity1.QuantitySymbol} / {TQuantity2.QuantitySymbol}";


    public CompositeQuantity(TBaseUnit1 dividend, TBaseUnit2 divisor)
        : this(new CompositeBaseUnit(dividend, divisor))
    {
    }

    public CompositeQuantity(TQuantity1 dividend, TQuantity2 divisor)
        : this(new CompositeBaseUnit(dividend.ToBaseUnit(), divisor.ToBaseUnit()))
    {
    }

    // TODO:
    //      [A/B] /* scalar -> [A/B]
    //      scalar / [A/B] -> [B/A]
    //      [A/B] * B -> A
    //      [A/B] / A -> [1/B]
    //      [A/B] / [C/B] -> [A/C]
    //      [A/B] * [B/C] -> [A/C]
    //      [A/B] * [B/A] -> scalar
    //      [A/B] / [A/B] -> scalar

    public static new bool TryParse(string? s, IFormatProvider? provider, [MaybeNullWhen(false), NotNullWhen(true)] out CompositeQuantity<TQuantity1, TQuantity2, TBaseUnit1, TBaseUnit2, TScalar>? result)
    {
        throw new NotImplementedException();
    }



    public record CompositeBaseUnit(TScalar Value)
        : BaseUnit<CompositeQuantity<TQuantity1, TQuantity2, TBaseUnit1, TBaseUnit2, TScalar>, CompositeBaseUnit, TScalar>(Value)
        , IBaseUnit<CompositeBaseUnit, TScalar>
        , IUnit
    {
        public static string UnitSymbol { get; } = TBaseUnit1.UnitSymbol + "/" + TBaseUnit2.UnitSymbol;
        public static UnitDisplay UnitDisplay { get; } = TBaseUnit1.UnitDisplay.IsImperial() || TBaseUnit2.UnitDisplay.IsImperial() ? UnitDisplay.Imperial : TBaseUnit1.UnitDisplay;


        public CompositeBaseUnit(TBaseUnit1 dividend, TBaseUnit2 divisor)
            : this(dividend.Value / divisor.Value)
        {
        }
    }

    public record CompositeUnit<TUnit1, TUnit2>(TScalar Value)
        : ArbitraryUnit<CompositeUnit<TUnit1, TUnit2>>(Value)
        , IUnit<CompositeUnit<TUnit1, TUnit2>, CompositeBaseUnit, TScalar>
        , IArbitraryUnit<TScalar>
        , IUnit
        where TUnit1 : Quantity<TQuantity1, TBaseUnit1, TScalar>.Unit<TUnit1>
                     , IUnit<TUnit1, TBaseUnit1, TScalar>
                     , IUnit
        where TUnit2 : Quantity<TQuantity2, TBaseUnit2, TScalar>.Unit<TUnit2>
                     , IUnit<TUnit2, TBaseUnit2, TScalar>
                     , IUnit
    {
        public static string UnitSymbol { get; } = TBaseUnit1.UnitSymbol + "/" + TBaseUnit2.UnitSymbol;
        public static UnitDisplay UnitDisplay { get; } = TBaseUnit1.UnitDisplay.IsImperial() || TBaseUnit2.UnitDisplay.IsImperial() ? UnitDisplay.Imperial : TBaseUnit1.UnitDisplay;


        public CompositeUnit(TUnit1 dividend, TUnit2 divisor)
            : this(dividend.Value / divisor.Value)
        {
        }

        public static TScalar FromBaseUnit(TScalar value)
        {
            TUnit1 dividend = TUnit1.FromBaseUnit((TBaseUnit1)value);
            TUnit2 divisor = TUnit2.FromBaseUnit((TBaseUnit2)TScalar.One);

            return dividend.Value / divisor.Value;
        }

        public override TScalar ToBaseUnit(TScalar value)
        {
            TBaseUnit1 dividend = ((TUnit1)value).ToBaseUnit();
            TBaseUnit2 divisor = ((TUnit2)TScalar.One).ToBaseUnit();

            return dividend.Value / divisor.Value;
        }
    }
}
