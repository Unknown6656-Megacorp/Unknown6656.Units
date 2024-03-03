#if !USE_DIACRITICS
global using Sthène = Unknown6656.Units.Electricity.Sthene;
#endif

namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<Force, Newton, Scalar>]
public partial record Newton(Scalar Value)
    : BaseUnit<Force, Newton, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "N";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Force, PoundForce, Newton, Scalar>]
public partial record PoundForce(Scalar Value)
    : Force.AffineUnit<PoundForce>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lbf";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lb", "pound", "lb force", "pound f"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.2248089430997105;
}

[KnownUnit<Force, OunceForce, Newton, Scalar>]
public partial record OunceForce(Scalar Value)
    : Force.AffineUnit<OunceForce>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ozf";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["oz", "ounce", "oz force", "ounce f"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = PoundForce.ScalingFactor * 16;
}

[KnownUnit<Force, Dyne, Newton, Scalar>]
public partial record Dyne(Scalar Value)
    : Force.AffineUnit<Dyne>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "dyn";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e5;
}

[KnownUnit<Force, Sthène, Newton, Scalar>]
#if USE_DIACRITICS
public partial record Sthène(Scalar Value)
#else
public partial record Sthene(Scalar Value)
#endif
    : Force.AffineUnit<Sthène>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "sn";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-3;
}
