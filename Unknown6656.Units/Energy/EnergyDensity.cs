using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Energy;


[KnownBaseUnit<EnergyDensity, JoulePerCubicMeter, Scalar>]
public partial record JoulePerCubicMeter(Scalar Value)
    : BaseUnit<EnergyDensity, JoulePerCubicMeter, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "J/m^3";
#else
    public static string UnitSymbol { get; } = "J/m³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["joule/meter^3", "joule/m^3", "J/meter^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
}

[KnownUnit<EnergyDensity, JoulePerLiter, JoulePerCubicMeter, Scalar>]
public partial record JoulePerLiter(Scalar Value)
    : EnergyDensity.AffineUnit<JoulePerLiter>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "J/L";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["J/liter", "joule/L"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Liter.ScalingFactor;
}

[KnownUnit<EnergyDensity, JoulePerCubicInch, JoulePerCubicMeter, Scalar>]
public partial record JoulePerCubicInch(Scalar Value)
    : EnergyDensity.AffineUnit<JoulePerCubicInch>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "J/in^3";
#else
    public static string UnitSymbol { get; } = "J/in³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["joule/in^3", "joule/inch^3", "J/inch^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / CubicInch.ScalingFactor;
}

[KnownUnit<EnergyDensity, JoulePerCubicFoot, JoulePerCubicMeter, Scalar>]
public partial record JoulePerCubicFoot(Scalar Value)
    : EnergyDensity.AffineUnit<JoulePerCubicFoot>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "J/ft^3";
#else
    public static string UnitSymbol { get; } = "J/ft³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["joule/ft^3", "joule/foot^3", "J/foot^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / CubicFoot.ScalingFactor;
}
