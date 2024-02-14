namespace Unknown6656.Units.Photometry;


[KnownBaseUnit<LuminousEfficacy, LumenPerWatt, Scalar>]
public partial record LumenPerWatt(Scalar Value)
    : BaseUnit<LuminousEfficacy, LumenPerWatt, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "lm/W";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lm/watt", "lumen/W"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
