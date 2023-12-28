using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Matter;
using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Movement;


[MultiplicativeQuantityRelationship<Speed, Time, Length, MeterPerSecond, Second, Meter, Scalar>]
public partial record Speed(MeterPerSecond value) : Quantity<Speed, MeterPerSecond, Scalar>(value);

[MultiplicativeQuantityRelationship<Acceleration, Time, Speed, MeterPerSecondSquared, Second, MeterPerSecond, Scalar>]
public partial record Acceleration(MeterPerSecondSquared value) : Quantity<Acceleration, MeterPerSecondSquared, Scalar>(value);

[MultiplicativeQuantityRelationship<VolumetricFlowRate, Time, Volume, CubicMeterPerSecond, Second, CubicMeter, Scalar>]
public partial record VolumetricFlowRate(CubicMeterPerSecond value) : Quantity<VolumetricFlowRate, CubicMeterPerSecond, Scalar>(value);

// TODO : mass flow rate


[MultiplicativeQuantityRelationship<Force, Time, Impulse, Newton, Second, NewtonSecond, Scalar>]
public partial record Impulse(NewtonSecond value) : Quantity<Impulse, NewtonSecond, Scalar>(value);

// TODO : specific impulse


[MultiplicativeQuantityRelationship<Mass, Acceleration, Force, Kilogram, MeterPerSecondSquared, Newton, Scalar>]
public partial record Force(Newton value) : Quantity<Force, Newton, Scalar>(value);

[MultiplicativeQuantityRelationship<Energy, Angle, Torque, Joule, Radian, NewtonMeter, Scalar>]
[MultiplicativeQuantityRelationship<Force, Length, Torque, Newton, Meter, NewtonMeter, Scalar>]
public partial record Torque(NewtonMeter value) : Quantity<Torque, NewtonMeter, Scalar>(value);
