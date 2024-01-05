#if !USE_DIACRITICS
global using Ampère = Unknown6656.Units.Electricity.Ampere;
global using Abampère = Unknown6656.Units.Electricity.Abampère;
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
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Current, Abampère, Ampère, Scalar>]
#if USE_DIACRITICS
public partial record Abampère(Scalar Value)
#else
public partial record Abampere(Scalar Value)
#endif
    : Current.AffineUnit<Abampère>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "abA";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar).1;
}

[KnownUnit<Current, Biot, Ampère, Scalar>]
public partial record Biot(Scalar Value)
    : Current.AffineUnit<Biot>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Bi";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar).1;
}
