#if !USE_DIACRITICS
global using Röntgen = Unknown6656.Units.Radioactivity.Roentgen;
#endif

namespace Unknown6656.Units.Radiometry;


[KnownBaseUnit<RadiationExposure, CoulombPerKilogram, Scalar>]
public partial record CoulombPerKilogram(Scalar Value)
    : BaseUnit<RadiationExposure, CoulombPerKilogram, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "C/kg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["coulomb/kg", "coulomb/kilo", "C/kilo", "C/kilogram"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<RadiationExposure, Röntgen, CoulombPerKilogram, Scalar>]
#if USE_DIACRITICS
public partial record Röntgen(Scalar Value)
#else
public partial record Roentgen(Scalar Value)
#endif
    : RadiationExposure.AffineUnit<Röntgen>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "R";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3875.968992248062015503875;
}
