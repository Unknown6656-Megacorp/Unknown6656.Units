namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Torque, NewtonMeter, Scalar>]
public partial record NewtonMeter(Scalar Value)
    : BaseUnit<Torque, NewtonMeter, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "Nm";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["newton m", "n meter"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Torque, FootPound, NewtonMeter, Scalar>]
public partial record FootPound(Scalar Value)
    : Torque.AffineUnit<FootPound>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lb·ft";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lb foot", "lbf foot", "foot lb", "foot lbf", "ft pound", "pound foot", "lbs ft", "ft lb", "ft lbf", "lbf ft", "pound ft"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.7375621492772656;
}

[KnownUnit<Torque, PoundInch, NewtonMeter, Scalar>]
public partial record PoundInch(Scalar Value)
    : Torque.AffineUnit<PoundInch>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lb·in";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lb inch", "lbf inch", "lb in", "lbf in", "pound in", "inch lb", "inch lbf", "inch pound", "in lb", "in lbf", "in pound"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)8.850745793490557;
}

[KnownUnit<Torque, OunceInch, NewtonMeter, Scalar>]
public partial record OunceInch(Scalar Value)
    : Torque.AffineUnit<OunceInch>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "oz·in";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ounce in", "in ounce", "inch ounce", "oz inch", "in oz", "inch oz"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)141.6119326958489;
}
