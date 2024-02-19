using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Radioactivity;


[KnownBaseUnit<CountRate, CountPerSecond, Scalar>]
public partial record CountPerSecond(Scalar Value)
    : BaseUnit<CountRate, CountPerSecond, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "cps";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["count/s", "count/sec", "count/second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<CountRate, CountPerMinute, CountPerSecond, Scalar>]
public partial record CountPerMinute(Scalar Value)
    : CountRate.AffineUnit<CountPerMinute>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "cpm";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["count/min", "count/minute"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Minute.ScalingFactor;
}
