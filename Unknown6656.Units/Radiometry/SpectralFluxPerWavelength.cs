namespace Unknown6656.Units.Radiometry;


[KnownBaseUnit<SpectralFluxPerWavelength, WattPerNanometer, Scalar>]
public partial record WattPerNanometer
{
    public static string UnitSymbol { get; } = "W/nm";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["W/nanometer", "watt/nm"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<SpectralFluxPerWavelength, WattPerMeter, WattPerNanometer, Scalar>(KnownUnitType.Linear)]
public partial record WattPerMeter
{
    public static string UnitSymbol { get; } = "W/m";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["W/meter", "watt/m"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-9;
}
