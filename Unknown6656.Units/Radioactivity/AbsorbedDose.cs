namespace Unknown6656.Units.Radioactivity;


[KnownBaseUnit<AbsorbedDose, Gray, Scalar>]
public partial record Gray(Scalar Value)
    : BaseUnit<AbsorbedDose, Gray, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "Gy";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<AbsorbedDose, ErgPerGram, Gray, Scalar>]
public partial record ErgPerGram(Scalar Value)
    : AbsorbedDose.AffineUnit<ErgPerGram>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "erg/g";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e4;
}

[KnownUnit<AbsorbedDose, Rad, Gray, Scalar>]
public partial record Rad(Scalar Value)
    : AbsorbedDose.AffineUnit<Rad>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "rad";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e2;
}
