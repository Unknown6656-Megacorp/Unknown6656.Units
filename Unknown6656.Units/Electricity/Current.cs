namespace Unknown6656.Units.Electricity;


[KnownBaseUnit<Current, Ampere, Scalar>]
public partial record Ampere(Scalar Value)
    : BaseUnit<Current, Ampere, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "A";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}
