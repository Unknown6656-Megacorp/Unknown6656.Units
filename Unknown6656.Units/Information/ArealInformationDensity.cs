namespace Unknown6656.Units.Information;


[KnownBaseUnit<ArealInformationDensity, BitPerSquareMeter, Scalar>]
public partial record BitPerSquareMeter(Scalar Value)
    : BaseUnit<ArealInformationDensity, BitPerSquareMeter, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "bit/m^2";
#else
    public static string UnitSymbol { get; } = "bit/m²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/sqm", "bit/sq meter", "bit/meter^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

// TODO : bit/in^2, bit/ft^2
// TODO : byte/in^2, byte/ft^2
// TODO : byte/m^2, byte/mm^2
// TODO : bit/m^2, bit/mm^2