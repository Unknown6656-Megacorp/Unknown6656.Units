namespace Unknown6656.Units.Photometry;


[KnownBaseUnit<LuminousExposure, LuxSecond, Scalar>]
public partial record LuxSecond(Scalar Value)
    : BaseUnit<LuminousExposure, LuxSecond, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lx*s";
#else
    public static string UnitSymbol { get; } = "lx·s";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lux s", "lx second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
