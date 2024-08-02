// #define ALLOW_W_AS_SYMBOL_FOR_OHM

namespace Unknown6656.Units.Electricity;


[KnownBaseUnit<Resistance, Ohm, Scalar>]
public partial record Ohm
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Ohm";
#else
    public static string UnitSymbol { get; } = "Ω";
#endif
#if ALLOW_W_AS_SYMBOL_FOR_OHM
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["W"];
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
