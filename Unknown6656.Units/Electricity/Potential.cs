namespace Unknown6656.Units.Electricity;


[KnownBaseUnit<Potential, Volt, Scalar>]
public partial record Volt
{
    public static string UnitSymbol { get; } = "V";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
