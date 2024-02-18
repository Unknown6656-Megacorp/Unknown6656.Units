using System;

using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Euclidean;


[KnownBaseUnit<Angle, Radian, Scalar>]
public partial record Radian(Scalar Value)
    : BaseUnit<Angle, Radian, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "rad";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Angle, Degree, Radian, Scalar>]
public partial record Degree(Scalar Value)
    : Angle.AffineUnit<Degree>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Angle, Gradian, Radian, Scalar>]
public partial record Gradian(Scalar Value)
    : Angle.AffineUnit<Gradian>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Angle, ArcMinute, Radian, Scalar>]
public partial record ArcMinute(Scalar Value)
    : Angle.AffineUnit<ArcMinute>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "'";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["arc'", "arc min"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = Degree.ScalingFactor / Minute.ScalingFactor;
}

[KnownUnit<Angle, ArcSecond, Radian, Scalar>]
public partial record ArcSecond(Scalar Value)
    : Angle.AffineUnit<ArcSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "\"";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["arc\"", "arc sec"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = Degree.ScalingFactor / Hour.ScalingFactor;
}

[KnownUnit<Angle, Turn, Radian, Scalar>]
public partial record Turn(Scalar Value)
    : Angle.AffineUnit<Turn>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "turns";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Math.Tau;
}

[KnownUnit<Angle, HourAngle, Radian, Scalar>]
public partial record HourAngle(Scalar Value)
    : Angle.AffineUnit<HourAngle>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "h";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["arc h", "arc hr", "arc hour"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)(12 / Math.PI);


    public static explicit operator Hour(HourAngle angle) => new(angle.Value);

    public static explicit operator HourAngle(Hour hour) => new(hour.Value);
}

[KnownUnit<Angle, Furman, Radian, Scalar>]
public partial record Furman(Scalar Value)
    : Angle.AffineUnit<Furman>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "furman";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = Turn.ScalingFactor * 65_536;
}

[KnownUnit<Angle, BinaryDegree, Radian, Scalar>]
public partial record BinaryDegree(Scalar Value)
    : Angle.AffineUnit<BinaryDegree>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "brad";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bin degree", "bin radian", "furboy", "small furman", "mifurman"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = Turn.ScalingFactor * 256;
}

[KnownUnit<Angle, NATOmil, Radian, Scalar>]
public partial record NATOmil(Scalar Value)
    : Angle.AffineUnit<NATOmil>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "NATO mil";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["mil"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = Turn.ScalingFactor * 6400;
}

[KnownUnit<Angle, Streck, Radian, Scalar>]
public partial record Streck(Scalar Value)
    : Angle.AffineUnit<Streck>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "streck";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["SWE streck", "streck SWE", "SE streck", "streck SE", "swedish streck"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = Turn.ScalingFactor * 6300;
}


// angular velocity:
// MERU = 7.292115×10−8 rad/sec
