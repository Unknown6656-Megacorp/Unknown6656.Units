using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Matter;


[KnownBaseUnit<AreaMassDensity, KilogramPerSquareMeter, Scalar>]
public partial record KilogramPerSquareMeter(Scalar Value)
    : BaseUnit<AreaMassDensity, KilogramPerSquareMeter, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "kg/m^2";
#else
    public static string UnitSymbol { get; } = "kg/m²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kilogram/meter^2", "kilogram/m^2", "kg/meter^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
}

[KnownUnit<AreaMassDensity, PoundPerSquareInch, KilogramPerSquareMeter, Scalar>]
public partial record PoundPerSquareInch(Scalar Value)
    : AreaMassDensity.AffineUnit<PoundPerSquareInch>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lb/in^2";
#else
    public static string UnitSymbol { get; } = "lb/in²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["pound/inch^2", "pound/in^2", "lbs/inch^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Pound.ScalingFactor / SquareInch.ScalingFactor;
}

[KnownUnit<AreaMassDensity, PoundPerSquareFoot, KilogramPerSquareMeter, Scalar>]
public partial record PoundPerSquareFoot(Scalar Value)
    : AreaMassDensity.AffineUnit<PoundPerSquareFoot>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lb/ft^2";
#else
    public static string UnitSymbol { get; } = "lb/ft²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["pound/foot^2", "pound/ft^2", "lbs/foot^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Pound.ScalingFactor / SquareFoot.ScalingFactor;
}
