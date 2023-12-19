using System.Numerics;

namespace Unknown6656.Units.Length;


public abstract class Length<TScalar>
    : Quantity<Length<TScalar>, TScalar>
    where TScalar : INumber<TScalar>
{
}

public abstract class Surface<TScalar>
    : Quantity<Surface<TScalar>, TScalar>
    where TScalar : INumber<TScalar>
{
}

public abstract class Volume<TScalar>
    : Quantity<Volume<TScalar>, TScalar>
    where TScalar : INumber<TScalar>
{
}

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



public record Meters(scalar Value)
    : Length<scalar>.BaseUnit<Meters>(Value)
    , IBaseUnit<Meters, scalar>
{
    public static string UnitSymbol { get; } = "m";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Metric;
}

public record Yards(scalar Value)
    : Length<scalar>.AffineUnit<Yards, Meters>(Value)
    , Length<scalar>.IAffineUnit
    , IUnit<Yards, Meters, scalar>
{
    public static string UnitSymbol { get; } = "yd";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;

    public static scalar ScalingFactor { get; } = (scalar)1.0936132983;
    public static scalar PreScalingOffset { get; } = 0;
    public static scalar PostScalingOffset { get; } = 0;
}

public record Feet(scalar Value)
    : Length<scalar>.AffineUnit<Feet, Meters>(Value)
    , Length<scalar>.IAffineUnit
    , IUnit<Feet, Meters, scalar>
{
    public static string UnitSymbol { get; } = "ft";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;

    public static scalar ScalingFactor { get; } = (scalar)3.280839895013123359580052493438320209973753;
    public static scalar PreScalingOffset { get; } = 0;
    public static scalar PostScalingOffset { get; } = 0;
}


public record SquareMeters(scalar Value)
    : Length<scalar>.BaseUnit<SquareMeters>(Value)
    , IBaseUnit<SquareMeters, scalar>
{
    public static string UnitSymbol { get; } = "m²";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Metric;
}



