using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Time;

namespace Unknown6656.Units.Movement;


[MultiplicativeQuantityRelationship<Speed, Time, Length, MetersPerSecond, Seconds, Meters, Scalar>]
public partial record Speed(MetersPerSecond value) : Quantity<Speed, MetersPerSecond, Scalar>(value);
