namespace Unknown6656.Units.Movement;


[KnownBaseUnit<VolumetricFlowRate, CubicMetersPerSecond, Scalar>]
public partial record CubicMetersPerSecond(Scalar Value)
    : BaseUnit<VolumetricFlowRate, CubicMetersPerSecond, Scalar>(Value)
    , IBaseUnit<CubicMetersPerSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "m³/s";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricNonSI;
}

[KnownUnit<VolumetricFlowRate, LitersPerSecond, CubicMetersPerSecond, Scalar>]
public partial record LitersPerSecond(Scalar Value)
    : VolumetricFlowRate.AffineUnit<LitersPerSecond>(Value)
    , ILinearUnit<Scalar>
    , IUnit<LitersPerSecond, CubicMetersPerSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "L/s";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1e3;
}
