using Unknown6656.Units.Temporal;
using Unknown6656.Units.Energy;

namespace Unknown6656.Units.Electricity;


public partial record Current(Ampère value)
    : Quantity<Current, Ampère, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "I";
}

[MultiplicativeRelationship<Current, Time, Charge, Ampère, Second, Coulomb, Scalar>]
public partial record Charge(Coulomb value)
    : Quantity<Charge, Coulomb, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "Q";
}

// V = kg * m^2 / s^3 / A
// V = kg * m/s * m/s^2 / A

// TODO : W = A^2 * Ω
[MultiplicativeRelationship<Potential, Current, Power, Volt, Ampère, Watt, Scalar>]
[MultiplicativeRelationship<Potential, Charge, KineticEnergy, Volt, Coulomb, Joule, Scalar>]
public partial record Potential(Volt value)
    : Quantity<Potential, Volt, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "U";
}

// Ω = kg * m^2 / s^3 / A^2
// J = Ω * A * C
// J = Ω * A^2 * s
// J * Hz = Ω * A^2
[MultiplicativeRelationship<Resistance, Current, Potential, Ohm, Ampère, Volt, Scalar>]
public partial record Resistance(Ohm value)
    : Quantity<Resistance, Ohm, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "R";
}

// F = s^4 * A^2 / kg / m^2
// F = s^2 * C^2 / kg / m^2
// F = A * s / V
// F = W * s / V^2
// F = J / V^2
// F = siemens / hertz
// F = s^2 / henry
[MultiplicativeRelationship<Capacitance, Resistance, Time, Farad, Ohm, Second, Scalar>]
[MultiplicativeRelationship<Capacitance, Potential, Charge, Farad, Volt, Coulomb, Scalar>]
public partial record Capacitance(Farad value)
    : Quantity<Capacitance, Farad, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "C";
}

[InverseRelationship<Capacitance, Elastance, Farad, InverseFarad, Scalar>]
[MultiplicativeRelationship<Elastance, Time, Resistance, InverseFarad, Second, Ohm, Scalar>]
[MultiplicativeRelationship<Elastance, Charge, Potential, InverseFarad, Coulomb, Volt, Scalar>]
[MultiplicativeRelationship<Resistance, Frequency, Elastance, Ohm, Hertz, InverseFarad, Scalar>]
public partial record Elastance(InverseFarad value)
    : Quantity<Elastance, InverseFarad, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "S";
}

// F^-1 * s * S = 1
[InverseRelationship<Resistance, Conductance, Ohm, Siemens, Scalar>]
[MultiplicativeRelationship<Potential, Conductance, Current, Volt, Siemens, Ampère, Scalar>]
[MultiplicativeRelationship<Time, Conductance, Capacitance, Second, Siemens, Farad, Scalar>]
[MultiplicativeRelationship<Elastance, Conductance, Frequency, InverseFarad, Siemens, Hertz, Scalar>]
public partial record Conductance(Siemens value)
    : Quantity<Conductance, Siemens, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "G";
}

// H = kg⋅m^2⋅s^−2⋅A^−2
// H = V⋅s/A
// H = J / A^2
// H = Nm / A^2
// H = Wb (magn.flux) / A
[MultiplicativeRelationship<Resistance, Time, Inductance, Ohm, Second, Henry, Scalar>]
public partial record Inductance(Henry value)
    : Quantity<Inductance, Henry, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "L";
}




// TODO:
// - resistivity
// - permittivity
// - electrostatic units
//      - esu
//      - statC
//      - statV
//      - statΩ
//      - statA
//      - statS
//      - statF
//      - statH