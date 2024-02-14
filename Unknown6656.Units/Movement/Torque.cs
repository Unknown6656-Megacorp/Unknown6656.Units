using Unknown6656.Units.Euclidean;

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
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lb*ft";
#else
    public static string UnitSymbol { get; } = "lb·ft";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lb foot", "lbf foot", "foot lb", "foot lbf", "ft pound", "pound foot", "lbs ft", "ft lb", "ft lbf", "lbf ft", "pound ft"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = PoundForce.ScalingFactor * Foot.ScalingFactor;
}

[KnownUnit<Torque, PoundInch, NewtonMeter, Scalar>]
public partial record PoundInch(Scalar Value)
    : Torque.AffineUnit<PoundInch>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lb*in";
#else
    public static string UnitSymbol { get; } = "lb·in";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lb inch", "lbf inch", "lb in", "lbf in", "pound in", "inch lb", "inch lbf", "inch pound", "in lb", "in lbf", "in pound"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = PoundForce.ScalingFactor * Inch.ScalingFactor;
}

[KnownUnit<Torque, OunceInch, NewtonMeter, Scalar>]
public partial record OunceInch(Scalar Value)
    : Torque.AffineUnit<OunceInch>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "oz*in";
#else
    public static string UnitSymbol { get; } = "oz·in";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ounce in", "in ounce", "inch ounce", "oz inch", "in oz", "inch oz"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = OunceForce.ScalingFactor * Inch.ScalingFactor;
}
