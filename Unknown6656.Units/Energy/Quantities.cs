using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Matter;
using Unknown6656.Units.Movement;
using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Energy;


public partial record Temperature(Kelvin value)
    : Quantity<Temperature, Kelvin, Scalar>(value)
{

}

// TODO : implement shit like  E = 1/2 * m * v^2
// TODO : implement gravitational energy    E = - g1 * g2 * m1 * m2 / r     or    E = m * g * h
[MultiplicativeQuantityRelationship<Force, Length, KineticEnergy, Newton, Meter, Joule, Scalar>]
[MultiplicativeQuantityRelationship<Pressure, Volume, KineticEnergy, Pascal, CubicMeter, Joule, Scalar>]
public partial record KineticEnergy(Joule value) : Quantity<KineticEnergy, Joule, Scalar>(value);

// TODO : W = kg * (m/s)^2 / s
// TODO : W = A^2 * Ω
[MultiplicativeQuantityRelationship<Power, Time, KineticEnergy, Watt, Second, Joule, Scalar>]
public partial record Power(Watt value) : Quantity<Power, Watt, Scalar>(value);
