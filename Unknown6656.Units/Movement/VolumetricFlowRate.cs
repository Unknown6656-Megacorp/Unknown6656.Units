using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Movement;


[KnownBaseUnit<VolumetricFlowRate, CubicMeterPerSecond, Scalar>]
public partial record CubicMeterPerSecond(Scalar Value)
    : BaseUnit<VolumetricFlowRate, CubicMeterPerSecond, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "m^3/s";
#else
    public static string UnitSymbol { get; } = "m³/s";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["cubic meter/second", "cubic m/s", "cubic meter/s", "meter^3/s", "meter^3/second", "m^3/second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
}

[KnownUnit<VolumetricFlowRate, LiterPerSecond, CubicMeterPerSecond, Scalar>]
public partial record LiterPerSecond(Scalar Value)
    : VolumetricFlowRate.AffineUnit<LiterPerSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "L/s";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["liter/second", "liter/s", "L/second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Liter.ScalingFactor;
}

[KnownUnit<VolumetricFlowRate, CubicFootPerSecond, CubicMeterPerSecond, Scalar>]
public partial record CubicFootPerSecond(Scalar Value)
    : VolumetricFlowRate.AffineUnit<CubicFootPerSecond>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "ft^3/s";
#else
    public static string UnitSymbol { get; } = "ft³/s";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["cubic feet/second", "cubic ft/s", "cubic feet/s", "feet^3/s", "feet^3/second", "ft^3/second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = CubicFoot.ScalingFactor;
}

[KnownUnit<VolumetricFlowRate, CubicInchPerSecond, CubicMeterPerSecond, Scalar>]
public partial record CubicInchPerSecond(Scalar Value)
    : VolumetricFlowRate.AffineUnit<CubicInchPerSecond>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "in^3/s";
#else
    public static string UnitSymbol { get; } = "in³/s";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["cubic inch/second", "cubic in/s", "cubic inch/s", "inch^3/s", "inch^3/second", "in^3/second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = CubicInch.ScalingFactor;
}

[KnownUnit<VolumetricFlowRate, GallonPerSecond, CubicMeterPerSecond, Scalar>]
public partial record GallonPerSecond(Scalar Value)
    : VolumetricFlowRate.AffineUnit<GallonPerSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "imp gal/s";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["imperial gal/s", "imp gallon/s", "gallon imp/s", "gal imp/s", "UK gal/s", "gal UK/s", "UK gallon/s", "gallon UK/s",
        "imperial gal/second", "imp gallon/second", "gallon imp/second", "gal imp/second", "UK gal/second", "gal UK/second", "UK gallon/second", "gallon UK/second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Gallon.ScalingFactor;
}

[KnownUnit<VolumetricFlowRate, USGallonPerSecond, CubicMeterPerSecond, Scalar>]
public partial record USGallonPerSecond(Scalar Value)
    : VolumetricFlowRate.AffineUnit<USGallonPerSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "US gal/s";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["gal us/s", "gallon us/s", "gal us/second", "gallon us/second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = USGallon.ScalingFactor;
}

[KnownUnit<VolumetricFlowRate, BarrelPerSecond, CubicMeterPerSecond, Scalar>]
public partial record BarrelPerSecond(Scalar Value)
    : VolumetricFlowRate.AffineUnit<BarrelPerSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "bbl/s";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["US bbl/s", "US barrel/s", "bbl US/s", "barrel US/s", "US bbl/second", "US barrel/second", "bbl US/second", "barrel US/second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Barrel.ScalingFactor;
}
