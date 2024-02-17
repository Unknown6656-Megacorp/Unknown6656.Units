namespace Unknown6656.Units.Information;


[KnownBaseUnit<LinearInformationDensity, BitPerMeter, Scalar>]
public partial record BitPerMeter(Scalar Value)
    : BaseUnit<LinearInformationDensity, BitPerMeter, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "bit/m";
    static string[] IUnit.AlternativeUnitSymbols { get; } = [];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
