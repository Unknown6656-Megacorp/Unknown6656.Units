namespace Unknown6656.Units.Matter;


[KnownBaseUnit<AreaMassDensity, KilogramPerSquareMeter, Scalar>]
public partial record KilogramPerSquareMeter(Scalar Value)
    : BaseUnit<AreaMassDensity, KilogramPerSquareMeter, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "kg/m²";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
}

[KnownUnit<AreaMassDensity, PoundPerSquareInch, KilogramPerSquareMeter, Scalar>]
public partial record PoundPerSquareInch(Scalar Value)
    : AreaMassDensity.AffineUnit<PoundPerSquareInch>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lbs/in²";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.00014503773773020923;
}
