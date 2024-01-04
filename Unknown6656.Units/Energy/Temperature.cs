#if !USE_DIACRITICS
global using Rømer = Unknown6656.Units.Energy.Romer;
global using Réaumur = Unknown6656.Units.Energy.Reaumur;
#endif

namespace Unknown6656.Units.Energy;


[KnownBaseUnit<Temperature, Kelvin, Scalar>]
public partial record Kelvin(Scalar Value)
    : BaseUnit<Temperature, Kelvin, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "K";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}

[KnownUnit<Temperature, PlanckTemperature, Kelvin, Scalar>]
public partial record PlanckTemperature(Scalar Value)
    : Temperature.AffineUnit<PlanckTemperature>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Tₚ";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1.416808338416e32;
}

[KnownUnit<Temperature, Celsius, Kelvin, Scalar>]
public partial record Celsius(Scalar Value)
    : Temperature.AffineUnit<Celsius>(Value)
    , IAffineUnit<Scalar>
{
    public static string UnitSymbol { get; } = "°C";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1;
    public static Scalar PreScalingOffset { get; } = (Scalar)(-273.15);
    public static Scalar PostScalingOffset { get; }
}

[KnownUnit<Temperature, Fahrenheit, Kelvin, Scalar>]
public partial record Fahrenheit(Scalar Value)
    : Temperature.AffineUnit<Fahrenheit>(Value)
    , IAffineUnit<Scalar>
{
    public static string UnitSymbol { get; } = "°F";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.8;
    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; } = (Scalar)(-459.67);
}

[KnownUnit<Temperature, Rankine, Kelvin, Scalar>]
public partial record Rankine(Scalar Value)
    : Temperature.AffineUnit<Rankine>(Value)
    , IAffineUnit<Scalar>
{
    public static string UnitSymbol { get; } = "°R";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.5555555555555556;
    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; } = (Scalar)459.67;
}

[KnownUnit<Temperature, Rømer, Kelvin, Scalar>]
#if USE_DIACRITICS
public partial record Rømer(Scalar Value)
#else
public partial record Romer(Scalar Value)
#endif
    : Temperature.AffineUnit<Rømer>(Value)
    , IAffineUnit<Scalar>
{
    public static string UnitSymbol { get; } = "°Rø";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.525;
    public static Scalar PreScalingOffset { get; } = (Scalar)(-273.15);
    public static Scalar PostScalingOffset { get; } = (Scalar)7.5;
}

[KnownUnit<Temperature, Réaumur, Kelvin, Scalar>]
#if USE_DIACRITICS
public partial record Réaumur(Scalar Value)
#else
public partial record Reaumur(Scalar Value)
#endif
    : Temperature.AffineUnit<Réaumur>(Value)
    , IAffineUnit<Scalar>
{
    public static string UnitSymbol { get; } = "°Ré";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.8;
    public static Scalar PreScalingOffset { get; } = (Scalar)(-273.15);
    public static Scalar PostScalingOffset { get; }
}

[KnownUnit<Temperature, Delisle, Kelvin, Scalar>]
public partial record Delisle(Scalar Value)
    : Temperature.AffineUnit<Delisle>(Value)
    , IAffineUnit<Scalar>
{
    public static string UnitSymbol { get; } = "°De";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1.5;
    public static Scalar PreScalingOffset { get; } = (Scalar)(-273.15);
    public static Scalar PostScalingOffset { get; } = (Scalar)(-100.0);
}

[KnownUnit<Temperature, Leiden, Kelvin, Scalar>]
public partial record Leiden(Scalar Value)
    : Temperature.AffineUnit<Leiden>(Value)
    , IAffineUnit<Scalar>
{
    public static string UnitSymbol { get; } = "°L";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1d;
    public static Scalar PreScalingOffset { get; } = (Scalar)20.15;
    public static Scalar PostScalingOffset { get; }
}

[KnownUnit<Temperature, Wedgwood, Kelvin, Scalar>]
public partial record Wedgwood(Scalar Value)
    : Temperature.AffineUnit<Wedgwood>(Value)
    , IAffineUnit<Scalar>
{
    public static string UnitSymbol { get; } = "°We";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;

#warning TODO: fix the following conversion!
    public static Scalar ScalingFactor { get; } = (Scalar)0.5555555555555556;
    public static Scalar PreScalingOffset { get; } = (Scalar)(-273.15);
    public static Scalar PostScalingOffset { get; } = (Scalar)537.7777777777778;
}

[KnownUnit<Temperature, DegreesNewton, Kelvin, Scalar>]
public partial record DegreesNewton(Scalar Value)
    : Temperature.AffineUnit<DegreesNewton>(Value)
    , IAffineUnit<Scalar>
{
    public static string UnitSymbol { get; } = "°N";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.33; // <-- TODO: 0.303 or 0.308 ????
    public static Scalar PreScalingOffset { get; } = (Scalar)(-273.15);
    public static Scalar PostScalingOffset { get; } = (Scalar)0;
}
