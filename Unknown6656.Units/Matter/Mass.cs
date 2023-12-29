namespace Unknown6656.Units.Matter;


[KnownBaseUnit<Mass, Kilogram, Scalar>]
public partial record Kilogram(Scalar Value)
    : BaseUnit<Mass, Kilogram, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "kg";
    public static UnitDisplay UnitDisplay { get; } = Unit.MetricSI_Shifted_k;
}

[KnownUnit<Mass, Gram, Kilogram, Scalar>]
public partial record Gram(Scalar Value)
    : Mass.AffineUnit<Gram>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "g";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1e3;
}

[KnownUnit<Mass, MetricTon, Kilogram, Scalar>]
public partial record MetricTon(Scalar Value)
    : Mass.AffineUnit<MetricTon>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "t";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-3;
}

[KnownUnit<Mass, Dalton, Kilogram, Scalar>]
public partial record Dalton(Scalar Value)
    : Mass.AffineUnit<Dalton>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Da";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)6.022173643e+26;
}

[KnownUnit<Mass, Pound, Kilogram, Scalar>]
public partial record Pound(Scalar Value)
    : Mass.AffineUnit<Pound>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lb";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)2.2046226218487757;
}

[KnownUnit<Mass, Ounce, Kilogram, Scalar>]
public partial record Ounce(Scalar Value)
    : Mass.AffineUnit<Ounce>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "oz";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)35.27396194958041;
}

[KnownUnit<Mass, UKTon, Kilogram, Scalar>]
public partial record UKTon(Scalar Value)
    : Mass.AffineUnit<UKTon>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "US t";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)9.842065276110606e-4;
}

[KnownUnit<Mass, USTon, Kilogram, Scalar>]
public partial record USTon(Scalar Value)
    : Mass.AffineUnit<USTon>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "s.t.";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.1023113109243879e-3;
}

[KnownUnit<Mass, Grain, Kilogram, Scalar>]
public partial record Grain(Scalar Value)
    : Mass.AffineUnit<Grain>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "gr";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.543235835294122e4;
}

[KnownUnit<Mass, Slug, Kilogram, Scalar>]
public partial record Slug(Scalar Value)
    : Mass.AffineUnit<Slug>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "slug";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.06852176556196146;
}

[KnownUnit<Mass, UKStone, Kilogram, Scalar>]
public partial record UKStone(Scalar Value)
    : Mass.AffineUnit<UKStone>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "UK st";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.1574730444177697;
}

[KnownUnit<Mass, USStone, Kilogram, Scalar>]
public partial record USStone(Scalar Value)
    : Mass.AffineUnit<USStone>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "US st";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.14285714285714285;
}

[KnownUnit<Mass, Carat, Kilogram, Scalar>]
public partial record Carat(Scalar Value)
    : Mass.AffineUnit<Carat>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ct";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)5e3;
}

[KnownUnit<Mass, PlanckMass, Kilogram, Scalar>]
public partial record PlanckMass(Scalar Value)
    : Mass.AffineUnit<PlanckMass>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "mₚ";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)4.59467132297156563388720245813872525405673487755159606404846e7;
}

[KnownUnit<Mass, SolarMass, Kilogram, Scalar>]
public partial record SolarMass(Scalar Value)
    : Mass.AffineUnit<SolarMass>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "M☉";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)5.0289921396852856718984948226525921939984007804995800791563e-31;
}

[KnownUnit<Mass, ElectronVoltMassEquivalent, Kilogram, Scalar>]
public partial record ElectronVoltMassEquivalent(Scalar Value)
    : Mass.AffineUnit<ElectronVoltMassEquivalent>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "eV/c²";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)5.60958864983476645299741629583157968944023663372081019062242e35;
}


// TODO:
// - mass
//      - from g, kg, mg, lb, oz, stone, ton, ...