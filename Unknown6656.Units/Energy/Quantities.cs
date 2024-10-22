using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;
using Unknown6656.Units.Kinematics;

namespace Unknown6656.Units.Energy;


// TODO : implement gravitational energy    E = - g1 * g2 * m1 * m2 / r     or    E = m * g * h
[MultiplicativeRelationship<Pressure, Volume, KineticEnergy, Pascal, CubicMeter, Joule, Scalar>]
[MultiplicativeRelationship<Impulse, Speed, KineticEnergy, NewtonSecond, MeterPerSecond, Joule, Scalar>] // <-- todo : verify this
public partial record KineticEnergy(Joule value)
    : Quantity<KineticEnergy, Joule, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "E";
}

[MultiplicativeRelationship<Speed, SpecificEnergy, MeterPerSecond, JoulePerKilogram, Scalar>]
[MultiplicativeRelationship<SpecificEnergy, Mass, KineticEnergy, JoulePerKilogram, Kilogram, Joule, Scalar>]
public partial record SpecificEnergy(JoulePerKilogram value)
    : Quantity<SpecificEnergy, JoulePerKilogram, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "e";
}

[MultiplicativeRelationship<EnergyDensity, Volume, KineticEnergy, JoulePerCubicMeter, CubicMeter, Joule, Scalar>]
public partial record EnergyDensity(JoulePerCubicMeter value)
    : Quantity<EnergyDensity, JoulePerCubicMeter, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "U";
}

// TODO : W = kg * (m/s)^2 / s
//          = kg * m^2 / s^3
[MultiplicativeRelationship<Power, Time, KineticEnergy, Watt, Second, Joule, Scalar>]
public partial record Power(Watt value)
    : Quantity<Power, Watt, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "P";
}


// J*s / W = s^2

[MultiplicativeRelationship<KineticEnergy, Time, Action, Joule, Second, JouleSecond, Scalar>]
[MultiplicativeRelationship<Action, Frequency, KineticEnergy, JouleSecond, Hertz, Joule, Scalar>]
public partial record Action(JouleSecond value)
    : Quantity<Action, JouleSecond, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "P";

    public static Action PlanckConstant { get; } = new JouleSecond(6.62607015e-34);
    public static Action ReducedPlanckConstant { get; } = PlanckConstant / Scalar.Tau;
}
