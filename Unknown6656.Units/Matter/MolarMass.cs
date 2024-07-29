namespace Unknown6656.Units.Matter;


[KnownBaseUnit<MolarMass, KilogramPerMol, Scalar>]
public partial record KilogramPerMol
{
    public static string UnitSymbol { get; } = "kg/mol";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kilog/mol", "kilo/mol"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
}

// TODO : imperial equivalents