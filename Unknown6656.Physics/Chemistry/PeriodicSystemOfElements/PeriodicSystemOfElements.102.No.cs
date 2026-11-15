using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;

namespace Unknown6656.Physics.Chemistry;


public partial class Element
{
    public static Element Nobelium => field ??= PeriodicTableOfElements.RegisterElement(new()
    {
        Name = nameof(Nobelium),
        AlternateNames = ["Unnilbium"],
        Symbol = "No",
        CASNumber = "CAS10028-14-5",
        CIDNumber = null,
        DiscoveryYear = 1965,
        AtomicNumber = 102,
        Category = ElementCategory.Actinide,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = 1100.Kelvin,
            BoilingPoint = null,
            StandardDensity = 9.94.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = null,
            HeatOfVaporization = null,
            ThermalCapacity = null,
            IonizationEnergies = [
                .639e6.JoulePerMol,
                1.254e6.JoulePerMol,
                2.643e6.JoulePerMol,
                3.956e6.JoulePerMol,
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
            ]),
            Valence = 16,
            OxidationStates = [2, 3],
            CommonOxidationStates = [2, 3],
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
            NeutronCount = 146,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission , 2e-6.Second)],
        },
        new()
        {
            NeutronCount = 147,
            Spin = 2.5,
            Decays = [new(DecayMode.Alpha, 38.3e-3.Second)],
        },
        new()
        {
            NeutronCount = 148,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 4.0e-6.Second)],
        },
        new()
        {
            NeutronCount = 149,
            Spin = 3.5,
            Decays = [
                new(DecayMode.Alpha, .8.Second, 0.91),
                new(DecayMode.PositronEmission, .8.Second, 0.09),
                new(DecayMode.SpontaneousFission, .8.Second, 0.0014)
            ],
        },
        new()
        {
            NeutronCount = 150,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 2.467.Second, 0.7),
                new(DecayMode.SpontaneousFission, 2.467.Second, 0.29),
                new(DecayMode.PositronEmission, 2.467.Second, 0.008)
            ],
        },
        new()
        {
            NeutronCount = 151,
            Spin = -4.5,
            Decays = [
                new(DecayMode.Alpha, 1.57.Minute, 0.55),
                new(DecayMode.PositronEmission, 1.57.Minute, 0.45)
            ],
        },
        new()
        {
            NeutronCount = 152,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 51.2.Second, 0.9),
                new(DecayMode.PositronEmission, 51.2.Second, 0.1),
                new(DecayMode.SpontaneousFission, 51.2.Second, 0.0017)
            ],
        },
        new()
        {
            NeutronCount = 153,
            Spin = 0.5,
            Decays = [
                new(DecayMode.PositronEmission, 3.52.Minute, 0.7),
                new(DecayMode.Alpha, 3.52.Minute, 0.3)
            ],
        },
        new()
        {
            NeutronCount = 154,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 2.91.Second, 0.9945),
                new(DecayMode.SpontaneousFission, 2.91.Second, 0.0055)
            ],
        },
        new()
        {
            NeutronCount = 155,
            Spin = 1.5,
            Decays = [
                new(DecayMode.Alpha, 24.5.Second, 0.85),
                new(DecayMode.PositronEmission, 24.5.Second, 0.15)
            ],
        },
        new()
        {
            NeutronCount = 156,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 1.23e-3.Second)],
        },
        new()
        {
            NeutronCount = 157,
            Spin = 4.5,
            Decays = [
                new(DecayMode.Alpha, 58.Minute, 0.75),
                new(DecayMode.ElectronCapture, 58.Minute, 0.25),
                new(DecayMode.SpontaneousFission, 58.Minute, .1)
            ],
        },
        new ()
        {
            NeutronCount = 158,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 106e-3.Second)],
        },
        new ()
        {
            NeutronCount = 160,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 5e-3.Second)],
        },
    ]);
}
