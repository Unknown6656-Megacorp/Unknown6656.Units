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
        Symbol = "H",
        AtomicNumber = 1,
        Category = ElementCategory.NonMetal,
        Thermodynamics = new()
        {
            StandardDensity = 0.08988.GramPerLiter(),
            STPMeltingPoint = 13.99.Kelvin(),
            STPBoilingPoint = 20.271.Kelvin(),
            TriplePoint = (13.8033.Kelvin(), 7_041d.Pascal()),
            CriticalPoint = (32.938.Kelvin(), 1_285_800d.Pascal()),
            IonizationEnergies = [
                1312.3e3.JoulePerMol(),
            ],
            HeatOfFusion = 117d.JoulePerMol(),
            HeatOfVaporization = 904d.JoulePerMol(),
            ThermalConductivity = 0.1805.WattPerMeterKelvin(),
            ThermalCapacity = 28.836.JoulePerMolKelvin(),
            ThermalExpansion = null,
        },
        Kinematics = new()
        {
            SpeedOfSound = 1310d.MeterPerSecond(),
        },
        ChemicalBonding = new()
        {
            ElectroNegativity = 2.20,
            CovalentRadius = 31e-12.Meter(),
            VanDerWaalsRadius = 120e-12.Meter(),
            MeanAtomicRadius = 25e-12.Meter(),
            OxidationStates = [1, -1],
            ElectronConfiguration = new([
                new(1, ElectronOrbital.S, 1),
            ])
        },
        Electromagnetics = new()
        {
            MagneticOrdering = MagneticOrdering.Diamagnetic,
            MagneticSusceptibility = -3.98e-6.CubicCentimeterPerMol(),
            ElectricalResistivity = null,
            CurieTemperature = null,
        },
        Optics = new()
        {
            RefractiveIndex = 1.000132,
            EmissionSpectrum = new SparseSpectrum([
                (91.8125d.Nanometer(), 0.006666666666666667),
                (91.9342d.Nanometer(), 0.007261904761904762),
                (92.0947d.Nanometer(), 0.008809523809523809),
                (92.3148d.Nanometer(), 0.014285714285714285),
                (92.6249d.Nanometer(), 0.013095238095238096),
                (93.0751d.Nanometer(), 0.006666666666666667),
                (93.7814d.Nanometer(), 0.02261904761904762),
                (94.9742d.Nanometer(), 0.039285714285714285),
                (97.2517d.Nanometer(), 0.0988095238095238),
                (102.5728d.Nanometer(), 0.2976190476190476),
                (121.56701d.Nanometer(), 1),
                (365.665d.Nanometer(), 0.0008333333333333334),
                (365.725d.Nanometer(), 0.0008333333333333334),
                (365.804d.Nanometer(), 0.0008333333333333334),
                (365.865d.Nanometer(), 0.0008333333333333334),
                (365.941d.Nanometer(), 0.0008333333333333334),
                (366.032d.Nanometer(), 0.0008333333333333334),
                (366.127d.Nanometer(), 0.0009523809523809524),
                (366.222d.Nanometer(), 0.0013095238095238095),
                (366.341d.Nanometer(), 0.0010714285714285715),
                (366.465d.Nanometer(), 0.0011904761904761906),
                (366.608d.Nanometer(), 0.0010714285714285715),
                (366.773d.Nanometer(), 0.0011904761904761906),
                (366.945d.Nanometer(), 0.0015476190476190477),
                (367.132d.Nanometer(), 0.0014285714285714286),
                (367.381d.Nanometer(), 0.0015476190476190477),
                (367.6376d.Nanometer(), 0.0016666666666666668),
                (367.937d.Nanometer(), 0.0020238095238095236),
                (368.2823d.Nanometer(), 0.0020238095238095236),
                (368.6831d.Nanometer(), 0.002380952380952381),
                (369.1551d.Nanometer(), 0.0027380952380952383),
                (369.7157d.Nanometer(), 0.0027380952380952383),
                (370.3859d.Nanometer(), 0.0033333333333333335),
                (371.1978d.Nanometer(), 0.003928571428571429),
                (372.1946d.Nanometer(), 0.005952380952380952),
                (373.4369d.Nanometer(), 0.007142857142857143),
                (375.0151d.Nanometer(), 0.009523809523809525),
                (377.0633d.Nanometer(), 0.010714285714285714),
                (379.7909d.Nanometer(), 0.02023809523809524),
                (383.5397d.Nanometer(), 0.03571428571428571),
                (388.9064d.Nanometer(), 0.08333333333333333),
                (397.0075d.Nanometer(), 0.03571428571428571),
                (410.1734d.Nanometer(), 0.08333333333333333),
                (434.0472d.Nanometer(), 0.10714285714285714),
                (486.135d.Nanometer(), 0.21428571428571427),
                (656.279d.Nanometer(), 0.5952380952380952),
                (824.999d.Nanometer(), 0.00010714285714285714),
                (825.229d.Nanometer(), 0.00010714285714285714),
                (825.499d.Nanometer(), 0.00010714285714285714),
                (825.789d.Nanometer(), 0.00013095238095238096),
                (826.089d.Nanometer(), 0.00013095238095238096),
                (826.428d.Nanometer(), 0.00013095238095238096),
                (826.794d.Nanometer(), 0.00013095238095238096),
                (827.194d.Nanometer(), 0.00016666666666666666),
                (827.632d.Nanometer(), 0.00016666666666666666),
                (828.113d.Nanometer(), 0.00016666666666666666),
                (828.642d.Nanometer(), 0.00016666666666666666),
                (829.23d.Nanometer(), 0.0002023809523809524),
                (829.883d.Nanometer(), 0.00025),
                (830.61d.Nanometer(), 0.00029761904761904765),
                (831.426d.Nanometer(), 0.00034523809523809523),
                (832.342d.Nanometer(), 0.00034523809523809523),
                (833.378d.Nanometer(), 0.00044047619047619046),
                (834.554d.Nanometer(), 0.0005952380952380953),
                (835.9d.Nanometer(), 0.0005952380952380953),
                (837.448d.Nanometer(), 0.0007142857142857143),
                (839.24d.Nanometer(), 0.0008333333333333334),
                (841.332d.Nanometer(), 0.0008333333333333334),
                (843.795d.Nanometer(), 0.0008333333333333334),
                (846.726d.Nanometer(), 0.0008333333333333334),
                (859.839d.Nanometer(), 0.0027380952380952383),
                (875.046d.Nanometer(), 0.002619047619047619),
                (1093.817d.Nanometer(), 0.016666666666666666),
                (1281.8072d.Nanometer(), 0.0380952380952381),
                (1555.621d.Nanometer(), 0.0009523809523809524),
                (1640.688d.Nanometer(), 0.0016666666666666668),
                (1680.651d.Nanometer(), 0.0019047619047619048),
                (1736.2143d.Nanometer(), 0.0036904761904761906),
                (1817.424d.Nanometer(), 0.0033333333333333335),
                (2166.1178d.Nanometer(), 0.009523809523809525),
                (3740.576d.Nanometer(), 0.002976190476190476),
                (4052.279d.Nanometer(), 0.013095238095238096),
                (4653.78d.Nanometer(), 0.005),
                (7502.44d.Nanometer(), 0.0007380952380952381),
                (8154.84d.Nanometer(), 0.00014285714285714287),
                (8664.46d.Nanometer(), 0.00021428571428571427),
                (8760.064d.Nanometer(), 0.0005),
                (10503.507d.Nanometer(), 0.00022619047619047618),
                (11308.681d.Nanometer(), 0.0005),
                (11539.54d.Nanometer(), 0.00013095238095238096),
                (12371.912d.Nanometer(), 0.0004880952380952381),
                (12387.153d.Nanometer(), 0.0004047619047619048),
                (12587.05d.Nanometer(), 0.00025),
                (19061.96d.Nanometer(), 0.0006428571428571428),
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
            Decays = [new(DecayMode.Beta, 12.32.SolarYear())],
        },
        new()
        {
            NeutronCount = 3,
            Spin = -2,
            Decays = [new(DecayMode.NeutronEmission, 139e-24.Second())],
        },
        new()
        {
            NeutronCount = 4,
            Spin = 3,
            Decays = [new(DecayMode.DoubleNeutronEmission, 86e-24.Second())],
        },
    ]);
}
