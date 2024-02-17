namespace Unknown6656.Units.Information;


[KnownBaseUnit<VolumetricInformationDensity, BitPerCubicMeter, Scalar>]
public partial record BitPerCubicMeter(Scalar Value)
    : BaseUnit<VolumetricInformationDensity, BitPerCubicMeter, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "bit/m^3";
#else
    public static string UnitSymbol { get; } = "bit/m�";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/cb meter", "bit/meter^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

// TODO : bit/in^3, bit/ft^3
// TODO : byte/in^3, byte/ft^3
// TODO : byte/m^3, byte/mm^3
// TODO : bit/mm^3