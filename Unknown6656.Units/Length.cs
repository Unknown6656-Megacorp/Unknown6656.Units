using System;
using System.Numerics;

using Unknown6656.Units.Internals;

namespace Unknown6656.Units.Length;


#pragma warning disable IDE0004 // Remove Unnecessary Cast

#region QUANTITIES

[QuantityDependency<Length, Area, Meters, SquareMeters, Scalar>]
public partial record Length(Meters value) : Quantity<Length, Meters, Scalar>(value);

[QuantityDependency<Area, Length, Volume, SquareMeters, Meters, CubicMeters, Scalar>]
public partial record Area(SquareMeters value) : Quantity<Area, SquareMeters, Scalar>(value);

public record Volume(CubicMeters value) : Quantity<Volume, CubicMeters, Scalar>(value);

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

public partial record Meters(Scalar Value)
    : BaseUnit<Length, Meters, Scalar>(Value)
    , IBaseUnit<Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "m";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Metric;
}

[KnownUnit<Length, Yards, Meters, Scalar>]
public partial record Yards(Scalar Value)
    : Length.AffineUnit<Yards>(Value)
    , IAffineUnit<Scalar>
    , IUnit<Yards, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "yd";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.0936132983;
    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; }
}

[KnownUnit<Length, Feet, Meters, Scalar>]
public partial record Feet(Scalar Value)
    : Length.AffineUnit<Feet>(Value)
    , IAffineUnit<Scalar>
    , IUnit<Feet, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ft";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)3.280839895013123359580052493438320209973753;
    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; }
}

[KnownUnit<Length, Inch, Meters, Scalar>]
public partial record Inch(Scalar Value)
    : Length.AffineUnit<Inch>(Value)
    , IAffineUnit<Scalar>
    , IUnit<Inch, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "in";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)39.37007874015748031496062992125984251968504;
    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; }
}

[KnownUnit<Length, Miles, Meters, Scalar>]
public partial record Miles(Scalar Value)
    : Length.AffineUnit<Miles>(Value)
    , IAffineUnit<Scalar>
    , IUnit<Miles, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "mi";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.000621371192237333969617434184363523125;
    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; }
}

[KnownUnit<Length, NauticalMiles, Meters, Scalar>]
public partial record NauticalMiles(Scalar Value)
    : Length.AffineUnit<NauticalMiles>(Value)
    , IAffineUnit<Scalar>
    , IUnit<NauticalMiles, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "nmi";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.000539956803455723542116630669546436285;
    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; }
}

[KnownUnit<Length, Leagues, Meters, Scalar>]
public partial record Leagues(Scalar Value)
    : Length.AffineUnit<Leagues>(Value)
    , IAffineUnit<Scalar>
    , IUnit<Leagues, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "lea";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.000179986803455723542116630669546436285;
    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; }
}

[KnownUnit<Length, Fathoms, Meters, Scalar>]
public partial record Fathoms(Scalar Value)
    : Length.AffineUnit<Fathoms>(Value)
    , IAffineUnit<Scalar>
    , IUnit<Fathoms, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ftm";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.546806649168853893185;
    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; }
}

[KnownUnit<Length, Rods, Meters, Scalar>]
public partial record Rods(Scalar Value)
    : Length.AffineUnit<Rods>(Value)
    , IAffineUnit<Scalar>
    , IUnit<Rods, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "rd";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)5.029210058420116567036;
    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; }
}

[KnownUnit<Length, Chains, Meters, Scalar>]
public partial record Chains(Scalar Value)
    : Length.AffineUnit<Chains>(Value)
    , IAffineUnit<Scalar>
    , IUnit<Chains, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ch";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.04970969537898686567036;
    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; }
}

[KnownUnit<Length, Furlongs, Meters, Scalar>]
public partial record Furlongs(Scalar Value)
    : Length.AffineUnit<Furlongs>(Value)
    , IAffineUnit<Scalar>
    , IUnit<Furlongs, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "fur";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.004970969537898686567036;
    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; }
}

#endregion
#region UNITS OF AREA

public partial record SquareMeters(Scalar Value)
    : BaseUnit<Area, SquareMeters, Scalar>(Value)
    , IBaseUnit<SquareMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "m²";
    public static UnitSystem UnitSystem { get; } = UnitSystem.NonSI;
}

[KnownUnit<Area, SquareFeet, SquareMeters, Scalar>]
public partial record SquareFeet(Scalar Value)
    : Area.AffineUnit<SquareFeet>(Value)
    , IAffineUnit<Scalar>
    , IUnit<SquareFeet, SquareMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ft²";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)10.763910416709722258073075107890473764;
    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; }
}

[KnownUnit<Area, Acres, SquareMeters, Scalar>]
public partial record Acres(Scalar Value)
    : Area.AffineUnit<Acres>(Value)
    , IAffineUnit<Scalar>
    , IUnit<Acres, SquareMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ac";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.000247105381467165348551;
    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; }
}

[KnownUnit<Area, Hectares, SquareMeters, Scalar>]
public partial record Hectares(Scalar Value)
    : Area.AffineUnit<Hectares>(Value)
    , IAffineUnit<Scalar>
    , IUnit<Hectares, SquareMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ha";
    public static UnitSystem UnitSystem { get; } = UnitSystem.NonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0001;


    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; }
}

[KnownUnit<Area, SquareKilometers, SquareMeters, Scalar>]
public partial record SquareKilometers(Scalar Value)
    : Area.AffineUnit<SquareKilometers>(Value)
    , IAffineUnit<Scalar>
    , IUnit<SquareKilometers, SquareMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "km²";
    public static UnitSystem UnitSystem { get; } = UnitSystem.NonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-6;
    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; }
}

#endregion
#region UNITS OF VOLUME

public partial record CubicMeters(Scalar Value)
    : BaseUnit<Volume, CubicMeters, Scalar>(Value)
    , IBaseUnit<CubicMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "m²";
    public static UnitSystem UnitSystem { get; } = UnitSystem.NonSI;
}

[KnownUnit<Volume, Liters, CubicMeters, Scalar>]
public partial record Liters(Scalar Value)
    : Volume.AffineUnit<Liters>(Value)
    , IAffineUnit<Scalar>
    , IUnit<Liters, CubicMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "l";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Metric;
    public static Scalar ScalingFactor { get; } = (Scalar)0.001;
    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; }
}

#endregion
