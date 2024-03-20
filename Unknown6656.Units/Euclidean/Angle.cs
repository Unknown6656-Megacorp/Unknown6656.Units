using System;

using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Euclidean;


[KnownBaseUnit<Angle, Radian, Scalar>]
public partial record Radian
{
    public static string UnitSymbol { get; } = "rad";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Angle, Degree, Radian, Scalar>(KnownUnitType.Linear)]
public partial record Degree
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "deg";
#else
    public static string UnitSymbol { get; } = "°";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["deg"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)(180 / Math.PI);
}

[KnownUnit<Angle, Gradian, Radian, Scalar>(KnownUnitType.Linear)]
public partial record Gradian
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "gon";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ᵍ"];
#else
    public static string UnitSymbol { get; } = "ᵍ";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["gon"];
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)(200 / Math.PI);
}

[KnownUnit<Angle, ArcMinute, Radian, Scalar>(KnownUnitType.Linear)]
public partial record ArcMinute
{
    public static string UnitSymbol { get; } = "'";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["arc'", "arc min"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = Degree.ScalingFactor / Minute.ScalingFactor;
}

[KnownUnit<Angle, ArcSecond, Radian, Scalar>(KnownUnitType.Linear)]
public partial record ArcSecond
{
    public static string UnitSymbol { get; } = "\"";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["arc\"", "arc sec"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = Degree.ScalingFactor / Hour.ScalingFactor;
}

[KnownUnit<Angle, Turn, Radian, Scalar>(KnownUnitType.Linear)]
public partial record Turn
{
    public static string UnitSymbol { get; } = "turns";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Math.Tau;
}

[KnownUnit<Angle, HourAngle, Radian, Scalar>(KnownUnitType.Linear)]
public partial record HourAngle
{
    public static string UnitSymbol { get; } = "h";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["arc h", "arc hr", "arc hour"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)(12 / Math.PI);


    public static explicit operator Hour(HourAngle angle) => new(angle.Value);

    public static explicit operator HourAngle(Hour hour) => new(hour.Value);
}

[KnownUnit<Angle, Furman, Radian, Scalar>(KnownUnitType.Linear)]
public partial record Furman
{
    public static string UnitSymbol { get; } = "furman";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = Turn.ScalingFactor * 65_536;
}

[KnownUnit<Angle, BinaryDegree, Radian, Scalar>(KnownUnitType.Linear)]
public partial record BinaryDegree
{
    public static string UnitSymbol { get; } = "brad";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bin degree", "bin radian", "furboy", "small furman", "mifurman"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = Turn.ScalingFactor * 256;
}

[KnownUnit<Angle, NATOmil, Radian, Scalar>(KnownUnitType.Linear)]
public partial record NATOmil
{
    public static string UnitSymbol { get; } = "NATO mil";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["mil"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = Turn.ScalingFactor * 6400;
}

[KnownUnit<Angle, Streck, Radian, Scalar>(KnownUnitType.Linear)]
public partial record Streck
{
    public static string UnitSymbol { get; } = "streck";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["SWE streck", "streck SWE", "SE streck", "streck SE", "swedish streck"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = Turn.ScalingFactor * 6300;
}

// angular velocity:
// MERU = 7.292115×10−8 rad/sec
