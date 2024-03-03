using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<LinearForceDensity, NewtonPerMeter, Scalar>]
public partial record NewtonPerMeter(Scalar Value)
    : BaseUnit<LinearForceDensity, NewtonPerMeter, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "N/m";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["newton/m", "N/meter"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<LinearForceDensity, PoundForcePerInch, NewtonPerMeter, Scalar>]
public partial record PoundForcePerInch(Scalar Value)
    : LinearForceDensity.AffineUnit<PoundForcePerInch>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lbf/in";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["pound/in", "pound f/in", "lb force/in", "lb/in", "pound/inch", "pound f/inch", "lb/inch", "lb force/inch"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = PoundForce.ScalingFactor / Inch.ScalingFactor;
}

[KnownUnit<LinearForceDensity, PoundForcePerFoot, NewtonPerMeter, Scalar>]
public partial record PoundForcePerFoot(Scalar Value)
    : LinearForceDensity.AffineUnit<PoundForcePerFoot>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lbf/ft";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["pound/ft", "pound f/ft", "lb force/ft", "lb/ft", "pound/foot", "pound f/foot", "lb/foot", "lb force/foot"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = PoundForce.ScalingFactor / Foot.ScalingFactor;
}

[KnownUnit<LinearForceDensity, OunceForcePerInch, NewtonPerMeter, Scalar>]
public partial record OunceForcePerInch(Scalar Value)
    : LinearForceDensity.AffineUnit<OunceForcePerInch>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "oz/in";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ounce/in", "ounce f/in", "oz force/in", "ounce/inch", "ounce f/inch", "oz/inch", "oz force/inch"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = OunceForce.ScalingFactor / Inch.ScalingFactor;
}

[KnownUnit<LinearForceDensity, OunceForcePerFoot, NewtonPerMeter, Scalar>]
public partial record OunceForcePerFoot(Scalar Value)
    : LinearForceDensity.AffineUnit<OunceForcePerFoot>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "oz/ft";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ounce/ft", "ounce f/ft", "oz force/ft", "ounce/foot", "ounce f/fpot", "oz/foot", "oz force/foot"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = OunceForce.ScalingFactor / Foot.ScalingFactor;
}
