﻿namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Speed, MeterPerSecond, Scalar>]
public partial record MeterPerSecond(Scalar Value)
    : BaseUnit<Speed, MeterPerSecond, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "m/s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Speed, KilometerPerHour, MeterPerSecond, Scalar>]
public partial record KilometerPerHour(Scalar Value)
    : Speed.AffineUnit<KilometerPerHour>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "km/h";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3.6;
}

[KnownUnit<Speed, MeterPerHour, MeterPerSecond, Scalar>]
public partial record MeterPerHour(Scalar Value)
    : Speed.AffineUnit<MeterPerHour>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "m/h";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3600;
}

[KnownUnit<Speed, MilePerHour, MeterPerSecond, Scalar>]
public partial record MilePerHour(Scalar Value)
    : Speed.AffineUnit<MilePerHour>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "mi/h";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)2.2369362920544025;
}

[KnownUnit<Speed, FootPerSecond, MeterPerSecond, Scalar>]
public partial record FootPerSecond(Scalar Value)
    : Speed.AffineUnit<FootPerSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ft/s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)3.280839895013123;
}

[KnownUnit<Speed, Knot, MeterPerSecond, Scalar>]
public partial record Knot(Scalar Value)
    : Speed.AffineUnit<Knot>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "kn";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.9438444924406046;
}

[KnownUnit<Speed, SpeedOfLightVacuum, MeterPerSecond, Scalar>]
public partial record SpeedOfLightVacuum(Scalar Value)
    : Speed.AffineUnit<SpeedOfLightVacuum>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "c₀";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3.3356409519815204957557671447491851179258151984597290969e-9;
}



[KnownUnit<Speed, Mach, MeterPerSecond, Scalar>]
public partial record Mach(Scalar Value)
    : Speed.AffineUnit<Mach>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Mach";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.PrefixedUnitNotation;
    public static Scalar ScalingFactor { get; } = (Scalar)340;
}


// TODO:
// - speed
//      - mach / speed of sound (per medium)
//      - speed of light (per medium)
// - propagation speed of waves
//      - in different media
// - length contraction / lorentz factor
// - time dilation
