namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Acceleration, MeterPerSecondSquared, Scalar>]
public partial record MeterPerSecondSquared(Scalar Value)
    : BaseUnit<Acceleration, MeterPerSecondSquared, Scalar>(Value)
    , IBaseUnit<MeterPerSecondSquared, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "m/s²";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}

[KnownUnit<Acceleration, FootPerSecondSquared, MeterPerSecondSquared, Scalar>]
public partial record FootPerSecondSquared(Scalar Value)
    : Acceleration.AffineUnit<FootPerSecondSquared>(Value)
    , ILinearUnit<Scalar>
    , IUnit<FootPerSecondSquared, MeterPerSecondSquared, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ft/s²";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)3.280839895013123;
}

[KnownUnit<Acceleration, Gal, MeterPerSecondSquared, Scalar>]
public partial record Gal(Scalar Value)
    : Acceleration.AffineUnit<Gal>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Gal, MeterPerSecondSquared, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Gal";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-2;
}

[KnownUnit<Acceleration, G, MeterPerSecondSquared, Scalar>]
public partial record G(Scalar Value)
    : Acceleration.AffineUnit<G>(Value)
    , ILinearUnit<Scalar>
    , IUnit<G, MeterPerSecondSquared, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "g₀";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)9.80665;
}
