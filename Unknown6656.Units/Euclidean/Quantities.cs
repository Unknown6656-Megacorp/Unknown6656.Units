using System;

using Unknown6656.Units.Kinematics;
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

[IdentityRelationship<Wavelength, Length, Nanometer, Meter, Scalar>(1e-9)]
public partial record Wavelength(Nanometer value)
    : Quantity<Wavelength, Nanometer, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "l";
#else
    public static string QuantitySymbol { get; } = "λ";
#endif

    public Frequency Frequency => Speed.C0 / (Length)this;

}

[MultiplicativeRelationship<Area, Length, Volume, SquareMeter, Meter, CubicMeter, Scalar>]
public partial record Area(SquareMeter value)
    : Quantity<Area, SquareMeter, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "A";


    public static Area OfCircle(Length radius) => OfSquare(radius) * Scalar.Pi;

    public static Area OfSquare(Length sidelength) => OfRectangle(sidelength, sidelength);

    public static Area OfRectangle(Length width, Length height) => width * height;

    public static Area OfTriangle(Length width, Length height) => OfRectangle(width, height) * (Scalar).5;

    public static Area OfEquilateralTriangle(Length sidelength) => OfSquare(sidelength) * (Scalar).4330127018922193233818615853764680917357013134525951570139;

    public static Area OfPentagon(Length sidelength) => OfSquare(sidelength) * (Scalar)1.7204774005889669227590119773886095994073741700101983292070;

    public static Area OfHexagon(Length sidelength) => (Area)(
        3.4641016151377545870548926830117447338856105076207612561116139589 * Math.Pow((Scalar)sidelength * .8660254037844386467637231707529361834714026269051903140279034897, 2)
    );
}

public partial record Volume(CubicMeter value)
    : Quantity<Volume, CubicMeter, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "V";


    public static Volume OfSphere(Length radius) => OfCube(radius) * (Scalar)4.1887902047863909846168578443726705122628925325001410946332594564;

    public static Volume OfCube(Length sidelength) => OfRectangularCuboid(sidelength, sidelength, sidelength);

    public static Volume OfRectangularCuboid(Area basearea, Length height) => basearea * height;

    public static Volume OfRectangularCuboid(Length length, Length width, Length height) => length * width * height;
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