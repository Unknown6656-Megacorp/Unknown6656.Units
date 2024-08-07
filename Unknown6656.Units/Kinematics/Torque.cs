﻿using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<Torque, NewtonMeter, Scalar>]
public partial record NewtonMeter
{
    public static string UnitSymbol { get; } = "Nm";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["newton m", "n meter"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Torque, FootPound, NewtonMeter, Scalar>(KnownUnitType.Linear)]
public partial record FootPound
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lb*ft";
#else
    public static string UnitSymbol { get; } = "lb·ft";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lb foot", "lbf foot", "foot lb", "foot lbf", "ft pound", "pound foot", "lbs ft", "ft lb", "ft lbf", "lbf ft", "pound ft"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = PoundForce.ScalingFactor * Foot.ScalingFactor;
}

[KnownUnit<Torque, PoundInch, NewtonMeter, Scalar>(KnownUnitType.Linear)]
public partial record PoundInch
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lb*in";
#else
    public static string UnitSymbol { get; } = "lb·in";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lb inch", "lbf inch", "lb in", "lbf in", "pound in", "inch lb", "inch lbf", "inch pound", "in lb", "in lbf", "in pound"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = PoundForce.ScalingFactor * Inch.ScalingFactor;
}

[KnownUnit<Torque, OunceInch, NewtonMeter, Scalar>(KnownUnitType.Linear)]
public partial record OunceInch
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "oz*in";
#else
    public static string UnitSymbol { get; } = "oz·in";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ounce in", "in ounce", "inch ounce", "oz inch", "in oz", "inch oz"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = OunceForce.ScalingFactor * Inch.ScalingFactor;
}
