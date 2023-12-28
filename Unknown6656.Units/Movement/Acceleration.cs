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
