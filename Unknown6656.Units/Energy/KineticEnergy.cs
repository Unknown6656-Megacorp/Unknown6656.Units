namespace Unknown6656.Units.Energy;


[KnownBaseUnit<KineticEnergy, Joule, Scalar>]
[KnownAlias<KineticEnergy, Joule, Scalar>("WattSecond", "Ws")]
public partial record Joule
{
    public static string UnitSymbol { get; } = "J";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<KineticEnergy, TonTNTEquivalent, Joule, Scalar>(KnownUnitType.Linear)]
public partial record TonTNTEquivalent
{
    public static string UnitSymbol { get; } = "t TNT";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ton TNT", "ton of TNT", "ton of TNT equivalent", "ton TNT equiv"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixesOnlyOnMultiples;
    public static Scalar ScalingFactor { get; } = (Scalar)2.3900573613766730401529636711281070745697896749521988527724e-10;
}

[KnownUnit<KineticEnergy, BarrelOfOilEquivalent, Joule, Scalar>(KnownUnitType.Linear)]
public partial record BarrelOfOilEquivalent
{
    public static string UnitSymbol { get; } = "BOE";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["barrel oil equivalent", "barrel of oil equiv"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.6345576344368079364703676277037381286982683757949997966610e-10;
}

[KnownUnit<KineticEnergy, GasolineGallonEquivalent, Joule, Scalar>(KnownUnitType.Linear)]
public partial record GasolineGallonEquivalent
{
    public static string UnitSymbol { get; } = "GGE";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["GEG", "GGE US", "US GGE", "GEG US", "US GEG",
        "gas gal eq", "US gas gal eq", "gas US gal eq", "gasoline US gal eq", "gasoline US gallon eq", "US gallon gas eq", "US gal gasoline eq", "US gallon gasoline eq", "gasoline gal eq", "gal gas eq", "gal gasoline eq", "gallon gasoline eq",
        "gas gal equivalent", "US gas gal equivalent", "gas US gal equivalent", "gasoline US gal equivalent", "gasoline US gallon equivalent", "US gallon gas equivalent", "US gal gasoline equivalent", "US gallon gasoline equivalent", "gasoline gal equivalent", "gal gas equivalent", "gal gasoline equivalent", "gallon gasoline equivalent",
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)7.7243290163201292397660818713450292397660818713450292397660e-9;
}

[KnownUnit<KineticEnergy, BritishThermalUnit, Joule, Scalar>(KnownUnitType.Linear)]
public partial record BritishThermalUnit
{
    public static string UnitSymbol { get; } = "BTU";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["british TU"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.00094781707774915;
}

[KnownUnit<KineticEnergy, Calorie, Joule, Scalar>(KnownUnitType.Linear)]
public partial record Calorie
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "cal";
#else
    public static string UnitSymbol { get; } = "calₜₕ";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["therm cal", "thermochemical cal", "thermochem cal", "therm calorie", "thermochemical calorie", "thermochem calorie"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.2390057361376673;
}

[KnownUnit<KineticEnergy, InternationalSteamTableCalorie, Joule, Scalar>(KnownUnitType.Linear)]
public partial record InternationalSteamTableCalorie
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "cal";
#else
    public static string UnitSymbol { get; } = "calᵢₜ";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["int steam cal", "IT cal", "IST cal", "international steam cal", "int steam tbl cal", "int steam calorie", "IT calorie", "IST calorie", "international steam calorie", "int steam tbl calorie"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.2388458966274959;
}

[KnownUnit<KineticEnergy, HorsepowerHour, Joule, Scalar>(KnownUnitType.Linear)]
public partial record HorsepowerHour
{
    public static string UnitSymbol { get; } = "HPh";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3.725061361e-7;
}

[KnownUnit<KineticEnergy, CelsiusHeatUnit, Joule, Scalar>(KnownUnitType.Linear)]
public partial record CelsiusHeatUnit
{
    public static string UnitSymbol { get; } = "CHU";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["celsius HU"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0005265650668407317777848805802642281309214842536926048141251772;
    
}

[KnownUnit<KineticEnergy, CubicCentimeterAtmosphere, Joule, Scalar>(KnownUnitType.Linear)]
public partial record CubicCentimeterAtmosphere
{
    public static string UnitSymbol { get; } = "cm³ atm";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["cm³ atmosphere"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)9.8692326671601283000246730816679003207500616827041697508018751542;
}

[KnownUnit<KineticEnergy, CubicCentimeterNaturalGas, Joule, Scalar>(KnownUnitType.Linear)]
public partial record CubicCentimeterNaturalGas
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "cm^3 NG";
#else
    public static string UnitSymbol { get; } = "cm³ NG";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["cm³ natural gas", "cm³ LNG"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0268393373959122031527620341044158663699466053012642829388485032;
}

[KnownUnit<KineticEnergy, CubicFootAtmosphere, Joule, Scalar>(KnownUnitType.Linear)]
public partial record CubicFootAtmosphere
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "ft^3 atm";
#else
    public static string UnitSymbol { get; } = "ft³ atm";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ft³ atmosphere"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0003485286624375878633154503859265001424333055087486547255862562;
}

[KnownUnit<KineticEnergy, CubicFootNaturalGas, Joule, Scalar>(KnownUnitType.Linear)]
public partial record CubicFootNaturalGas
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "ft^3 NG";
#else
    public static string UnitSymbol { get; } = "ft³ NG";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ft³ natural gas", "ft³ LNG"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)9.4781712031331720001278504447561063565867165664668866542531e-7;
}

[KnownUnit<KineticEnergy, ElectronVolt, Joule, Scalar>(KnownUnitType.Linear)]
public partial record ElectronVolt
{
    public static string UnitSymbol { get; } = "eV";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)6.241509074461e18;
}

[KnownUnit<KineticEnergy, Hartree, Joule, Scalar>(KnownUnitType.Linear)]
public partial record Hartree
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Eh";
#else
    public static string UnitSymbol { get; } = "Eₕ";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["E", "Eh"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)2.29371265835792193303093025645542490568253548832225011376814e17;
}

[KnownUnit<KineticEnergy, LiterAtmosphere, Joule, Scalar>(KnownUnitType.Linear)]
public partial record LiterAtmosphere
{
    public static string UnitSymbol { get; } = "L atm";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["liters atm", "liters atmosphere"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)9.8692326671601283000246730816679003207500616827041697508018751542e-4;
}

[KnownUnit<KineticEnergy, Quad, Joule, Scalar>(KnownUnitType.Linear)]
public partial record Quad
{
    public static string UnitSymbol { get; } = "quad";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)9.4781712031331720001278504447561063565867165664668866542531e-19;
}

[KnownUnit<KineticEnergy, Rydberg, Joule, Scalar>(KnownUnitType.Linear)]
public partial record Rydberg
{
    public static string UnitSymbol { get; } = "Ry";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)4.5874259248637628320505826227272124528413412201287502844205e17;
}

[KnownUnit<KineticEnergy, TonCoalEquivalent, Joule, Scalar>(KnownUnitType.Linear)]
public partial record TonCoalEquivalent
{
    public static string UnitSymbol { get; } = "t coal";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ton coal", "ton of coal", "ton coal equivalent", "ton of coal equivalent"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixesOnlyOnMultiples;
    public static Scalar ScalingFactor { get; } = (Scalar)2.930710746e-10;
}

[KnownUnit<KineticEnergy, TonOilEquivalent, Joule, Scalar>(KnownUnitType.Linear)]
public partial record TonOilEquivalent
{
    public static string UnitSymbol { get; } = "t oil";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ton oil", "ton of oil", "ton of oil equivalent", "ton oil equiv"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixesOnlyOnMultiples;
    public static Scalar ScalingFactor { get; } = (Scalar)2.388458966275e-10;
}

[KnownUnit<KineticEnergy, WattHour, Joule, Scalar>(KnownUnitType.Linear)]
public partial record WattHour
{
    public static string UnitSymbol { get; } = "Wh";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["whr"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.00028;
}

[KnownUnit<KineticEnergy, Erg, Joule, Scalar>(KnownUnitType.Linear)]
public partial record Erg
{
    public static string UnitSymbol { get; } = "erg";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e7;
}

[KnownUnit<KineticEnergy, AtomicUnitOfAction, Joule, Scalar>(KnownUnitType.Linear)]
public partial record AtomicUnitOfAction
{
    public static string UnitSymbol { get; } = "au";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)9.48252280015712160978948344222556782484430076863054012601590e33;
}
