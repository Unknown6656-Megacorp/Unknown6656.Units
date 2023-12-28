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



// TODO:
// - speed
//      - km/h
//      - mi/h
//      - m/s
//      - ft/s
//      - knots
//      - mach
//      - speed of sound
//      - speed of light
// - acceleration
//      - m/s^2
//      - ft/s^2
//      - g
// - propagation speed of waves
//      - in different media
