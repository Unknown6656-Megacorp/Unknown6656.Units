using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;

using Unknown6656.Physics.Optics;

namespace Unknown6656.Physics.Chemistry;


public partial class Element
{
    public static Element Einsteinium => field ??= PeriodicTableOfElements.RegisterElement(new()
    {
        Name = nameof(Einsteinium),
        AlternateNames = ["Athenium"],
        Symbol = "Es",
        CASNumber = "CAS7429-92-7",
        CIDNumber = null,
        DiscoveryYear = 1952,
        AtomicNumber = 99,
        Category = ElementCategory.Actinide,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = 1133.Kelvin,
            BoilingPoint = 1269.Kelvin,
            StandardDensity = 8.84.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = null,
            HeatOfVaporization = null,
            ThermalCapacity = null,
            IonizationEnergies = [
                .619e6.JoulePerMol,
                1.216e6.JoulePerMol,
                2.334e6.JoulePerMol,
                3.734e6.JoulePerMol,
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
                new(5, ElectronOrbital.F, 11),
                new(6, ElectronOrbital.S, 2),
                new(6, ElectronOrbital.P, 6),
                new(7, ElectronOrbital.S, 2),
            ]),
            Valence = 13,
            OxidationStates = [2, 3, 4],
            CommonOxidationStates = [3],
            PaulingElectronegativity = 1.3,
            AllenElectronegativity = null,
            MeanAtomicRadius = 186e-9.Meter,
            CovalentRadius = 186e-9.Meter,
            VanDerWaalsRadius = 186e-9.Meter,
        },
        Electromagnetics = ElectromagneticalElementProperties.Unknown[ElectricalElementType.Conductor],
        Kinematics = KinematicElementProperties.Unknown,
        Optics = new()
        {
            RefractiveIndex = null,
            ExtinctionCoefficient = 1,
            EmissionSpectrum = new SparseSpectrum([
                (269.432.Nanometer, 0.03),
                (270.866.Nanometer, 1),
                (271.602.Nanometer, 0.01),
                (272.457.Nanometer, 0.1),
                (278.71.Nanometer, 0.3),
                (279.611.Nanometer, 0.1),
                (288.584.Nanometer, 0.01),
                (313.525.Nanometer, 0.3),
                (315.427.Nanometer, 0.1),
                (342.312.Nanometer, 0.03),
                (342.848.Nanometer, 1),
                (348.459.Nanometer, 0.3),
                (349.811.Nanometer, 1),
                (351.433.Nanometer, 1),
                (352.349.Nanometer, 1),
                (354.775.Nanometer, 1),
                (355.534.Nanometer, 1),
                (360.243.Nanometer, 1),
                (367.001.Nanometer, 1),
                (372.855.Nanometer, 1),
                (516.174.Nanometer, 1),
                (520.44.Nanometer, 1),
                (561.551.Nanometer, 0.3),
            ]),
        }
    }).AddIsotopes([
        new()
        {
            NeutronCount = 141,
            Spin = -4,
            Decays = [
                new(DecayMode.Alpha, 6.Second, .7),
                new(DecayMode.PositronEmission, 6.Second, .3),
                new(DecayMode.SpontaneousFission, 6.Second, .0016),
            ],
        },
        new()
        {
            NeutronCount = 142,
            Spin = -1.5,
            Decays = [new(DecayMode.Alpha, 4.3.Second)],
        },
        new()
        {
            NeutronCount = 143,
            Spin = 2,
            Decays = [
                new(DecayMode.PositronEmission, 16.9.Second, .575),
                new(DecayMode.Alpha, 16.9.Second, .41),
                new(DecayMode.SpontaneousFission, 16.9.Second, .015),
            ],
        },
        new()
        {
            NeutronCount = 144,
            Spin = 3.5,
            Decays = [
                new(DecayMode.Alpha, 22.1.Second, .61),
                new(DecayMode.PositronEmission, 22.1.Second, .39)
            ],
        },
        new()
        {
            NeutronCount = 145,
            Spin = 6,
            Decays = [
                new(DecayMode.PositronEmission, 37.Second, .95),
                new(DecayMode.Alpha, 37.Second, .05),
                new(DecayMode.SpontaneousFission, 37.Second, .00011),
            ],
        },
        new()
        {
            NeutronCount = 146,
            Spin = -1.5,
            Decays = [
                new(DecayMode.PositronEmission, 1.11.Minute, .51),
                new(DecayMode.Alpha, 1.11.Minute, .49)
            ],
        },
        new()
        {
            NeutronCount = 147,
            Spin = -4,
            Decays = [
                new(DecayMode.PositronEmission, 7.5.Minute, .901),
                new(DecayMode.Alpha, 7.5.Minute, .099),
                new(DecayMode.SpontaneousFission, 7.5.Minute, .00003)
            ],
        },
        new()
        {
            NeutronCount = 148,
            Spin = 3.5,
            Decays = [
                new(DecayMode.PositronEmission, 4.55.Minute, .93),
                new(DecayMode.Alpha, 4.55.Minute, .07)
            ],
        },
        new()
        {
            NeutronCount = 149,
            Spin = -2,
            Decays = [
                new(DecayMode.PositronEmission, 24.Minute, .9975),
                new(DecayMode.Alpha, 24.Minute, .0025),
                new(DecayMode.SpontaneousFission, 24.Minute, 3.5e-6),
            ],
        },
        new()
        {
            NeutronCount = 150,
            Spin = 3.5,
            Decays = [
                new(DecayMode.PositronEmission, 102.2.Minute, .9943),
                new(DecayMode.Alpha, 102.2.Minute, .0057),
            ],
        },
        new()
        {
            NeutronCount = 151,
            Spin = 6,
            Decays = [new(DecayMode.PositronEmission, 8.6.Hour)],
        },
        new()
        {
            NeutronCount = 152,
            Spin = -1.5,
            Decays = [
                new(DecayMode.ElectronCapture, 33.Hour, .995),
                new(DecayMode.Alpha, 33.Hour, .005)
            ],
        },
        new()
        {
            NeutronCount = 153,
            Spin = 4,
            Decays = [
                new(DecayMode.Alpha, 471.7.StandardDay, .78),
                new(DecayMode.ElectronCapture, 471.7.StandardDay, .22)
            ],
        },
        new()
        {
            NeutronCount = 154,
            Spin = 3.5,
            Decays = [
                new(DecayMode.Alpha, 20.47.StandardDay, .999913),
                new(DecayMode.SpontaneousFission, 20.47.StandardDay, 8.7e-8)
            ],
        },
        new()
        {
            NeutronCount = 155,
            Spin = 7,
            Decays = [
                new(DecayMode.Alpha, 275.7.StandardDay, .99999823),
                new(DecayMode.Beta, 275.7.StandardDay, 1.74e-6),
                new(DecayMode.SpontaneousFission, 275.7.StandardDay, 3e-8),
            ],
        },
        new ()
        {
    NeutronCount = 156,
            Spin = 3.5,
            Decays = [
                new(DecayMode.Beta, 39.8.StandardDay, .92),
                new (DecayMode.Alpha, 39.8.StandardDay, .08),
                new (DecayMode.SpontaneousFission, 39.8.StandardDay, 4.1e-5),
            ],
        },
        new()
        {
            NeutronCount = 157,
            Spin = 7,
            Decays = [
                new(DecayMode.Beta, 7.6 .Hour, .99998),
                new(DecayMode.SpontaneousFission, 7.6 .Hour, 2e-5),
            ],
        },
        new()
        {
            NeutronCount = 158,
            Spin = 3.5,
            Decays = [new(DecayMode.Beta, 7.7.StandardDay)],
        },
    ]);
}
