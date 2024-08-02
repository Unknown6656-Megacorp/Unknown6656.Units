namespace Unknown6656.Units.Thermodynamics;


[KnownBaseUnit<ThermalConductivity, WattPerMeterKelvin, Scalar>]
public partial record WattPerMeterKelvin
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "W/m/K";
#else
    public static string UnitSymbol { get; } = "W·m⁻¹K⁻¹";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = [
        "K/m/W", "m/K/W", "K/(m*W)", "m/(K*W)", "K/meter/W", "meter/K/W", "K/(meter*W)", "meter/(K*W)", "K/m/watt", "m/K/watt",
        "K/(m*watt)", "m/(K*watt)", "K/meter/watt", "meter/K/watt", "K/(meter*watt)", "meter/(K*watt)", "kelvin/m/W", "m/kelvin/W",
        "kelvin/(m*W)", "m/(kelvin*W)", "kelvin/meter/W", "meter/kelvin/W", "kelvin/(meter*W)", "meter/(kelvin*W)", "kelvin/m/watt",
        "m/kelvin/watt", "kelvin/(m*watt)", "m/(kelvin*watt)", "kelvin/meter/watt", "meter/kelvin/watt", "kelvin/(meter*watt)", "meter/(kelvin*watt)",
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

// TODO : imperial equivalents