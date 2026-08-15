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
    public static Element Meitnerium { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Meitnerium),
        AlternateNames = ["Unnilennium"],
        Symbol = "Mt",
        CASNumber = "CAS54038-01-6",
        CIDNumber = null,
        DiscoveryYear = 1982,
        AtomicNumber = 109,
        Category = ElementCategory.TransitionMetal,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = null,
            BoilingPoint = null,
            StandardDensity = 27.5.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = null,
            HeatOfVaporization = null,
            ThermalCapacity = null,
            IonizationEnergies = [
                .8e6.JoulePerMol,
                1.82e6.JoulePerMol,
                2.9e6.JoulePerMol,
                3.9e6.JoulePerMol,
                4.9e6.JoulePerMol,
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
                new(6, ElectronOrbital.D, 7),
                new(7, ElectronOrbital.S, 2),
            ]),
            Valence = 9,
            OxidationStates = [1, 3, 6],
            CommonOxidationStates = [],
            PaulingElectronegativity = null,
            AllenElectronegativity = null,
            MeanAtomicRadius = 128e-12.Meter,
            CovalentRadius = 129e-12.Meter,
            VanDerWaalsRadius = 128e-12.Meter,
        },
        Electromagnetics = ElectromagneticalElementProperties.Unknown[ElectricalElementType.Conductor],
        Kinematics = KinematicElementProperties.Unknown,
        Optics = OpticalElementProperties.Unknown,
    }).AddIsotopes([
        new()
        {
            NeutronCount = 157,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 2.0e-3.Second)],
        },
        new()
        {
            NeutronCount = 159,
            Spin = 5,
            Decays = [new(DecayMode.Alpha, 23e-3.Second)],
        },
        new()
        {
            NeutronCount = 161,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 0.8.Second)],
        },
        new()
        {
            NeutronCount = 165,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 640e-3.Second)],
        },
        new()
        {
            NeutronCount = 166,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 20e-3.Second)],
        },
        new()
        {
            NeutronCount = 167,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 620e-3.Second)],
        },
        new()
        {
            NeutronCount = 168,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 5e-3.Second)],
        },
        new()
        {
            NeutronCount = 169,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 6.Second)],
        },
        new()
        {
            NeutronCount = 173,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 67.Second)],
        },
    ]);
}
