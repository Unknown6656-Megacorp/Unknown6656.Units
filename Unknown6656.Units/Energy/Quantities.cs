using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;

namespace Unknown6656.Units.Energy;


public partial record Temperature(Kelvin value)
    : Quantity<Temperature, Kelvin, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "T";
    public static Kelvin AbsoluteZero { get; } = new((Scalar)0);
    public static Kelvin AbsoluteHot { get; } = new((Scalar)1.416808338416e32);
}

// TODO : implement shit like  E = 1/2 * m * v^2
// TODO : implement gravitational energy    E = - g1 * g2 * m1 * m2 / r     or    E = m * g * h
[MultiplicativeRelationship<Pressure, Volume, KineticEnergy, Pascal, CubicMeter, Joule, Scalar>]
public partial record KineticEnergy(Joule value)
    : Quantity<KineticEnergy, Joule, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "E";
}

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

// TODO : specific heat capacity https://en.wikipedia.org/wiki/Specific_heat_capacity
// TODO : (thermal) energetic entropy