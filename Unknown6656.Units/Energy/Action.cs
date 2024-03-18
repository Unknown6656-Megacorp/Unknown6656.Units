namespace Unknown6656.Units.Energy;


[KnownBaseUnit<Action, JouleSecond, Scalar>]
public partial record JouleSecond
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "J*s";
#else
    public static string UnitSymbol { get; } = "J·s";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["joule*s", "joule*sec", "j*sec", "j*second", "jsec", "jsecond", "js"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
