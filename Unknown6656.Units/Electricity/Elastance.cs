namespace Unknown6656.Units.Electricity;


[KnownBaseUnit<Elastance, InverseFarad, Scalar>]
public partial record InverseFarad(Scalar Value)
    : BaseUnit<Elastance, InverseFarad, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "{0}F⁻¹";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["daraf"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.UseInverseFormatStrings;
}
