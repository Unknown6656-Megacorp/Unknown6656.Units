using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Kinematics;

namespace Unknown6656.Units.Matter;


public partial record Amount(Mol value)
    : Quantity<Amount, Mol, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "n";
}

public partial record Mass(Kilogram value)
    : Quantity<Mass, Kilogram, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "m";
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

[MultiplicativeRelationship<MolarMass, Amount, Mass, GramPerMol, Mol, Kilogram, Scalar>((Scalar)1e-3)]
public partial record MolarMass(GramPerMol value)
    : Quantity<MolarMass, GramPerMol, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "M";
}

// TODO : conversion to force

[MultiplicativeRelationship<AreaMassDensity, Area, Mass, KilogramPerSquareMeter, SquareMeter, Kilogram, Scalar>]
[MultiplicativeRelationship<AreaMassDensity, Length, VolumetricMassDensity, KilogramPerSquareMeter, Meter, KilogramPerCubicMeter, Scalar>]
[MultiplicativeRelationship<AreaMassDensity, KinematicViscosity, MassFlowRate, KilogramPerSquareMeter, SquareMeterPerSecond, KilogramPerSecond, Scalar>]
public partial record AreaMassDensity(KilogramPerSquareMeter value)
    : Quantity<AreaMassDensity, KilogramPerSquareMeter, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "DA";
#else
    public static string QuantitySymbol { get; } = "ρᴀ";
#endif

    public static Grammage OfficePaperDensity { get; } = new(80);
}

// TODO : conversion to force
[MultiplicativeRelationship<VolumetricMassDensity, Volume, Mass, KilogramPerCubicMeter, CubicMeter, Kilogram, Scalar>]
public partial record VolumetricMassDensity(KilogramPerCubicMeter value)
    : Quantity<VolumetricMassDensity, KilogramPerCubicMeter, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "D";
#else
    public static string QuantitySymbol { get; } = "ρ";
#endif
}

[MultiplicativeRelationship<Force, Area, Pressure, Newton, SquareMeter, Pascal, Scalar>]
public partial record Pressure(Pascal value)
    : Quantity<Pressure, Pascal, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "p";
}

[InverseRelationship<Compressibility, Pressure, SquareMeterPerNewton, Pascal, Scalar>]
[MultiplicativeRelationship<Compressibility, Force, Area, SquareMeterPerNewton, Newton, SquareMeter, Scalar>]
[MultiplicativeRelationship<Compressibility, Torque, Volume, SquareMeterPerNewton, NewtonMeter, CubicMeter, Scalar>]
public partial record Compressibility(SquareMeterPerNewton value)
    : Quantity<Compressibility, SquareMeterPerNewton, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "k";
#else
    public static string QuantitySymbol { get; } = "κ";
#endif
}
