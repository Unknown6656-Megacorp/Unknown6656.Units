namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Speed, MetersPerSecond, Scalar>]
public partial record MetersPerSecond(Scalar Value)
    : BaseUnit<Speed, MetersPerSecond, Scalar>(Value)
    , IBaseUnit<MetersPerSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "m/s";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricSI;
}

[KnownUnit<Speed, KilometersPerHour, MetersPerSecond, Scalar>]
public partial record KilometersPerHour(Scalar Value)
    : Speed.AffineUnit<KilometersPerHour>(Value)
    , ILinearUnit<Scalar>
    , IUnit<KilometersPerHour, MetersPerSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "km/h";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)3.6;
}

[KnownUnit<Speed, MetersPerHour, MetersPerSecond, Scalar>]
public partial record MetersPerHour(Scalar Value)
    : Speed.AffineUnit<MetersPerHour>(Value)
    , ILinearUnit<Scalar>
    , IUnit<MetersPerHour, MetersPerSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "m/h";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)3600;
}

[KnownUnit<Speed, MilesPerHour, MetersPerSecond, Scalar>]
public partial record MilesPerHour(Scalar Value)
    : Speed.AffineUnit<MilesPerHour>(Value)
    , ILinearUnit<Scalar>
    , IUnit<MilesPerHour, MetersPerSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "mi/h";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)2.2369362920544025;
}

[KnownUnit<Speed, FeetPerSecond, MetersPerSecond, Scalar>]
public partial record FeetPerSecond(Scalar Value)
    : Speed.AffineUnit<FeetPerSecond>(Value)
    , ILinearUnit<Scalar>
    , IUnit<FeetPerSecond, MetersPerSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ft/s";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)3.280839895013123;
}

[KnownUnit<Speed, Knots, MetersPerSecond, Scalar>]
public partial record Knots(Scalar Value)
    : Speed.AffineUnit<Knots>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Knots, MetersPerSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "kn";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.9438444924406046;
}




[KnownUnit<Speed, Mach, MetersPerSecond, Scalar>]
public partial record Mach(Scalar Value)
    : Speed.AffineUnit<Mach>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Mach, MetersPerSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Mach";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Prefix;
    public static Scalar ScalingFactor { get; } = (Scalar)340;
}


// TODO:
// - speed
//      - mach / speed of sound (per medium)
//      - speed of light (per medium)
// - propagation speed of waves
//      - in different media
