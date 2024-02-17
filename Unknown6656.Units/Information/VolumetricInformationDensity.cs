namespace Unknown6656.Units.Information;


[KnownBaseUnit<VolumetricInformationDensity, BitPerCubicMeter, Scalar>]
public partial record BitPerCubicMeter(Scalar Value)
    : BaseUnit<VolumetricInformationDensity, BitPerCubicMeter, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "bit/m^3";
#else
    public static string UnitSymbol { get; } = "bit/m³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/cb meter", "bit/meter^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
