namespace Unknown6656.Units.Euclidean;

#pragma warning disable IDE0004 // Remove Unnecessary Cast


[KnownBaseUnit<Area, SquareMeter, Scalar>]
public partial record SquareMeter(Scalar Value)
    : BaseUnit<Area, SquareMeter, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "m²";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
}

[KnownUnit<Area, SquareFoot, SquareMeter, Scalar>]
public partial record SquareFoot(Scalar Value)
    : Area.AffineUnit<SquareFoot>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ft²";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)10.763910416709722258073075107890473764;
}

[KnownUnit<Area, Acre, SquareMeter, Scalar>]
public partial record Acre(Scalar Value)
    : Area.AffineUnit<Acre>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ac";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.000247105381467165348551;
}

[KnownUnit<Area, Hectare, SquareMeter, Scalar>]
public partial record Hectare(Scalar Value)
    : Area.AffineUnit<Hectare>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ha";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0001;
}

[KnownUnit<Area, SquareKilometer, SquareMeter, Scalar>]
public partial record SquareKilometer(Scalar Value)
    : Area.AffineUnit<SquareKilometer>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "km²";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-6;
}

[KnownUnit<Area, Barn, SquareMeter, Scalar>]
public partial record Barn(Scalar Value)
    : Area.AffineUnit<Barn>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "b";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1e28;
}
