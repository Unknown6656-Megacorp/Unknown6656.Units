using Unknown6656.Units.Energy;

namespace Unknown6656.Units.Matter;


[KnownBaseUnit<Mass, Kilogram, Scalar>]
public partial record Kilogram
{
    public static string UnitSymbol { get; } = "kg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kilo"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
}

[KnownUnit<Mass, Gram, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record Gram
{
    public static string UnitSymbol { get; } = "g";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e3;
}

[KnownUnit<Mass, MetricTon, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record MetricTon
{
    public static string UnitSymbol { get; } = "t";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ton"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-3;
}

[KnownUnit<Mass, Dalton, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record Dalton
{
    public static string UnitSymbol { get; } = "Da";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)6.022173643e+26;
}

[KnownUnit<Mass, Pound, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record Pound
{
    public static string UnitSymbol { get; } = "lb";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)2.2046226218487757;
}

[KnownUnit<Mass, Ounce, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record Ounce
{
    public static string UnitSymbol { get; } = "oz";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Pound.ScalingFactor * 16;
}

[KnownUnit<Mass, UKTon, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record UKTon
{
    public static string UnitSymbol { get; } = "l.t.";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["long ton", "long t", "l ton","UK t"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)9.842065276110606e-4;
}

[KnownUnit<Mass, USTon, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record USTon
{
    public static string UnitSymbol { get; } = "s.t.";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["US t", "s ton", "short ton", "short t"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.1023113109243879e-3;
}

[KnownUnit<Mass, Grain, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record Grain
{
    public static string UnitSymbol { get; } = "gr";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.543235835294122e4;
}

[KnownUnit<Mass, Slug, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record Slug
{
    public static string UnitSymbol { get; } = "slug";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.06852176556196146;
}

[KnownUnit<Mass, UKStone, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record UKStone
{
    public static string UnitSymbol { get; } = "UK st";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["stone"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.1574730444177697;
}

[KnownUnit<Mass, USStone, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record USStone
{
    public static string UnitSymbol { get; } = "US st";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.14285714285714285;
}

[KnownUnit<Mass, Carat, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record Carat
{
    public static string UnitSymbol { get; } = "ct";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)5e3;
}

[KnownUnit<Mass, PlanckMass, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record PlanckMass
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "mp";
#else
    public static string UnitSymbol { get; } = "mₚ";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["m planck", "m p"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)4.59467132297156563388720245813872525405673487755159606404846e7;
}

[KnownUnit<Mass, SolarMass, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record SolarMass
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "MS";
#else
    public static string UnitSymbol { get; } = "M☉";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["mass sun", "sun mass", "sun masses", "solar masses", "sun"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)5.0289921396852856718984948226525921939984007804995800791563e-31;
}

[KnownUnit<Mass, ElectronVoltMassEquivalent, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record ElectronVoltMassEquivalent
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "eV/c^2";
#else
    public static string UnitSymbol { get; } = "eV/c²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["eV", "electron volt"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)5.60958864983476645299741629583157968944023663372081019062242e35;

    public KineticEnergy EnergyEquivalent => (Mass)this * SpecificEnergy.C0;
}

[KnownUnit<Mass, DutchOunce, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record DutchOunce
{
    public static string UnitSymbol { get; } = "ons";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["NL oz", "NL ounce", "ounce NL", "oz NL", "dutch oz", "oz dutch", "ounce dutch"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Pound.ScalingFactor * 16;
}

[KnownUnit<Mass, USHundredweight, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record USHundredweight
{
    public static string UnitSymbol { get; } = "cwt US";
    static string[] IUnit.AlternativeUnitSymbols { get; } = [
        "centum weight US", "centum wt US", "hundred wt US", "quintal US", "US centum weight", "US centum wt", "US hundred wt",
        "US quintal", "short hundredweight", "short cental", "US cental"
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Pound.ScalingFactor / 100;
}

[KnownUnit<Mass, Hundredweight, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record Hundredweight
{
    public static string UnitSymbol { get; } = "cwt";
    static string[] IUnit.AlternativeUnitSymbols { get; } = [
        "UK centum weight", "UK centum wt", "UK hundred wt", "UK quintal", "cental", "long cental", "UK cental", "centum weight UK",
        "centum wt UK", "hundred wt UK", "quintal UK", "UK hundredweight", "centum weight", "centum wt", "hundred wt", "quintal", 
        "imperial centum weight", "imperial centum wt", "imperial hundred wt", "imperial quintal", "imperial hundredweight"
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Pound.ScalingFactor / 112;
}

[KnownUnit<Mass, Firkin, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record Firkin
{
    public static string UnitSymbol { get; } = "fir";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Pound.ScalingFactor / 90;
}

// TODO : dram
