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
    , IUnit<PlanckTemperature, Kelvin, Scalar>
    , IUnit
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
    public static Scalar ScalingFactor { get; } = (Scalar)0.5555555555555556;
    public static Scalar PreScalingOffset { get; } = (Scalar)(-273.15);
    public static Scalar PostScalingOffset { get; } = (Scalar)32;
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
public partial record Rømer(Scalar Value)
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
public partial record Réaumur(Scalar Value)
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
    public static Scalar ScalingFactor { get; } = (Scalar)(-1.5);
    public static Scalar PreScalingOffset { get; } = (Scalar)(-273.15);
    public static Scalar PostScalingOffset { get; } = (Scalar)559.725;
}

[KnownUnit<Temperature, Leiden, Kelvin, Scalar>]
public partial record Leiden(Scalar Value)
    : Temperature.AffineUnit<Leiden>(Value)
    , IAffineUnit<Scalar>
{
    public static string UnitSymbol { get; } = "°L";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.5555555555555556;
    public static Scalar PreScalingOffset { get; } = (Scalar)(-273.15);
    public static Scalar PostScalingOffset { get; } = (Scalar)474.6;
}

[KnownUnit<Temperature, Wedgwood, Kelvin, Scalar>]
public partial record Wedgwood(Scalar Value)
    : Temperature.AffineUnit<Wedgwood>(Value)
    , IAffineUnit<Scalar>
{
    public static string UnitSymbol { get; } = "°W";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.5555555555555556;
    public static Scalar PreScalingOffset { get; } = (Scalar)(-273.15);
    public static Scalar PostScalingOffset { get; } = (Scalar)537.7777777777778;
}


// TODO:
// - temperature
//      - from °C, °F, K, °R, ...
