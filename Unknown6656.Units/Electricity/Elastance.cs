namespace Unknown6656.Units.Electricity;


[KnownBaseUnit<Elastance, InverseFarad, Scalar>]
public partial record InverseFarad(Scalar Value)
    : BaseUnit<Elastance, InverseFarad, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "{0}F^-1";
#else
    public static string UnitSymbol { get; } = "{0}F⁻¹";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["daraf"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.UseInverseFormatStrings;
}
