namespace Unknown6656.Units.Euclidean;

#pragma warning disable IDE0004 // Remove Unnecessary Cast


[KnownBaseUnit<Length, Meters, Scalar>]
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
    , ILinearUnit<Scalar>
    , IUnit<Yards, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "yd";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.0936132983;
}

[KnownUnit<Length, Feet, Meters, Scalar>]
public partial record Feet(Scalar Value)
    : Length.AffineUnit<Feet>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Feet, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ft";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)3.280839895013123359580052493438320209973753;
}

[KnownUnit<Length, Inch, Meters, Scalar>]
public partial record Inch(Scalar Value)
    : Length.AffineUnit<Inch>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Inch, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "in";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)39.37007874015748031496062992125984251968504;
}

[KnownUnit<Length, Miles, Meters, Scalar>]
public partial record Miles(Scalar Value)
    : Length.AffineUnit<Miles>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Miles, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "mi";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.000621371192237333969617434184363523125;
}

[KnownUnit<Length, NauticalMiles, Meters, Scalar>]
public partial record NauticalMiles(Scalar Value)
    : Length.AffineUnit<NauticalMiles>(Value)
    , ILinearUnit<Scalar>
    , IUnit<NauticalMiles, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "nmi";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.000539956803455723542116630669546436285;
}

[KnownUnit<Length, Leagues, Meters, Scalar>]
public partial record Leagues(Scalar Value)
    : Length.AffineUnit<Leagues>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Leagues, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "lea";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.000179986803455723542116630669546436285;
}

[KnownUnit<Length, Fathoms, Meters, Scalar>]
public partial record Fathoms(Scalar Value)
    : Length.AffineUnit<Fathoms>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Fathoms, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ftm";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.546806649168853893185;
}

[KnownUnit<Length, Rods, Meters, Scalar>]
public partial record Rods(Scalar Value)
    : Length.AffineUnit<Rods>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Rods, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "rd";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)5.029210058420116567036;
}

[KnownUnit<Length, Chains, Meters, Scalar>]
public partial record Chains(Scalar Value)
    : Length.AffineUnit<Chains>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Chains, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ch";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.04970969537898686567036;
}

[KnownUnit<Length, Furlongs, Meters, Scalar>]
public partial record Furlongs(Scalar Value)
    : Length.AffineUnit<Furlongs>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Furlongs, Meters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "fur";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.004970969537898686567036;
}
