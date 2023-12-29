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
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-3;
}

[KnownUnit<Mass, Dalton, Kilogram, Scalar>]
public partial record Dalton(Scalar Value)
    : Mass.AffineUnit<Dalton>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Da";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1.66053906660e-27;
}




// TODO:
// - mass
//      - lb
//      - eV/c²
//      - sl
//      - planck mass
//      - solar mass
//      - oz
//      - stone
//      - ton
//      - from g, kg, mg, ...
//      - from lb, oz, stone, ton, ...