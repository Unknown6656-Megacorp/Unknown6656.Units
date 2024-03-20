namespace Unknown6656.Units.Magnetism;


[KnownBaseUnit<MagneticFlux, Weber, Scalar>]
public partial record Weber
{
    public static string UnitSymbol { get; } = "Wb";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<MagneticFlux, Maxwell, Weber, Scalar>(KnownUnitType.Linear)]
public partial record Maxwell
{
    public static string UnitSymbol { get; } = "Mx";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e8;
}
