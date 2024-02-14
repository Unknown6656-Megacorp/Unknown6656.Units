using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Photometry;


[KnownBaseUnit<LuminousEnergyDensity, LumenSecondPerCubicMeter, Scalar>]
public partial record LumenSecondPerCubicMeter(Scalar Value)
    : BaseUnit<LuminousEnergyDensity, LumenSecondPerCubicMeter, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lm*s/m^3";
#else
    public static string UnitSymbol { get; } = "lm·s/m³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lumen*s/m^3", "lm*second/m^3", "lumen*s/meter^3", "lm*second/meter^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<LuminousEnergyDensity, LumergPerCubicMeter, LumenSecondPerCubicMeter, Scalar>]
public partial record LumergPerCubicMeter(Scalar Value)
    : LuminousEnergyDensity.AffineUnit<LumergPerCubicMeter>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lumerg/m^3";
#else
    public static string UnitSymbol { get; } = "lumerg/m³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lmerg/m^3", "lumen erg/m^3", "lmerg/meter^3", "lumen erg/meter^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Lumerg.ScalingFactor;
}

[KnownUnit<LuminousEnergyDensity, LumenSecondPerCubicFoot, LumenSecondPerCubicMeter, Scalar>]
public partial record LumenSecondPerCubicFoot(Scalar Value)
    : LuminousEnergyDensity.AffineUnit<LumenSecondPerCubicFoot>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lm*s/ft^3";
#else
    public static string UnitSymbol { get; } = "lm·s/ft³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lumen*s/ft^3", "lm*second/ft^3", "lumen*s/foot^3", "lm*second/foot^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / CubicFoot.ScalingFactor;
}

[KnownUnit<LuminousEnergyDensity, LumenSecondPerCubicInch, LumenSecondPerCubicMeter, Scalar>]
public partial record LumenSecondPerCubicInch(Scalar Value)
    : LuminousEnergyDensity.AffineUnit<LumenSecondPerCubicInch>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lm*s/in^3";
#else
    public static string UnitSymbol { get; } = "lm·s/in³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lumen*s/in^3", "lm*second/in^3", "lumen*s/inch^3", "lm*second/inch^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / CubicInch.ScalingFactor;
}
