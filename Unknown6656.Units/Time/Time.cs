namespace Unknown6656.Units.Time;


#pragma warning disable IDE0004 // Remove Unnecessary Cast


[KnownBaseUnit<Time, Seconds, Scalar>]
public partial record Seconds(Scalar Value)
    : BaseUnit<Time, Seconds, Scalar>(Value)
    , IBaseUnit<Seconds, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "s";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Metric;
}

[KnownUnit<Time, Minutes, Seconds, Scalar>]
public partial record Minutes(Scalar Value)
    : Time.AffineUnit<Minutes>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Minutes, Seconds, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "min";
    public static UnitSystem UnitSystem { get; } = UnitSystem.NonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)60;
}

[KnownUnit<Time, Hours, Seconds, Scalar>]
public partial record Hours(Scalar Value)
    : Time.AffineUnit<Hours>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Hours, Seconds, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "h";
    public static UnitSystem UnitSystem { get; } = UnitSystem.NonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)3600;
}

[KnownUnit<Time, PlanckTime, Seconds, Scalar>]
public partial record PlanckTime(Scalar Value)
    : Time.AffineUnit<PlanckTime>(Value)
    , ILinearUnit<Scalar>
    , IUnit<PlanckTime, Seconds, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "tₚ";
    public static UnitSystem UnitSystem { get; } = UnitSystem.NonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)5.39116e-44;
}


// // - Time
// //      - datetime
// //      - from seconds, minutes, hours, days, weeks, months, years, ...
// //      - from ticks, ...
// //      - planck time
// //      - fortnight
// // Frequency
// //      - hertz
// //      - cesium frequency
