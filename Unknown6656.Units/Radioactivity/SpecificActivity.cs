using Unknown6656.Units.Matter;

namespace Unknown6656.Units.Radioactivity;


[KnownBaseUnit<SpecificActivity, BecquerelPerKilogram, Scalar>]
public partial record BecquerelPerKilogram(Scalar Value)
    : BaseUnit<SpecificActivity, BecquerelPerKilogram, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "Bq/kg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["becquerel/kg", "becquerel/kilo", "Bq/kilo", "Bq/kilogram"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<SpecificActivity, CuriePerGram, BecquerelPerKilogram, Scalar>]
public partial record CuriePerGram(Scalar Value)
    : SpecificActivity.AffineUnit<CuriePerGram>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Ci/g";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["curie/g", "ci/gram"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = Curie.ScalingFactor / Gram.ScalingFactor;
}

[KnownUnit<SpecificActivity, BecquerelPerPound, BecquerelPerKilogram, Scalar>]
public partial record BecquerelPerPound(Scalar Value)
    : SpecificActivity.AffineUnit<BecquerelPerPound>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Bq/lb";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["becquerel/lb", "bq/pound"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Pound.ScalingFactor;
}

[KnownUnit<SpecificActivity, BecquerelPerOunce, BecquerelPerKilogram, Scalar>]
public partial record BecquerelPerOunce(Scalar Value)
    : SpecificActivity.AffineUnit<BecquerelPerOunce>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Bq/lb";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["becquerel/lb", "bq/pound"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Pound.ScalingFactor;
}

[KnownUnit<SpecificActivity, CuriePerPound, BecquerelPerKilogram, Scalar>]
public partial record CuriePerPound(Scalar Value)
    : SpecificActivity.AffineUnit<CuriePerPound>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Ci/lb";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["curie/lb", "ci/pound"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = Curie.ScalingFactor / Pound.ScalingFactor;
}

[KnownUnit<SpecificActivity, CuriePerOunce, BecquerelPerKilogram, Scalar>]
public partial record CuriePerOunce(Scalar Value)
    : SpecificActivity.AffineUnit<CuriePerOunce>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Ci/oz";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["curie/oz", "ci/ounce"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = Curie.ScalingFactor / Ounce.ScalingFactor;
}
