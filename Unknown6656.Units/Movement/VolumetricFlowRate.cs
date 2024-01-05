namespace Unknown6656.Units.Movement;


[KnownBaseUnit<VolumetricFlowRate, CubicMeterPerSecond, Scalar>]
public partial record CubicMeterPerSecond(Scalar Value)
    : BaseUnit<VolumetricFlowRate, CubicMeterPerSecond, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "m³/s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
}

[KnownUnit<VolumetricFlowRate, LiterPerSecond, CubicMeterPerSecond, Scalar>]
public partial record LiterPerSecond(Scalar Value)
    : VolumetricFlowRate.AffineUnit<LiterPerSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "L/s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e3;
}

[KnownUnit<VolumetricFlowRate, GallonPerSecond, CubicMeterPerSecond, Scalar>]
public partial record GallonPerSecond(Scalar Value)
    : VolumetricFlowRate.AffineUnit<GallonPerSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "gal/s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)219.96915738094787;
}

[KnownUnit<VolumetricFlowRate, USGallonPerSecond, CubicMeterPerSecond, Scalar>]
public partial record USGallonPerSecond(Scalar Value)
    : VolumetricFlowRate.AffineUnit<USGallonPerSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "US gal/s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)264.17205235814842;
}

[KnownUnit<VolumetricFlowRate, BarrelPerSecond, CubicMeterPerSecond, Scalar>]
public partial record BarrelPerSecond(Scalar Value)
    : VolumetricFlowRate.AffineUnit<BarrelPerSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "bbl/s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)6.2898105697751;
}

