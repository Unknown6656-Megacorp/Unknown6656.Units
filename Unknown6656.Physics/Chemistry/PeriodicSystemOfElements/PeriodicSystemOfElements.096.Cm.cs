using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Electricity;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;

using Unknown6656.Physics.Optics;

namespace Unknown6656.Physics.Chemistry;


public partial class Element
{

    public static Element Curium => field ??= PeriodicTableOfElements.RegisterElement(new()
    {
        Name = nameof(Curium),
        Symbol = "Cm",
        CASNumber = "CAS7440-51-9",
        CIDNumber = null,
        DiscoveryYear = 1944,
        AtomicNumber = 96,
        Category = ElementCategory.Actinide,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = 1613.Kelvin,
            BoilingPoint = 3383.Kelvin,
            StandardDensity = 13.51.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = 13.85e3.JoulePerMol,
            HeatOfVaporization = null,
            ThermalCapacity = null,
            IonizationEnergies = [
                .581e6.JoulePerMol,
                1.196e6.JoulePerMol,
                2.026e6.JoulePerMol,
                3.55e6.JoulePerMol,
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
                new(5, ElectronOrbital.F, 7),
                new(6, ElectronOrbital.S, 2),
                new(6, ElectronOrbital.P, 6),
                new(6, ElectronOrbital.D, 1),
                new(7, ElectronOrbital.S, 2),
            ]),
            Valence = 9,
            OxidationStates = [2, 3, 4, 5, 6],
            CommonOxidationStates = [3],
            PaulingElectronegativity = 1.3,
            AllenElectronegativity = null,
            MeanAtomicRadius = 176e-9.Meter,
            CovalentRadius = 166e-9.Meter,
            VanDerWaalsRadius = 176e-9.Meter,
        },
        Electromagnetics = new()
        {
            ElectricalType = ElectricalElementType.Conductor,
            BandGap = null,
            ElectricalResistivity = 1.25e-6.OhmMeter,
            MagneticOrdering = MagneticOrdering.Paramagnetic,
            CuriePoint = null,
            MagneticSusceptibility = null,
            SuperconductingPoint = 42.Kelvin,
        },
        Kinematics = KinematicElementProperties.Unknown,
        Optics = new()
        {
            RefractiveIndex = null,
            ExtinctionCoefficient = 1,
            EmissionSpectrum = new SparseSpectrum([
                (246.276.Nanometer, 1),
                (261.717.Nanometer, 1),
                (263.628.Nanometer, 1),
                (265.117.Nanometer, 1),
                (265.38.Nanometer, 1),
                (272.568.Nanometer, 1),
                (273.689.Nanometer, 1),
                (274.804.Nanometer, 1),
                (278.483.Nanometer, 1),
                (281.162.Nanometer, 1),
                (282.42.Nanometer, 1),
                (283.358.Nanometer, 1),
                (289.99.Nanometer, 1),
                (291.297.Nanometer, 1),
                (292.892.Nanometer, 1),
                (299.618.Nanometer, 1),
                (299.939.Nanometer, 1),
                (301.487.Nanometer, 1),
                (304.485.Nanometer, 1),
                (310.969.Nanometer, 1),
                (311.641.Nanometer, 1),
                (313.716.Nanometer, 1),
                (314.733.Nanometer, 1),
                (315.51.Nanometer, 1),
                (315.86.Nanometer, 1),
                (316.998.Nanometer, 1),
                (317.755.Nanometer, 1),
                (317.91.Nanometer, 1),
                (318.641.Nanometer, 1),
                (318.811.Nanometer, 1),
                (320.712.Nanometer, 1),
                (320.771.Nanometer, 1),
                (320.989.Nanometer, 1),
                (320.994.Nanometer, 1),
                (321.005.Nanometer, 1),
                (322.076.Nanometer, 1),
                (322.423.Nanometer, 1),
                (322.511.Nanometer, 1),
                (322.641.Nanometer, 1),
                (323.028.Nanometer, 1),
                (323.035.Nanometer, 1),
                (323.674.Nanometer, 1),
                (323.855.Nanometer, 1),
                (324.266.Nanometer, 1),
                (324.625.Nanometer, 1),
                (325.268.Nanometer, 1),
                (326.581.Nanometer, 1),
                (328.045.Nanometer, 1),
                (329.671.Nanometer, 1),
                (330.485.Nanometer, 1),
                (331.714.Nanometer, 1),
                (337.47.Nanometer, 1),
                (345.292.Nanometer, 1),
                (345.834.Nanometer, 1),
                (351.028.Nanometer, 1),
                (352.236.Nanometer, 1),
                (352.494.Nanometer, 1),
                (354.206.Nanometer, 1),
                (354.702.Nanometer, 1),
                (354.792.Nanometer, 1),
                (356.144.Nanometer, 1),
                (357.295.Nanometer, 1),
                (360.062.Nanometer, 1),
                (363.994.Nanometer, 1),
                (366.434.Nanometer, 1),
                (370.943.Nanometer, 1),
                (372.9.Nanometer, 1),
                (373.235.Nanometer, 1),
                (374.786.Nanometer, 1),
                (376.305.Nanometer, 1),
                (377.575.Nanometer, 1),
                (381.63.Nanometer, 1),
                (382.514.Nanometer, 1),
                (383.332.Nanometer, 1),
                (383.759.Nanometer, 1),
                (384.2.Nanometer, 1),
                (384.992.Nanometer, 1),
                (385.411.Nanometer, 1),
                (390.025.Nanometer, 1),
                (390.406.Nanometer, 1),
                (390.824.Nanometer, 1),
                (393.667.Nanometer, 1),
                (394.203.Nanometer, 1),
                (394.415.Nanometer, 1),
                (394.868.Nanometer, 1),
                (395.336.Nanometer, 1),
                (396.483.Nanometer, 1),
                (399.51.Nanometer, 1),
                (401.617.Nanometer, 1),
                (403.176.Nanometer, 1),
                (404.829.Nanometer, 1),
                (404.965.Nanometer, 1),
                (411.329.Nanometer, 1),
                (412.971.Nanometer, 1),
                (420.766.Nanometer, 1),
                (421.162.Nanometer, 1),
                (426.645.Nanometer, 1),
                (429.3.Nanometer, 1),
                (433.082.Nanometer, 1),
                (434.569.Nanometer, 1),
                (444.777.Nanometer, 1),
                (445.916.Nanometer, 1),
                (460.84.Nanometer, 1),
                (584.607.Nanometer, 1),
                (595.241.Nanometer, 1),
                (605.89.Nanometer, 1),
                (624.335.Nanometer, 1),
                (637.671.Nanometer, 1),
                (651.016.Nanometer, 1),
                (655.441.Nanometer, 1),
                (664.017.Nanometer, 1),
                (666.325.Nanometer, 1),
                (668.687.Nanometer, 1),
                (670.685.Nanometer, 1),
                (672.668.Nanometer, 1),
                (679.315.Nanometer, 1),
                (716.269.Nanometer, 1),
                (757.78.Nanometer, 1),
                (767.379.Nanometer, 1),
                (772.047.Nanometer, 1),
                (839.237.Nanometer, 1),
                (929.325.Nanometer, 1),
                (956.708.Nanometer, 1),
                (965.712.Nanometer, 1),
                (1031.083.Nanometer, 1),
                (1035.173.Nanometer, 1),
                (1042.449.Nanometer, 1),
                (1050.811.Nanometer, 1),
                (1054.298.Nanometer, 1),
                (1079.225.Nanometer, 1),
                (1089.745.Nanometer, 1),
                (1150.745.Nanometer, 1),
                (1170.773.Nanometer, 1),
                (1178.095.Nanometer, 1),
                (1183.428.Nanometer, 1),
                (1201.785.Nanometer, 1),
                (1239.416.Nanometer, 1),
                (1245.498.Nanometer, 1),
                (1246.499.Nanometer, 1),
                (1300.456.Nanometer, 1),
                (1325.818.Nanometer, 1),
                (1328.984.Nanometer, 1),
                (1334.462.Nanometer, 1),
                (1348.054.Nanometer, 1),
                (1359.001.Nanometer, 1),
                (1364.477.Nanometer, 1),
                (1378.952.Nanometer, 1),
                (1384.018.Nanometer, 1),
                (1390.846.Nanometer, 1),
                (1396.414.Nanometer, 1),
                (1423.527.Nanometer, 1),
                (1433.452.Nanometer, 1),
                (1456.341.Nanometer, 1),
                (1458.023.Nanometer, 1),
                (1501.813.Nanometer, 1),
                (1522.227.Nanometer, 1),
                (1564.259.Nanometer, 1),
                (1575.723.Nanometer, 1),
                (1579.331.Nanometer, 1),
                (1600.841.Nanometer, 1),
                (1714.822.Nanometer, 1),
                (1745.318.Nanometer, 1),
                (1761.928.Nanometer, 1),
                (1806.902.Nanometer, 1),
                (1957.262.Nanometer, 1),
                (1997.598.Nanometer, 1),
                (2053.192.Nanometer, 1),
                (2085.918.Nanometer, 1),
                (2091.723.Nanometer, 1),
                (2097.383.Nanometer, 1),
                (2124.686.Nanometer, 1),
                (2139.907.Nanometer, 1),
            ]),
        }
    }).AddIsotopes([
        new()
        {
            NeutronCount = 137,
            Spin = 1.5,
            Decays = [
                new(DecayMode.PositronEmission, 27.Second, .8),
                new(DecayMode.Alpha, 27.Second, .2)
            ],
        },
        new()
        {
            NeutronCount = 138,
            Spin = 0,
            Decays = [
                new(DecayMode.PositronEmission, 52.Second, .71),
                new(DecayMode.Alpha, 52.Second, .27),
                new(DecayMode.SpontaneousFission, 52.Second, .02),
            ],
        },
        new()
        {
            NeutronCount = 139,
            Spin = 2.5,
            Decays = [
                new(DecayMode.PositronEmission, 7.Minute, .96),
                new(DecayMode.Alpha, 7.Minute, .04)
            ],
        },
        new()
        {
            NeutronCount = 140,
            Spin = 0,
            Decays = [
                new(DecayMode.PositronEmission, 6.8.Minute, .82),
                new(DecayMode.Alpha, 6.8.Minute, .18)
            ],
        },
        new()
        {
            NeutronCount = 141,
            Spin = 2.5,
            Decays = [new(DecayMode.Alpha, 10.Minute)],
        },
        new()
        {
            NeutronCount = 142,
            Spin = 0,
            Decays = [
                new(DecayMode.ElectronCapture, 2.2.Hour, .9611),
                new(DecayMode.Alpha, 2.2.Hour, .0384),
                new(DecayMode.SpontaneousFission, 2.2.Hour, .00048)
            ],
        },
        new()
        {
            NeutronCount = 143,
            Spin = -3.5,
            Decays = [
                new(DecayMode.PositronEmission, 2.5.Hour),
                new(DecayMode.Alpha, 2.5.Hour, .00062)
            ],
        },
        new()
        {
            NeutronCount = 144,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 30.4.StandardDay),
                new(DecayMode.SpontaneousFission, 30.4.StandardDay, .000039)
            ],
        },
        new()
        {
            NeutronCount = 145,
            Spin = 0.5,
            Decays = [
                new(DecayMode.ElectronCapture, 32.8.StandardDay, .99),
                new(DecayMode.Alpha, 32.8.StandardDay, .01)
            ],
        },
        new()
        {
            NeutronCount = 146,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 162.8.StandardDay, .999938),
                new(DecayMode.SpontaneousFission, 162.8.StandardDay, .000062),
                new(DecayMode.ClusterDecay, 162.8.StandardDay, .00000000000011)
            ],
        },
        new()
        {
            NeutronCount = 147,
            Spin = 2.5,
            Decays = [
                new(DecayMode.Alpha, 29.1.SolarYear, .9971),
                new(DecayMode.ElectronCapture, 29.1.SolarYear, .0029),
                new(DecayMode.SpontaneousFission, 29.1.SolarYear, .000000053)
            ],
        },
        new()
        {
            NeutronCount = 148,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 18.11.SolarYear),
                new(DecayMode.SpontaneousFission, 18.11.SolarYear, .00000137)
            ],
        },
        new()
        {
            NeutronCount = 149,
            Spin = 3.5,
            Decays = [
                new(DecayMode.Alpha, 8250.SolarYear),
                new(DecayMode.SpontaneousFission, 8250.SolarYear, .0000061)
            ],
        },
        new()
        {
            NeutronCount = 150,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 4706.SolarYear, .9997),
                new(DecayMode.SpontaneousFission, 4706.SolarYear, .0002615)
            ],
        },
        new()
        {
            NeutronCount = 151,
            Spin = -4.5,
            Decays = [new(DecayMode.Alpha, 1.56e7 .SolarYear)],
        },
        new()
        {
            NeutronCount = 152,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 3.48e5 .SolarYear, .9161),
                new(DecayMode.SpontaneousFission, 3.48e5 .SolarYear, .0839)
            ],
        },
        new()
        {
            NeutronCount = 153,
            Spin = 0.5,
            Decays = [new(DecayMode.Beta, 64.15.Minute)],
        },
        new()
        {
            NeutronCount = 154,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 8300.SolarYear),
                new(DecayMode.Alpha, 8300.SolarYear),
                new(DecayMode.Beta, 8300.SolarYear)
            ],
        },
        new()
        {
            NeutronCount = 155,
            Spin = 1.5,
            Decays = [new(DecayMode.Beta, 16.8.Minute)],
        },
    ]);
}
