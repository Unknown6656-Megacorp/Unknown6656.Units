namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Force, Newton, Scalar>]
public partial record Newton(Scalar Value)
    : BaseUnit<Force, Newton, Scalar>(Value)
    , IBaseUnit<Newton, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "N";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricSI;
}


// TODO:
// - force
//      - N, kN, ...
//      - lbf
//      - from N, kN, lbf, ...

