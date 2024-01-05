namespace Unknown6656.Units.Euclidean;


[KnownBaseUnit<LinearWavenumber, ReciprocalMeter, Scalar>]
public partial record ReciprocalMeter(Scalar Value)
    : BaseUnit<LinearWavenumber, ReciprocalMeter, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "{0}m¯¹";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.UseInverseFormatStrings;
}

[KnownUnit<LinearWavenumber, Kayser, ReciprocalMeter, Scalar>]
public partial record Kayser(Scalar Value)
    : LinearWavenumber.AffineUnit<Kayser>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "cm¯¹";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static double ScalingFactor { get; } = (Scalar)1e-2;
}
