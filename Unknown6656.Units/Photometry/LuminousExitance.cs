namespace Unknown6656.Units.Photometry;


[KnownBaseUnit<LuminousExitance, LumenPerSquareMeter, Scalar>]
public partial record LumenPerSquareMeter(Scalar Value)
    : BaseUnit<LuminousExitance, LumenPerSquareMeter, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lm/m^2";
#else
    public static string UnitSymbol { get; } = "lm/m²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lm/meter^2", "lumen/m^2", "lm*m^-2", "lumen*m^-2", "lm*meter^-2", "lumen*meter^-2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
