﻿using Unknown6656.Units.Matter;

namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<MassFlowRate, KilogramPerSecond, Scalar>]
public partial record KilogramPerSecond
{
    public static string UnitSymbol { get; } = "kg/s";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kilo/s", "kilo/second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
}

[KnownUnit<MassFlowRate, MetricTonPerSecond, KilogramPerSecond, Scalar>(KnownUnitType.Linear)]
public partial record MetricTonPerSecond
{
    public static string UnitSymbol { get; } = "t/s";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ton/s", "ton/second", "metric t/s", "metric ton/s", "metric t/second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = MetricTon.ScalingFactor;
}

[KnownUnit<MassFlowRate, PoundPerSecond, KilogramPerSecond, Scalar>(KnownUnitType.Linear)]
public partial record PoundPerSecond
{
    public static string UnitSymbol { get; } = "lb/s";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lb/second", "pound/s"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Pound.ScalingFactor;
}

[KnownUnit<MassFlowRate, OuncePerSecond, KilogramPerSecond, Scalar>(KnownUnitType.Linear)]
public partial record OuncePerSecond
{
    public static string UnitSymbol { get; } = "oz/s";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["oz/second", "ounce/s"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Ounce.ScalingFactor;
}

[KnownUnit<MassFlowRate, PlanckMassPerPlanckTime, KilogramPerSecond, Scalar>(KnownUnitType.Linear)]
public partial record PlanckMassPerPlanckTime
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "mp/tp";
#else
    public static string UnitSymbol { get; } = "mₚ/tₚ";
#endif
#warning TODO    static string[] IUnit.AlternativeUnitSymbols { get; } = ["m/t", ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)2.4767851446758066576843206023376418356223089642890698915169e10-36;
}

[KnownUnit<MassFlowRate, KilogramPerMinute, KilogramPerSecond, Scalar>(KnownUnitType.Linear)]
public partial record KilogramPerMinute
{
    public static string UnitSymbol { get; } = "kg/min";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kilo/minute", "kg/minute", "kilogram/min", "kilo/min", "kg/minute"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
    public static Scalar ScalingFactor { get; } = (Scalar)60.0;
}

[KnownUnit<MassFlowRate, KilogramPerHour, KilogramPerSecond, Scalar>(KnownUnitType.Linear)]
public partial record KilogramPerHour
{
    public static string UnitSymbol { get; } = "kg/h";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kilo/hour", "kg/hour", "kilogram/h", "kilo/h", "kg/hour", "kilo/hr", "kg/hr", "kilogram/hr"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
    public static Scalar ScalingFactor { get; } = (Scalar)3.6e3;
}
