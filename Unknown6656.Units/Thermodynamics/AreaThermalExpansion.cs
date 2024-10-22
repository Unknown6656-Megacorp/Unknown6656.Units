namespace Unknown6656.Units.Thermodynamics;


[KnownBaseUnit<AreaThermalExpansion, SquareMeterPerKelvin, Scalar>]
public partial record SquareMeterPerKelvin
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "m^2/K";
#else
    public static string UnitSymbol { get; } = "m²/K";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["m^2/kelvin", "meter^2/k", "meter^2/kelvin", "square meter/k"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
}

// TODO : add all imperial units
