namespace Unknown6656.Units.Radioactivity;


[KnownBaseUnit<SpecificActivity, BecquerelPerKilogram, Scalar>]
public partial record BecquerelPerKilogram(Scalar Value)
    : BaseUnit<SpecificActivity, BecquerelPerKilogram, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "Bq/kg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["becquerel/kg", "becquerel/kilo", "Bq/kilo", "Bq/kilogram"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

// TODO : curie per gram


