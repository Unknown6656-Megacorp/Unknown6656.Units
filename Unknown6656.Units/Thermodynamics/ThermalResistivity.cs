namespace Unknown6656.Units.Thermodynamics;


[KnownBaseUnit<ThermalResistivity, KelvinMeterPerWatt, Scalar>]
public partial record KelvinMeterPerWatt(Scalar Value)
    : BaseUnit<ThermalResistivity, KelvinMeterPerWatt, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "K*m/W";
#else
    public static string UnitSymbol { get; } = "K·m·W⁻¹";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = [.];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
