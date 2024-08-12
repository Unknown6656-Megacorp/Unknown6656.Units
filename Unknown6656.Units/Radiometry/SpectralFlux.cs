namespace Unknown6656.Units.Radiometry;


[KnownBaseUnit<SpectralFlux, WattPerHertz, Scalar>]
public partial record WattPerHertz
{
    public static string UnitSymbol { get; } = "W/Hz";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["watt/hz", "W/hertz"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
