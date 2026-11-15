using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;

namespace Unknown6656.Physics.Chemistry;


public partial class Element
{
    public static Element Lawrencium => field ??= PeriodicTableOfElements.RegisterElement(new()
    {
        Name = nameof(Lawrencium),
        AlternateNames = ["Unniltrium"],
        Symbol = "Lr",
        CASNumber = "CAS22537-19-5",
        CIDNumber = null,
        DiscoveryYear = 1961,
        AtomicNumber = 103,
        Category = ElementCategory.TransitionMetal,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = 1900.Kelvin,
            BoilingPoint = null,
            StandardDensity = 14.4.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = null,
            HeatOfVaporization = null,
            ThermalCapacity = null,
            IonizationEnergies = [
                .479e6.JoulePerMol,
                1.428e6.JoulePerMol,
                2.228e6.JoulePerMol,
                4.91e6.JoulePerMol,
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
                new(4, ElectronOrbital.F, 14),
                new(5, ElectronOrbital.S, 2),
                new(5, ElectronOrbital.P, 6),
                new(5, ElectronOrbital.D, 10),
                new(5, ElectronOrbital.F, 14),
                new(6, ElectronOrbital.S, 2),
                new(6, ElectronOrbital.P, 6),
                new(7, ElectronOrbital.S, 2),
                new(7, ElectronOrbital.P, 1),
            ]),
            Valence = 17,
            OxidationStates = [3],
            CommonOxidationStates = [3],
            PaulingElectronegativity = 1.3,
            AllenElectronegativity = null,
            MeanAtomicRadius = null,
            CovalentRadius = null,
            VanDerWaalsRadius = null,
        },
        Electromagnetics = ElectromagneticalElementProperties.Unknown[ElectricalElementType.Conductor],
        Kinematics = KinematicElementProperties.Unknown,
        Optics = OpticalElementProperties.Unknown,
    }).AddIsotopes([
        new()
        {
            NeutronCount = 148,
            Spin = -3.5,
            Decays = [
                new(DecayMode.Alpha, 24.4e-3.Second),
                new(DecayMode.SpontaneousFission, 24.4e-3.Second)
            ],
        },
        new()
        {
            NeutronCount = 149,
            Spin = -7,
            Decays = [
                new(DecayMode.Alpha, 369e-3.Second, .98),
                new(DecayMode.SpontaneousFission, 369e-3.Second, .02)
            ],
        },
        new()
        {
            NeutronCount = 150,
            Spin = -3.5,
            Decays = [
                new(DecayMode.Alpha, 632e-3.Second, .99),
                new(DecayMode.SpontaneousFission, 632e-3.Second, .01)
            ],
        },
        new()
        {
            NeutronCount = 151,
            Spin = 4,
            Decays = [
                new(DecayMode.Alpha, 12.0.Second, .717),
                new(DecayMode.PositronEmission, 12.0.Second, .283),
                new(DecayMode.SpontaneousFission, 12.0.Second, .001),
            ],
        },
        new ()
        {
            NeutronCount = 152,
            Spin = -.5,
            Decays = [
                new (DecayMode.Alpha, 31.1.Second, .85),
                new (DecayMode.PositronEmission, 31.1.Second, .15)
            ],
        },
        new()
        {
            NeutronCount = 153,
            Spin = -3,
            Decays = [
                new(DecayMode.Alpha, 27.9.Second, .85),
                new(DecayMode.PositronEmission, 27.9.Second, .15),
                new(DecayMode.SpontaneousFission, 27.9.Second, .0003),
            ],
        },
        new()
        {
            NeutronCount = 154,
            Spin = -3.5,
            Decays = [new(DecayMode.Alpha, 6.Second)],
        },
        new()
        {
            NeutronCount = 155,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 3.92.Second, .974),
                new(DecayMode.PositronEmission, 3.92.Second, .026)
            ],
        },
        new()
        {
            NeutronCount = 156,
            Spin = -0.5,
            Decays = [
                new(DecayMode.Alpha, 6.2.Second, .78),
                new(DecayMode.SpontaneousFission, 6.2.Second, .22)
            ],
        },
        new()
        {
            NeutronCount = 157,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 3.0.Minute, .8),
                new(DecayMode.PositronEmission, 3.0.Minute, .2)
            ],
        },
        new()
        {
            NeutronCount = 158,
            Spin = -.5,
            Decays = [new(DecayMode.SpontaneousFission, 39.Minute)],
        },
        new()
        {
            NeutronCount = 159,
            Spin = 0,
            Decays = [
                new(DecayMode.PositronEmission, 4.Hour),
                new(DecayMode.SpontaneousFission, 4.Hour)
            ],
        },
        new()
        {
            NeutronCount = 161,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 4.8.Hour)],
        },
        new()
        {
            NeutronCount = 163,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 22.Hour)],
        },
    ]);
}
