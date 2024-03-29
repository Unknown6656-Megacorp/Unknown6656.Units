﻿using Unknown6656.Units.Kinematics;
using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Euclidean;


public partial record Angle(Radian value)
    : Quantity<Angle, Radian, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "∠";
    public static Degree North { get; } = new(0);
    public static Degree East { get; } = new(90);
    public static Degree South { get; } = new(180);
    public static Degree West { get; } = new(270);
    public static Degree CivilTwilight { get; } = new(6);
    public static Degree NauticalTwilight { get; } = new(12);
    public static Degree AstronomicalTwilight { get; } = new(18);
}

[MultiplicativeRelationship<Angle, SolidAngle, Radian, Steradian, Scalar>]
public partial record SolidAngle(Steradian value)
    : Quantity<SolidAngle, Steradian, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "Ω";
}

[MultiplicativeRelationship<Length, Area, Meter, SquareMeter, Scalar>]
public partial record Length(Meter value)
    : Quantity<Length, Meter, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "l";
}

[MultiplicativeRelationship<Area, Length, Volume, SquareMeter, Meter, CubicMeter, Scalar>]
public partial record Area(SquareMeter value)
    : Quantity<Area, SquareMeter, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "A";
}

public partial record Volume(CubicMeter value)
    : Quantity<Volume, CubicMeter, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "V";
}

[InverseRelationship<LinearWavenumber, Length, ReciprocalMeter, Meter, Scalar>]
[MultiplicativeRelationship<LinearWavenumber, Area, Length, ReciprocalMeter, SquareMeter, Meter, Scalar>]
[MultiplicativeRelationship<LinearWavenumber, Volume, Area, ReciprocalMeter, CubicMeter, SquareMeter, Scalar>]
[MultiplicativeRelationship<LinearWavenumber, Speed, Frequency, ReciprocalMeter, MeterPerSecond, Hertz, Scalar>]
public partial record LinearWavenumber(ReciprocalMeter value)
    : Quantity<LinearWavenumber, ReciprocalMeter, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "v";
#else
    public static string QuantitySymbol { get; } = "̃𝑣";
#endif
}

// TODO : angular wavenumber
// TODO : angular wavelength
// TODO : angular frequency
// TODO : angular period