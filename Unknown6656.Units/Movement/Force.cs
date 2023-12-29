namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Force, Newton, Scalar>]
public partial record Newton(Scalar Value)
    : BaseUnit<Force, Newton, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "N";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}


// TODO:
// - force
//      - N, kN, ...
//      - lbf
//      - from N, kN, lbf, ...

