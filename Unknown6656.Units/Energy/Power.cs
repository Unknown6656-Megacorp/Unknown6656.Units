﻿namespace Unknown6656.Units.Energy;


[KnownBaseUnit<Power, Watt, Scalar>]
public partial record Watt(Scalar Value)
    : BaseUnit<Power, Watt, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "W";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Power, MetricHorsepower, Watt, Scalar>]
public partial record MetricHorsepower(Scalar Value)
    : Power.AffineUnit<MetricHorsepower>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "hp";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
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

[KnownUnit<Power, Lusec, Watt, Scalar>]
public partial record Lusec(Scalar Value)
    : Power.AffineUnit<Lusec>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lusec";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)7501.8754688672168042010502625656414103525881470367591897974493623;
}

[KnownUnit<Power, Poncelet, Watt, Scalar>]
public partial record Poncelet(Scalar Value)
    : Power.AffineUnit<Poncelet>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "p";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.001359621617303904;
}

[KnownUnit<Power, TonAirConditioningEquivalent, Watt, Scalar>]
public partial record TonAirConditioningEquivalent(Scalar Value)
    : Power.AffineUnit<TonAirConditioningEquivalent>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "t AC";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.00028434513626109;
}

[KnownUnit<Power, TonRefrigerationEquivalent, Watt, Scalar>]
public partial record TonRefrigerationEquivalent(Scalar Value)
    : Power.AffineUnit<TonRefrigerationEquivalent>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "t ice";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.00028434513626109;
}

