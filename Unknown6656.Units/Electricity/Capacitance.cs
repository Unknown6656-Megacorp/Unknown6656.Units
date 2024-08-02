namespace Unknown6656.Units.Electricity;


[KnownBaseUnit<Capacitance, Farad, Scalar>]
public partial record Farad
{
    public static string UnitSymbol { get; } = "F";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
