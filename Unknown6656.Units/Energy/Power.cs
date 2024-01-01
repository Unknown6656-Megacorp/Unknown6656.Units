namespace Unknown6656.Units.Energy;


[KnownBaseUnit<Power, Watt, Scalar>]
public partial record Watt(Scalar Value)
    : BaseUnit<Power, Watt, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "W";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}

[KnownUnit<Power, MetricHorsepower, Watt, Scalar>]
public partial record MetricHorsepower(Scalar Value)
    : Power.AffineUnit<MetricHorsepower>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "hp";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0013596216;
}

[KnownUnit<Power, BoilerHorsepower, Watt, Scalar>]
public partial record BoilerHorsepower(Scalar Value)
    : Power.AffineUnit<BoilerHorsepower>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "hp";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0001019419950048422447627300066262296753147459095774504307049288;
}

[KnownUnit<Power, UKHorsepower, Watt, Scalar>]
public partial record UKHorsepower(Scalar Value)
    : Power.AffineUnit<UKHorsepower>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "hp";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.001341022089595027;
}


