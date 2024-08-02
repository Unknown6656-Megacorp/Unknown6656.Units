namespace Unknown6656.Units.Photometry;


[KnownBaseUnit<LuminousEfficacy, LumenPerWatt, Scalar>]
public partial record LumenPerWatt
{
    public static string UnitSymbol { get; } = "lm/W";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lm/watt", "lumen/W"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
