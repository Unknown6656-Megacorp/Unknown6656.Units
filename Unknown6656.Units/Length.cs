using System;
using System.Numerics;

using Unknown6656.Units.Internals;

namespace Unknown6656.Units.Length;


#pragma warning disable IDE0004 // Remove Unnecessary Cast
#region QUANTITIES

[QuantityDependency<Length, Area, Meters, SquareMeters, scalar>]
public partial record Length(Meters value) : Quantity<Length, Meters, scalar>(value);

[QuantityDependency<Area, Length, Volume, SquareMeters, Meters, CubicMeters, scalar>]
public partial record Area(SquareMeters value) : Quantity<Area, SquareMeters, scalar>(value);

public record Volume(CubicMeters value) : Quantity<Volume, CubicMeters, scalar>(value);

#endregion


// TODO:
//  - lengths
//      - light year
//      - parsec
//      - astronomical unit
//      - from KM, CM, MM, ...
//      - from inches, feet, yards, ...
//  - areas
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

#region UNITS OF LENGTH

public partial record Meters(scalar Value)
    : BaseUnit<Length, Meters, scalar>(Value)
    , IBaseUnit<Meters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "m";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Metric;
}

[KnownUnit<Length, Yards, Meters, scalar>]
public partial record Yards(scalar Value)
    : Length.AffineUnit<Yards>(Value)
    , IAffineUnit<scalar>
    , IUnit<Yards, Meters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "yd";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static scalar ScalingFactor { get; } = (scalar)1.0936132983;
    public static scalar PreScalingOffset { get; } = (scalar)0;
    public static scalar PostScalingOffset { get; } = (scalar)0;
}

[KnownUnit<Length, Feet, Meters, scalar>]
public partial record Feet(scalar Value)
    : Length.AffineUnit<Feet>(Value)
    , IAffineUnit<scalar>
    , IUnit<Feet, Meters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ft";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static scalar ScalingFactor { get; } = (scalar)3.280839895013123359580052493438320209973753;
    public static scalar PreScalingOffset { get; } = (scalar)0;
    public static scalar PostScalingOffset { get; } = (scalar)0;
}

[KnownUnit<Length, Inch, Meters, scalar>]
public partial record Inch(scalar Value)
    : Length.AffineUnit<Inch>(Value)
    , IAffineUnit<scalar>
    , IUnit<Inch, Meters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "in";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static scalar ScalingFactor { get; } = (scalar)39.37007874015748031496062992125984251968504;
    public static scalar PreScalingOffset { get; } = (scalar)0;
    public static scalar PostScalingOffset { get; } = (scalar)0;
}

[KnownUnit<Length, Miles, Meters, scalar>]
public partial record Miles(scalar Value)
    : Length.AffineUnit<Miles>(Value)
    , IAffineUnit<scalar>
    , IUnit<Miles, Meters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "mi";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static scalar ScalingFactor { get; } = (scalar)0.000621371192237333969617434184363523125;
    public static scalar PreScalingOffset { get; } = (scalar)0;
    public static scalar PostScalingOffset { get; } = (scalar)0;
}

[KnownUnit<Length, NauticalMiles, Meters, scalar>]
public partial record NauticalMiles(scalar Value)
    : Length.AffineUnit<NauticalMiles>(Value)
    , IAffineUnit<scalar>
    , IUnit<NauticalMiles, Meters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "nmi";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static scalar ScalingFactor { get; } = (scalar)0.000539956803455723542116630669546436285;
    public static scalar PreScalingOffset { get; } = (scalar)0;
    public static scalar PostScalingOffset { get; } = (scalar)0;
}

[KnownUnit<Length, Leagues, Meters, scalar>]
public partial record Leagues(scalar Value)
    : Length.AffineUnit<Leagues>(Value)
    , IAffineUnit<scalar>
    , IUnit<Leagues, Meters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "lea";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static scalar ScalingFactor { get; } = (scalar)0.000179986803455723542116630669546436285;
    public static scalar PreScalingOffset { get; } = (scalar)0;
    public static scalar PostScalingOffset { get; } = (scalar)0;
}

[KnownUnit<Length, Fathoms, Meters, scalar>]
public partial record Fathoms(scalar Value)
    : Length.AffineUnit<Fathoms>(Value)
    , IAffineUnit<scalar>
    , IUnit<Fathoms, Meters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ftm";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static scalar ScalingFactor { get; } = (scalar)0.546806649168853893185;
    public static scalar PreScalingOffset { get; } = (scalar)0;
    public static scalar PostScalingOffset { get; } = (scalar)0;
}

[KnownUnit<Length, Rods, Meters, scalar>]
public partial record Rods(scalar Value)
    : Length.AffineUnit<Rods>(Value)
    , IAffineUnit<scalar>
    , IUnit<Rods, Meters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "rd";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static scalar ScalingFactor { get; } = (scalar)5.029210058420116567036;
    public static scalar PreScalingOffset { get; } = (scalar)0;
    public static scalar PostScalingOffset { get; } = (scalar)0;
}

[KnownUnit<Length, Chains, Meters, scalar>]
public partial record Chains(scalar Value)
    : Length.AffineUnit<Chains>(Value)
    , IAffineUnit<scalar>
    , IUnit<Chains, Meters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ch";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static scalar ScalingFactor { get; } = (scalar)0.04970969537898686567036;
    public static scalar PreScalingOffset { get; } = (scalar)0;
    public static scalar PostScalingOffset { get; } = (scalar)0;
}

[KnownUnit<Length, Furlongs, Meters, scalar>]
public partial record Furlongs(scalar Value)
    : Length.AffineUnit<Furlongs>(Value)
    , IAffineUnit<scalar>
    , IUnit<Furlongs, Meters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "fur";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static scalar ScalingFactor { get; } = (scalar)0.004970969537898686567036;
    public static scalar PreScalingOffset { get; } = (scalar)0;
    public static scalar PostScalingOffset { get; } = (scalar)0;
}

#endregion
#region UNITS OF AREA

public partial record SquareMeters(scalar Value)
    : BaseUnit<Area, SquareMeters, scalar>(Value)
    , IBaseUnit<SquareMeters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "m²";
    public static UnitSystem UnitSystem { get; } = UnitSystem.NonSI;
}

[KnownUnit<Area, SquareFeet, SquareMeters, scalar>]
public partial record SquareFeet(scalar Value)
    : Area.AffineUnit<SquareFeet>(Value)
    , IAffineUnit<scalar>
    , IUnit<SquareFeet, SquareMeters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ft²";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static scalar ScalingFactor { get; } = (scalar)10.763910416709722258073075107890473764;
    public static scalar PreScalingOffset { get; } = (scalar)0;
    public static scalar PostScalingOffset { get; } = (scalar)0;
}

[KnownUnit<Area, Acres, SquareMeters, scalar>]
public partial record Acres(scalar Value)
    : Area.AffineUnit<Acres>(Value)
    , IAffineUnit<scalar>
    , IUnit<Acres, SquareMeters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ac";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static scalar ScalingFactor { get; } = (scalar)0.000247105381467165348551;
    public static scalar PreScalingOffset { get; } = (scalar)0;
    public static scalar PostScalingOffset { get; } = (scalar)0;
}

[KnownUnit<Area, Hectares, SquareMeters, scalar>]
public partial record Hectares(scalar Value)
    : Area.AffineUnit<Hectares>(Value)
    , IAffineUnit<scalar>
    , IUnit<Hectares, SquareMeters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ha";
    public static UnitSystem UnitSystem { get; } = UnitSystem.NonSI;
    public static scalar ScalingFactor { get; } = (scalar)0.0001;


    public static scalar PreScalingOffset { get; } = (scalar)0;
    public static scalar PostScalingOffset { get; } = (scalar)0;
}

[KnownUnit<Area, SquareKilometers, SquareMeters, scalar>]
public partial record SquareKilometers(scalar Value)
    : Area.AffineUnit<SquareKilometers>(Value)
    , IAffineUnit<scalar>
    , IUnit<SquareKilometers, SquareMeters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "km²";
    public static UnitSystem UnitSystem { get; } = UnitSystem.NonSI;
    public static scalar ScalingFactor { get; } = (scalar)1e-6;
    public static scalar PreScalingOffset { get; } = (scalar)0;
    public static scalar PostScalingOffset { get; } = (scalar)0;
}

#endregion
#region UNITS OF VOLUME

public partial record CubicMeters(scalar Value)
    : BaseUnit<Volume, CubicMeters, scalar>(Value)
    , IBaseUnit<CubicMeters, scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "m²";
    public static UnitSystem UnitSystem { get; } = UnitSystem.NonSI;
}


#endregion
