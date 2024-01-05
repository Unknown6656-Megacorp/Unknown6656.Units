namespace Unknown6656.Units.Matter;


[KnownBaseUnit<MolarMass, GramPerMol, Scalar>]
public partial record GramPerMol(Scalar Value)
    : BaseUnit<MolarMass, GramPerMol, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "g/mol";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
