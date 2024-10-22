namespace Unknown6656.Units.Thermodynamics;


[KnownBaseUnit<LinearThermalExpansion, MeterPerKelvin, Scalar>]
public partial record MeterPerKelvin
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "m/K";
#else
    public static string UnitSymbol { get; } = "m/K";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["m/kelvin", "meter/k"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
}

// TODO : add all imperial units
