namespace Unknown6656.Units.Movement;


[KnownBaseUnit<KinematicViscosity, SquareMeterPerSecond, Scalar>]
public partial record SquareMeterPerSecond(Scalar Value)
    : BaseUnit<KinematicViscosity, SquareMeterPerSecond, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "m²/s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
}
