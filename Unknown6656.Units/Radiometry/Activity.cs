using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Radiometry;


[KnownBaseUnit<Activity, Becquerel, Scalar>]
public partial record Becquerel(Scalar Value)
    : BaseUnit<Activity, Becquerel, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "Bq";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["dps", "disintegration/sec", "disintegration/s", "disintegration/second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Activity, Curie, Becquerel, Scalar>]
public partial record Curie(Scalar Value)
    : Activity.AffineUnit<Curie>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Ci";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)(1 / 3.7e10);
}

[KnownUnit<Activity, Rutherford, Becquerel, Scalar>]
public partial record Rutherford(Scalar Value)
    : Activity.AffineUnit<Rutherford>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Rd";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-6;
}

[KnownUnit<Activity, DisintegrationPerMinute, Becquerel, Scalar>]
public partial record DisintegrationPerMinute(Scalar Value)
    : Activity.AffineUnit<DisintegrationPerMinute>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "dpm";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["disintegration/min", "disintegration/minute"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Minute.ScalingFactor;
}
