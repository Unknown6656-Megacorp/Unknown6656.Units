using System.Numerics;

namespace Unknown6656.Units.Time;


// public class Time<TScalar>
//     : Quantity<Time<TScalar>, TScalar>
//     where TScalar : INumber<TScalar>
// {
// }

// public record Seconds(scalar Value)
//     : Time<scalar>.BaseUnit<Seconds>(Value)
//     , IBaseUnit<Seconds, scalar>
// {
//     public static string UnitSymbol { get; } = "s";
//     public static UnitSystem UnitSystem { get; } = UnitSystem.Metric;
// }

// public record Hours(scalar Value)
//     : Time<scalar>.AffineUnit<Hours, Seconds>(Value)
//     , Time<scalar>.IAffineUnit
//     , IUnit<Hours, Seconds, scalar>
// {
//     public static scalar ScalingFactor { get; } = (scalar)2.77777777777777777777777777e-4;
//     public static scalar PreScalingOffset { get; } = 0;
//     public static scalar PostScalingOffset { get; } = 0;
//     public static string UnitSymbol { get; } = "h";
//     public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial; // prevents formatting with SI prefixes
// }

// public record Minutes(scalar Value)
//     : Time<scalar>.AffineUnit<Minutes, Seconds>(Value)
//     , Time<scalar>.IAffineUnit
//     , IUnit<Minutes, Seconds, scalar>
// {
//     public static scalar ScalingFactor { get; } = (scalar)0.016666666666666666666;
//     public static scalar PreScalingOffset { get; } = 0;
//     public static scalar PostScalingOffset { get; } = 0;
//     public static string UnitSymbol { get; } = "min";
//     public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial; // prevents formatting with SI prefixes
// }

// // - Time
// //      - datetime
// //      - from seconds, minutes, hours, days, weeks, months, years, ...
// //      - from ticks, ...
// //      - planck time
// //      - fortnight
// // Frequency
// //      - hertz
// //      - cesium frequency
