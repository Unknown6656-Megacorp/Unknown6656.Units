﻿#if !USE_DIACRITICS
global using RöntgenEquivalentMan = Unknown6656.Units.Radioactivity.RoentgenEquivalentMan;
#endif

using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Radiometry;


[KnownBaseUnit<EquivalentDose, Sievert, Scalar>]
public partial record Sievert
{
    public static string UnitSymbol { get; } = "Sv";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<EquivalentDose, RöntgenEquivalentMan, Sievert, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record RöntgenEquivalentMan
#else
public partial record RoentgenEquivalentMan
#endif
{
    public static string UnitSymbol { get; } = "rem";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["röntgen equivalent man", "röntgen eq man"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e2;
}

[KnownUnit<EquivalentDose, BananaEquivalentDose, Sievert, Scalar>(KnownUnitType.Linear)]
public partial record BananaEquivalentDose
{
    public static string UnitSymbol { get; } = "BED";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["banana equivalent dose", "banana eq dose", "banana ED"];
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

[KnownUnit<EquivalentDose, BackgroundRadiationEquivalentTime, Sievert, Scalar>(KnownUnitType.Linear)]
public partial record BackgroundRadiationEquivalentTime
{
    public static string UnitSymbol { get; } = "BRET";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["back eq T", "back equivalent T", "background eq T", "background equivalent T",
        "back eq time", "back equivalent time", "background eq time", "background equivalent time",
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / (DoseRate.BackgroundRadiationGlobalAverage * StandardDay.One).Sievert.Value;
}
