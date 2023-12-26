namespace Unknown6656.Units.Euclidean;

#pragma warning disable IDE0004 // Remove Unnecessary Cast


public partial record SquareMeters(Scalar Value)
    : BaseUnit<Area, SquareMeters, Scalar>(Value)
    , IBaseUnit<SquareMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "m²";
    public static UnitSystem UnitSystem { get; } = UnitSystem.NonSI;
}

[KnownUnit<Area, SquareFeet, SquareMeters, Scalar>]
public partial record SquareFeet(Scalar Value)
    : Area.AffineUnit<SquareFeet>(Value)
    , ILinearUnit<Scalar>
    , IUnit<SquareFeet, SquareMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ft²";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)10.763910416709722258073075107890473764;
}

[KnownUnit<Area, Acres, SquareMeters, Scalar>]
public partial record Acres(Scalar Value)
    : Area.AffineUnit<Acres>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Acres, SquareMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ac";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.000247105381467165348551;
}

[KnownUnit<Area, Hectares, SquareMeters, Scalar>]
public partial record Hectares(Scalar Value)
    : Area.AffineUnit<Hectares>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Hectares, SquareMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ha";
    public static UnitSystem UnitSystem { get; } = UnitSystem.NonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0001;
}

[KnownUnit<Area, SquareKilometers, SquareMeters, Scalar>]
public partial record SquareKilometers(Scalar Value)
    : Area.AffineUnit<SquareKilometers>(Value)
    , ILinearUnit<Scalar>
    , IUnit<SquareKilometers, SquareMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "km²";
    public static UnitSystem UnitSystem { get; } = UnitSystem.NonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-6;
}

[KnownUnit<Area, Barns, SquareMeters, Scalar>]
public partial record Barns(Scalar Value)
    : Area.AffineUnit<Barns>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Barns, SquareMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "b";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Metric;
    public static Scalar ScalingFactor { get; } = (Scalar)1e28;
}
