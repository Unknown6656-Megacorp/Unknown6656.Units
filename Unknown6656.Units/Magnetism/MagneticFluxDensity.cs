namespace Unknown6656.Units.Magnetism;


[KnownBaseUnit<MagneticFluxDensity, Tesla, Scalar>]
public partial record Tesla
{
    public static string UnitSymbol { get; } = "T";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<MagneticFluxDensity, Gauss, Tesla, Scalar>(KnownUnitType.Linear)]
public partial record Gauss
{
    public static string UnitSymbol { get; } = "G";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e4;
}

[KnownUnit<MagneticFluxDensity, Gamma, Tesla, Scalar>(KnownUnitType.Linear)]
public partial record Gamma
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "gamma";
#else
    public static string UnitSymbol { get; } = "γ";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e9;
}
