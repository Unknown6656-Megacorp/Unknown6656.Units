namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Torque, NewtonMeter, Scalar>]
public partial record NewtonMeter(Scalar Value)
    : BaseUnit<Torque, NewtonMeter, Scalar>(Value)
    , IBaseUnit<NewtonMeter, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Nm";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}

[KnownUnit<Torque, FootPound, NewtonMeter, Scalar>]
public partial record FootPound(Scalar Value)
    : Torque.AffineUnit<FootPound>(Value)
    , ILinearUnit<Scalar>
    , IUnit<FootPound, NewtonMeter, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "lbft";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.7375621492772656;
}

[KnownUnit<Torque, PoundInch, NewtonMeter, Scalar>]
public partial record PoundInch(Scalar Value)
    : Torque.AffineUnit<PoundInch>(Value)
    , ILinearUnit<Scalar>
    , IUnit<PoundInch, NewtonMeter, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "lbin";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)8.850745793490557;
}

[KnownUnit<Torque, OunceInch, NewtonMeter, Scalar>]
public partial record OunceInch(Scalar Value)
    : Torque.AffineUnit<OunceInch>(Value)
    , ILinearUnit<Scalar>
    , IUnit<OunceInch, NewtonMeter, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ozin";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)141.6119326958489;
}
