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
    static string[] IUnit.AlternativeUnitSymbols { get; } = [
        "K*m/W", "m*K/W", "K*meter/W", "meter*K/W", "K*m/watt", "m*K/watt", "K*meter/watt", "meter*K/watt", "kelvin*m/W",
        "m*kelvin/W", "kelvin*meter/W", "meter*kelvin/W", "kelvin*m/watt", "m*kelvin/watt", "kelvin*meter/watt", "meter*kelvin/watt",
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

// TODO : imperial equivalents