namespace Unknown6656.Units.Thermodynamics;


[KnownBaseUnit<VolumetricThermalExpansion, CubicMeterPerKelvin, Scalar>]
public partial record CubicMeterPerKelvin
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "m^3/K";
#else
    public static string UnitSymbol { get; } = "m³/K";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["m^3/kelvin", "meter^3/k", "meter^3/kelvin", "cubic meter/k"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
}

// TODO : add all imperial units
