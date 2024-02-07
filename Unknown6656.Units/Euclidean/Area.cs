namespace Unknown6656.Units.Euclidean;

#pragma warning disable IDE0004 // Remove Unnecessary Cast


[KnownBaseUnit<Area, SquareMeter, Scalar>]
public partial record SquareMeter(Scalar Value)
    : BaseUnit<Area, SquareMeter, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "m^2";
#else
    public static string UnitSymbol { get; } = "m²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["meter^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
}

[KnownUnit<Area, SquareFoot, SquareMeter, Scalar>]
public partial record SquareFoot(Scalar Value)
    : Area.AffineUnit<SquareFoot>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "ft^2";
#else
    public static string UnitSymbol { get; } = "ft²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["foot^2", "feet^2"];
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
    public static Scalar ScalingFactor { get; } = (Scalar)2.47105381467165348551e-4;
}

[KnownUnit<Area, Hectare, SquareMeter, Scalar>]
public partial record Hectare(Scalar Value)
    : Area.AffineUnit<Hectare>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ha";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["hectar", "hektar"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-4;
}

[KnownUnit<Area, SquareKilometer, SquareMeter, Scalar>]
public partial record SquareKilometer(Scalar Value)
    : Area.AffineUnit<SquareKilometer>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "km^2";
#else
    public static string UnitSymbol { get; } = "km²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kilometer^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-6;
}

[KnownUnit<Area, Barn, SquareMeter, Scalar>]
public partial record Barn(Scalar Value)
    : Area.AffineUnit<Barn>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "b";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e28;
}
