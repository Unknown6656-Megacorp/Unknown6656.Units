namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Force, Newtons, Scalar>]
public partial record Newtons(Scalar Value)
    : BaseUnit<Force, Newtons, Scalar>(Value)
    , IBaseUnit<Newtons, Scalar>
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

