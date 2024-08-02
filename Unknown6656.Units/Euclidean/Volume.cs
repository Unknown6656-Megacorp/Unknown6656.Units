#if !USE_DIACRITICS
global using Gō = Unknown6656.Units.Euclidean.Go;
#endif

namespace Unknown6656.Units.Euclidean;

#pragma warning disable IDE0004 // Remove Unnecessary Cast


[KnownBaseUnit<Volume, CubicMeter, Scalar>]
public partial record CubicMeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "m^3";
#else
    public static string UnitSymbol { get; } = "m³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["meter^3", "m cubed", "meter cubed", "cubic m", "stere"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
}

[KnownUnit<Volume, CubicCentimeter, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record CubicCentimeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "cm^3";
#else
    public static string UnitSymbol { get; } = "cm³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["centimeter^3", "cm cubed", "centimeter cubed", "cubic cm"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e8;
}

[KnownUnit<Volume, CubicMillimeter, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record CubicMillimeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "mm^3";
#else
    public static string UnitSymbol { get; } = "mm³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["millimeter^3", "mm cubed", "millimeter cubed", "cubic mm"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e9;
}

[KnownUnit<Volume, Liter, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record Liter
{
    public static string UnitSymbol { get; } = "L";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e3;
}

[KnownUnit<Volume, Gallon, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record Gallon
{
    public static string UnitSymbol { get; } = "imp gal";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["imperial gal", "imp gallon", "gallon imp", "gal imp", "UK gal", "gal UK", "UK gallon", "gallon UK"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)219.96915738094787;
}

[KnownUnit<Volume, USGallon, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record USGallon
{
    public static string UnitSymbol { get; } = "US gal";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["gal us", "gallon us"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)264.17205235814842;
}

[KnownUnit<Volume, AleGallon, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record AleGallon
{
    public static string UnitSymbol { get; } = "Ale gal";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["gal ale", "gallon ale"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = CubicInch.ScalingFactor / 282;
}

[KnownUnit<Volume, Tun, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record Tun
{
    public static string UnitSymbol { get; } = "tun";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Gallon.ScalingFactor / 252;
}

[KnownUnit<Volume, Pin, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record Pin
{
    public static string UnitSymbol { get; } = "pin";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar).0488820551775750638949563739878053936948503488101252333812621884;
}

[KnownUnit<Volume, USCup, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record USCup
{
    public static string UnitSymbol { get; } = "US cup";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["cup us", "cups us"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)4226.75283773037465;
}

[KnownUnit<Volume, MetricCups, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record MetricCups
{
    public static string UnitSymbol { get; } = "cup";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)4000;
}

[KnownUnit<Volume, Pint, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record Pint
{
    public static string UnitSymbol { get; } = "pt";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)2113.37641886518732;
}

[KnownUnit<Volume, Ge, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record Ge
{
    public static string UnitSymbol { get; } = "ge";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)10_000;
}

[KnownUnit<Volume, Gō, CubicMeter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record Gō
#else
public partial record Go
#endif
{
    public static string UnitSymbol { get; } = "gō";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0055435235318617242815493544356518117451062057476051645147855060;
}

[KnownUnit<Volume, USFluidOunce, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record USFluidOunce
{
    public static string UnitSymbol { get; } = "US fl oz";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["US fluid oz", "fl oz US", "fluid oz US", "fluid ounce US", "fl ounce US"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)33814.022701843;
}

[KnownUnit<Volume, FluidOunce, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record FluidOunce
{
    public static string UnitSymbol { get; } = "fl oz";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["fluid oz", "fl ounce", "UK fl oz", "UK fl ounce", "UK fluid oz", "UK fluid ounce",
        "imp fl oz", "imp fl ounce", "imp fluid oz", "imp fluid ounce", "imperial fl oz", "imperial fl ounce", "imperial fluid oz", "imperial fluid ounce"
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)35195.079727854;
}

[KnownUnit<Volume, Barrel, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record Barrel
{
    public static string UnitSymbol { get; } = "bbl";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["US bbl", "US barrel", "bbl US", "barrel US"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)6.2898105697751;
}

[KnownUnit<Volume, Quart, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record Quart
{
    public static string UnitSymbol { get; } = "qt";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1056.68820943259366;
}

[KnownUnit<Volume, CubicFoot, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record CubicFoot
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "ft^3";
#else
    public static string UnitSymbol { get; } = "ft³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["foot^3", "feet^3", "cu foot", "cu feet", "cu ft", "cubic ft"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Foot.ScalingFactor * SquareFoot.ScalingFactor;
}

[KnownUnit<Volume, CubicInch, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record CubicInch
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "in^3";
#else
    public static string UnitSymbol { get; } = "in³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["inch^3", "inches^3", "cu in", "cu inch", "cubic in"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Inch.ScalingFactor * SquareInch.ScalingFactor;
}

[KnownUnit<Volume, Teaspoon, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record Teaspoon
{
    public static string UnitSymbol { get; } = "tsp";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["teasp"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)202884.13621106095;
}

[KnownUnit<Volume, Tablespoon, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record Tablespoon
{
    public static string UnitSymbol { get; } = "tbsp";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["tablesp"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)67628.04540368698;
}

[KnownUnit<Volume, Drop, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record Drop
{
    public static string UnitSymbol { get; } = "gtt";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)500000;
}

[KnownUnit<Volume, Peck, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record Peck
{
    public static string UnitSymbol { get; } = "pk";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)109.9846241495439;
}

[KnownUnit<Volume, USPeck, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record USPeck
{
    public static string UnitSymbol { get; } = "US pk";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["pk US", "peck US"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)113.510373033607;
}

[KnownUnit<Volume, Bushel, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record Bushel
{
    public static string UnitSymbol { get; } = "bsh";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)36.36872;
}

[KnownUnit<Volume, USBushel, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record USBushel
{
    public static string UnitSymbol { get; } = "US bsh";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bsh US", "bushel US"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)35.23907016688;
}

[KnownUnit<Volume, Brass, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record Brass
{
    public static string UnitSymbol { get; } = "brass";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = CubicFoot.ScalingFactor * 100;
}

[KnownUnit<Volume, MetricOunce, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record MetricOunce
{
    public static string UnitSymbol { get; } = "Metric oz";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["metr oz", "metr fl oz", "metr fluid oz", "metric fluid ounce US", "fl ounce metric", "fl oz metric", "oz metric", "oz metr"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)33333.3333333333333333333333333333333333333333333333333333333333; // 30 mL
}

[KnownUnit<Volume, Cord, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record Cord
{
    public static string UnitSymbol { get; } = "cord";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = CubicFoot.ScalingFactor / 128;
}

[KnownUnit<Volume, TwentyFootEquivalentUnit, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record TwentyFootEquivalentUnit
{
    public static string UnitSymbol { get; } = "TEU";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["20ft EU", "container EU", "container equivalent unit", "container eq unit",
        "20 foot EU", "20 foot eq unit", "20 foot equivalent unit", "20ft eq unit", "20ft EU", "20ft equivalent unit",
        "shipping container", "standard shipping container", "ISO container", "container", "intermodal container"
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = CubicFoot.ScalingFactor / 1_172;
}

[KnownUnit<Volume, AcreFoot, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record AcreFoot
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "ac·ft";
#else
    public static string UnitSymbol { get; } = "ac*ft";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["acre ft", "ft acre", "ft*ac", "ft ac", "ac ft", "ac foot", "foot ac", "acre*ft", "ft*acre", "ac*ft", "ac*foot", "foot*ac"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Foot.ScalingFactor * Acre.ScalingFactor;
}

[KnownUnit<Volume, BoardFoot, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record BoardFoot
{
    public static string UnitSymbol { get; } = "FBM";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["board ft", "board-ft", "board-foot", "foot board measure", "ft board measure", "super foot"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = SquareFoot.ScalingFactor * Inch.ScalingFactor;
}

[KnownUnit<Volume, HoppusCubicFoot, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record HoppusCubicFoot
{
    public static string UnitSymbol { get; } = "h cu ft";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["hoppus", "hoppus ft^3", "hoppus cubic ft", "hoppus foot^3", "hoppus cubic foot"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)27.7392510402;
}

[KnownUnit<Volume, HoppusTon, CubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record HoppusTon
{
    public static string UnitSymbol { get; } = "HT";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["hoppus t", "hoppus ton"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = HoppusCubicFoot.ScalingFactor * .02;
}
