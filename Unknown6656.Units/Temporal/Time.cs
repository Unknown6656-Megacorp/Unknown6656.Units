namespace Unknown6656.Units.Temporal;


#pragma warning disable IDE0004 // Remove Unnecessary Cast


[KnownBaseUnit<Time, Second, Scalar>]
public partial record Second(Scalar Value)
    : BaseUnit<Time, Second, Scalar>(Value)
    , IBaseUnit<Second, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_OnlySubmultiple;
}

[KnownUnit<Time, Minute, Second, Scalar>]
public partial record Minute(Scalar Value)
    : Time.AffineUnit<Minute>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Minute, Second, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "min";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1 / (Scalar)60;
}

[KnownUnit<Time, Hour, Second, Scalar>]
public partial record Hour(Scalar Value)
    : Time.AffineUnit<Hour>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Hour, Second, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "h";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)2.7777777777777777777777777777778e-4;
}

#if !D128
[KnownUnit<Time, PlanckTime, Second, Scalar>]
public partial record PlanckTime(Scalar Value)
    : Time.AffineUnit<PlanckTime>(Value)
    , ILinearUnit<Scalar>
    , IUnit<PlanckTime, Second, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "tₚ";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1.8550948324478e43;
}
#endif


// - Time
//      - datetime
//      - from seconds, minutes, hours, days, weeks, months, years, ...
//      - from ticks, ...
//      - fortnight
