#if !USE_DIACRITICS
global using Sthène = Unknown6656.Units.Electricity.Sthene;
#endif

namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<Force, Newton, Scalar>]
public partial record Newton
{
    public static string UnitSymbol { get; } = "N";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Force, PoundForce, Newton, Scalar>(KnownUnitType.Linear)]
public partial record PoundForce
{
    public static string UnitSymbol { get; } = "lbf";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lb", "pound", "lb force", "pound f"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.2248089430997105;
}

[KnownUnit<Force, OunceForce, Newton, Scalar>(KnownUnitType.Linear)]
public partial record OunceForce
{
    public static string UnitSymbol { get; } = "ozf";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["oz", "ounce", "oz force", "ounce f"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = PoundForce.ScalingFactor * 16;
}

[KnownUnit<Force, Dyne, Newton, Scalar>(KnownUnitType.Linear)]
public partial record Dyne
{
    public static string UnitSymbol { get; } = "dyn";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e5;
}

[KnownUnit<Force, Sthène, Newton, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record Sthène
#else
public partial record Sthene
#endif
{
    public static string UnitSymbol { get; } = "sn";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-3;
}
