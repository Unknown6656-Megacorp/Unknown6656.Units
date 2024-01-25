// #define ALLOW_W_AS_SYMBOL_FOR_OHM

namespace Unknown6656.Units.Electricity;


[KnownBaseUnit<Resistance, Ohm, Scalar>]
public partial record Ohm(Scalar Value)
    : BaseUnit<Resistance, Ohm, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "Ω";
#if ALLOW_W_AS_SYMBOL_FOR_OHM
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["W"];
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
