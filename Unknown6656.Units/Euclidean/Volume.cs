namespace Unknown6656.Units.Euclidean;

#pragma warning disable IDE0004 // Remove Unnecessary Cast


public partial record CubicMeters(Scalar Value)
    : BaseUnit<Volume, CubicMeters, Scalar>(Value)
    , IBaseUnit<CubicMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "m²";
    public static UnitSystem UnitSystem { get; } = UnitSystem.NonSI;
}

[KnownUnit<Volume, Liters, CubicMeters, Scalar>]
public partial record Liters(Scalar Value)
    : Volume.AffineUnit<Liters>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Liters, CubicMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "l";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Metric;
    public static Scalar ScalingFactor { get; } = (Scalar)1e3;
}

[KnownUnit<Volume, ImperialGallons, CubicMeters, Scalar>]
public partial record ImperialGallons(Scalar Value)
    : Volume.AffineUnit<ImperialGallons>(Value)
    , ILinearUnit<Scalar>
    , IUnit<ImperialGallons, CubicMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "imp gal";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)219.96915738094787;
}

[KnownUnit<Volume, USGallons, CubicMeters, Scalar>]
public partial record USGallons(Scalar Value)
    : Volume.AffineUnit<USGallons>(Value)
    , ILinearUnit<Scalar>
    , IUnit<USGallons, CubicMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "US gal";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)264.17205235814842;
}

[KnownUnit<Volume, UKGallons, CubicMeters, Scalar>]
public partial record UKGallons(Scalar Value)
    : Volume.AffineUnit<UKGallons>(Value)
    , ILinearUnit<Scalar>
    , IUnit<UKGallons, CubicMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "UK gal";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)219.96915738094787;
}

[KnownUnit<Volume, USCups, CubicMeters, Scalar>]
public partial record USCups(Scalar Value)
    : Volume.AffineUnit<USCups>(Value)
    , ILinearUnit<Scalar>
    , IUnit<USCups, CubicMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "US cups";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)4226.75283773037465;
}

[KnownUnit<Volume, MetricCups, CubicMeters, Scalar>]
public partial record MetricCups(Scalar Value)
    : Volume.AffineUnit<MetricCups>(Value)
    , ILinearUnit<Scalar>
    , IUnit<MetricCups, CubicMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "cups";
    public static UnitSystem UnitSystem { get; } = UnitSystem.NonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)4000;
}

[KnownUnit<Volume, Pints, CubicMeters, Scalar>]
public partial record Pints(Scalar Value)
    : Volume.AffineUnit<Pints>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Pints, CubicMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "pt";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)2113.37641886518732;
}

[KnownUnit<Volume, Ge, CubicMeters, Scalar>]
public partial record Ge(Scalar Value)
    : Volume.AffineUnit<Ge>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Ge, CubicMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ge";
    public static UnitSystem UnitSystem { get; } = UnitSystem.NonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)10_000;
}

[KnownUnit<Volume, Gō, CubicMeters, Scalar>]
public partial record Gō(Scalar Value)
    : Volume.AffineUnit<Gō>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Gō, CubicMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "gō";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0055435235318617242815493544356518117451062057476051645147855060;
}

[KnownUnit<Volume, FluidOunces, CubicMeters, Scalar>]
public partial record FluidOunces(Scalar Value)
    : Volume.AffineUnit<FluidOunces>(Value)
    , ILinearUnit<Scalar>
    , IUnit<FluidOunces, CubicMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "fl oz";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)33814.022701843;
}

[KnownUnit<Volume, UKFluidOunces, CubicMeters, Scalar>]
public partial record UKFluidOunces(Scalar Value)
    : Volume.AffineUnit<UKFluidOunces>(Value)
    , ILinearUnit<Scalar>
    , IUnit<UKFluidOunces, CubicMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "fl oz";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)35195.079727854;
}



// TODO:
//  - volumes
//      - from KM³, CM³, MM³, ...
//      - from inches³, feet³, yards³, ...
//      - quart
//      - barrel
//      - teaspoon
//      - tablespoon
//      - drop
//      - peck
//      - bushel
