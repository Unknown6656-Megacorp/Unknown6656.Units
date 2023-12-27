namespace Unknown6656.Units.Time;


[InverseQuantityRelationship<Time, Frequency, Seconds, Hertz, Scalar>]
public partial record Time(Seconds value) : Quantity<Time, Seconds, Scalar>(value);

public partial record Frequency(Hertz value) : Quantity<Frequency, Hertz, Scalar>(value);
