namespace Unknown6656.Units.Photometry;


[KnownBaseUnit<LuminousFlux, Lumen, Scalar>]
public partial record Lumen
{
    public static string UnitSymbol { get; } = "lm";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
