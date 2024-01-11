namespace Unknown6656.Units.Matter;


[KnownBaseUnit<AreaMassDensity, KilogramPerSquareMeter, Scalar>]
public partial record KilogramPerSquareMeter(Scalar Value)
    : BaseUnit<AreaMassDensity, KilogramPerSquareMeter, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "kg/m²";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
}
