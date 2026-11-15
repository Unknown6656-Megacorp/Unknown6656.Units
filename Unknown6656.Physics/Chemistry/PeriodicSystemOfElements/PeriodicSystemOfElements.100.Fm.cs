using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;

namespace Unknown6656.Physics.Chemistry;


public partial class Element
{
    public static Element Fermium => field ??= PeriodicTableOfElements.RegisterElement(new()
    {
        Name = nameof(Fermium),
        AlternateNames = ["Centurium"],
        Symbol = "Md",
        CASNumber = "CAS7440-72-4",
        CIDNumber = null,
        DiscoveryYear = 1953,
        AtomicNumber = 100,
        Category = ElementCategory.Actinide,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = 1800.Kelvin,
            BoilingPoint = null,
            StandardDensity = 9.71.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = null,
            HeatOfVaporization = null,
            ThermalCapacity = null,
            IonizationEnergies = [
                .629e6.JoulePerMol,
                1.225e6.JoulePerMol,
                2.363e6.JoulePerMol,
                3.792e6.JoulePerMol,
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
                new(5, ElectronOrbital.F, 12),
                new(6, ElectronOrbital.S, 2),
                new(6, ElectronOrbital.P, 6),
                new(7, ElectronOrbital.S, 2),
            ]),
            Valence = 14,
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
            NeutronCount = 141,
            Spin = 2.5,
            Decays = [
                new(DecayMode.SpontaneousFission, 730e-6.Second, .74),
                new(DecayMode.Alpha, 730e-6.Second, .14),
                new(DecayMode.PositronEmission, 730e-6.Second, .12)
            ],
        },
        new ()
        {
            NeutronCount = 142,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 0.8e-3.Second)],
        },
        new ()
        {
            NeutronCount = 143,
            Spin = -3.5,
            Decays = [
                new(DecayMode.Alpha, 231e-3.Second, .91),
                new(DecayMode.SpontaneousFission, 231e-3.Second, .09)
            ],
        },
        new()
        {
            NeutronCount = 144,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 3.12e-3.Second, .97),
                new(DecayMode.PositronEmission, 3.12e-3.Second, .02),
                new(DecayMode.Alpha, 3.12e-3.Second, .01)
            ],
        },
        new()
        {
            NeutronCount = 145,
            Spin = 0.5,
            Decays = [
                new(DecayMode.Alpha, 4.2.Second, .885),
                new(DecayMode.PositronEmission, 4.2.Second, .115),
                new(DecayMode.SpontaneousFission, 4.2.Second, .003)
            ],
        },
        new()
        {
            NeutronCount = 146,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 1.54.Second, .932),
                new(DecayMode.SpontaneousFission, 1.54.Second, .068),
                new(DecayMode.ElectronCapture, 1.54.Second, .013)
            ],
        },
        new()
        {
            NeutronCount = 147,
            Spin = 3.5,
            Decays = [
                new(DecayMode.Alpha, 31.Second, .64),
                new(DecayMode.PositronEmission, 31.Second, .36)
            ],
        },
        new()
        {
            NeutronCount = 148,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 34.5.Second, .999),
                new(DecayMode.SpontaneousFission, 34.5.Second, .001)
            ],
        },
        new()
        {
            NeutronCount = 149,
            Spin = 3.5,
            Decays = [
                new(DecayMode.PositronEmission, 1.6.Minute, .67),
                new(DecayMode.Alpha, 1.6.Minute, .33)
            ],
        },
        new()
        {
            NeutronCount = 150,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 31.0.Minute, .9999),
                new(DecayMode.SpontaneousFission, 31.0.Minute, .000069)
            ],
        },
        new()
        {
            NeutronCount = 151,
            Spin = -4.5,
            Decays = [
                new(DecayMode.PositronEmission, 5.30.Hour, .982),
                new(DecayMode.Alpha, 5.30.Hour, .018)
            ],
        },
        new()
        {
            NeutronCount = 152,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 25.39.Hour, .9999),
                new(DecayMode.SpontaneousFission, 25.39.Hour, .000023),
            ],
        },
        new()
        {
            NeutronCount = 153,
            Spin = 0.5,
            Decays = [
                new(DecayMode.ElectronCapture, 3.00.StandardDay, .88),
                new(DecayMode.Alpha, 3.00.StandardDay, .12)
            ],
        },
        new()
        {
            NeutronCount = 154,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 3.240.Hour, .9994),
                new(DecayMode.SpontaneousFission, 3.240.Hour, .000592)
            ],
        },
        new()
        {
            NeutronCount = 155,
            Spin = 3.5,
            Decays = [
                new(DecayMode.Alpha, 20.07.Hour, .999976),
                new(DecayMode.SpontaneousFission, 20.07.Hour, .000024)
            ],
        },
        new()
        {
            NeutronCount = 156,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 157.1.Minute, .919),
                new(DecayMode.Alpha, 157.1.Minute, .081)
            ],
        },
        new()
        {
            NeutronCount = 157,
            Spin = 4.5,
            Decays = [
                new(DecayMode.Alpha, 100.5.StandardDay, .9979),
                new(DecayMode.SpontaneousFission, 100.5.StandardDay, .0021)
            ],
        },
        new()
        {
            NeutronCount = 158,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 370e-6.Second)],
        },
        new()
        {
            NeutronCount = 159,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 1.5.Second)],
        },
        new()
        {
            NeutronCount = 160,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 1.Minute)],
        },
    ]);
}
