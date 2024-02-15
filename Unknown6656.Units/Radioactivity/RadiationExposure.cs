#if !USE_DIACRITICS
global using Röntgen = Unknown6656.Units.Radioactivity.Roentgen;
#endif

namespace Unknown6656.Units.Radioactivity;


[KnownBaseUnit<RadiationExposure, Röntgen, Scalar>]
#if USE_DIACRITICS
public partial record Röntgen(Scalar Value)
#else
public partial record Roentgen(Scalar Value)
#endif
    : BaseUnit<RadiationExposure, Röntgen, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "R";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
