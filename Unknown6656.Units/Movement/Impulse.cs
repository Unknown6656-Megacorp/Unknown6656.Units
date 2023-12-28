namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Impulse, NewtonSeconds, Scalar>]
public partial record NewtonSeconds(Scalar Value)
    : BaseUnit<Impulse, NewtonSeconds, Scalar>(Value)
    , IBaseUnit<NewtonSeconds, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Ns";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricSI;
}

[KnownUnit<Impulse, PoundSeconds, NewtonSeconds, Scalar>]
public partial record PoundSeconds(Scalar Value)
    : Impulse.AffineUnit<PoundSeconds>(Value)
    , ILinearUnit<Scalar>
    , IUnit<PoundSeconds, NewtonSeconds, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "lbf·s";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.224808943099717;
}

[KnownUnit<Impulse, SlugFeetPerSecond, NewtonSeconds, Scalar>]
public partial record SlugFeetPerSecond(Scalar Value)
    : Impulse.AffineUnit<SlugFeetPerSecond>(Value)
    , ILinearUnit<Scalar>
    , IUnit<SlugFeetPerSecond, NewtonSeconds, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "slug·ft/s";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.224735720691;
}

