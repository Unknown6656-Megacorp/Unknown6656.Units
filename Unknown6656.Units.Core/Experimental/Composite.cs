using System.Numerics;

namespace Unknown6656.Units.Experimental;


static class Composite
{
    //public static Per<Unit1, Unit2> Per<Unit1, Unit2, TScalar>(TScalar value)
}

public record CompositeQuantity<TQuantity1, TQuantity2, TBaseUnit1, TBaseUnit2, TScalar>(CompositeQuantity<TQuantity1, TQuantity2, TBaseUnit1, TBaseUnit2, TScalar>.CompositeBaseUnit value)
    : Quantity<CompositeQuantity<TQuantity1, TQuantity2, TBaseUnit1, TBaseUnit2, TScalar>,
               CompositeQuantity<TQuantity1, TQuantity2, TBaseUnit1, TBaseUnit2, TScalar>.CompositeBaseUnit,
               TScalar>(value)
    where TQuantity1 : Quantity<TQuantity1, TBaseUnit1, TScalar>
    where TBaseUnit1 : BaseUnit<TQuantity1, TBaseUnit1, TScalar>
                     , IBaseUnit<TBaseUnit1, TScalar>
                     , IUnit<TBaseUnit1, TBaseUnit1, TScalar>
                     , IUnit
    where TQuantity2 : Quantity<TQuantity2, TBaseUnit2, TScalar>
    where TBaseUnit2 : BaseUnit<TQuantity2, TBaseUnit2, TScalar>
                     , IBaseUnit<TBaseUnit2, TScalar>
                     , IUnit<TBaseUnit2, TBaseUnit2, TScalar>
                     , IUnit
    where TScalar : INumber<TScalar>
{
    public record CompositeBaseUnit(TScalar Value)
        : BaseUnit<CompositeQuantity<TQuantity1, TQuantity2, TBaseUnit1, TBaseUnit2, TScalar>, CompositeBaseUnit, TScalar>(Value)
        , IBaseUnit<CompositeBaseUnit, TScalar>
        , IUnit
    {
        public static string UnitSymbol { get; } = TBaseUnit1.UnitSymbol + "/" + TBaseUnit2.UnitSymbol;
        public static UnitDisplay UnitDisplay { get; } = TBaseUnit1.UnitDisplay.IsImperial() || TBaseUnit2.UnitDisplay.IsImperial() ? UnitDisplay.Imperial : TBaseUnit1.UnitDisplay;
    }

    public record CompositeUnit<TUnit1, TUnit2>(TScalar Value)
        : AffineUnit<CompositeUnit<TUnit1, TUnit2>>(Value)
        , IAffineUnit<TScalar>
        , IUnit<CompositeUnit<TUnit1, TUnit2>, CompositeBaseUnit, TScalar>
        , IUnit
        where TUnit1 : Quantity<TQuantity1, TBaseUnit1, TScalar>.AffineUnit<TUnit1>
                     , IUnit<TUnit1, TBaseUnit1, TScalar>
                     , IAffineUnit<TScalar>
                     , IUnit
        where TUnit2 : Quantity<TQuantity2, TBaseUnit2, TScalar>.AffineUnit<TUnit2>
                     , IUnit<TUnit2, TBaseUnit2, TScalar>
                     , IAffineUnit<TScalar>
                     , IUnit
    {
        public static string UnitSymbol { get; }
        public static UnitDisplay UnitDisplay { get; }
        public static TScalar ScalingFactor { get; }
        public static TScalar PreScalingOffset { get; }
        public static TScalar PostScalingOffset { get; }
    }
}
