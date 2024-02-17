namespace Unknown6656.Units.Information;


[KnownBaseUnit<SpecificInformationCapacity, BitPerKilogram, Scalar>]
public partial record BitPerKilogram(Scalar Value)
    : BaseUnit<SpecificInformationCapacity, BitPerKilogram, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "bit/kg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/kilo"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
