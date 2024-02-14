namespace Unknown6656.Units.Magnetism;


[KnownBaseUnit<MagneticFlux, Weber, Scalar>]
public partial record Weber(Scalar Value)
    : BaseUnit<MagneticFlux, Weber, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "Wb";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<MagneticFlux, Maxwell, Weber, Scalar>]
public partial record Maxwell(Scalar Value)
    : MagneticFlux.AffineUnit<Maxwell>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Mx";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e8;
}
