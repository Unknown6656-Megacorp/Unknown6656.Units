namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Impulse, NewtonSecond, Scalar>]
public partial record NewtonSecond(Scalar Value)
    : BaseUnit<Impulse, NewtonSecond, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "Ns";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Impulse, PoundSecond, NewtonSecond, Scalar>]
public partial record PoundSecond(Scalar Value)
    : Impulse.AffineUnit<PoundSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lbf·s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.224808943099717;
}

[KnownUnit<Impulse, SlugFootPerSecond, NewtonSecond, Scalar>]
public partial record SlugFootPerSecond(Scalar Value)
    : Impulse.AffineUnit<SlugFootPerSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "sl·ft/s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.224735720691;
}
