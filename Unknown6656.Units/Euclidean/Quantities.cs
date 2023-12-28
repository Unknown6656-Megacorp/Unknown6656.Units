namespace Unknown6656.Units.Euclidean;


public record Angle(Radians value) : Quantity<Angle, Radians, Scalar>(value);

[MultiplicativeQuantityRelationship<Length, Area, Meters, SquareMeters, Scalar>]
public partial record Length(Meters value) : Quantity<Length, Meters, Scalar>(value);

[MultiplicativeQuantityRelationship<Area, Length, Volume, SquareMeters, Meters, CubicMeters, Scalar>]
public partial record Area(SquareMeters value) : Quantity<Area, SquareMeters, Scalar>(value);

public record Volume(CubicMeters value) : Quantity<Volume, CubicMeters, Scalar>(value);
