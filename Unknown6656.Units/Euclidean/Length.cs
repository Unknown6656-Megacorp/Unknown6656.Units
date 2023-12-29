namespace Unknown6656.Units.Euclidean;

#pragma warning disable IDE0004 // Remove Unnecessary Cast


[KnownBaseUnit<Length, Meter, Scalar>]
public partial record Meter(Scalar Value)
    : BaseUnit<Length, Meter, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "m";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}

[KnownUnit<Length, Yard, Meter, Scalar>]
public partial record Yard(Scalar Value)
    : Length.AffineUnit<Yard>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "yd";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.0936132983;
}

[KnownUnit<Length, Foot, Meter, Scalar>]
public partial record Foot(Scalar Value)
    : Length.AffineUnit<Foot>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ft";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)3.280839895013123359580052493438320209973753;
}

[KnownUnit<Length, Inch, Meter, Scalar>]
public partial record Inch(Scalar Value)
    : Length.AffineUnit<Inch>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "in";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)39.37007874015748031496062992125984251968504;
}

[KnownUnit<Length, Mile, Meter, Scalar>]
public partial record Mile(Scalar Value)
    : Length.AffineUnit<Mile>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "mi";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.000621371192237333969617434184363523125;
}

[KnownUnit<Length, NauticalMile, Meter, Scalar>]
public partial record NauticalMile(Scalar Value)
    : Length.AffineUnit<NauticalMile>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "nmi";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.000539956803455723542116630669546436285;
}

[KnownUnit<Length, League, Meter, Scalar>]
public partial record League(Scalar Value)
    : Length.AffineUnit<League>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lea";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.000179986803455723542116630669546436285;
}

[KnownUnit<Length, Fathom, Meter, Scalar>]
public partial record Fathom(Scalar Value)
    : Length.AffineUnit<Fathom>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ftm";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.546806649168853893185;
}

[KnownUnit<Length, Rod, Meter, Scalar>]
public partial record Rod(Scalar Value)
    : Length.AffineUnit<Rod>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "rd";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)5.029210058420116567036;
}

[KnownUnit<Length, Chain, Meter, Scalar>]
public partial record Chain(Scalar Value)
    : Length.AffineUnit<Chain>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ch";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.04970969537898686567036;
}

[KnownUnit<Length, Furlong, Meter, Scalar>]
public partial record Furlong(Scalar Value)
    : Length.AffineUnit<Furlong>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "fur";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.004970969537898686567036;
}

[KnownUnit<Length, Planck, Meter, Scalar>]
public partial record Planck(Scalar Value)
    : Length.AffineUnit<Planck>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "P";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1.616255e-35;
}
