namespace Unknown6656.Units.Photometry;


[KnownBaseUnit<LuminousEnergy, LumenSecond, Scalar>]
public partial record LumenSecond(Scalar Value)
    : BaseUnit<LuminousEnergy, LumenSecond, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lm*s";
#else
    public static string UnitSymbol { get; } = "lm·s";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lumen*s", "lm*second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<LuminousEnergy, Lumerg, LumenSecond, Scalar>]
public partial record Lumerg(Scalar Value)
    : LuminousEnergy.AffineUnit<Lumerg>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lumerg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lmerg", "lumen erg"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e7;
}
