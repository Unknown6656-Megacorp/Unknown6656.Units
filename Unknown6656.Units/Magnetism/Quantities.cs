using Unknown6656.Units.Electricity;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Movement;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Energy;

namespace Unknown6656.Units.Magnetism;



[MultiplicativeRelationship<Potential, Time, MagneticFlux, Volt, Second, Weber, Scalar>]
[MultiplicativeRelationship<MagneticFluxDensity, Area, MagneticFlux, Tesla, SquareMeter, Weber, Scalar>]
[MultiplicativeRelationship<Inductance, Current, MagneticFlux, Henry, Ampère, Weber, Scalar>]
[MultiplicativeRelationship<MagneticFlux, Current, Torque, Weber, Ampère, NewtonMeter, Scalar>]
//[MultiplicativeRelationship<MagneticFlux, Current, KineticEnergy, Weber, Ampère, Joule, Scalar>] // TODO : duplicate multiply operator
[MultiplicativeRelationship<Resistance, Charge, MagneticFlux, Ohm, Coulomb, Weber, Scalar>]
public partial record MagneticFlux(Weber value)
    : Quantity<MagneticFlux, Weber, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "Phi_B";
#else
    public static string QuantitySymbol { get; } = "Φʙ";
#endif
}

// magnetic induction
// T = N*s/C/m
// T = kg/A/s^2
// T = V*s/m^2
// T = Wb/m^2
// T = N/A/m
// T = J/A/m^2
public partial record MagneticFluxDensity(Tesla value)
    : Quantity<MagneticFluxDensity, Tesla, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "B";
}

[MultiplicativeRelationship<MagneticFieldStrength, Length, Current, AmpèrePerMeter, Meter, Ampère, Scalar>]
public partial record MagneticFieldStrength(AmpèrePerMeter value)
    : Quantity<MagneticFieldStrength, AmpèrePerMeter, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "H";
}



/*
TODO:
    - magnetic moment
    - magnetic field strength
    - magnetic dipole moment
    - vacuum permeability constant
    - lorentz force
// - magnetic dipole moment / magnetic dipole
//      - A·m^2
// - magnetic vector potential
//      - A
// - magnetic scalar potential
//      - V
// - magnetic pole strength / magnetic charge / magnetic circuit
//      - A·m
// - magnetic susceptibility
//      - dimensionless
// - magnetic permeability
//      - H/m
// - magnetic reluctance
//      - A/V

 */