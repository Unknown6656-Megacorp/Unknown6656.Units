using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Radiometry;


[KnownBaseUnit<CountRate, CountPerSecond, Scalar>]
public partial record CountPerSecond
{
    public static string UnitSymbol { get; } = "cps";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["count/s", "count/sec", "count/second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<CountRate, CountPerMinute, CountPerSecond, Scalar>(KnownUnitType.Linear)]
public partial record CountPerMinute
{
    public static string UnitSymbol { get; } = "cpm";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["count/min", "count/minute"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Minute.ScalingFactor;
}
