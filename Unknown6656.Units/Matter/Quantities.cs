using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Movement;

namespace Unknown6656.Units.Matter;

public partial record Amount(Mol value) : Quantity<Amount, Mol, Scalar>(value);

public partial record Mass(Kilogram value)
    : Quantity<Mass, Kilogram, Scalar>(value)
{
    public static ElectronVoltMassEquivalent MassOfElectronNeutrino { get; } = new(0.120);
    public static ElectronVoltMassEquivalent MassOfMuonNeutrino { get; } = new(0.170);
    public static ElectronVoltMassEquivalent MassOfTauNeutrino { get; } = new(15.5);
    public static ElectronVoltMassEquivalent MassOfElectron { get; } = new(511_000);
    public static ElectronVoltMassEquivalent MassOfMuon { get; } = new(105_700_000);
    public static ElectronVoltMassEquivalent MassOfTau { get; } = new(1_777_000_000);
    public static ElectronVoltMassEquivalent MassOfProton { get; } = new(938_000_000);
    public static ElectronVoltMassEquivalent MassOfNeutron { get; } = new(939_000_000);
    public static ElectronVoltMassEquivalent MassOfDeuteron { get; } = new(1_875_610_000);
    public static ElectronVoltMassEquivalent MassOfAlphaParticle { get; } = new(3_727_380_000);


    // TODO : atomic masses for entire perdiodic system
}


[MultiplicativeQuantityRelationship<MolarMass, Amount, Mass, GramPerMol, Mol, Kilogram, Scalar>((Scalar)1e-3)]
public partial record MolarMass(GramPerMol value) : Quantity<MolarMass, GramPerMol, Scalar>(value);

[MultiplicativeQuantityRelationship<VolumetricMassDensity, Volume, Mass, KilogramPerCubicMeter, CubicMeter, Kilogram, Scalar>]
public partial record VolumetricMassDensity(KilogramPerCubicMeter value) : Quantity<VolumetricMassDensity, KilogramPerCubicMeter, Scalar>(value);

[MultiplicativeQuantityRelationship<Force, Area, Pressure, Newton, SquareMeter, Pascal, Scalar>]
[MultiplicativeQuantityRelationship<Volume, Pressure, Torque, CubicMeter, Pascal, NewtonMeter, Scalar>]
public partial record Pressure(Pascal value) : Quantity<Pressure, Pascal, Scalar>(value);
