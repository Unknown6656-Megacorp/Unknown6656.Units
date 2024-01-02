namespace Unknown6656.Units.Euclidean;


[KnownBaseUnit<LinearWavenumber, ReciprocalMeter, Scalar>]
public partial record ReciprocalMeter(Scalar Value)
    : BaseUnit<LinearWavenumber, ReciprocalMeter, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "1/{0}m";
    public static UnitDisplay UnitDisplay { get; } = Unit.MetricSI_InverseFormatted;
}

[KnownUnit<LinearWavenumber, Kayser, ReciprocalMeter, Scalar>]
public partial record Kayser(Scalar Value)
    : LinearWavenumber.AffineUnit<Kayser>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "cm¯¹";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static double ScalingFactor { get; } = (Scalar)1e-2;
}
