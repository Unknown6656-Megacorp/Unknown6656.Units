namespace Unknown6656.Units.Time;


//[QuantityDependency<Length, Area, Meters, SquareMeters, Scalar>]
public partial record Time(Seconds value) : Quantity<Time, Seconds, Scalar>(value);
