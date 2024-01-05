namespace Unknown6656.Units.Matter;


[KnownBaseUnit<VolumetricMassDensity, KilogramPerCubicMeter, Scalar>]
public partial record KilogramPerCubicMeter(Scalar Value)
    : BaseUnit<VolumetricMassDensity, KilogramPerCubicMeter, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "kg/m³";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
}

[KnownUnit<VolumetricMassDensity, GramPerCubicMeter, KilogramPerCubicMeter, Scalar>]
public partial record GramPerCubicMeter(Scalar Value)
    : VolumetricMassDensity.AffineUnit<GramPerCubicMeter>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "g/m³";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e3;
}

[KnownUnit<VolumetricMassDensity, GramPerLiter, KilogramPerCubicMeter, Scalar>]
public partial record GramPerLiter(Scalar Value)
    : VolumetricMassDensity.AffineUnit<GramPerLiter>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "g/L";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1;
}

[KnownUnit<VolumetricMassDensity, PoundPerCubicInch, KilogramPerCubicMeter, Scalar>]
public partial record PoundPerCubicInch(Scalar Value)
    : VolumetricMassDensity.AffineUnit<PoundPerCubicInch>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lb/in³";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)3.6127292e-5;
}

[KnownUnit<VolumetricMassDensity, PoundPerCubicFoot, KilogramPerCubicMeter, Scalar>]
public partial record PoundPerCubicFoot(Scalar Value)
    : VolumetricMassDensity.AffineUnit<PoundPerCubicFoot>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lb/ft³";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)16.018463;
}
