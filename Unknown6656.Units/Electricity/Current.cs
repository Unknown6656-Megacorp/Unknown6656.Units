#if !USE_DIACRITICS
global using Ampère = Unknown6656.Units.Electricity.Ampere;
#endif

namespace Unknown6656.Units.Electricity;


[KnownBaseUnit<Current, Ampère, Scalar>]
#if USE_DIACRITICS
public partial record Ampère(Scalar Value)
#else
public partial record Ampere(Scalar Value)
#endif
    : BaseUnit<Current, Ampère, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "A";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}
