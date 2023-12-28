namespace Unknown6656.Units.Temporal;


[InverseQuantityRelationship<Time, Frequency, Second, Hertz, Scalar>]
public partial record Time(Second value) : Quantity<Time, Second, Scalar>(value);

public partial record Frequency(Hertz value) : Quantity<Frequency, Hertz, Scalar>(value);
