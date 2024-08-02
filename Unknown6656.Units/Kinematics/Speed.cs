using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<Speed, MeterPerSecond, Scalar>]
public partial record MeterPerSecond
{
    public static string UnitSymbol { get; } = "m/s";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["mps"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Speed, KilometerPerHour, MeterPerSecond, Scalar>(KnownUnitType.Linear)]
public partial record KilometerPerHour
{
    public static string UnitSymbol { get; } = "km/h";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kph", "kphr", "km/hr"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3.6;
}

[KnownUnit<Speed, MeterPerHour, MeterPerSecond, Scalar>(KnownUnitType.Linear)]
public partial record MeterPerHour
{
    public static string UnitSymbol { get; } = "m/h";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["m/hr"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3600.0;
}

[KnownUnit<Speed, MilePerHour, MeterPerSecond, Scalar>(KnownUnitType.Linear)]
public partial record MilePerHour
{
    public static string UnitSymbol { get; } = "mi/h";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["mph", "miph", "miphr", "mi/hr"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)2.2369362920544025;
}

[KnownUnit<Speed, FootPerSecond, MeterPerSecond, Scalar>(KnownUnitType.Linear)]
public partial record FootPerSecond
{
    public static string UnitSymbol { get; } = "ft/s";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ftps", "fps"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Foot.ScalingFactor;
}

[KnownUnit<Speed, Knot, MeterPerSecond, Scalar>(KnownUnitType.Linear)]
public partial record Knot
{
    public static string UnitSymbol { get; } = "kn";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kt", "nm/h", "nm/hr"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.9438444924406046;
}

[KnownUnit<Speed, SpeedOfLightVacuum, MeterPerSecond, Scalar>(KnownUnitType.Linear)]
public partial record SpeedOfLightVacuum
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "c0";
#else
    public static string UnitSymbol { get; } = "c₀";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["c"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3.3356409519815204957557671447491851179258151984597290969e-9;
}

[KnownUnit<Speed, Mach, MeterPerSecond, Scalar>(KnownUnitType.Linear)]
public partial record Mach
{
    public static string UnitSymbol { get; } = "Mach";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ma"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.PrefixedUnitNotation;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0029411764705882;
}

// furlong/fortnight
// furlong/microfortnight


// TODO:
// - speed
//      - mach / speed of sound (per medium)
//      - speed of light (per medium)
// - propagation speed of waves
//      - in different media
// - length contraction / lorentz factor
// - time dilation
