namespace Unknown6656.Units.Radioactivity;


[KnownBaseUnit<EquivalentDose, Sievert, Scalar>]
public partial record Sievert(Scalar Value)
    : BaseUnit<EquivalentDose, Sievert, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "Sv";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
