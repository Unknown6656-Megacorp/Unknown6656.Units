namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Jerk, MeterPerSecondCubed, Scalar>]
public partial record MeterPerSecondCubed(Scalar Value)
    : BaseUnit<Jerk, MeterPerSecondCubed, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "m/s³";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}

[KnownUnit<Jerk, FootPerSecondCubed, MeterPerSecondCubed, Scalar>]
public partial record FootPerSecondCubed(Scalar Value)
    : Jerk.AffineUnit<FootPerSecondCubed>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ft/s³";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)3.280839895013123;
}
