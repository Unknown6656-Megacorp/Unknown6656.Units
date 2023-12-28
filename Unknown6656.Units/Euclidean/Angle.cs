using System;

namespace Unknown6656.Units.Euclidean;


[KnownBaseUnit<Angle, Radians, Scalar>]
public partial record Radians(Scalar Value)
    : BaseUnit<Angle, Radians, Scalar>(Value)
    , IBaseUnit<Radians, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "rad";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricSI;
}

[KnownUnit<Angle, Degrees, Radians, Scalar>]
public partial record Degrees(Scalar Value)
    : Angle.AffineUnit<Degrees>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Degrees, Radians, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "°";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)(180 / Math.PI);
}

[KnownUnit<Angle, Gradians, Radians, Scalar>]
public partial record Gradians(Scalar Value)
    : Angle.AffineUnit<Gradians>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Gradians, Radians, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "gon"; // ᵍ
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)(200 / Math.PI);
}

[KnownUnit<Angle, ArcMinutes, Radians, Scalar>]
public partial record ArcMinutes(Scalar Value)
    : Angle.AffineUnit<ArcMinutes>(Value)
    , ILinearUnit<Scalar>
    , IUnit<ArcMinutes, Radians, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "'";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)3437.7467707849392526078892888463102199443283479938592929496146316;
}

[KnownUnit<Angle, ArcSeconds, Radians, Scalar>]
public partial record ArcSeconds(Scalar Value)
    : Angle.AffineUnit<ArcSeconds>(Value)
    , ILinearUnit<Scalar>
    , IUnit<ArcSeconds, Radians, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "\"";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)206264.80624709635515647335733077861319665970087963155757697687790;
}

[KnownUnit<Angle, Turns, Radians, Scalar>]
public partial record Turns(Scalar Value)
    : Angle.AffineUnit<Turns>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Turns, Radians, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "turns";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.1591549430918953357688837633725143620344596457404564487476673440;
}
