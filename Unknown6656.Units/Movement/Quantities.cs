using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;
using Unknown6656.Units.Energy;

namespace Unknown6656.Units.Movement;


[MultiplicativeRelationship<Speed, Time, Length, MeterPerSecond, Second, Meter, Scalar>]
[MultiplicativeRelationship<Length, Frequency, Speed, Meter, Hertz, MeterPerSecond, Scalar>]
public partial record Speed(MeterPerSecond value)
    : Quantity<Speed, MeterPerSecond, Scalar>(value)
{
    public static SpeedOfLightVacuum C0 { get; } = new(1);
}

[MultiplicativeRelationship<Acceleration, Time, Speed, MeterPerSecondSquared, Second, MeterPerSecond, Scalar>]
[MultiplicativeRelationship<Speed, Frequency, Acceleration, MeterPerSecond, Hertz, MeterPerSecondSquared, Scalar>]
public partial record Acceleration(MeterPerSecondSquared value) : Quantity<Acceleration, MeterPerSecondSquared, Scalar>(value);

[MultiplicativeRelationship<Jerk, Time, Acceleration, MeterPerSecondCubed, Second, MeterPerSecondSquared, Scalar>]
[MultiplicativeRelationship<Acceleration, Frequency, Jerk, MeterPerSecondSquared, Hertz, MeterPerSecondCubed, Scalar>]
public partial record Jerk(MeterPerSecondCubed value) : Quantity<Jerk, MeterPerSecondCubed, Scalar>(value);

[MultiplicativeRelationship<VolumetricFlowRate, Time, Volume, CubicMeterPerSecond, Second, CubicMeter, Scalar>]
[MultiplicativeRelationship<Volume, Frequency, VolumetricFlowRate, CubicMeter, Hertz, CubicMeterPerSecond, Scalar>]
public partial record VolumetricFlowRate(CubicMeterPerSecond value) : Quantity<VolumetricFlowRate, CubicMeterPerSecond, Scalar>(value);

// TODO : mass flux https://en.wikipedia.org/wiki/Mass_flux
// kg / m^2 / s


// Pa*s = J*s / m^3     [todo: verify]
[MultiplicativeRelationship<Pressure, Time, DynamicViscosity, Pascal, Second, PascalSecond, Scalar>]
[MultiplicativeRelationship<VolumetricFlowRate, DynamicViscosity, Torque, CubicMeterPerSecond, PascalSecond, NewtonMeter, Scalar>]
[MultiplicativeRelationship<MassFlowRate, Length, DynamicViscosity, KilogramPerSecond, Meter, PascalSecond, Scalar>]
public partial record DynamicViscosity(PascalSecond value) : Quantity<DynamicViscosity, PascalSecond, Scalar>(value);

// TODO: kvis = J*s / kg
[MultiplicativeRelationship<KinematicViscosity, Time, Area, SquareMeterPerSecond, Second, SquareMeter, Scalar>]
[MultiplicativeRelationship<SpecificEnergy, Time, KinematicViscosity, JoulePerKilogram, Second, SquareMeterPerSecond, Scalar>] // TODO : verify this.
[MultiplicativeRelationship<KinematicViscosity, MassFlowRate, Torque, SquareMeterPerSecond, KilogramPerSecond, NewtonMeter, Scalar>]
public partial record KinematicViscosity(SquareMeterPerSecond value) : Quantity<KinematicViscosity, SquareMeterPerSecond, Scalar>(value);

[MultiplicativeRelationship<MassFlowRate, Time, Mass, KilogramPerSecond, Second, Kilogram, Scalar>]
public partial record MassFlowRate(KilogramPerSecond value) : Quantity<MassFlowRate, KilogramPerSecond, Scalar>(value);

[MultiplicativeRelationship<Force, Time, Impulse, Newton, Second, NewtonSecond, Scalar>]
public partial record Impulse(NewtonSecond value) : Quantity<Impulse, NewtonSecond, Scalar>(value);

// public partial record SpecificImpulse(Second value) : Quantity<SpecificImpulse, Second, Scalar>(value);

[MultiplicativeRelationship<Mass, Acceleration, Force, Kilogram, MeterPerSecondSquared, Newton, Scalar>]
public partial record Force(Newton value) : Quantity<Force, Newton, Scalar>(value);

[IdentityRelationship<Torque, KineticEnergy, NewtonMeter, Joule, Scalar>]
[MultiplicativeRelationship<Force, Length, Torque, Newton, Meter, NewtonMeter, Scalar>]
[MultiplicativeRelationship<KineticEnergy, Angle, Torque, Joule, Radian, NewtonMeter, Scalar>]
public partial record Torque(NewtonMeter value) : Quantity<Torque, NewtonMeter, Scalar>(value);


// TODO : implement all viscosity formulas from https://en.wikipedia.org/wiki/Viscosity
// TODO : surface tension https://en.wikipedia.org/wiki/Surface_tension
// TODO : drag force https://en.wikipedia.org/wiki/Drag_(physics)
// TODO : lift force https://en.wikipedia.org/wiki/Lift_(force)
// TODO : buoyancy https://en.wikipedia.org/wiki/Buoyancy
// TODO : friction https://en.wikipedia.org/wiki/Friction
