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
    public static Element Darmstadtium { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Darmstadtium),
        AlternateNames = ["Policium", "Ununnilium"],
        Symbol = "Ds",
        CASNumber = "CAS54083-77-1",
        CIDNumber = null,
        DiscoveryYear = 1994,
        AtomicNumber = 110,
        Category = ElementCategory.TransitionMetal,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = null,
            BoilingPoint = null,
            StandardDensity = 26.5.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = null,
            HeatOfVaporization = null,
            ThermalCapacity = null,
            IonizationEnergies = [
                .96e6.JoulePerMol,
                1.89e6.JoulePerMol,
                3.03e6.JoulePerMol,
                4e6.JoulePerMol,
                5.1e6.JoulePerMol,
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
                new(6, ElectronOrbital.D, 8),
                new(7, ElectronOrbital.S, 2),
            ]),
            Valence = 10,
            OxidationStates = [2, 4, 6],
            CommonOxidationStates = [],
            PaulingElectronegativity = null,
            AllenElectronegativity = null,
            MeanAtomicRadius = 132e-12.Meter,
            CovalentRadius = 128e-12.Meter,
            VanDerWaalsRadius = 132e-12.Meter,
        },
        Electromagnetics = ElectromagneticalElementProperties.Unknown[ElectricalElementType.Conductor],
        Kinematics = KinematicElementProperties.Unknown,
        Optics = OpticalElementProperties.Unknown,
    }).AddIsotopes([
        new()
        {
            NeutronCount = 157,
            Spin = 1.5,
            Decays = [new(DecayMode.Alpha, 10e-6.Second)],
        },
        new()
        {
            NeutronCount = 159,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 230e-6.Second)],
        },
        new()
        {
            NeutronCount = 160,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 205e-6.Second)],
        },
        new()
        {
            NeutronCount = 161,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 144e-3.Second, .75),
                new(DecayMode.Alpha, 144e-3.Second, .25),
            ],
        },
        new()
        {
            NeutronCount = 162,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 200e-3.Second),
                new(DecayMode.Alpha, 200e-3.Second)
            ],
        },
        new()
        {
            NeutronCount = 163,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 240e-6.Second)],
        },
        new()
        {
            NeutronCount = 165,
            Spin = 1.5,
            Decays = [new(DecayMode.Alpha, 430e-6.Second)],
        },
        new()
        {
            NeutronCount = 166,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 150e-6.Second, .57),
                new(DecayMode.Alpha, 150e-6.Second, .43),
            ],
        },
        new()
        {
            NeutronCount = 167,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 4.0e-3.Second)],
        },
        new()
        {
            NeutronCount = 169,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 186e-3.Second, .87),
                new(DecayMode.Alpha, 186e-3.Second, .13),
            ],
        },
        new()
        {
            NeutronCount = 170,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 360e-6.Second)],
        },
        new()
        {
            NeutronCount = 171,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 14.Second, .9),
                new(DecayMode.Alpha, 14.Second, .1),
            ],
        },
        new()
        {
            NeutronCount = 172,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 4.2.Minute)],
        },
    ]);
}
