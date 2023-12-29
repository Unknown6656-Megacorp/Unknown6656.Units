namespace Unknown6656.Units.Matter;


[KnownBaseUnit<Pressure, Pascal, Scalar>]
public partial record Pascal(Scalar Value)
    : BaseUnit<Pressure, Pascal, Scalar>(Value)
    , IBaseUnit<Pascal, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Pa";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}

[KnownUnit<Pressure, Atmosphere, Pascal, Scalar>]
public partial record Atmosphere(Scalar Value)
    : Pressure.AffineUnit<Atmosphere>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Atmosphere, Pascal, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "atm";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)9.8692326671601e-6;
}

[KnownUnit<Pressure, Bar, Pascal, Scalar>]
public partial record Bar(Scalar Value)
    : Pressure.AffineUnit<Bar>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Bar, Pascal, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "bar";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-5;
}

[KnownUnit<Pressure, PoundPerSquareInch, Pascal, Scalar>]
public partial record PoundPerSquareInch(Scalar Value)
    : Pressure.AffineUnit<PoundPerSquareInch>(Value)
    , ILinearUnit<Scalar>
    , IUnit<PoundPerSquareInch, Pascal, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "psi";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.00014503773773020923;
}

[KnownUnit<Pressure, Torr, Pascal, Scalar>]
public partial record Torr(Scalar Value)
    : Pressure.AffineUnit<Torr>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Torr, Pascal, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Torr";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0075006168270417;
}







// TODO:
// - pressure
//      - psi
//      - ksi
//      - mmHg
//      - inHg
//      - from Pa, atm, bar, psi, ...

