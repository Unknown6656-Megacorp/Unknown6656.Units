namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Torque, NewtonMeters, Scalar>]
public partial record NewtonMeters(Scalar Value)
    : BaseUnit<Torque, NewtonMeters, Scalar>(Value)
    , IBaseUnit<NewtonMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Nm";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricSI;
}

[KnownUnit<Torque, FootPounds, NewtonMeters, Scalar>]
public partial record FootPounds(Scalar Value)
    : Torque.AffineUnit<FootPounds>(Value)
    , ILinearUnit<Scalar>
    , IUnit<FootPounds, NewtonMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "lbft";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.7375621492772656;
}

[KnownUnit<Torque, PoundInches, NewtonMeters, Scalar>]
public partial record PoundInches(Scalar Value)
    : Torque.AffineUnit<PoundInches>(Value)
    , ILinearUnit<Scalar>
    , IUnit<PoundInches, NewtonMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "lbin";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)8.850745793490557;
}

[KnownUnit<Torque, OunceInches, NewtonMeters, Scalar>]
public partial record OunceInches(Scalar Value)
    : Torque.AffineUnit<OunceInches>(Value)
    , ILinearUnit<Scalar>
    , IUnit<OunceInches, NewtonMeters, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ozin";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)141.6119326958489;
}
