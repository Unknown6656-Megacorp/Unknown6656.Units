using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Energy;
using Unknown6656.Units.Matter;
using Unknown6656.Units.Kinematics;

namespace Unknown6656.Units.Thermodynamics;


public partial record Temperature(Kelvin value)
    : Quantity<Temperature, Kelvin, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "T";
    public static Kelvin AbsoluteZero { get; } = new((Scalar)0);
    public static Kelvin AbsoluteHot { get; } = new((Scalar)1.416808338416e32);
}

// HeatFlux = kg * s^-3
// HeatFlux = MassFlow * s^-2
// HeatFlux = MassFlow * Hz^2

// TODO : this thing is usually a multi-dimensional vector
[MultiplicativeRelationship<HeatFlux, Area, Power, WattPerSquareMeter, SquareMeter, Watt, Scalar>]
public partial record HeatFlux(WattPerSquareMeter value)
    : Quantity<HeatFlux, WattPerSquareMeter, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "phi_q";
#else
    public static string QuantitySymbol { get; } = "φq";
#endif
}

[MultiplicativeRelationship<ChemicalPotential, Amount, KineticEnergy, JoulePerMol, Mol, Joule, Scalar>]
public partial record ChemicalPotential(JoulePerMol value)
    : Quantity<ChemicalPotential, JoulePerMol, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "my_i";
#else
    public static string QuantitySymbol { get; } = "μᵢ";
#endif
}

[MultiplicativeRelationship<Temperature, MolarMass, CryoscopicConstant, Kelvin, KilogramPerMol, KilogramKelvinPerMol, Scalar>]
[MultiplicativeRelationship<CryoscopicConstant, SpecificEntropy, ChemicalPotential, KilogramKelvinPerMol, JoulePerKilogramKelvin, JoulePerMol, Scalar>]
public partial record CryoscopicConstant(KilogramKelvinPerMol value)
    : Quantity<CryoscopicConstant, KilogramKelvinPerMol, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "Kf";
#else
    public static string QuantitySymbol { get; } = "K𝘧";
#endif
}

[MultiplicativeRelationship<ThermalEntropy, Temperature, KineticEnergy, JoulePerKelvin, Kelvin, Joule, Scalar>]
[MultiplicativeRelationship<ThermodynamicEntropy, Amount, ThermalEntropy, JoulePerMolKelvin, Mol, JoulePerKelvin, Scalar>]
[MultiplicativeRelationship<SpecificEntropy, Mass, ThermalEntropy, JoulePerKilogramKelvin, Kilogram, JoulePerKelvin, Scalar>]
public partial record ThermalEntropy(JoulePerKelvin value)
    : Quantity<ThermalEntropy, JoulePerKelvin, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "S";
}

[MultiplicativeRelationship<ThermodynamicEntropy, Temperature, ChemicalPotential, JoulePerMolKelvin, Kelvin, JoulePerMol, Scalar>]
public partial record ThermodynamicEntropy(JoulePerMolKelvin value)
    : Quantity<ThermodynamicEntropy, JoulePerMolKelvin, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "S";
}

[MultiplicativeRelationship<SpecificEntropy, Temperature, SpecificEnergy, JoulePerKilogramKelvin, Kelvin, JoulePerKilogram, Scalar>]
public partial record SpecificEntropy(JoulePerKilogramKelvin value)
    : Quantity<SpecificEntropy, JoulePerKilogramKelvin, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "S";
#else
    public static string QuantitySymbol { get; } = "Sₛₚ";
#endif
}

// TODO : Negentropy
// TODO : free entropy https://en.wikipedia.org/wiki/Free_entropy
// TODO : https://en.wikipedia.org/wiki/Entropy_(statistical_thermodynamics)
// TODO : heat capacity == entropy ?
// TODO : specific enthalpy == j/kg

public partial record HeatTransferCoefficient
{
    // TODO
}

// W/m/K * m/s = W/K/s = J/K/s^2
[MultiplicativeRelationship<ThermalConductivity, Absement, ThermalEntropy, WattPerMeterKelvin, MeterSecond, JoulePerKelvin, Scalar>]
public partial record ThermalConductivity(WattPerMeterKelvin value)
    : Quantity<ThermalConductivity, WattPerMeterKelvin, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "k";
#else
    public static string QuantitySymbol { get; } = "κ";
#endif
}

[InverseRelationship<ThermalConductivity, ThermalResistivity, WattPerMeterKelvin, KelvinMeterPerWatt, Scalar>]
[MultiplicativeRelationship<ThermalResistivity, ThermalEntropy, Absement, KelvinMeterPerWatt, JoulePerKelvin, MeterSecond, Scalar>]
public partial record ThermalResistivity(KelvinMeterPerWatt value)
    : Quantity<ThermalResistivity, KelvinMeterPerWatt, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "p";
#else
    public static string QuantitySymbol { get; } = "ρ";
#endif
}
{
    // TODO
}

// TODO : specific heat capacity https://en.wikipedia.org/wiki/Specific_heat_capacity