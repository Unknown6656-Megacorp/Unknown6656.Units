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

[KnownUnit<VolumetricFlowRate, GallonsPerSecond, CubicMetersPerSecond, Scalar>]
public partial record GallonsPerSecond(Scalar Value)
    : VolumetricFlowRate.AffineUnit<GallonsPerSecond>(Value)
    , ILinearUnit<Scalar>
    , IUnit<GallonsPerSecond, CubicMetersPerSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "gal/s";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)219.96915738094787;
}

[KnownUnit<VolumetricFlowRate, USGallonsPerSecond, CubicMetersPerSecond, Scalar>]
public partial record USGallonsPerSecond(Scalar Value)
    : VolumetricFlowRate.AffineUnit<USGallonsPerSecond>(Value)
    , ILinearUnit<Scalar>
    , IUnit<USGallonsPerSecond, CubicMetersPerSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "US gal/s";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)264.17205235814842;
}

[KnownUnit<VolumetricFlowRate, BarrelsPerSecond, CubicMetersPerSecond, Scalar>]
public partial record BarrelsPerSecond(Scalar Value)
    : VolumetricFlowRate.AffineUnit<BarrelsPerSecond>(Value)
    , ILinearUnit<Scalar>
    , IUnit<BarrelsPerSecond, CubicMetersPerSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "bbl/s";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)6.2898105697751;
}




