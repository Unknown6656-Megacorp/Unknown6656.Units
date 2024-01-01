namespace Unknown6656.Units.Energy;


[KnownBaseUnit<KineticEnergy, Joule, Scalar>]
public partial record Joule(Scalar Value)
    : BaseUnit<KineticEnergy, Joule, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "J";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}

[KnownUnit<KineticEnergy, TonTNTEquivalent, Joule, Scalar>]
public partial record TonTNTEquivalent(Scalar Value)
    : KineticEnergy.AffineUnit<TonTNTEquivalent>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "t TNT";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)2.3900573613766730401529636711281070745697896749521988527724e-10;
}

[KnownUnit<KineticEnergy, BarrelOfOilEquivalent, Joule, Scalar>]
public partial record BarrelOfOilEquivalent(Scalar Value)
    : KineticEnergy.AffineUnit<BarrelOfOilEquivalent>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "boe";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1.6345576344368079364703676277037381286982683757949997966610e-10;
}

[KnownUnit<KineticEnergy, BritishThermalUnit, Joule, Scalar>]
public partial record BritishThermalUnit(Scalar Value)
    : KineticEnergy.AffineUnit<BritishThermalUnit>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "BTU";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.00094781707774915;
}

[KnownUnit<KineticEnergy, Calorie, Joule, Scalar>]
public partial record Calorie(Scalar Value)
    : KineticEnergy.AffineUnit<Calorie>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "cal";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0002388459966275;
}

[KnownUnit<KineticEnergy, HorsepowerHour, Joule, Scalar>]
public partial record HorsepowerHour(Scalar Value)
    : KineticEnergy.AffineUnit<HorsepowerHour>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "HPh";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)3.725061361e-7;
}

[KnownUnit<KineticEnergy, CelsiusHeatUnit, Joule, Scalar>]
public partial record CelsiusHeatUnit(Scalar Value)
    : KineticEnergy.AffineUnit<CelsiusHeatUnit>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "CHU";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0005265650668407317777848805802642281309214842536926048141251772;
    
}

[KnownUnit<KineticEnergy, CubicCentimeterAtmosphere, Joule, Scalar>]
public partial record CubicCentimeterAtmosphere(Scalar Value)
    : KineticEnergy.AffineUnit<CubicCentimeterAtmosphere>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "cm³ atm";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)9.8692326671601283000246730816679003207500616827041697508018751542;
}

[KnownUnit<KineticEnergy, CubicCentimeterNaturalGas, Joule, Scalar>]
public partial record CubicCentimeterNaturalGas(Scalar Value)
    : KineticEnergy.AffineUnit<CubicCentimeterNaturalGas>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "cm³ NG";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0268393373959122031527620341044158663699466053012642829388485032;
}

[KnownUnit<KineticEnergy, CubicFootAtmosphere, Joule, Scalar>]
public partial record CubicFootAtmosphere(Scalar Value)
    : KineticEnergy.AffineUnit<CubicFootAtmosphere>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ft³ atm";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0003485286624375878633154503859265001424333055087486547255862562;
}

[KnownUnit<KineticEnergy, CubicFootNaturalGas, Joule, Scalar>]
public partial record CubicFootNaturalGas(Scalar Value)
    : KineticEnergy.AffineUnit<CubicFootNaturalGas>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ft³ NG";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)9.4781712031331720001278504447561063565867165664668866542531e-7;
}

[KnownUnit<KineticEnergy, ElectronVolt, Joule, Scalar>]
public partial record ElectronVolt(Scalar Value)
    : KineticEnergy.AffineUnit<ElectronVolt>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "eV";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)6.241509074461e18;
}

[KnownUnit<KineticEnergy, Hartree, Joule, Scalar>]
public partial record Hartree(Scalar Value)
    : KineticEnergy.AffineUnit<Hartree>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Eₕ";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)2.29371265835792193303093025645542490568253548832225011376814e17;
}

[KnownUnit<KineticEnergy, LiterAtmosphere, Joule, Scalar>]
public partial record LiterAtmosphere(Scalar Value)
    : KineticEnergy.AffineUnit<LiterAtmosphere>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "L atm";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)9.8692326671601283000246730816679003207500616827041697508018751542e-4;
}

[KnownUnit<KineticEnergy, Quad, Joule, Scalar>]
public partial record Quad(Scalar Value)
    : KineticEnergy.AffineUnit<Quad>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "quad";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)9.4781712031331720001278504447561063565867165664668866542531e-19;
}

[KnownUnit<KineticEnergy, Rydberg, Joule, Scalar>]
public partial record Rydberg(Scalar Value)
    : KineticEnergy.AffineUnit<Rydberg>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Ry";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)4.5874259248637628320505826227272124528413412201287502844205e17;
}

[KnownUnit<KineticEnergy, TonCoalEquivalent, Joule, Scalar>]
public partial record TonCoalEquivalent(Scalar Value)
    : KineticEnergy.AffineUnit<TonCoalEquivalent>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "t coal";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)2.930710746e-10;
}

[KnownUnit<KineticEnergy, TonOilEquivalent, Joule, Scalar>]
public partial record TonOilEquivalent(Scalar Value)
    : KineticEnergy.AffineUnit<TonOilEquivalent>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "t oil";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)2.388458966275e-10;
}

[KnownUnit<KineticEnergy, WattHour, Joule, Scalar>]
public partial record WattHour(Scalar Value)
    : KineticEnergy.AffineUnit<WattHour>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Wh";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)3.6e3;
}

[KnownUnit<KineticEnergy, WattSecond, Joule, Scalar>]
public partial record WattSecond(Scalar Value)
    : KineticEnergy.AffineUnit<WattSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Ws";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1.0;
}

[KnownUnit<KineticEnergy, Erg, Joule, Scalar>]
public partial record Erg(Scalar Value)
    : KineticEnergy.AffineUnit<Erg>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "erg";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1e7;
}

