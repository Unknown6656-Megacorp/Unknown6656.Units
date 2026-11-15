using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;

namespace Unknown6656.Physics.Chemistry;


public partial class Element
{
    public static Element Dubnium => field ??= PeriodicTableOfElements.RegisterElement(new()
    {
        Name = nameof(Dubnium),
        AlternateNames = ["Unnilpentium"],
        Symbol = "Db",
        CASNumber = "CAS53850-35-4",
        CIDNumber = null,
        DiscoveryYear = 1970,
        AtomicNumber = 105,
        Category = ElementCategory.TransitionMetal,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = null,
            BoilingPoint = null,
            StandardDensity = 21.6.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = null,
            HeatOfVaporization = null,
            ThermalCapacity = null,
            IonizationEnergies = [
                .665e6.JoulePerMol,
                1.547e6.JoulePerMol,
                2.378e6.JoulePerMol,
                3.299e6.JoulePerMol,
                4.305e6.JoulePerMol,
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
                new(6, ElectronOrbital.D, 3),
                new(7, ElectronOrbital.S, 2),
            ]),
            Valence = 5,
            OxidationStates = [3, 4, 5],
            CommonOxidationStates = [],
            PaulingElectronegativity = null,
            AllenElectronegativity = null,
            MeanAtomicRadius = 139e-12.Meter,
            CovalentRadius = 149e-12.Meter,
            VanDerWaalsRadius = 139e-12.Meter,
        },
        Electromagnetics = ElectromagneticalElementProperties.Unknown[ElectricalElementType.Conductor],
        Kinematics = KinematicElementProperties.Unknown,
        Optics = OpticalElementProperties.Unknown,
    }).AddIsotopes([
        new()
        {
            NeutronCount = 150,
            Spin = 4.5,
            Decays = [
                new(DecayMode.SpontaneousFission, 54e-3.Second, .67),
                new(DecayMode.Alpha, 54e-3.Second, .33)
            ],
        },
        new()
        {
            NeutronCount = 151,
            Spin = -9,
            Decays = [
                new(DecayMode.Alpha, 1.7.Second, .7),
                new(DecayMode.PositronEmission, 1.7.Second, .3),
            ],
        },
        new()
        {
            NeutronCount = 152,
            Spin = 4.5,
            Decays = [
                new(DecayMode.Alpha, 2.3.Second, .94),
                new(DecayMode.SpontaneousFission, 2.3.Second, .06)
            ],
        },
        new ()
        {
    NeutronCount = 153,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 2.17.Second, .64),
                new (DecayMode.PositronEmission, 2.17.Second, .36),
            ],
        },
        new()
        {
            NeutronCount = 154,
            Spin = 4.5,
            Decays = [new(DecayMode.Alpha, 0.51.Second)],
        },
        new()
        {
            NeutronCount = 155,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 1.52.Second, .904),
                new(DecayMode.SpontaneousFission, 1.52.Second, .096),
                new(DecayMode.PositronEmission, 1.52.Second, 1e-6)
            ],
        },
        new()
        {
            NeutronCount = 156,
            Spin = 4.5,
            Decays = [
                new(DecayMode.SpontaneousFission, 4.7.Second, .73),
                new(DecayMode.Alpha, 4.7.Second, .27)
            ],
        },
        new()
        {
            NeutronCount = 157,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 33.8.Second, .52),
                new(DecayMode.Alpha, 33.8.Second, .48)
            ],
        },
        new()
        {
            NeutronCount = 158,
            Spin = 4.5,
            Decays = [
                new(DecayMode.SpontaneousFission, 29.Second, .56),
                new(DecayMode.Alpha, 29.Second, .37),
                new(DecayMode.PositronEmission, 29.Second, .069)
            ],
        },
        new()
        {
            NeutronCount = 161,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 11.Minute),
                new(DecayMode.ElectronCapture, 11.Minute)
            ],
        },
        new()
        {
            NeutronCount = 162,
            Spin = 4.5,
            Decays = [
                new(DecayMode.SpontaneousFission, 1.4.Hour),
                new(DecayMode.ElectronCapture, 1.4.Hour)
            ],
        },
        new()
        {
            NeutronCount = 163,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 16.Hour, .51),
                new(DecayMode.SpontaneousFission, 16.Hour, .49),
                new(DecayMode.ElectronCapture, 16.Hour)
            ],
        },
        new()
        {
            NeutronCount = 165,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 1.7.Hour, .87),
                new(DecayMode.Alpha, 1.7.Hour, .13),
                new(DecayMode.ElectronCapture, 1.7.Hour, 1e-6)
            ],
        },
    ]);
}
