namespace Unknown6656.Units.Euclidean;

#pragma warning disable IDE0004 // Remove Unnecessary Cast


[KnownBaseUnit<Volume, CubicMeter, Scalar>]
public partial record CubicMeter(Scalar Value)
    : BaseUnit<Volume, CubicMeter, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "m³";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["meter^3", "meters^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
}

[KnownUnit<Volume, Liter, CubicMeter, Scalar>]
public partial record Liter(Scalar Value)
    : Volume.AffineUnit<Liter>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "L";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e3;
}

[KnownUnit<Volume, Gallon, CubicMeter, Scalar>]
public partial record Gallon(Scalar Value)
    : Volume.AffineUnit<Gallon>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "imp gal";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["imperial gal", "imp gallon", "gallon imp", "gal imp", "gallons imp", "gals imp"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)219.96915738094787;
}

[KnownUnit<Volume, USGallon, CubicMeter, Scalar>]
public partial record USGallon(Scalar Value)
    : Volume.AffineUnit<USGallon>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "US gal";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["gal us", "gallon us", "gals us", "gallons us"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)264.17205235814842;
}

[KnownUnit<Volume, USCup, CubicMeter, Scalar>]
public partial record USCup(Scalar Value)
    : Volume.AffineUnit<USCup>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "US cup";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["cup us", "cups us"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)4226.75283773037465;
}

[KnownUnit<Volume, MetricCups, CubicMeter, Scalar>]
public partial record MetricCups(Scalar Value)
    : Volume.AffineUnit<MetricCups>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "cup";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)4000;
}

[KnownUnit<Volume, Pint, CubicMeter, Scalar>]
public partial record Pint(Scalar Value)
    : Volume.AffineUnit<Pint>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "pt";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)2113.37641886518732;
}

[KnownUnit<Volume, Ge, CubicMeter, Scalar>]
public partial record Ge(Scalar Value)
    : Volume.AffineUnit<Ge>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ge";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)10_000;
}

[KnownUnit<Volume, Gō, CubicMeter, Scalar>]
public partial record Gō(Scalar Value)
    : Volume.AffineUnit<Gō>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "gō";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0055435235318617242815493544356518117451062057476051645147855060;
}

[KnownUnit<Volume, USFluidOunce, CubicMeter, Scalar>]
public partial record USFluidOunce(Scalar Value)
    : Volume.AffineUnit<USFluidOunce>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "US fl oz";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["US fluid oz", "fl oz US", "fluid oz US", "fluid ounces US", "fl ounces US", "fl ounce US"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)33814.022701843;
}

[KnownUnit<Volume, FluidOunce, CubicMeter, Scalar>]
public partial record FluidOunce(Scalar Value)
    : Volume.AffineUnit<FluidOunce>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "fl oz";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["fluid oz", "fl ounce"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)35195.079727854;
}

[KnownUnit<Volume, Barrel, CubicMeter, Scalar>]
public partial record Barrel(Scalar Value)
    : Volume.AffineUnit<Barrel>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "bbl";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["US bbl", "US barrel", "bbl US", "barrel US", "barrels US"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)6.2898105697751;
}

[KnownUnit<Volume, Quart, CubicMeter, Scalar>]
public partial record Quart(Scalar Value)
    : Volume.AffineUnit<Quart>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "qt";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1056.68820943259366;
}

[KnownUnit<Volume, CubicFoot, CubicMeter, Scalar>]
public partial record CubicFoot(Scalar Value)
    : Volume.AffineUnit<CubicFoot>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ft³";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["foot^3", "feet^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)35.31466672148859025;
}

[KnownUnit<Volume, CubicInch, CubicMeter, Scalar>]
public partial record CubicInch(Scalar Value)
    : Volume.AffineUnit<CubicInch>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "in³";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["inch^3", "inches^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)61023.744094732284;
}

[KnownUnit<Volume, Teaspoon, CubicMeter, Scalar>]
public partial record Teaspoon(Scalar Value)
    : Volume.AffineUnit<Teaspoon>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "tsp";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["teasp"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)202884.13621106095;
}

[KnownUnit<Volume, Tablespoon, CubicMeter, Scalar>]
public partial record Tablespoon(Scalar Value)
    : Volume.AffineUnit<Tablespoon>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "tbsp";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["tablesp"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)67628.04540368698;
}

[KnownUnit<Volume, Drop, CubicMeter, Scalar>]
public partial record Drop(Scalar Value)
    : Volume.AffineUnit<Drop>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "gtt";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)500000;
}

[KnownUnit<Volume, Peck, CubicMeter, Scalar>]
public partial record Peck(Scalar Value)
    : Volume.AffineUnit<Peck>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "pk";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)109.9846241495439;
}

[KnownUnit<Volume, USPeck, CubicMeter, Scalar>]
public partial record USPeck(Scalar Value)
    : Volume.AffineUnit<USPeck>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "US pk";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["pk US", "peck US", "pecks US"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)113.510373033607;
}

[KnownUnit<Volume, Bushel, CubicMeter, Scalar>]
public partial record Bushel(Scalar Value)
    : Volume.AffineUnit<Bushel>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "bsh";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)36.36872;
}

[KnownUnit<Volume, USBushel, CubicMeter, Scalar>]
public partial record USBushel(Scalar Value)
    : Volume.AffineUnit<USBushel>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "US bsh";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bsh US", "bushel US", "bushels US"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)35.23907016688;
}
