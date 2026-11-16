using Unknown6656.Physics.Chemistry;
using Unknown6656.Physics.Optics;
using Unknown6656.Units.Electricity;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Magnetism;
using Unknown6656.Units.Matter;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Thermodynamics;

namespace Unknown6656.Physics.Chemistry;


public partial class Element
{
    public static Element Americium => field ??= PeriodicTableOfElements.RegisterElement(new()
    {
        Name = nameof(Americium),
        AlternateNames = ["Columbium"],
        Symbol = "Am",
        CASNumber = "CAS7440-35-9",
        CIDNumber = null,
        DiscoveryYear = 1944,
        AtomicNumber = 95,
        Category = ElementCategory.Actinide,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = 1449.Kelvin,
            BoilingPoint = 2880.Kelvin,
            StandardDensity = 12.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = 14.39e3.JoulePerMol,
            HeatOfVaporization = null,
            ThermalCapacity = 28.JoulePerMolKelvin,
            IonizationEnergies = [
                .578e6.JoulePerMol,
                1.158e6.JoulePerMol,
                2.132e6.JoulePerMol,
                3.493e6.JoulePerMol,
            ],
            ThermalExpansion = null,
            ThermalConductivity = 10.WattPerMeterKelvin,
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
                new(5, ElectronOrbital.F, 7),
                new(6, ElectronOrbital.S, 2),
                new(6, ElectronOrbital.P, 6),
                new(7, ElectronOrbital.S, 2),
            ]),
            Valence = 8,
            OxidationStates = [2, 3, 4, 5, 6, 7],
            CommonOxidationStates = [3],
            PaulingElectronegativity = 1.3,
            AllenElectronegativity = null,
            MeanAtomicRadius = 173e-9.Meter,
            CovalentRadius = 180e-9.Meter,
            VanDerWaalsRadius = 173e-9.Meter,
        },
        Electromagnetics = new()
        {
            ElectricalType = ElectricalElementType.Conductor,
            BandGap = null,
            ElectricalResistivity = .69e-6.OhmMeter,
            MagneticOrdering = MagneticOrdering.Paramagnetic,
            CuriePoint = null,
            MagneticSusceptibility = 1e-9.CubicMeterPerMol,
            SuperconductingPoint = null,
        },
        Kinematics = KinematicElementProperties.Unknown,
        Optics = new()
        {
            RefractiveIndex = null,
            ExtinctionCoefficient = 1,
            EmissionSpectrum = new SparseSpectrum([
                (270.635.Nanometer, 0.01),
                (272.869.Nanometer, 0.01),
                (275.655.Nanometer, 0.02),
                (281.21.Nanometer, 0.01),
                (281.292.Nanometer, 0.02),
                (281.528.Nanometer, 0.1),
                (281.598.Nanometer, 0.01),
                (283.124.Nanometer, 0.01),
                (283.226.Nanometer, 0.5),
                (283.395.Nanometer, 0.01),
                (286.192.Nanometer, 0.01),
                (286.62.Nanometer, 0.01),
                (288.851.Nanometer, 0.1),
                (289.329.Nanometer, 0.01),
                (289.956.Nanometer, 0.02),
                (290.986.Nanometer, 0.01),
                (291.113.Nanometer, 0.02),
                (292.059.Nanometer, 0.1),
                (292.753.Nanometer, 0.02),
                (293.699.Nanometer, 0.02),
                (293.908.Nanometer, 0.01),
                (295.039.Nanometer, 0.05),
                (295.705.Nanometer, 0.01),
                (295.839.Nanometer, 0.01),
                (296.302.Nanometer, 0.01),
                (296.671.Nanometer, 0.1),
                (296.929.Nanometer, 0.1),
                (298.724.Nanometer, 0.1),
                (299.351.Nanometer, 0.05),
                (300.425.Nanometer, 0.1),
                (302.799.Nanometer, 0.05),
                (302.886.Nanometer, 0.01),
                (303.836.Nanometer, 0.05),
                (305.369.Nanometer, 0.02),
                (312.049.Nanometer, 0.2),
                (316.183.Nanometer, 0.02),
                (316.786.Nanometer, 0.01),
                (320.326.Nanometer, 0.01),
                (328.232.Nanometer, 0.05),
                (328.667.Nanometer, 0.02),
                (334.387.Nanometer, 0.01),
                (336.255.Nanometer, 0.05),
                (339.501.Nanometer, 0.02),
                (341.966.Nanometer, 0.02),
                (344.619.Nanometer, 0.02),
                (345.21.Nanometer, 0.1),
                (348.331.Nanometer, 0.5),
                (351.013.Nanometer, 0.5),
                (353.095.Nanometer, 0.1),
                (356.268.Nanometer, 0.02),
                (356.916.Nanometer, 0.5),
                (359.607.Nanometer, 0.01),
                (360.341.Nanometer, 0.05),
                (367.312.Nanometer, 0.5),
                (368.457.Nanometer, 0.01),
                (369.642.Nanometer, 0.1),
                (370.786.Nanometer, 0.01),
                (377.75.Nanometer, 0.5),
                (392.625.Nanometer, 0.5),
                (395.258.Nanometer, 0.1),
                (402.025.Nanometer, 0.01),
                (403.581.Nanometer, 0.01),
                (403.637.Nanometer, 0.05),
                (408.929.Nanometer, 0.5),
                (408.932.Nanometer, 0.01),
                (414.096.Nanometer, 0.01),
                (418.812.Nanometer, 0.1),
                (426.555.Nanometer, 0.1),
                (428.926.Nanometer, 0.5),
                (430.965.Nanometer, 0.02),
                (432.457.Nanometer, 0.2),
                (444.136.Nanometer, 0.2),
                (450.945.Nanometer, 0.5),
                (457.559.Nanometer, 0.5),
                (459.331.Nanometer, 0.1),
                (464.912.Nanometer, 0.01),
                (465.345.Nanometer, 0.01),
                (466.279.Nanometer, 0.5),
                (468.165.Nanometer, 0.2),
                (469.97.Nanometer, 0.2),
                (470.68.Nanometer, 0.1),
                (487.222.Nanometer, 0.2),
                (499.079.Nanometer, 0.02),
                (500.021.Nanometer, 0.01),
                (502.096.Nanometer, 0.1),
                (521.599.Nanometer, 0.02),
                (540.262.Nanometer, 0.1),
                (542.47.Nanometer, 0.1),
                (558.421.Nanometer, 0.1),
                (559.813.Nanometer, 0.1),
                (605.464.Nanometer, 1),
                (640.511.Nanometer, 0.1),
                (654.416.Nanometer, 0.05),
                (695.558.Nanometer, 0.05),
            ]),
        }
    }).AddIsotopes([
        new()
        {
            NeutronCount = 128,
            Spin = -9/2,
            Decays = [new(DecayMode.Alpha, 10e-3.Second)],
        },
        new()
        {
            NeutronCount = 134,
            Spin = -2.5,
            Decays = [new(DecayMode.Alpha, 1.8.Second)],
        },
        new()
        {
            NeutronCount = 135,
            Spin = -1,
            Decays = [
                new(DecayMode.PositronEmission, 40.Second, .7),
                new(DecayMode.SpontaneousFission, 40.Second, .3)
            ],
        },
        new ()
        {
            NeutronCount = 136,
            Spin = -2.5,
            Decays = [
                new(DecayMode.PositronEmission, 75+137-30.Second, .83),
                new(DecayMode.Alpha, 75+137-30.Second, .17)
            ],
        },
        new()
        {
            NeutronCount = 137,
            Spin = -1,
            Decays = [
                new(DecayMode.PositronEmission, 1.31.Minute, .97),
                new(DecayMode.Alpha, 1.31.Minute, .03),
                new(DecayMode.SpontaneousFission, 1.31.Minute, .00069)
            ],
        },
        new()
        {
            NeutronCount = 138,
            Spin = -2.5,
            Decays = [
                new(DecayMode.PositronEmission, 3.2.Minute, .955),
                new(DecayMode.Alpha, 3.2.Minute, .045)
            ],
        },
        new()
        {
            NeutronCount = 139,
            Spin = 0,
            Decays = [
                new(DecayMode.PositronEmission, 2.32.Minute, .9995),
                new(DecayMode.Alpha, 2.32.Minute, .00039),
                new(DecayMode.SpontaneousFission, 2.32.Minute, .000066)
            ],
        },
        new()
        {
            NeutronCount = 140,
            Spin = -2.5,
            Decays = [
                new(DecayMode.PositronEmission, 10.3.Minute, .996),
                new(DecayMode.Alpha, 10.3.Minute, .004)
            ],
        },
        new()
        {
            NeutronCount = 141,
            Spin = -5,
            Decays = [
                new(DecayMode.PositronEmission, 3.6.Minute),
                new(DecayMode.Alpha, 3.6.Minute)
            ],
        },
        new()
        {
            NeutronCount = 142,
            Spin = -2.5,
            Decays = [
                new(DecayMode.PositronEmission, 73.6.Minute, .99975),
                new(DecayMode.Alpha, 73.6.Minute, .00025)
            ],
        },
        new()
        {
            NeutronCount = 143,
            Spin = 1,
            Decays = [
                new(DecayMode.PositronEmission, 98.Minute),
                new(DecayMode.Alpha, 98.Minute)
            ],
        },
        new()
        {
            NeutronCount = 144,
            Spin = -2.5,
            Decays = [
                new(DecayMode.ElectronCapture, 11.9.Hour, .9999),
                new(DecayMode.Alpha, 11.9.Hour, .0001)
            ],
        },
        new()
        {
            NeutronCount = 145,
            Spin = -3,
            Decays = [
                new(DecayMode.PositronEmission, 50.8.Hour, 1),
                new(DecayMode.Alpha, 50.8.Hour, 1e-6)
            ],
        },
        new()
        {
            NeutronCount = 146,
            Spin = -2.5,
            Decays = [
                new(DecayMode.Alpha, 432.6.SolarYear, 1),
                new(DecayMode.SpontaneousFission, 432.6.SolarYear, 3.6e-6)
            ],
        },
        new()
        {
            NeutronCount = 147,
            Spin = -1,
            Decays = [
                new(DecayMode.Beta, 16.02.Hour, 0.827),
                new(DecayMode.ElectronCapture, 16.02.Hour, 0.173),
            ],
        },
        new()
        {
            NeutronCount = 148,
            Spin = -2.5,
            Decays = [
                new(DecayMode.Alpha, 7350.SolarYear, 1),
                new(DecayMode.SpontaneousFission, 7350.SolarYear, 3.7e-7)
            ],
        },
        new()
        {
            NeutronCount = 149,
            Spin = -6,
            Decays = [new(DecayMode.Beta, 10.01.Hour)],
        },
        new()
        {
            NeutronCount = 150,
            Spin = 2.5,
            Decays = [new(DecayMode.Beta, 2.05.Hour)],
        },
        new()
        {
            NeutronCount = 151,
            Spin = -7,
            Decays = [new(DecayMode.Beta, 39.Minute)],
        },
        new()
        {
            NeutronCount = 152,
            Spin = 2.5,
            Decays = [new(DecayMode.Beta, 23.0.Minute)],
        },
    ]);
}
