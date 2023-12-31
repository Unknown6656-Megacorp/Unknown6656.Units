﻿using Unknown6656.Units.Movement;
using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Euclidean;


public partial record Angle(Radian value)
    : Quantity<Angle, Radian, Scalar>(value)
{
    public static Degree North { get; } = new((Scalar)0);
    public static Degree East { get; } = new((Scalar)90);
    public static Degree South { get; } = new((Scalar)180);
    public static Degree West { get; } = new((Scalar)270);
}

[MultiplicativeRelationship<Length, Area, Meter, SquareMeter, Scalar>]
public partial record Length(Meter value) : Quantity<Length, Meter, Scalar>(value);

[MultiplicativeRelationship<Area, Length, Volume, SquareMeter, Meter, CubicMeter, Scalar>]
public partial record Area(SquareMeter value) : Quantity<Area, SquareMeter, Scalar>(value);

public partial record Volume(CubicMeter value) : Quantity<Volume, CubicMeter, Scalar>(value);

[InverseRelationship<LinearWavenumber, Length, ReciprocalMeter, Meter, Scalar>]
[MultiplicativeRelationship<LinearWavenumber, Area, Length, ReciprocalMeter, SquareMeter, Meter, Scalar>]
[MultiplicativeRelationship<LinearWavenumber, Volume, Area, ReciprocalMeter, CubicMeter, SquareMeter, Scalar>]
[MultiplicativeRelationship<LinearWavenumber, Speed, Frequency, ReciprocalMeter, MeterPerSecond, Hertz, Scalar>]
public partial record LinearWavenumber(ReciprocalMeter value) : Quantity<LinearWavenumber, ReciprocalMeter, Scalar>(value);

// TODO : angular wavenumber
// TODO : angular wavelength
// TODO : angular frequency
// TODO : angular period