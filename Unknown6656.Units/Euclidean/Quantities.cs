namespace Unknown6656.Units.Euclidean;


public partial record Angle(Radian value) : Quantity<Angle, Radian, Scalar>(value);

[MultiplicativeQuantityRelationship<Length, Area, Meter, SquareMeter, Scalar>]
public partial record Length(Meter value) : Quantity<Length, Meter, Scalar>(value);

[MultiplicativeQuantityRelationship<Area, Length, Volume, SquareMeter, Meter, CubicMeter, Scalar>]
public partial record Area(SquareMeter value) : Quantity<Area, SquareMeter, Scalar>(value);

public partial record Volume(CubicMeter value) : Quantity<Volume, CubicMeter, Scalar>(value);
