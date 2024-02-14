namespace Unknown6656.Units.Euclidean;


[KnownBaseUnit<LinearWavenumber, ReciprocalMeter, Scalar>]
public partial record ReciprocalMeter(Scalar Value)
    : BaseUnit<LinearWavenumber, ReciprocalMeter, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "{0}m^-1";
#else
    public static string UnitSymbol { get; } = "{0}m¯¹";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["m^-1", "reciprocal m"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.UseInverseFormatStrings;
}

[KnownUnit<LinearWavenumber, Kayser, ReciprocalMeter, Scalar>]
public partial record Kayser(Scalar Value)
    : LinearWavenumber.AffineUnit<Kayser>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "cm^-1";
#else
    public static string UnitSymbol { get; } = "cm¯¹";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["cm^-1", "reciprocal cm", "reciprocal centimeter", "centimeter^-1"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static double ScalingFactor { get; } = (Scalar)1e-2;
}
