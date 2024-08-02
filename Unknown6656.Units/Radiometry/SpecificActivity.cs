using Unknown6656.Units.Matter;

namespace Unknown6656.Units.Radiometry;


[KnownBaseUnit<SpecificActivity, BecquerelPerKilogram, Scalar>]
public partial record BecquerelPerKilogram
{
    public static string UnitSymbol { get; } = "Bq/kg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["becquerel/kg", "becquerel/kilo", "Bq/kilo", "Bq/kilogram"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<SpecificActivity, CuriePerGram, BecquerelPerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record CuriePerGram
{
    public static string UnitSymbol { get; } = "Ci/g";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["curie/g", "ci/gram"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = Curie.ScalingFactor / Gram.ScalingFactor;
}

[KnownUnit<SpecificActivity, BecquerelPerPound, BecquerelPerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record BecquerelPerPound
{
    public static string UnitSymbol { get; } = "Bq/lb";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["becquerel/lb", "bq/pound"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Pound.ScalingFactor;
}

[KnownUnit<SpecificActivity, BecquerelPerOunce, BecquerelPerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record BecquerelPerOunce
{
    public static string UnitSymbol { get; } = "Bq/lb";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["becquerel/lb", "bq/pound"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Pound.ScalingFactor;
}

[KnownUnit<SpecificActivity, CuriePerPound, BecquerelPerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record CuriePerPound
{
    public static string UnitSymbol { get; } = "Ci/lb";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["curie/lb", "ci/pound"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = Curie.ScalingFactor / Pound.ScalingFactor;
}

[KnownUnit<SpecificActivity, CuriePerOunce, BecquerelPerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record CuriePerOunce
{
    public static string UnitSymbol { get; } = "Ci/oz";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["curie/oz", "ci/ounce"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = Curie.ScalingFactor / Ounce.ScalingFactor;
}
