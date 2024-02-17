namespace Unknown6656.Units.Information;


[KnownBaseUnit<BitRate, BitPerSecond, Scalar>]
public partial record BitPerSecond(Scalar Value)
    : BaseUnit<BitRate, BitPerSecond, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "bps";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/s"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
