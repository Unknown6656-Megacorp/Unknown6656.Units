namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Acceleration, MetersPerSecondSquared, Scalar>]
public partial record MetersPerSecondSquared(Scalar Value)
    : BaseUnit<Acceleration, MetersPerSecondSquared, Scalar>(Value)
    , IBaseUnit<MetersPerSecondSquared, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "m/s²";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricSI;
}

[KnownUnit<Acceleration, FeetPerSecondSquared, MetersPerSecondSquared, Scalar>]
public partial record FeetPerSecondSquared(Scalar Value)
    : Acceleration.AffineUnit<FeetPerSecondSquared>(Value)
    , ILinearUnit<Scalar>
    , IUnit<FeetPerSecondSquared, MetersPerSecondSquared, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ft/s²";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)3.280839895013123;
}

[KnownUnit<Acceleration, Gals, MetersPerSecondSquared, Scalar>]
public partial record Gals(Scalar Value)
    : Acceleration.AffineUnit<Gals>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Gals, MetersPerSecondSquared, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Gal";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-2;
}

[KnownUnit<Acceleration, G, MetersPerSecondSquared, Scalar>]
public partial record G(Scalar Value)
    : Acceleration.AffineUnit<G>(Value)
    , ILinearUnit<Scalar>
    , IUnit<G, MetersPerSecondSquared, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "g₀";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)9.80665;
}
