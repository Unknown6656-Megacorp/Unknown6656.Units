using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;

namespace Unknown6656.Physics.Chemistry;


public partial class Element
{
    public static Element Mendelevium => field ??= PeriodicTableOfElements.RegisterElement(new()
    {
        Name = nameof(Mendelevium),
        AlternateNames = ["Mv"],
        Symbol = "Md",
        CASNumber = "CAS7440-11-1",
        CIDNumber = null,
        DiscoveryYear = 1955,
        AtomicNumber = 101,
        Category = ElementCategory.Actinide,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = 1100.Kelvin,
            BoilingPoint = null,
            StandardDensity = 10.37.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = null,
            HeatOfVaporization = null,
            ThermalCapacity = null,
            IonizationEnergies = [
                .636e6.JoulePerMol,
                1.235e6.JoulePerMol,
                2.47e6.JoulePerMol,
                3.84e6.JoulePerMol,
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
                new(5, ElectronOrbital.F, 13),
                new(6, ElectronOrbital.S, 2),
                new(6, ElectronOrbital.P, 6),
                new(7, ElectronOrbital.S, 2),
            ]),
            Valence = 15,
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
            NeutronCount = 143,
            Spin = 3,
            Decays = [
                new(DecayMode.Alpha, .36.Second),
                new(DecayMode.PositronEmission, .36.Second, .7),
                new(DecayMode.SpontaneousFission, .36.Second, .14),
            ],
        },
        new ()
        {
            NeutronCount = 144,
            Spin = -3.5,
            Decays = [new(DecayMode.Alpha, 0.38.Second)],
        },
        new ()
        {
            NeutronCount = 145,
            Spin = -1,
            Decays = [new(DecayMode.Alpha, 0.92.Second)],
        },
        new ()
        {
            NeutronCount = 146,
            Spin = -3.5,
            Decays = [
                new(DecayMode.Alpha, 1.20.Second, 0.9914),
                new (DecayMode.SpontaneousFission, 1.20.Second, 0.0086),
            ],
        },
        new()
        {
            NeutronCount = 147,
            Spin = 0,
            Decays = [
                new(DecayMode.PositronEmission, 7.Second, 0.76),
                new(DecayMode.Alpha, 7.Second, 0.17),
                new(DecayMode.PositronEmission, 7.Second, .002),
                new(DecayMode.SpontaneousFission, 7.Second, .005)
            ],
        },
        new()
        {
            NeutronCount = 148,
            Spin = -3.5,
            Decays = [
                new(DecayMode.Alpha, 25.6.Second, .75),
                new(DecayMode.PositronEmission, 25.6.Second, .25)
            ],
        },
        new()
        {
            NeutronCount = 149,
            Spin = -2,
            Decays = [
                new(DecayMode.PositronEmission, 54.Second, .93),
                new(DecayMode.Alpha, 54.Second, .07),
                new(DecayMode.PositronEmission, 54.Second, .00026),
            ],
        },
        new()
        {
            NeutronCount = 150,
            Spin = -3.5,
            Decays = [
                new(DecayMode.PositronEmission, 4.21.Minute, .9),
                new(DecayMode.Alpha, 4.21.Minute, .1),
            ],
        },
        new()
        {
            NeutronCount = 151,
            Spin = 1,
            Decays = [new(DecayMode.PositronEmission, 2.3.Minute)],
        },
        new()
        {
            NeutronCount = 152,
            Spin = -3.5,
            Decays = [
                new(DecayMode.PositronEmission, 12.4.Minute, .993),
                new(DecayMode.Alpha, 12.4.Minute, .007)
            ],
        },
        new()
        {
            NeutronCount = 153,
            Spin = 0,
            Decays = [new(DecayMode.PositronEmission, 10.Minute)],
        },
        new()
        {
            NeutronCount = 154,
            Spin = -3.5,
            Decays = [
                new(DecayMode.PositronEmission, 27.Minute, .93),
                new(DecayMode.Alpha, 27.Minute, .07)
            ],
        },
        new()
        {
            NeutronCount = 155,
            Spin = -1,
            Decays = [
                new(DecayMode.PositronEmission, 77.7.Minute, .908),
                new(DecayMode.Alpha, 77.7.Minute, .092),
                new(DecayMode.SpontaneousFission, 77.7.Minute, .03)
            ],
        },
        new()
        {
            NeutronCount = 156,
            Spin = -3.5,
            Decays = [
                new(DecayMode.ElectronCapture, 5.52.Hour, .85),
                new(DecayMode.Alpha, 5.52.Hour, .15)
            ],
        },
        new()
        {
            NeutronCount = 157,
            Spin = -8,
            Decays = [
                new(DecayMode.Alpha, 51.59.StandardDay, .99997),
                new(DecayMode.Beta, 51.59.StandardDay, .000015),
                new(DecayMode.PositronEmission, 51.59.StandardDay, .000015)
            ],
        },
        new()
        {
            NeutronCount = 158,
            Spin = -3.5,
            Decays = [new(DecayMode.SpontaneousFission, 1.60.Hour)],
        },
        new()
        {
            NeutronCount = 159,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 27.8.StandardDay, .03),
                new(DecayMode.Alpha, 27.8.StandardDay, .05),
                new(DecayMode.ElectronCapture, 27.8.StandardDay, .05),
                new(DecayMode.Beta, 27.8.StandardDay, .035)
            ],
        },
    ]);
}
