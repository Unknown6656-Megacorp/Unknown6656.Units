using System.Numerics;

namespace Unknown6656.Units.Time;


public class Time<TScalar>
    : Quantity<Time<TScalar>, TScalar>
    where TScalar : INumber<TScalar>
{
}

public record Seconds(scalar Value)
    : Time<scalar>.BaseUnit<Seconds>(Value)
    , IBaseUnit<Seconds, scalar>
{
    public static string UnitSymbol { get; } = "s";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Metric;
}

// - hour
// - day
// - week
// - datetime
// - from seconds, minutes, hours, days, weeks, months, years, ...
// - from ticks, ...
// - planck time
// - fortnight
// - cesium frequency
