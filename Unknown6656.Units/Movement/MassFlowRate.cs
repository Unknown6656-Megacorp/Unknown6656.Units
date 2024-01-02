namespace Unknown6656.Units.Movement;


[KnownBaseUnit<MassFlowRate, KilogramPerSecond, Scalar>]
public partial record KilogramPerSecond(Scalar Value)
    : BaseUnit<MassFlowRate, KilogramPerSecond, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "kg/s";
    public static UnitDisplay UnitDisplay { get; } = Unit.MetricSI_Shifted_k;
}

[KnownUnit<MassFlowRate, MetricTonPerSecond, KilogramPerSecond, Scalar>]
public partial record MetricTonPerSecond(Scalar Value)
    : MassFlowRate.AffineUnit<MetricTonPerSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "t";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-3;
}

[KnownUnit<MassFlowRate, PoundPerSecond, KilogramPerSecond, Scalar>]
public partial record PoundPerSecond(Scalar Value)
    : MassFlowRate.AffineUnit<PoundPerSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lb";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)2.2046226218487757;
}

[KnownUnit<MassFlowRate, OuncePerSecond, KilogramPerSecond, Scalar>]
public partial record OuncePerSecond(Scalar Value)
    : MassFlowRate.AffineUnit<OuncePerSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "oz";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)35.27396194958041;
}

[KnownUnit<MassFlowRate, PlanckMassPerPlanckTime, KilogramPerSecond, Scalar>]
public partial record PlanckMassPerPlanckTime(Scalar Value)
    : MassFlowRate.AffineUnit<PlanckMassPerPlanckTime>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "mₚ/tₚ";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)2.4767851446758066576843206023376418356223089642890698915169e10-36;
}

[KnownUnit<MassFlowRate, KilogramPerMinute, KilogramPerSecond, Scalar>]
public partial record KilogramPerMinute(Scalar Value)
    : MassFlowRate.AffineUnit<KilogramPerMinute>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "kg/min";
    public static UnitDisplay UnitDisplay { get; } = Unit.MetricSI_Shifted_k;
    public static Scalar ScalingFactor { get; } = (Scalar)60;
}

[KnownUnit<MassFlowRate, KilogramPerHour, KilogramPerSecond, Scalar>]
public partial record KilogramPerHour(Scalar Value)
    : MassFlowRate.AffineUnit<KilogramPerHour>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "kg/h";
    public static UnitDisplay UnitDisplay { get; } = Unit.MetricSI_Shifted_k;
    public static Scalar ScalingFactor { get; } = (Scalar)3.6e3;
}
