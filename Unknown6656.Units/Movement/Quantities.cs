using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Movement;


[MultiplicativeQuantityRelationship<Speed, Time, Length, MetersPerSecond, Seconds, Meters, Scalar>]
public partial record Speed(MetersPerSecond value) : Quantity<Speed, MetersPerSecond, Scalar>(value);

[MultiplicativeQuantityRelationship<Acceleration, Time, Speed, MetersPerSecondSquared, Seconds, MetersPerSecond, Scalar>]
public partial record Acceleration(MetersPerSecondSquared value) : Quantity<Acceleration, MetersPerSecondSquared, Scalar>(value);

// TODO : mass flow rate
// TODO : volumetric flow rate
