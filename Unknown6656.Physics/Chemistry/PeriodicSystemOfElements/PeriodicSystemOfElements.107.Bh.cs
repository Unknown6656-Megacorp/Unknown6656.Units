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
    public static Element Bohrium { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Bohrium),
        AlternateNames = ["Unnilseptium", "Nielsbohrium"],
        Symbol = "Bh",
        CASNumber = "CAS54037-14-8",
        CIDNumber = null,
        DiscoveryYear = 1981,
        AtomicNumber = 107,
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
                .74e6.JoulePerMol,
                1.69e6.JoulePerMol,
                2.57e6.JoulePerMol,
                3.6e6.JoulePerMol,
                4.73e6.JoulePerMol,
                5.99e6.JoulePerMol,
                7.23e6.JoulePerMol,
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
                new(6, ElectronOrbital.D, 5),
                new(7, ElectronOrbital.S, 2),
            ]),
            Valence = 7,
            OxidationStates = [3, 4, 5, 7],
            CommonOxidationStates = [],
            PaulingElectronegativity = null,
            AllenElectronegativity = null,
            MeanAtomicRadius = 128e-12.Meter,
            CovalentRadius = 141e-12.Meter,
            VanDerWaalsRadius = 128e-12.Meter,
        },
        Electromagnetics = ElectromagneticalElementProperties.Unknown[ElectricalElementType.Conductor],
        Kinematics = KinematicElementProperties.Unknown,
        Optics = OpticalElementProperties.Unknown,
    }).AddIsotopes([
        new()
        {
            NeutronCount = 153,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 41e-3.Second)],
        },
        new()
        {
            NeutronCount = 154,
            Spin = -2.5,
            Decays = [
                new(DecayMode.Alpha, 12.8e-3.Second, .99),
                new(DecayMode.SpontaneousFission, 12.8e-3.Second, .01),
            ],
        },
        new()
        {
            NeutronCount = 155,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 84e-3.Second, .8),
                new(DecayMode.SpontaneousFission, 84e-3.Second, .2),
            ],
        },
        new ()
        {
            NeutronCount = 157,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 1.07.Second, .86),
                new (DecayMode.SpontaneousFission, 1.07.Second, .14),
            ],
        },
        new()
        {
            NeutronCount = 158,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 1.19.Second)],
        },
        new()
        {
            NeutronCount = 159,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 10.Second),
                new(DecayMode.PositronEmission, 10.Second),
            ],
        },
        new()
        {
            NeutronCount = 160,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 22.Second)],
        },
        new()
        {
            NeutronCount = 163,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 2.4.Minute)],
        },
        new()
        {
            NeutronCount = 164,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 2.9.Second)],
        },
        new()
        {
            NeutronCount = 165,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 8.8.Second)],
        },
        new()
        {
            NeutronCount = 167,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 57.Second)],
        },
        new()
        {
            NeutronCount = 171,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 11.5.Minute)],
        },
    ]);
}
