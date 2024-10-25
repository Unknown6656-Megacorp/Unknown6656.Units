namespace Unknown6656.Units.Thermodynamics;


[KnownBaseUnit<ThermalExpansion, InverseKelvin, Scalar>]
public partial record InverseKelvin
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "{0}K^-1";
#else
    public static string UnitSymbol { get; } = "{0}K⁻¹";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["/kelvin", "/k", "inv k", "inverse k", "inv kelvin", "1/k", "1/kelvin", "kelvin^-1"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.UseInverseFormatStrings;
}
