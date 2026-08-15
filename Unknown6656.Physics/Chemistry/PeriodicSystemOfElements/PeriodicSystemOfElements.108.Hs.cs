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
    public static Element Hassium { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Hassium),
        AlternateNames = ["Unniloctium"],
        Symbol = "Hs",
        CASNumber = "CAS54037-57-9",
        CIDNumber = null,
        DiscoveryYear = 1984,
        AtomicNumber = 108,
        Category = ElementCategory.TransitionMetal,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = null,
            BoilingPoint = null,
            StandardDensity = 28.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = null,
            HeatOfVaporization = null,
            ThermalCapacity = null,
            IonizationEnergies = [
                .73e6.JoulePerMol,
                1.76e6.JoulePerMol,
                2.83e6.JoulePerMol,
                3.64e6.JoulePerMol,
                4.94e6.JoulePerMol,
                6.18e6.JoulePerMol,
                7.54e6.JoulePerMol,
                8.86e6.JoulePerMol,
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
                new(6, ElectronOrbital.D, 6),
                new(7, ElectronOrbital.S, 2),
            ]),
            Valence = 8,
            OxidationStates = [3, 4, 6, 8],
            CommonOxidationStates = [],
            PaulingElectronegativity = null,
            AllenElectronegativity = null,
            MeanAtomicRadius = 126e-12.Meter,
            CovalentRadius = 134e-12.Meter,
            VanDerWaalsRadius = 126e-12.Meter,
        },
        Electromagnetics = ElectromagneticalElementProperties.Unknown[ElectricalElementType.Conductor],
        Kinematics = KinematicElementProperties.Unknown,
        Optics = OpticalElementProperties.Unknown,
    }).AddIsotopes([
        new()
        {
            NeutronCount = 155,
            Spin = 1.5,
            Decays = [new(DecayMode.Alpha, .74e-3.Second)],
        },
        new()
        {
            NeutronCount = 156,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 0.63.Second, .7),
                new(DecayMode.SpontaneousFission, 0.63.Second, .3),
            ],
        },
        new()
        {
            NeutronCount = 157,
            Spin = 9/2,
            Decays = [new(DecayMode.Alpha, 1.96e-3.Second)],
        },
        new()
        {
            NeutronCount = 158,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 3.0e-3.Second, .76),
                new(DecayMode.SpontaneousFission, 3.0e-3.Second, .24)
            ],
        },
        new()
        {
            NeutronCount = 159,
            Spin = 2.5,
            Decays = [new(DecayMode.Alpha, 55e-3.Second)],
        },
        new()
        {
            NeutronCount = 160,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 1.4.Second)],
        },
        new()
        {
            NeutronCount = 161,
            Spin = 9/2,
            Decays = [new(DecayMode.Alpha, 13.Second)],
        },
        new()
        {
            NeutronCount = 162,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 7.6e-3.Second)],
        },
        new()
        {
            NeutronCount = 163,
            Spin = 10.5,
            Decays = [new(DecayMode.Alpha, 46.Second)],
        },
        new()
        {
            NeutronCount = 164,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 160e-3.Second)],
        },
        new()
        {
            NeutronCount = 165,
            Spin = 1.5,
            Decays = [new(DecayMode.Alpha, .68.Second)],
        },
        new()
        {
            NeutronCount = 167,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 600e-3.Second, .89),
                new(DecayMode.SpontaneousFission, 600e-3.Second, .11),
            ],
        },
        new ()
        {
            NeutronCount = 169,
            Spin = 1.5,
            Decays = [new(DecayMode.SpontaneousFission, 18e-3.Second)],
        },
        new ()
        {
            NeutronCount = 170,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 1e-6.Second)],
        },
    ]);
}
