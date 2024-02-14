namespace Unknown6656.Units.Magnetism;


[KnownBaseUnit<MagneticFluxDensity, Tesla, Scalar>]
public partial record Tesla(Scalar Value)
    : BaseUnit<MagneticFluxDensity, Tesla, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "T";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<MagneticFluxDensity, Gauss, Tesla, Scalar>]
public partial record Gauss(Scalar Value)
    : MagneticFluxDensity.AffineUnit<Gauss>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "G";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e4;
}
