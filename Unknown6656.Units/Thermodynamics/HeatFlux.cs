namespace Unknown6656.Units.Thermodynamics;


[KnownBaseUnit<HeatFlux, WattPerSquareMeter, Scalar>]
public partial record WattPerSquareMeter(Scalar Value)
    : BaseUnit<HeatFlux, WattPerSquareMeter, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "W/m^2";
#else
    public static string UnitSymbol { get; } = "W/m²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["watt/sq meter", "watt/square meter", "watt/sqm", "w/sqm", "w/square meter", "w/sq meter", "watt/m^2", "w/m^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
