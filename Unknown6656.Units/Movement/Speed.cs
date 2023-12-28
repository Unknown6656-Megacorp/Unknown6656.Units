namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Speed, MeterPerSecond, Scalar>]
public partial record MeterPerSecond(Scalar Value)
    : BaseUnit<Speed, MeterPerSecond, Scalar>(Value)
    , IBaseUnit<MeterPerSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "m/s";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricSI;
}

[KnownUnit<Speed, KilometerPerHour, MeterPerSecond, Scalar>]
public partial record KilometerPerHour(Scalar Value)
    : Speed.AffineUnit<KilometerPerHour>(Value)
    , ILinearUnit<Scalar>
    , IUnit<KilometerPerHour, MeterPerSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "km/h";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)3.6;
}

[KnownUnit<Speed, MeterPerHour, MeterPerSecond, Scalar>]
public partial record MeterPerHour(Scalar Value)
    : Speed.AffineUnit<MeterPerHour>(Value)
    , ILinearUnit<Scalar>
    , IUnit<MeterPerHour, MeterPerSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "m/h";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)3600;
}

[KnownUnit<Speed, MilePerHour, MeterPerSecond, Scalar>]
public partial record MilePerHour(Scalar Value)
    : Speed.AffineUnit<MilePerHour>(Value)
    , ILinearUnit<Scalar>
    , IUnit<MilePerHour, MeterPerSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "mi/h";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)2.2369362920544025;
}

[KnownUnit<Speed, FootPerSecond, MeterPerSecond, Scalar>]
public partial record FootPerSecond(Scalar Value)
    : Speed.AffineUnit<FootPerSecond>(Value)
    , ILinearUnit<Scalar>
    , IUnit<FootPerSecond, MeterPerSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ft/s";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)3.280839895013123;
}

[KnownUnit<Speed, Knot, MeterPerSecond, Scalar>]
public partial record Knot(Scalar Value)
    : Speed.AffineUnit<Knot>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Knot, MeterPerSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "kn";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.9438444924406046;
}




[KnownUnit<Speed, Mach, MeterPerSecond, Scalar>]
public partial record Mach(Scalar Value)
    : Speed.AffineUnit<Mach>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Mach, MeterPerSecond, Scalar>
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
