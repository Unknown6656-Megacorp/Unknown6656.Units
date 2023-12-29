namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Force, Newton, Scalar>]
public partial record Newton(Scalar Value)
    : BaseUnit<Force, Newton, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "N";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}

[KnownUnit<Force, PoundForce, Newton, Scalar>]
public partial record PoundForce(Scalar Value)
    : Force.AffineUnit<PoundForce>(Value)
    , ILinearUnit<Scalar>
    , IUnit<PoundForce, Newton, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "lbf";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.2248089430997105;
}


// TODO:
// - force
//      - N, kN, ...
//      - lbf
//      - from N, kN, lbf, ...

