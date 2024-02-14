#if !USE_DIACRITICS
global using AmpèrePerMeter = Unknown6656.Units.Magnetism.AmperePerMeter;
global using Ørsted = Unknown6656.Units.Magnetism.Oersted;
#endif

namespace Unknown6656.Units.Magnetism;


[KnownBaseUnit<MagneticFieldStrength, AmpèrePerMeter, Scalar>]
#if USE_DIACRITICS
public partial record AmpèrePerMeter(Scalar Value)
#else
public partial record AmperePerMeter(Scalar Value)
#endif
    : BaseUnit<MagneticFieldStrength, AmpèrePerMeter, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "A/m";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<MagneticFieldStrength, Ørsted, AmpèrePerMeter, Scalar>]
#if USE_DIACRITICS
public partial record Ørsted(Scalar Value)
#else
public partial record Oersted(Scalar Value)
#endif
    : MagneticFieldStrength.AffineUnit<Ørsted>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Oe";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["Ø"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0125663706143591729538505735331180115367886775975004232838997783;
}
