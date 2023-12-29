namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Impulse, NewtonSecond, Scalar>]
public partial record NewtonSecond(Scalar Value)
    : BaseUnit<Impulse, NewtonSecond, Scalar>(Value)
    , IBaseUnit<NewtonSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Ns";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}

[KnownUnit<Impulse, PoundSecond, NewtonSecond, Scalar>]
public partial record PoundSecond(Scalar Value)
    : Impulse.AffineUnit<PoundSecond>(Value)
    , ILinearUnit<Scalar>
    , IUnit<PoundSecond, NewtonSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "lbf·s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.224808943099717;
}

[KnownUnit<Impulse, SlugFootPerSecond, NewtonSecond, Scalar>]
public partial record SlugFootPerSecond(Scalar Value)
    : Impulse.AffineUnit<SlugFootPerSecond>(Value)
    , ILinearUnit<Scalar>
    , IUnit<SlugFootPerSecond, NewtonSecond, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "slug·ft/s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.224735720691;
}

