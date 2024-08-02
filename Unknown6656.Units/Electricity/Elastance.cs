namespace Unknown6656.Units.Electricity;


[KnownBaseUnit<Elastance, InverseFarad, Scalar>]
public partial record InverseFarad
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "{0}F^-1";
#else
    public static string UnitSymbol { get; } = "{0}F⁻¹";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["daraf"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.UseInverseFormatStrings;
}
