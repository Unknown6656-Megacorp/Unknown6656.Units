﻿using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<Acceleration, MeterPerSecondSquared, Scalar>]
public partial record MeterPerSecondSquared
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "m/s^2";
#else
    public static string UnitSymbol { get; } = "m/s²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["meter/s^2", "m/second^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Acceleration, FootPerSecondSquared, MeterPerSecondSquared, Scalar>(KnownUnitType.Linear)]
public partial record FootPerSecondSquared
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "ft/s^2";
#else
    public static string UnitSymbol { get; } = "ft/s²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["feet/s^2", "ft/second^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Foot.ScalingFactor;
}

[KnownUnit<Acceleration, Gal, MeterPerSecondSquared, Scalar>(KnownUnitType.Linear)]
public partial record Gal
{
    public static string UnitSymbol { get; } = "Gal";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e2;
}

[KnownUnit<Acceleration, G, MeterPerSecondSquared, Scalar>(KnownUnitType.Linear)]
public partial record G
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "g";
#else
    public static string UnitSymbol { get; } = "g₀";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["g0"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.1019716212977928242570092743189570342573661749934993091422657074;
}
