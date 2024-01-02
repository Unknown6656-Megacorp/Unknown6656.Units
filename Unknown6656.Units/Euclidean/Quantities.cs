namespace Unknown6656.Units.Euclidean;


public partial record Angle(Radian value)
    : Quantity<Angle, Radian, Scalar>(value)
{
    public static Degree North { get; } = new((Scalar)0);
    public static Degree East { get; } = new((Scalar)90);
    public static Degree South { get; } = new((Scalar)180);
    public static Degree West { get; } = new((Scalar)270);
}

[MultiplicativeQuantityRelationship<Length, Area, Meter, SquareMeter, Scalar>]
public partial record Length(Meter value) : Quantity<Length, Meter, Scalar>(value);

[MultiplicativeQuantityRelationship<Area, Length, Volume, SquareMeter, Meter, CubicMeter, Scalar>]
public partial record Area(SquareMeter value) : Quantity<Area, SquareMeter, Scalar>(value);

public partial record Volume(CubicMeter value) : Quantity<Volume, CubicMeter, Scalar>(value);

[InverseQuantityRelationship<LinearWavenumber, Length, ReciprocalMeter, Meter, Scalar>]
public partial record LinearWavenumber(ReciprocalMeter value) : Quantity<LinearWavenumber, ReciprocalMeter, Scalar>(value);

// TODO : angular wavenumber
// TODO : angular wavelength
// TODO : angular frequency
// TODO : angular period