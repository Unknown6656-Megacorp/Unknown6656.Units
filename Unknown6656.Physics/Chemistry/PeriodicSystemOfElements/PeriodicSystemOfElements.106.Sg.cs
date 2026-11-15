using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;

namespace Unknown6656.Physics.Chemistry;


public partial class Element
{
    public static Element Seaborgium => field ??= PeriodicTableOfElements.RegisterElement(new()
    {
        Name = nameof(Seaborgium),
        AlternateNames = ["Unnilhexium"],
        Symbol = "Sg",
        CASNumber = "CAS54038-81-2",
        CIDNumber = null,
        DiscoveryYear = 1974,
        AtomicNumber = 106,
        Category = ElementCategory.TransitionMetal,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = null,
            BoilingPoint = null,
            StandardDensity = 23.5.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = null,
            HeatOfVaporization = null,
            ThermalCapacity = null,
            IonizationEnergies = [
                .757e6.JoulePerMol,
                1.733e6.JoulePerMol,
                2.484e6.JoulePerMol,
                3.416e6.JoulePerMol,
                4.562e6.JoulePerMol,
                5.716e6.JoulePerMol,
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
                new(6, ElectronOrbital.D, 4),
                new(7, ElectronOrbital.S, 2),
            ]),
            Valence = 6,
            OxidationStates = [0, 3, 4, 5, 6],
            CommonOxidationStates = [],
            PaulingElectronegativity = null,
            AllenElectronegativity = null,
            MeanAtomicRadius = 132e-12.Meter,
            CovalentRadius = 143e-12.Meter,
            VanDerWaalsRadius = 132e-12.Meter,
        },
        Electromagnetics = ElectromagneticalElementProperties.Unknown[ElectricalElementType.Conductor],
        Kinematics = KinematicElementProperties.Unknown,
        Optics = OpticalElementProperties.Unknown,
    }).AddIsotopes([
        new()
        {
            NeutronCount = 151,
            Spin = -4.5,
            Decays = [
                new(DecayMode.SpontaneousFission, 12.6e-3.Second, .9),
                new(DecayMode.Alpha, 12.6e-3.Second, .1)
            ],
        },
        new()
        {
            NeutronCount = 152,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 2.7e-3.Second)],
        },
        new()
        {
            NeutronCount = 153,
            Spin = -10.5,
            Decays = [
                new(DecayMode.Alpha, 402e-3.Second),
                new(DecayMode.PositronEmission, 402e-3.Second),
                new(DecayMode.SpontaneousFission, 402e-3.Second)
            ],
        },
        new()
        {
            NeutronCount = 154,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 4.95e-3.Second, .71),
                new(DecayMode.Alpha, 4.95e-3.Second, .29)
            ],
        },
        new()
        {
            NeutronCount = 155,
            Spin = 1.5,
            Decays = [
                new(DecayMode.Alpha, 183e-3.Second, .981),
                new(DecayMode.PositronEmission, 183e-3.Second, .013),
                new(DecayMode.SpontaneousFission, 183e-3.Second, .006),
            ],
        },
        new()
        {
            NeutronCount = 156,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 10.3e-3.Second, .94),
                new(DecayMode.Alpha, 10.3e-3.Second, .06)
            ],
        },
        new()
        {
            NeutronCount = 157,
            Spin = 1.5,
            Decays = [
                new(DecayMode.Alpha, .94.Second, .87),
                new(DecayMode.SpontaneousFission, .94.Second, .13),
            ],
        },
        new()
        {
            NeutronCount = 158,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 78e-3.Second)],
        },
        new()
        {
            NeutronCount = 159,
            Spin = -10.5,
            Decays = [new(DecayMode.Alpha, 9.2.Second)],
        },
        new()
        {
            NeutronCount = 160,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 390e-3.Second)],
        },
        new()
        {
            NeutronCount = 161,
            Spin = 4.5,
            Decays = [new(DecayMode.Alpha, 9.8.Minute)],
        },
        new()
        {
            NeutronCount = 162,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 13.Second)],
        },
        new()
        {
            NeutronCount = 163,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 13.Minute, .87),
                new(DecayMode.SpontaneousFission, 13.Minute, .13),
            ],
        },
        new()
        {
            NeutronCount = 165,
            Spin = 1.5,
            Decays = [
                new(DecayMode.Alpha, 31.Second, .73),
                new(DecayMode.SpontaneousFission, 31.Second, .27),
            ],
        },
    ]);
}
