#if !USE_DIACRITICS
global using Ampère = Unknown6656.Units.Electricity.Ampere;
global using Abampère = Unknown6656.Units.Electricity.Abampere;
global using Statampère = Unknown6656.Units.Electricity.Statampere;
#endif

namespace Unknown6656.Units.Electricity;


[KnownBaseUnit<Current, Ampère, Scalar>]
#if USE_DIACRITICS
public partial record Ampère
#else
public partial record Ampere
#endif
{
    public static string UnitSymbol { get; } = "A";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Current, Abampère, Ampère, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record Abampère
#else
public partial record Abampere
#endif
{
    public static string UnitSymbol { get; } = "abA";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar).1;
}

[KnownUnit<Current, Statampère, Ampère, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record Statampère
#else
public partial record Statampere
#endif
{
    public static string UnitSymbol { get; } = "statA";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3.3356409519815204957557671447491851179258151984597290969874e-10;
}

[KnownUnit<Current, Biot, Ampère, Scalar>(KnownUnitType.Linear)]
public partial record Biot
{
    public static string UnitSymbol { get; } = "Bi";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar).1;
}
