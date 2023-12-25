using System;
using System.Numerics;

using Unknown6656.Units.Internals;

namespace Unknown6656.Units.Length;




[QuantityDependency<Length, Surface, Meters, SquareMeters, scalar>]
public partial record Length(Meters value)
    : Quantity<Length, Meters, scalar>(value)
{
}

public record Surface(SquareMeters value)
    : Quantity<Surface, SquareMeters, scalar>(value)
{
}

//public record Volume(CubicMeters value) : Quantity<Volume, CubicMeters, scalar>(value);


// TODO:
//  - lengths
//      - inch
//      - mile
//      - nautical mile
//      - light year
//      - parsec
//      - astronomical unit
//      - league
//      - fathom
//      - rod
//      - chain
//      - furlong
//      - from KM, CM, MM, ...
//      - from inches, feet, yards, ...
//  - areas
//      - acre
//      - hectare
//      - barn
//      - from KM², CM², MM², ...
//      - from inches², feet², yards², ...
//  - volumes
//      - liter
//      - gallon
//      - from KM³, CM³, MM³, ...
//      - from inches³, feet³, yards³, ...
//      - cup
//      - pint
//      - quart
//      - barrel
//      - fluid ounce
//      - teaspoon
//      - tablespoon
//      - drop
//      - peck
//      - bushel



public partial record Meters(scalar Value)
    : BaseUnit<Length, Meters, scalar>(Value)
    , IBaseUnit<Meters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "m";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Metric;
}

public record Yards(scalar Value)
    : Length.AffineUnit<Yards>(Value)
    , IAffineUnit<scalar>
    , IUnit<Yards, Meters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "yd";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;

    public static scalar ScalingFactor { get; } = (scalar)1.0936132983;
    public static scalar PreScalingOffset { get; } = 0;
    public static scalar PostScalingOffset { get; } = 0;
}

//public record Feet(scalar Value)
//    : Length<scalar>.AffineUnit<Feet>(Value)
//    , Length<scalar>.IAffineUnit
//    , IUnit<Feet, Length<scalar>, scalar>
//{
//    public static string UnitSymbol { get; } = "ft";
//    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;

//    public static scalar ScalingFactor { get; } = (scalar)3.280839895013123359580052493438320209973753;
//    public static scalar PreScalingOffset { get; } = 0;
//    public static scalar PostScalingOffset { get; } = 0;
//}


public record SquareMeters(scalar Value)
    : BaseUnit<Surface, SquareMeters, scalar>(Value)
    , IBaseUnit<SquareMeters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "m²";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricNoPrefixes;
}
