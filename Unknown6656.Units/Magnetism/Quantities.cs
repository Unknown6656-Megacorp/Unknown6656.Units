using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Unknown6656.Units.Electricity;
using Unknown6656.Units.Energy;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Movement;
using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Magnetism;



[MultiplicativeRelationship<Potential, Time, MagneticFlux, Volt, Second, Weber, Scalar>]
[MultiplicativeRelationship<MagneticFluxDensity, Area, MagneticFlux, Tesla, SquareMeter, Weber, Scalar>]
[MultiplicativeRelationship<Inductance, Current, MagneticFlux, Henry, Ampère, Weber, Scalar>]
[MultiplicativeRelationship<MagneticFlux, Current, Torque, Weber, Ampère, NewtonMeter, Scalar>]
[MultiplicativeRelationship<MagneticFlux, Current, KineticEnergy, Weber, Ampère, Joule, Scalar>]
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

public partial record MagneticFluxDensity(Tesla value)
    : Quantity<MagneticFluxDensity, Tesla, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "B";
}

/*
TODO:
    - magnetic moment
    - magnetic flux density
    - magnetic field strength
    - magnetic dipole moment
    - vacuum permeability constant
    - lorentz force
// - magnetic flux density
//      - T
// - magnetic field strength
//      - A/m
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