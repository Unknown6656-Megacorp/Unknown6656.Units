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
    public static string UnitSymbol { get; } = "gon"; // ᵍ
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ᵍ"];
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
    public static Scalar ScalingFactor { get; } = (Scalar)3437.7467707849392526078892888463102199443283479938592929496146316;
}

[KnownUnit<Angle, ArcSecond, Radian, Scalar>]
public partial record ArcSecond(Scalar Value)
    : Angle.AffineUnit<ArcSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "\"";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["arc\"", "arc sec"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)206264.80624709635515647335733077861319665970087963155757697687790;
}

[KnownUnit<Angle, Turn, Radian, Scalar>]
public partial record Turn(Scalar Value)
    : Angle.AffineUnit<Turn>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "turns";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.1591549430918953357688837633725143620344596457404564487476673440;
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
