namespace Unknown6656.Units.Matter;


[KnownBaseUnit<Pressure, Pascals, Scalar>]
public partial record Pascals(Scalar Value)
    : BaseUnit<Pressure, Pascals, Scalar>(Value)
    , IBaseUnit<Pascals, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Pa";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricSI;
}

[KnownUnit<Pressure, Atmospheres, Pascals, Scalar>]
public partial record Atmospheres(Scalar Value)
    : Pressure.AffineUnit<Atmospheres>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Atmospheres, Pascals, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "atm";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)9.8692326671601e-6;
}

[KnownUnit<Pressure, Bars, Pascals, Scalar>]
public partial record Bars(Scalar Value)
    : Pressure.AffineUnit<Bars>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Bars, Pascals, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "bar";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-5;
}

[KnownUnit<Pressure, PoundsPerSquareInch, Pascals, Scalar>]
public partial record PoundsPerSquareInch(Scalar Value)
    : Pressure.AffineUnit<PoundsPerSquareInch>(Value)
    , ILinearUnit<Scalar>
    , IUnit<PoundsPerSquareInch, Pascals, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "psi";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.00014503773773020923;
}

[KnownUnit<Pressure, Torrs, Pascals, Scalar>]
public partial record Torrs(Scalar Value)
    : Pressure.AffineUnit<Torrs>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Torrs, Pascals, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Torr";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0075006168270417;
}







// TODO:
// - pressure
//      - psi
//      - ksi
//      - mmHg
//      - inHg
//      - from Pa, atm, bar, psi, ...

