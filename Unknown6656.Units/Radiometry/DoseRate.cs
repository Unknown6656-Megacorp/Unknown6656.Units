using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Radiometry;


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

[KnownUnit<DoseRate, RemPerSecond, SievertPerSecond, Scalar>]
public partial record RemPerSecond(Scalar Value)
    : DoseRate.AffineUnit<RemPerSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "rem/s";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["röntgen eq man/s", "röntgen equivalent man/s", "rem/sec",
        "röntgen eq man/sec", "röntgen equivalent man/sec", "röntgen eq man/second", "röntgen equivalent man/second"
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = RöntgenEquivalentMan.ScalingFactor;
}

[KnownUnit<DoseRate, RemPerMinute, SievertPerSecond, Scalar>]
public partial record RemPerMinute(Scalar Value)
    : DoseRate.AffineUnit<RemPerMinute>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "rem/min";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["röntgen eq man/min", "röntgen equivalent man/min", "röntgen eq man/minute", "röntgen equivalent man/minute"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = RöntgenEquivalentMan.ScalingFactor / Minute.ScalingFactor;
}

[KnownUnit<DoseRate, RemPerHour, SievertPerSecond, Scalar>]
public partial record RemPerHour(Scalar Value)
    : DoseRate.AffineUnit<RemPerHour>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "rem/h";
    static string[] IUnit.AlternativeUnitSymbols { get; } = [
        "röntgen eq man/h", "röntgen equivalent man/h", "rem/hr", "röntgen eq man/hr", "röntgen equivalent man/hr", "rem/hou",
        "röntgen eq man/hou", "röntgen equivalent man/hou", "röntgen eq man/hour", "röntgen equivalent man/hour",
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = RöntgenEquivalentMan.ScalingFactor / Hour.ScalingFactor;
}
