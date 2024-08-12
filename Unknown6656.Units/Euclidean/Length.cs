#if !USE_DIACRITICS
global using Ångström = Unknown6656.Units.Euclidean.Angstrom;
#endif


namespace Unknown6656.Units.Euclidean;

#pragma warning disable IDE0004 // Remove Unnecessary Cast


[KnownBaseUnit<Length, Meter, Scalar>]
public partial record Meter
{
    public static string UnitSymbol { get; } = "m";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Length, Yard, Meter, Scalar>(KnownUnitType.Linear)]
public partial record Yard
{
    public static string UnitSymbol { get; } = "yd";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Inch.ScalingFactor / 36;
}

[KnownUnit<Length, Foot, Meter, Scalar>(KnownUnitType.Linear)]
public partial record Foot
{
    public static string UnitSymbol { get; } = "ft";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["feet"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Inch.ScalingFactor / 12;
}

[KnownUnit<Length, Inch, Meter, Scalar>(KnownUnitType.Linear)]
public partial record Inch
{
    public static string UnitSymbol { get; } = "in";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["inches", "\""];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)39.37007874015748031496062992125984251968504;
}

[KnownUnit<Length, Mile, Meter, Scalar>(KnownUnitType.Linear)]
public partial record Mile
{
    public static string UnitSymbol { get; } = "mi";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.000621371192237333969617434184363523125;
}

[KnownUnit<Length, NauticalMile, Meter, Scalar>(KnownUnitType.Linear)]
public partial record NauticalMile
{
    public static string UnitSymbol { get; } = "nmi";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["nautical mi"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.000539956803455723542116630669546436285;
}

[KnownUnit<Length, League, Meter, Scalar>(KnownUnitType.Linear)]
public partial record League
{
    public static string UnitSymbol { get; } = "lea";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.000179986803455723542116630669546436285;
}

[KnownUnit<Length, Fathom, Meter, Scalar>(KnownUnitType.Linear)]
public partial record Fathom
{
    public static string UnitSymbol { get; } = "ftm";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.546806649168853893185;
}

[KnownUnit<Length, Rod, Meter, Scalar>(KnownUnitType.Linear)]
public partial record Rod
{
    public static string UnitSymbol { get; } = "rd";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)5.029210058420116567036;
}

[KnownUnit<Length, Chain, Meter, Scalar>(KnownUnitType.Linear)]
public partial record Chain
{
    public static string UnitSymbol { get; } = "ch";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.04970969537898686567036;
}

[KnownUnit<Length, Hand, Meter, Scalar>(KnownUnitType.Linear)]
public partial record Hand
{
    public static string UnitSymbol { get; } = "h";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["hh"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Inch.ScalingFactor / 4;
}

[KnownUnit<Length, Furlong, Meter, Scalar>(KnownUnitType.Linear)]
public partial record Furlong
{
    public static string UnitSymbol { get; } = "fur";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.004970969537898686567036;
}

[KnownUnit<Length, Planck, Meter, Scalar>(KnownUnitType.Linear)]
public partial record Planck
{
    public static string UnitSymbol { get; } = "P";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["planck length"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.616255e-35;
}

[KnownUnit<Length, RackUnit, Meter, Scalar>(KnownUnitType.Linear)]
public partial record RackUnit
{
    public static string UnitSymbol { get; } = "U";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["Rack U", "RU"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Inch.ScalingFactor / 1.75;
}

[KnownUnit<Length, HorizontalPitch, Meter, Scalar>(KnownUnitType.Linear)]
public partial record HorizontalPitch
{
    public static string UnitSymbol { get; } = "HP";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["H pitch"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Inch.ScalingFactor * 5;
}

// https://en.wikipedia.org/wiki/List_of_unusual_units_of_measurement
[KnownUnit<Length, HammerUnit, Meter, Scalar>(KnownUnitType.Linear)]
public partial record HammerUnit
{
    public static string UnitSymbol { get; } = "Hammer unit";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["H pitch"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Foot.ScalingFactor * 16;
}

[KnownUnit<Length, LightNanosecond, Meter, Scalar>(KnownUnitType.Linear)]
public partial record LightNanosecond
{
    public static string UnitSymbol { get; } = "lns";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["light ns", "l nanosecond"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3.3356409519815204957557671447491851179258151984597290969874899254;
}

[KnownUnit<Length, LightYear, Meter, Scalar>(KnownUnitType.Linear)]
public partial record LightYear
{
    public static string UnitSymbol { get; } = "ly";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lyr", "light y", "light yr", "l year"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.0570008340246154637094605244851272333529213877036685606597e-13;
}

[KnownUnit<Length, MetricFoot, Meter, Scalar>(KnownUnitType.Linear)]
public partial record MetricFoot
{
    public static string UnitSymbol { get; } = "metric ft";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ft metric", "foot metric"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)(10d / 3d);
}

[KnownUnit<Length, Ångström, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record Ångström
#else
public partial record Angstrom
#endif
{
    public static string UnitSymbol { get; } = "Å";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["angstrom"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e10;
}

[KnownUnit<Length, Potrzebie, Meter, Scalar>(KnownUnitType.Linear)]
public partial record Potrzebie
{
    public static string UnitSymbol { get; } = "pz";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)441.8232637707822;
}
