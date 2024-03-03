using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<Speed, MeterPerSecond, Scalar>]
public partial record MeterPerSecond(Scalar Value)
    : BaseUnit<Speed, MeterPerSecond, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "m/s";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["mps"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Speed, KilometerPerHour, MeterPerSecond, Scalar>]
public partial record KilometerPerHour(Scalar Value)
    : Speed.AffineUnit<KilometerPerHour>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "km/h";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kph", "kphr", "km/hr"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3.6;
}

[KnownUnit<Speed, MeterPerHour, MeterPerSecond, Scalar>]
public partial record MeterPerHour(Scalar Value)
    : Speed.AffineUnit<MeterPerHour>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "m/h";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["m/hr"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3600.0;
}

[KnownUnit<Speed, MilePerHour, MeterPerSecond, Scalar>]
public partial record MilePerHour(Scalar Value)
    : Speed.AffineUnit<MilePerHour>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "mi/h";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["mph", "miph", "miphr", "mi/hr"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)2.2369362920544025;
}

[KnownUnit<Speed, FootPerSecond, MeterPerSecond, Scalar>]
public partial record FootPerSecond(Scalar Value)
    : Speed.AffineUnit<FootPerSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ft/s";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ftps", "fps"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Foot.ScalingFactor;
}

[KnownUnit<Speed, Knot, MeterPerSecond, Scalar>]
public partial record Knot(Scalar Value)
    : Speed.AffineUnit<Knot>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "kn";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kt", "nm/h", "nm/hr"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.9438444924406046;
}

[KnownUnit<Speed, SpeedOfLightVacuum, MeterPerSecond, Scalar>]
public partial record SpeedOfLightVacuum(Scalar Value)
    : Speed.AffineUnit<SpeedOfLightVacuum>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Speed, Mach, MeterPerSecond, Scalar>]
public partial record Mach(Scalar Value)
    : Speed.AffineUnit<Mach>(Value)
    , ILinearUnit<Scalar>
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
