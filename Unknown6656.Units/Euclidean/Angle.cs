using System;

namespace Unknown6656.Units.Euclidean;


[KnownBaseUnit<Angle, Radian, Scalar>]
public partial record Radian(Scalar Value)
    : BaseUnit<Angle, Radian, Scalar>(Value)
    , IBaseUnit<Radian, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "rad";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}

[KnownUnit<Angle, Degree, Radian, Scalar>]
public partial record Degree(Scalar Value)
    : Angle.AffineUnit<Degree>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Degree, Radian, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "°";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)(180 / Math.PI);
}

[KnownUnit<Angle, Gradian, Radian, Scalar>]
public partial record Gradian(Scalar Value)
    : Angle.AffineUnit<Gradian>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Gradian, Radian, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "gon"; // ᵍ
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)(200 / Math.PI);
}

[KnownUnit<Angle, ArcMinute, Radian, Scalar>]
public partial record ArcMinute(Scalar Value)
    : Angle.AffineUnit<ArcMinute>(Value)
    , ILinearUnit<Scalar>
    , IUnit<ArcMinute, Radian, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "'";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)3437.7467707849392526078892888463102199443283479938592929496146316;
}

[KnownUnit<Angle, ArcSecond, Radian, Scalar>]
public partial record ArcSecond(Scalar Value)
    : Angle.AffineUnit<ArcSecond>(Value)
    , ILinearUnit<Scalar>
    , IUnit<ArcSecond, Radian, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "\"";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)206264.80624709635515647335733077861319665970087963155757697687790;
}

[KnownUnit<Angle, Turn, Radian, Scalar>]
public partial record Turn(Scalar Value)
    : Angle.AffineUnit<Turn>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Turn, Radian, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "turns";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.1591549430918953357688837633725143620344596457404564487476673440;
}
