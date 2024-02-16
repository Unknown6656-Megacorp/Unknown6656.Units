using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Radioactivity;


[KnownBaseUnit<DoseRate, SievertPerSecond, Scalar>]
public partial record SievertPerSecond(Scalar Value)
    : BaseUnit<DoseRate, SievertPerSecond, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "Sv/s";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["sievert/s", "sv/second", "sv/sec", "sievert/sec"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<DoseRate, SievertPerMinute, SievertPerSecond, Scalar>]
public partial record SievertPerMinute(Scalar Value)
    : DoseRate.AffineUnit<SievertPerMinute>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Sv/min";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["sievert/min", "sv/minute"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Minute.ScalingFactor;
}

[KnownUnit<DoseRate, SievertPerHour, SievertPerSecond, Scalar>]
public partial record SievertPerHour(Scalar Value)
    : DoseRate.AffineUnit<SievertPerHour>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Sv/h";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["sievert/h", "sv/hour", "sv/hou", "sievert/hou", "sv/hr", "sievert/hr"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Hour.ScalingFactor;
}

[KnownUnit<DoseRate, SievertPerDay, SievertPerSecond, Scalar>]
public partial record SievertPerDay(Scalar Value)
    : DoseRate.AffineUnit<SievertPerDay>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Sv/d";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["sievert/d", "sv/day"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / StandardDay.ScalingFactor;
}

[KnownUnit<DoseRate, SievertPerWeek, SievertPerSecond, Scalar>]
public partial record SievertPerWeek(Scalar Value)
    : DoseRate.AffineUnit<SievertPerWeek>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Sv/w";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["sievert/w", "sv/week"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / StandardWeek.ScalingFactor;
}

[KnownUnit<DoseRate, SievertPerYear, SievertPerSecond, Scalar>]
public partial record SievertPerYear(Scalar Value)
    : DoseRate.AffineUnit<SievertPerYear>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Sv/y";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["sievert/y", "sv/year", "sievert/a", "sv/a"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / SolarYear.ScalingFactor;
}

// rem/s
// rem/min
// rem/hr