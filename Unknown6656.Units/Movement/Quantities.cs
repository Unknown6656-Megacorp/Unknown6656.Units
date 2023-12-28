using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Matter;
using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Movement;


[MultiplicativeQuantityRelationship<Speed, Time, Length, MetersPerSecond, Seconds, Meters, Scalar>]
public partial record Speed(MetersPerSecond value) : Quantity<Speed, MetersPerSecond, Scalar>(value);

[MultiplicativeQuantityRelationship<Acceleration, Time, Speed, MetersPerSecondSquared, Seconds, MetersPerSecond, Scalar>]
public partial record Acceleration(MetersPerSecondSquared value) : Quantity<Acceleration, MetersPerSecondSquared, Scalar>(value);

[MultiplicativeQuantityRelationship<VolumetricFlowRate, Time, Volume, CubicMetersPerSecond, Seconds, CubicMeters, Scalar>]
public partial record VolumetricFlowRate(CubicMetersPerSecond value) : Quantity<VolumetricFlowRate, CubicMetersPerSecond, Scalar>(value);

// TODO : mass flow rate


[MultiplicativeQuantityRelationship<Force, Time, Impulse, Newtons, Seconds, NewtonSeconds, Scalar>]
public partial record Impulse(NewtonSeconds value) : Quantity<Impulse, NewtonSeconds, Scalar>(value);

// TODO : specific impulse


[MultiplicativeQuantityRelationship<Mass, Acceleration, Force, Kilograms, MetersPerSecondSquared, Newtons, Scalar>]
public partial record Force(Newtons value) : Quantity<Force, Newtons, Scalar>(value);

[MultiplicativeQuantityRelationship<Energy, Angle, Torque, Joules, Radians, NewtonMeters, Scalar>]
[MultiplicativeQuantityRelationship<Force, Length, Torque, Newtons, Meters, NewtonMeters, Scalar>]
public partial record Torque(NewtonMeters value) : Quantity<Torque, NewtonMeters, Scalar>(value);
