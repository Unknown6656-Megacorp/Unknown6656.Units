using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;
using Unknown6656.Units.Energy;

namespace Unknown6656.Units.Movement;


[MultiplicativeQuantityRelationship<Speed, Time, Length, MeterPerSecond, Second, Meter, Scalar>]
public partial record Speed(MeterPerSecond value) : Quantity<Speed, MeterPerSecond, Scalar>(value);

[MultiplicativeQuantityRelationship<Acceleration, Time, Speed, MeterPerSecondSquared, Second, MeterPerSecond, Scalar>]
public partial record Acceleration(MeterPerSecondSquared value) : Quantity<Acceleration, MeterPerSecondSquared, Scalar>(value);

[MultiplicativeQuantityRelationship<Jerk, Time, Acceleration, MeterPerSecondCubed, Second, MeterPerSecondSquared, Scalar>]
public partial record Jerk(MeterPerSecondCubed value) : Quantity<Jerk, MeterPerSecondCubed, Scalar>(value);

[MultiplicativeQuantityRelationship<VolumetricFlowRate, Time, Volume, CubicMeterPerSecond, Second, CubicMeter, Scalar>]
public partial record VolumetricFlowRate(CubicMeterPerSecond value) : Quantity<VolumetricFlowRate, CubicMeterPerSecond, Scalar>(value);

// TODO : mass flux https://en.wikipedia.org/wiki/Mass_flux
// kg / m^2 / s


// Pa*s = J*s / m^3     [todo: verify]
[MultiplicativeQuantityRelationship<Pressure, Time, DynamicViscosity, Pascal, Second, PascalSecond, Scalar>]
[MultiplicativeQuantityRelationship<VolumetricFlowRate, DynamicViscosity, Torque, CubicMeterPerSecond, PascalSecond, NewtonMeter, Scalar>]
[MultiplicativeQuantityRelationship<MassFlowRate, Length, DynamicViscosity, KilogramPerSecond, Meter, PascalSecond, Scalar>]
public partial record DynamicViscosity(PascalSecond value) : Quantity<DynamicViscosity, PascalSecond, Scalar>(value);

// TODO: kvis = J*s / kg
[MultiplicativeQuantityRelationship<KinematicViscosity, Time, Area, SquareMeterPerSecond, Second, SquareMeter, Scalar>]
[MultiplicativeQuantityRelationship<SpecificEnergy, Time, KinematicViscosity, JoulePerKilogram, Second, SquareMeterPerSecond, Scalar>] // TODO : verify this.
[MultiplicativeQuantityRelationship<KinematicViscosity, MassFlowRate, Torque, SquareMeterPerSecond, KilogramPerSecond, NewtonMeter, Scalar>]
public partial record KinematicViscosity(SquareMeterPerSecond value) : Quantity<KinematicViscosity, SquareMeterPerSecond, Scalar>(value);

[MultiplicativeQuantityRelationship<MassFlowRate, Time, Mass, KilogramPerSecond, Second, Kilogram, Scalar>]
public partial record MassFlowRate(KilogramPerSecond value) : Quantity<MassFlowRate, KilogramPerSecond, Scalar>(value);

[MultiplicativeQuantityRelationship<Force, Time, Impulse, Newton, Second, NewtonSecond, Scalar>]
public partial record Impulse(NewtonSecond value) : Quantity<Impulse, NewtonSecond, Scalar>(value);

// TODO : specific impulse

[MultiplicativeQuantityRelationship<Mass, Acceleration, Force, Kilogram, MeterPerSecondSquared, Newton, Scalar>]
public partial record Force(Newton value) : Quantity<Force, Newton, Scalar>(value);

[MultiplicativeQuantityRelationship<KineticEnergy, Angle, Torque, Joule, Radian, NewtonMeter, Scalar>]
[MultiplicativeQuantityRelationship<Force, Length, Torque, Newton, Meter, NewtonMeter, Scalar>]
public partial record Torque(NewtonMeter value) : Quantity<Torque, NewtonMeter, Scalar>(value);


// TODO : implement all viscosity formulas from https://en.wikipedia.org/wiki/Viscosity
// TODO : surface tension https://en.wikipedia.org/wiki/Surface_tension
// TODO : drag force https://en.wikipedia.org/wiki/Drag_(physics)
// TODO : lift force https://en.wikipedia.org/wiki/Lift_(force)
// TODO : buoyancy https://en.wikipedia.org/wiki/Buoyancy
// TODO : friction https://en.wikipedia.org/wiki/Friction
