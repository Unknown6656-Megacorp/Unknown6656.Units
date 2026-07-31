using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Electricity;
using Unknown6656.Units.Kinematics;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Magnetism;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;
using Unknown6656.Units.Energy;

using Unknown6656.Physics.Optics;

namespace Unknown6656.Physics.Chemistry;


public sealed partial class PeriodicTableOfElements
{
    public static Element Copernicium { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Copernicium),
        AlternateNames = ["Ununbium"],
        Symbol = "Cn",
        CASNumber = "CAS54084-26-3",
        CIDNumber = null,
        DiscoveryYear = 1996,
        AtomicNumber = 112,
        Category = ElementCategory.PostTransitionMetal,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = 283d.Kelvin(),
            BoilingPoint = 340d.Kelvin(),
            StandardDensity = 14d.GramPerCubicCentimeter(),
            TriplePoint = (283d.Kelvin(), 25e3.Pascal()),
            CriticalPoint = null,
            HeatOfFusion = null,
            HeatOfVaporization = null,
            ThermalCapacity = null,
            IonizationEnergies = [
                1.155e6.JoulePerMol(),
                2.17e6.JoulePerMol(),
                3.16e6.JoulePerMol(),
                4.2e6.JoulePerMol(),
                5.5e6.JoulePerMol(),
            ],
            ThermalExpansion = null,
            ThermalConductivity = null,
        },
        ChemicalBonding = new()
        {
            ElectronConfiguration = new([
                new(1, ElectronOrbital.S, 2),
                new(2, ElectronOrbital.S, 2),
                new(2, ElectronOrbital.P, 6),
                new(3, ElectronOrbital.S, 2),
                new(3, ElectronOrbital.P, 6),
                new(3, ElectronOrbital.D, 10),
                new(4, ElectronOrbital.S, 2),
                new(4, ElectronOrbital.P, 6),
                new(4, ElectronOrbital.D, 10),
                new(5, ElectronOrbital.S, 2),
                new(5, ElectronOrbital.P, 6),
                new(4, ElectronOrbital.F, 14),
                new(5, ElectronOrbital.D, 10),
                new(6, ElectronOrbital.S, 2),
                new(6, ElectronOrbital.P, 6),
                new(5, ElectronOrbital.F, 14),
                new(6, ElectronOrbital.D, 10),
                new(7, ElectronOrbital.S, 2),
            ]),
            Valence = 2,
            OxidationStates = [2, 4],
            CommonOxidationStates = [],
            PaulingElectronegativity = null,
            AllenElectronegativity = null,
            MeanAtomicRadius = 147e-12.Meter(),
            CovalentRadius = 122e-12.Meter(),
            VanDerWaalsRadius = 147e-12.Meter(),
        },
        Electromagnetics = new()
        {
            CuriePoint = null,
            SuperconductingPoint = null,
            BandGap = 6.4.ElectronVolt(),
            ElectricalResistivity = null,
            ElectricalType = ElectricalElementType.Semiconductor,
            MagneticOrdering = MagneticOrdering.Paramagnetic,
            MagneticSusceptibility = null,
        },
        Kinematics = KinematicElementProperties.Unknown,
        Optics = OpticalElementProperties.Unknown,
    }).AddIsotopes([
        new()
        {
            NeutronCount = 165,
            Spin = 1.5,
            Decays = [new(DecayMode.Alpha, 790e-6.Second())],
        },
        new()
        {
            NeutronCount = 168,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 10e-6.Second())],
        },
        new()
        {
            NeutronCount = 169,
            Spin = 1.5,
            Decays = [new(DecayMode.Alpha, 160e-3.Second())],
        },
        new()
        {
            NeutronCount = 170,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 0.83e-3.Second())],
        },
        new()
        {
            NeutronCount = 171,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 3.81.Second(), 0.96),
                new(DecayMode.SpontaneousFission, 3.81.Second(), 0.04),
                new(DecayMode.ElectronCapture, 3.81.Second())
            ],
        },
        new()
        {
            NeutronCount = 172,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 121e-3.Second(), 0.98),
                new(DecayMode.Alpha, 121e-3.Second(), 0.02)
            ],
        },
        new()
        {
            NeutronCount = 173,
            Spin = 2.5,
            Decays = [new(DecayMode.Alpha, 28.Second())],
        },
        new()
        {
            NeutronCount = 174,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 30.2.Second()),
                new(DecayMode.Alpha, 30.2.Second())
            ],
        },
    ]);
}
