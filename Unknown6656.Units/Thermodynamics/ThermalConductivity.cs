namespace Unknown6656.Units.Thermodynamics;


[KnownBaseUnit<ThermalConductivity, WattPerMeterKelvin, Scalar>]
public partial record WattPerMeterKelvin(Scalar Value)
    : BaseUnit<ThermalConductivity, WattPerMeterKelvin, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "W/m/K";
#else
    public static string UnitSymbol { get; } = "W·m⁻¹K⁻¹";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = [.];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
