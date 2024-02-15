namespace Unknown6656.Units.Radioactivity;


[KnownBaseUnit<Activity, Becquerel, Scalar>]
public partial record Becquerel(Scalar Value)
    : BaseUnit<Activity, Becquerel, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "Bq";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
