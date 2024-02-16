#if !USE_DIACRITICS
global using RöntgenEquivalentMan = Unknown6656.Units.Radioactivity.RoentgenEquivalentMan;
#endif

namespace Unknown6656.Units.Radioactivity;


[KnownBaseUnit<EquivalentDose, Sievert, Scalar>]
public partial record Sievert(Scalar Value)
    : BaseUnit<EquivalentDose, Sievert, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "Sv";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<EquivalentDose, RöntgenEquivalentMan, Sievert, Scalar>]
#if USE_DIACRITICS
public partial record RöntgenEquivalentMan(Scalar Value)
#else
public partial record RoentgenEquivalentMan(Scalar Value)
#endif
    : EquivalentDose.AffineUnit<RöntgenEquivalentMan>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "rem";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["röntgen eqv man", "röntgen eqiv man", "röntgen eq man"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e2;
}

[KnownUnit<EquivalentDose, BananaEquivalentDose, Sievert, Scalar>]
public partial record BananaEquivalentDose(Scalar Value)
    : EquivalentDose.AffineUnit<BananaEquivalentDose>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "BED";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["banana eqv dose", "banana eqiv dose", "banana eq dose", "banana ED"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor => (Scalar)(ScalingFactorType is BananaEquivalentDoseScalingFactorType.Realistic ? 1.01936799184505606523955147808358817533129459734964322120285e7 : 1e7);
    public static BananaEquivalentDoseScalingFactorType ScalingFactorType { set; get; } = BananaEquivalentDoseScalingFactorType.Official;
}

public enum BananaEquivalentDoseScalingFactorType
{
    /// <summary>
    /// 1 BED = 1×10^-7 Sv
    /// </summary>
    Official,
    /// <summary>
    /// 1 BED = 9.82×10^−8 Sv
    /// </summary>
    Realistic,
}
