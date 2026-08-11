using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Kinematics;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Magnetism;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;

using Unknown6656.Physics.Optics;

namespace Unknown6656.Physics.Chemistry;


public sealed partial class PeriodicTableOfElements
{
    public static Element Hydrogen { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Hydrogen),
        AlternateNames = ["protium", "deuterium", "tritium"],
        Symbol = "H",
        CASNumber = "CAS1333-74-0",
        CIDNumber = 783,
        DiscoveryYear = 1671,
        AtomicNumber = 1,
        Category = ElementCategory.NonMetal,
        Occurrence = ElementOccurrence.Primordial,
        Abundance = new()
        {
            UniverseAbundance = .75,
            SolarAbundance = .75,
            MeteoriteAbundance = .024,
            CrustalAbundance = .0015,
            OceanAbundance = .11,
            HumanBodyAbundance = .1,
        },
        Thermodynamics = new()
        {
            StandardDensity = 0.08988.GramPerLiter,
            MeltingPoint = 13.99.Kelvin,
            BoilingPoint = 20.271.Kelvin,
            TriplePoint = (13.8033.Kelvin, 7_041.Pascal),
            CriticalPoint = (32.938.Kelvin, 1_285_800.Pascal),
            IonizationEnergies = [
                1312.3e3.JoulePerMol,
            ],
            HeatOfFusion = 117.JoulePerMol,
            HeatOfVaporization = 904.JoulePerMol,
            ThermalConductivity = 0.1805.WattPerMeterKelvin,
            ThermalCapacity = 28.836.JoulePerMolKelvin,
            ThermalExpansion = null,
        },
        Kinematics = new()
        {
            BrinellHardness = null,
            VickersHardness = null,
            MohsHardness = null,
            PoissonRatio = null,
            BulkModulus = null,
            ShearModulus = null,
            YoungModulus = null,
            SpeedOfSound = 1310.MeterPerSecond,
        },
        ChemicalBonding = new()
        {
            Valence = 1,
            PaulingElectronegativity = 2.2,
            AllenElectronegativity = 2.3,
            CovalentRadius = 31e-12.Meter,
            VanDerWaalsRadius = 120e-12.Meter,
            MeanAtomicRadius = 25e-12.Meter,
            OxidationStates = [1, -1],
            CommonOxidationStates = [1, -1],
            ElectronConfiguration = new([
                new(1, ElectronOrbital.S, 1),
            ])
        },
        Electromagnetics = new()
        {
            ElectricalType = ElectricalElementType.Insulator,
            MagneticOrdering = MagneticOrdering.Diamagnetic,
            MagneticSusceptibility = -3.98e-6.CubicCentimeterPerMol,
            SuperconductingPoint = null,
            BandGap = null,
            ElectricalResistivity = null,
            CuriePoint = null,
        },
        Optics = new()
        {
            RefractiveIndex = 1.000132,
            EmissionSpectrum = new SparseSpectrum([
                (91.8125.Nanometer, 0.006666666666666667),
                (91.9342.Nanometer, 0.007261904761904762),
                (92.0947.Nanometer, 0.008809523809523809),
                (92.3148.Nanometer, 0.014285714285714285),
                (92.6249.Nanometer, 0.013095238095238096),
                (93.0751.Nanometer, 0.006666666666666667),
                (93.7814.Nanometer, 0.02261904761904762),
                (94.9742.Nanometer, 0.039285714285714285),
                (97.2517.Nanometer, 0.0988095238095238),
                (102.5728.Nanometer, 0.2976190476190476),
                (121.56701.Nanometer, 1),
                (365.665.Nanometer, 0.0008333333333333334),
                (365.725.Nanometer, 0.0008333333333333334),
                (365.804.Nanometer, 0.0008333333333333334),
                (365.865.Nanometer, 0.0008333333333333334),
                (365.941.Nanometer, 0.0008333333333333334),
                (366.032.Nanometer, 0.0008333333333333334),
                (366.127.Nanometer, 0.0009523809523809524),
                (366.222.Nanometer, 0.0013095238095238095),
                (366.341.Nanometer, 0.0010714285714285715),
                (366.465.Nanometer, 0.0011904761904761906),
                (366.608.Nanometer, 0.0010714285714285715),
                (366.773.Nanometer, 0.0011904761904761906),
                (366.945.Nanometer, 0.0015476190476190477),
                (367.132.Nanometer, 0.0014285714285714286),
                (367.381.Nanometer, 0.0015476190476190477),
                (367.6376.Nanometer, 0.0016666666666666668),
                (367.937.Nanometer, 0.0020238095238095236),
                (368.2823.Nanometer, 0.0020238095238095236),
                (368.6831.Nanometer, 0.002380952380952381),
                (369.1551.Nanometer, 0.0027380952380952383),
                (369.7157.Nanometer, 0.0027380952380952383),
                (370.3859.Nanometer, 0.0033333333333333335),
                (371.1978.Nanometer, 0.003928571428571429),
                (372.1946.Nanometer, 0.005952380952380952),
                (373.4369.Nanometer, 0.007142857142857143),
                (375.0151.Nanometer, 0.009523809523809525),
                (377.0633.Nanometer, 0.010714285714285714),
                (379.7909.Nanometer, 0.02023809523809524),
                (383.5397.Nanometer, 0.03571428571428571),
                (388.9064.Nanometer, 0.08333333333333333),
                (397.0075.Nanometer, 0.03571428571428571),
                (410.1734.Nanometer, 0.08333333333333333),
                (434.0472.Nanometer, 0.10714285714285714),
                (486.135.Nanometer, 0.21428571428571427),
                (656.279.Nanometer, 0.5952380952380952),
                (824.999.Nanometer, 0.00010714285714285714),
                (825.229.Nanometer, 0.00010714285714285714),
                (825.499.Nanometer, 0.00010714285714285714),
                (825.789.Nanometer, 0.00013095238095238096),
                (826.089.Nanometer, 0.00013095238095238096),
                (826.428.Nanometer, 0.00013095238095238096),
                (826.794.Nanometer, 0.00013095238095238096),
                (827.194.Nanometer, 0.00016666666666666666),
                (827.632.Nanometer, 0.00016666666666666666),
                (828.113.Nanometer, 0.00016666666666666666),
                (828.642.Nanometer, 0.00016666666666666666),
                (829.23.Nanometer, 0.0002023809523809524),
                (829.883.Nanometer, 0.00025),
                (830.61.Nanometer, 0.00029761904761904765),
                (831.426.Nanometer, 0.00034523809523809523),
                (832.342.Nanometer, 0.00034523809523809523),
                (833.378.Nanometer, 0.00044047619047619046),
                (834.554.Nanometer, 0.0005952380952380953),
                (835.9.Nanometer, 0.0005952380952380953),
                (837.448.Nanometer, 0.0007142857142857143),
                (839.24.Nanometer, 0.0008333333333333334),
                (841.332.Nanometer, 0.0008333333333333334),
                (843.795.Nanometer, 0.0008333333333333334),
                (846.726.Nanometer, 0.0008333333333333334),
                (859.839.Nanometer, 0.0027380952380952383),
                (875.046.Nanometer, 0.002619047619047619),
                (1093.817.Nanometer, 0.016666666666666666),
                (1281.8072.Nanometer, 0.0380952380952381),
                (1555.621.Nanometer, 0.0009523809523809524),
                (1640.688.Nanometer, 0.0016666666666666668),
                (1680.651.Nanometer, 0.0019047619047619048),
                (1736.2143.Nanometer, 0.0036904761904761906),
                (1817.424.Nanometer, 0.0033333333333333335),
                (2166.1178.Nanometer, 0.009523809523809525),
                (3740.576.Nanometer, 0.002976190476190476),
                (4052.279.Nanometer, 0.013095238095238096),
                (4653.78.Nanometer, 0.005),
                (7502.44.Nanometer, 0.0007380952380952381),
                (8154.84.Nanometer, 0.00014285714285714287),
                (8664.46.Nanometer, 0.00021428571428571427),
                (8760.064.Nanometer, 0.0005),
                (10503.507.Nanometer, 0.00022619047619047618),
                (11308.681.Nanometer, 0.0005),
                (11539.54.Nanometer, 0.00013095238095238096),
                (12371.912.Nanometer, 0.0004880952380952381),
                (12387.153.Nanometer, 0.0004047619047619048),
                (12587.05.Nanometer, 0.00025),
                (19061.96.Nanometer, 0.0006428571428571428),
            ]),
        },
    }).AddIsotopes([
        new()
        {
            Name = "Protium",
            NeutronCount = 0,
            Abundance = 0.999885,
            Spin = .5,
            Decays = [],
        },
        new()
        {
            Name = "Deuterium",
            NeutronCount = 1,
            Abundance = 0.000115,
            Spin = 1,
            Decays = [],
        },
        new()
        {
            Name = "Tritium",
            NeutronCount = 2,
            Abundance = 0.0000000000001,
            Spin = .5,
            Decays = [new(DecayMode.Beta, 12.32.SolarYear)],
        },
        new()
        {
            NeutronCount = 3,
            Spin = -2,
            Decays = [new(DecayMode.NeutronEmission, 139e-24.Second)],
        },
        new()
        {
            NeutronCount = 4,
            Spin = 3,
            Decays = [new(DecayMode.DoubleNeutronEmission, 86e-24.Second)],
        },
    ]);
}
