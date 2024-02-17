namespace Unknown6656.Units.Euclidean;

#pragma warning disable IDE0004 // Remove Unnecessary Cast


[KnownBaseUnit<Area, SquareMeter, Scalar>]
public partial record SquareMeter(Scalar Value)
    : BaseUnit<Area, SquareMeter, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "m^2";
#else
    public static string UnitSymbol { get; } = "m²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["meter^2", "m squared", "meter squared", "sqm", "sq meter"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
}

[KnownUnit<Area, SquareCentimeter, SquareMeter, Scalar>]
public partial record SquareCentimeter(Scalar Value)
    : Area.AffineUnit<SquareCentimeter>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "cm^2";
#else
    public static string UnitSymbol { get; } = "cm²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["centimeter^2", "cm squared", "centimeter squared", "sq centimeter", "sq cm"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e4;
}

[KnownUnit<Area, SquareMillimeter, SquareMeter, Scalar>]
public partial record SquareMillimeter(Scalar Value)
    : Area.AffineUnit<SquareMillimeter>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "mm^2";
#else
    public static string UnitSymbol { get; } = "mm²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["millimeter^2", "mm squared", "millimeter squared", "sq millimeter", "sq mm"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e6;
}

[KnownUnit<Area, SquareFoot, SquareMeter, Scalar>]
public partial record SquareFoot(Scalar Value)
    : Area.AffineUnit<SquareFoot>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "ft^2";
#else
    public static string UnitSymbol { get; } = "ft²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["foot^2", "feet^2", "sq ft", "square ft"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Foot.ScalingFactor * Foot.ScalingFactor;
}

[KnownUnit<Area, SquareInch, SquareMeter, Scalar>]
public partial record SquareInch(Scalar Value)
    : Area.AffineUnit<SquareInch>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "in^2";
#else
    public static string UnitSymbol { get; } = "in²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["inch^2", "sq in", "sq inch"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Inch.ScalingFactor * Inch.ScalingFactor;
}

[KnownUnit<Area, Acre, SquareMeter, Scalar>]
public partial record Acre(Scalar Value)
    : Area.AffineUnit<Acre>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ac";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)2.47105381467165348551e-4;
}

[KnownUnit<Area, Hectare, SquareMeter, Scalar>]
public partial record Hectare(Scalar Value)
    : Area.AffineUnit<Hectare>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ha";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["hectar", "hektar"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-4;
}

[KnownUnit<Area, SquareKilometer, SquareMeter, Scalar>]
public partial record SquareKilometer(Scalar Value)
    : Area.AffineUnit<SquareKilometer>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "km^2";
#else
    public static string UnitSymbol { get; } = "km²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kilometer^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-6;
}

[KnownUnit<Area, Barn, SquareMeter, Scalar>]
public partial record Barn(Scalar Value)
    : Area.AffineUnit<Barn>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "b";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e28;
}

[KnownUnit<Area, Square, SquareMeter, Scalar>]
public partial record Square(Scalar Value)
    : Area.AffineUnit<Square>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "square";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = SquareFoot.ScalingFactor * 100;
}

[KnownUnit<Area, FIFAFootballField, SquareMeter, Scalar>]
public partial record FIFAFootballField(Scalar Value)
    : Area.AffineUnit<FIFAFootballField>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "FIFA field";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["field", "field FIFA", "FIFA football pitch", "FIFA pitch", "football field FIFA", "football pitch FIFA"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.400560224089635854341736694677871148459383753501400560224089e-4;
}

[KnownUnit<Area, AmericanFootballField, SquareMeter, Scalar>]
public partial record AmericanFootballField(Scalar Value)
    : Area.AffineUnit<AmericanFootballField>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "US field";
    static string[] IUnit.AlternativeUnitSymbols { get; } = [
        "field US", "US football pitch", "US pitch", "football field US", "football pitch US", "USA field",
        "field USA", "USA football pitch", "USA pitch", "football field USA", "football pitch USA", "american field",
        "field american", "american football pitch", "american pitch", "football field american", "football pitch american",
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.868734447345437900752344714565972341821226852330247870372283e-4;
}

[KnownUnit<Area, CanadianFootballPitch, SquareMeter, Scalar>]
public partial record CanadianFootballPitch(Scalar Value)
    : Area.AffineUnit<CanadianFootballPitch>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "CA field";
    static string[] IUnit.AlternativeUnitSymbols { get; } = [
        "field CA", "CA football pitch", "CA pitch", "football field CA", "football pitch CA", "canada field",
        "field canada", "canada football pitch", "canada pitch", "football field canada", "football pitch canada", "canadaian field",
        "field canadaian", "canadaian football pitch", "canadaian pitch", "football field canadaian", "football pitch canadaian"
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.672713351470042316757343520730380837434384874813089002850715e-4;
}

[KnownUnit<Area, Morgen, SquareMeter, Scalar>]
public partial record Morgen(Scalar Value)
    : Area.AffineUnit<Morgen>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Mg";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.1674987040764384751532925798452363717876273157336795356157154665e-4;
}
