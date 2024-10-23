namespace Unknown6656.Units.Magnetism;


[KnownBaseUnit<MassMagneticSusceptibility, CubicMeterPerKilogram, Scalar>]
public partial record CubicMeterPerKilogram
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "m^3/kg";
#else
    public static string UnitSymbol { get; } = "m³·kg⁻¹";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["m^3/kg", "cubic meter/kg", "cubic meter/kilo", "m^3/kilo"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
}
