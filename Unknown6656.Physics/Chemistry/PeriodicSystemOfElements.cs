using System.Collections.Generic;
using System.Linq;

using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Electricity;
using Unknown6656.Units.Kinematics;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Magnetism;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;

using Unknown6656.Physics.Optics;

namespace Unknown6656.Physics.Chemistry;


public sealed class PeriodicTableOfElements
{
    private readonly Dictionary<uint, Element> _elements = [];


    public static PeriodicTableOfElements Table { get; } = new();

    public Element this[int atomicNumber] => this[(uint)atomicNumber];

    public Element this[uint atomicNumber] => _elements[atomicNumber];

    public Isotope? this[int protons, int neutrons] => GetIsotope(protons, neutrons);

    public Isotope? this[uint protons, uint neutrons] => GetIsotope(protons, neutrons);


    private PeriodicTableOfElements()
    {
    }

    private Element RegisterElement(Element element) => _elements[element.AtomicNumber] = element;

    public Element GetElement(int atomicNumber) => GetElement((uint)atomicNumber);

    public Element GetElement(uint atomicNumber) => this[atomicNumber];

    public Isotope? GetIsotope(int protons, int neutrons) => GetIsotope((uint)protons, (uint)neutrons);

    public Isotope? GetIsotope(uint protons, uint neutrons) => GetElement(protons).GetIsotopeByNeutronCount(neutrons);

    public Isotope? GetIsotopeByHadrons(int hadrons, int protons) => GetIsotopeByHadrons((uint)hadrons, (uint)protons);

    public Isotope? GetIsotopeByHadrons(uint hadrons, uint protons) => GetIsotope(protons, hadrons - protons);

    public Isotope[] GetIsotopesByHadrons(int hadrons) => GetIsotopesByHadrons((uint)hadrons);

    public Isotope[] GetIsotopesByHadrons(uint hadrons) => [..from elem in _elements.Values
                                                              from iso in elem.KnownIsotopes
                                                              where iso.HadronCount == hadrons
                                                              select iso];


    #region 1 H  - HYDROGEN

    public static Element Hydrogen { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Hydrogen),
        Symbol = "H",
        AtomicNumber = 1,
        Category = ElementCategory.NonMetal,
        Thermodynamics = new()
        {
            MeltingPoint = 13.99.Kelvin(),
            BoilingPoint = 20.271.Kelvin(),
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
            MeanAtomicRadius = null,
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
                (9392.03d.Nanometer(), 7.142857142857143E-05),
                (10503.507d.Nanometer(), 0.00022619047619047618),
                (10803.59d.Nanometer(), 9.523809523809524E-05),
                (11308.681d.Nanometer(), 0.0005),
                (11539.54d.Nanometer(), 0.00013095238095238096),
                (12371.912d.Nanometer(), 0.0004880952380952381),
                (12387.153d.Nanometer(), 0.0004047619047619048),
                (12587.05d.Nanometer(), 0.00025),
                (19061.96d.Nanometer(), 0.0006428571428571428),
                (69071.7d.Nanometer(), 1.6666666666666667E-05),
                (88761d.Nanometer(), 1.0714285714285714E-05),
                (111863d.Nanometer(), 1.6666666666666667E-05),
                (138750d.Nanometer(), 2.261904761904762E-05),
                (169423d.Nanometer(), 1.9047619047619046E-05),
            ]),
        },
        StandardDensity = 0.08988.GramPerLiter(),
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
            Decays = [
                new(DecayMode.Beta, 12.32.SolarYear()),
            ],
        },
        new()
        {
            NeutronCount = 3,
            Spin = 2,
            Decays = [
                new(DecayMode.NeutronEmission, 139e-24.Second()),
            ],
        },
        new()
        {
            NeutronCount = 4,
            Spin = 3,
            Decays = [
                new(DecayMode.DoubleNeutronEmission, 86e-24.Second()),
            ],
        },
    ]);

    #endregion
    #region 2 He - HELIUM

    public static Element Helium { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Helium),
        Symbol = "He",
        AtomicNumber = 2,
        Category = ElementCategory.NobleGas,
        Thermodynamics = new()
        {
            MeltingPoint = 0.95.Kelvin(),
            BoilingPoint = 4.222.Kelvin(),
            TriplePoint = (2.177.Kelvin(), 5.043e3.Pascal()),
            CriticalPoint = (5.1953.Kelvin(), 227.46e3.Pascal()),
            IonizationEnergies = [
                2372.3e3.JoulePerMol(),
                5250.5e3.JoulePerMol(),
            ],
            HeatOfFusion = 13.8.JoulePerMol(),
            HeatOfVaporization = 82.9.JoulePerMol(),
            ThermalCapacity = 20.78.JoulePerMolKelvin(),
            ThermalConductivity = 0.1513.WattPerMeterKelvin(),
            ThermalExpansion = null,
        },
        Kinematics = new()
        {
            SpeedOfSound = 972d.MeterPerSecond(),
        },
        ChemicalBonding = new()
        {
            CovalentRadius = 28e-12.Meter(),
            VanDerWaalsRadius = 140e-12.Meter(),
            MeanAtomicRadius = null,
            ElectroNegativity = null,
            OxidationStates = [],
            ElectronConfiguration = new([
                new(1, ElectronOrbital.S, 2),
            ]),
        },
        Electromagnetics = new()
        {
            CurieTemperature = null,
            ElectricalResistivity = null,
            MagneticOrdering = MagneticOrdering.Diamagnetic,
            MagneticSusceptibility = -1.88e-6.CubicCentimeterPerMol(),
        },
        StandardDensity = 0.1786.GramPerLiter(),
        Optics = new()
        {
            RefractiveIndex = 1.000036,
            EmissionSpectrum = new SparseSpectrum([
                (32.02926d.Nanometer(), 0.005),
                (50.561d.Nanometer(), 0.001),
                (50.575d.Nanometer(), 0.0015),
                (50.59d.Nanometer(), 0.002),
                (50.631d.Nanometer(), 0.0025),
                (50.656d.Nanometer(), 0.0035),
                (50.708d.Nanometer(), 0.005),
                (50.771d.Nanometer(), 0.0075),
                (50.863d.Nanometer(), 0.01),
                (50.997d.Nanometer(), 0.0125),
                (51.207d.Nanometer(), 0.0175),
                (51.5596d.Nanometer(), 0.025),
                (52.2186d.Nanometer(), 0.05),
                (53.70293d.Nanometer(), 0.2),
                (58.43339d.Nanometer(), 0.5),
                (59.14121d.Nanometer(), 0.025),
                (257.76d.Nanometer(), 0.025),
                (267.7135d.Nanometer(), 0.0005),
                (269.6119d.Nanometer(), 0.0005),
                (272.3191d.Nanometer(), 0.0005),
                (276.3801583d.Nanometer(), 0.001),
                (276.3803097d.Nanometer(), 0.001),
                (276.3803221d.Nanometer(), 0.001),
                (281.82d.Nanometer(), 0.005),
                (282.9078411d.Nanometer(), 0.002),
                (282.9080951d.Nanometer(), 0.002),
                (282.9081157d.Nanometer(), 0.002),
                (294.5106d.Nanometer(), 0.005),
                (301.37d.Nanometer(), 0.02),
                (318.7745d.Nanometer(), 0.01),
                (325.8275d.Nanometer(), 0.0005),
                (335.4555098d.Nanometer(), 0.0005),
                (344.7589034d.Nanometer(), 0.001),
                (355.4415d.Nanometer(), 0.0005),
                (358.727d.Nanometer(), 0.0005),
                (361.3643d.Nanometer(), 0.0015),
                (363.4230767d.Nanometer(), 0.001),
                (363.4231071d.Nanometer(), 0.001),
                (363.4231092d.Nanometer(), 0.001),
                (363.4240864d.Nanometer(), 0.001),
                (363.4241168d.Nanometer(), 0.001),
                (365.199d.Nanometer(), 0.0005),
                (370.5005d.Nanometer(), 0.0015),
                (373.2863477d.Nanometer(), 0.0005),
                (373.287413d.Nanometer(), 0.0005),
                (381.96074d.Nanometer(), 0.005),
                (381.975731d.Nanometer(), 0.0005),
                (386.7472343d.Nanometer(), 0.0015),
                (386.7483778d.Nanometer(), 0.0015),
                (386.7631595d.Nanometer(), 0.0005),
                (387.1791d.Nanometer(), 0.0005),
                (388.8648d.Nanometer(), 0.25),
                (392.6544387d.Nanometer(), 0.0005),
                (396.47291d.Nanometer(), 0.01),
                (400.9256516d.Nanometer(), 0.0005),
                (402.3973d.Nanometer(), 0.0005),
                (402.61914d.Nanometer(), 0.025),
                (402.6356959d.Nanometer(), 0.0025),
                (412.08154d.Nanometer(), 0.006),
                (412.0991564d.Nanometer(), 0.001),
                (414.3761d.Nanometer(), 0.0015),
                (416.8967d.Nanometer(), 0.0005),
                (438.79296d.Nanometer(), 0.005),
                (443.7551d.Nanometer(), 0.0015),
                (447.14802d.Nanometer(), 0.1),
                (447.1683251d.Nanometer(), 0.0125),
                (471.31457d.Nanometer(), 0.015),
                (471.3375684d.Nanometer(), 0.002),
                (492.19313d.Nanometer(), 0.01),
                (501.56783d.Nanometer(), 0.05),
                (504.7738d.Nanometer(), 0.005),
                (587.5621d.Nanometer(), 0.25),
                (587.596628d.Nanometer(), 0.05),
                (667.8151d.Nanometer(), 0.05),
                (706.519d.Nanometer(), 0.1),
                (706.571d.Nanometer(), 0.015),
                (728.1349d.Nanometer(), 0.025),
                (781.612468d.Nanometer(), 0.0005),
                (781.61368d.Nanometer(), 0.0005),
                (781.613778d.Nanometer(), 0.0005),
                (836.171342d.Nanometer(), 0.001),
                (836.173561d.Nanometer(), 0.001),
                (836.173742d.Nanometer(), 0.001),
                (906.328214d.Nanometer(), 0.001),
                (906.328403d.Nanometer(), 0.001),
                (906.328417d.Nanometer(), 0.001),
                (906.330021d.Nanometer(), 0.001),
                (906.33021d.Nanometer(), 0.001),
                (921.0337d.Nanometer(), 0.001),
                (946.353679d.Nanometer(), 0.005),
                (946.358646d.Nanometer(), 0.005),
                (946.359051d.Nanometer(), 0.005),
                (951.65622d.Nanometer(), 0.002),
                (951.656532d.Nanometer(), 0.002),
                (951.656554d.Nanometer(), 0.002),
                (951.658212d.Nanometer(), 0.002),
                (951.658524d.Nanometer(), 0.002),
                (951.682735d.Nanometer(), 0.0005),
                (952.617d.Nanometer(), 0.0015),
                (952.927d.Nanometer(), 0.0005),
                (960.344084d.Nanometer(), 0.0005),
                (970.261409d.Nanometer(), 0.0015),
                (970.26348d.Nanometer(), 0.0015),
                (1002.773d.Nanometer(), 0.003),
                (1003.116d.Nanometer(), 0.001),
                (1013.842357d.Nanometer(), 0.0005),
                (1031.12211d.Nanometer(), 0.005),
                (1031.122691d.Nanometer(), 0.005),
                (1031.122731d.Nanometer(), 0.005),
                (1031.124448d.Nanometer(), 0.005),
                (1031.125029d.Nanometer(), 0.005),
                (1031.153237d.Nanometer(), 0.001),
                (1066.766206d.Nanometer(), 0.0015),
                (1066.768709d.Nanometer(), 0.0015),
                (1082.909115d.Nanometer(), 0.15),
                (1083.025011d.Nanometer(), 0.5),
                (1083.033978d.Nanometer(), 1),
                (1091.292d.Nanometer(), 0.006),
                (1091.305d.Nanometer(), 0.0045),
                (1091.71d.Nanometer(), 0.0015),
                (1101.307135d.Nanometer(), 0.001),
                (1104.498297d.Nanometer(), 0.001),
                (1196.904506d.Nanometer(), 0.022),
                (1196.905861d.Nanometer(), 0.022),
                (1196.905953d.Nanometer(), 0.022),
                (1196.907657d.Nanometer(), 0.022),
                (1196.912d.Nanometer(), 0.015),
                (1252.752d.Nanometer(), 0.01),
                (1278.479d.Nanometer(), 0.0405),
                (1278.499d.Nanometer(), 0.025),
                (1279.057d.Nanometer(), 0.01),
                (1284.596d.Nanometer(), 0.0035),
                (1296.845d.Nanometer(), 0.005),
                (1298.489d.Nanometer(), 0.001),
                (1508.364d.Nanometer(), 0.006),
                (1700.247d.Nanometer(), 0.1),
                (1855.557348d.Nanometer(), 0.0005),
                (1868.534d.Nanometer(), 0.25),
                (1869.723d.Nanometer(), 0.1),
                (1908.938d.Nanometer(), 0.05),
                (1954.308d.Nanometer(), 0.01),
                (2058.692d.Nanometer(), 0.5),
                (2112.583d.Nanometer(), 0.04),
                (2112.72d.Nanometer(), 0.005),
                (2113.78d.Nanometer(), 0.01),
            ]),
        },
    }).AddIsotopes([
        new()
        {
            NeutronCount = 0,
            Spin = 0,
            Decays = [
                new(DecayMode.ProtonEmission, 1e15.Second(), .9999),
                new(DecayMode.PositronEmission, 1e15.Second(), .0001),
            ],
        },
        new()
        {
            NeutronCount = 1,
            Spin = .5,
            Decays = [],
        },
        new()
        {
            NeutronCount = 2,
            Spin = 0,
            Decays = [],
        },
        new()
        {
            NeutronCount = 3,
            Spin = 1.5,
            Decays = [
                new(DecayMode.NeutronEmission, 6.02e-22.Second()),
            ],
        },
        new()
        {
            NeutronCount = 4,
            Spin = 0,
            Decays = [
                new(DecayMode.Beta, .80692.Second(), .99999722),
                new(DecayMode.BetaDeuteronEmission, .80692.Second(), .00000278),
            ],
        },
        new()
        {
            NeutronCount = 5,
            Spin = 1.5,
            Decays = [
                new(DecayMode.NeutronEmission, 2.51e-18.Second()),
            ],
        },
        new()
        {
            NeutronCount = 6,
            Spin = 0,
            Decays = [
                new(DecayMode.Beta, .1195.Second(), .831),
                new(DecayMode.BetaNeutronEmission, .1195.Second(), .16),
                new(DecayMode.BetaTritonEmission, .1195.Second(), .9),
            ],
        },
        new()
        {
            NeutronCount = 7,
            Spin = 1.5,
            Decays = [
                new(DecayMode.NeutronEmission, 2.5e-18.Second()),
            ],
        },
        new()
        {
            NeutronCount = 8,
            Spin = 0,
            Decays = [
                new(DecayMode.DoubleNeutronEmission, 2.6e-22.Second()),
            ],
        },
    ]);

    #endregion
    #region 3 Li - LITHIUM

    public static Element Lithium { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Lithium),
        Symbol = "Li",
        AtomicNumber = 3,
        Category = ElementCategory.AlkaliMetal,
        Thermodynamics = new()
        {
            MeltingPoint = 453.65.Kelvin(),
            BoilingPoint = 1_603d.Kelvin(),
            TriplePoint = null,
            CriticalPoint = (3_220d.Kelvin(), 67e6.Pascal()),
            HeatOfFusion = 3e3.JoulePerMol(),
            HeatOfVaporization = 136e3.JoulePerMol(),
            IonizationEnergies = [
                520.2e3.JoulePerMol(),
                7298.1e3.JoulePerMol(),
                11815.0e3.JoulePerMol(),
            ],
            ThermalCapacity = 24.860.JoulePerMolKelvin(),
            ThermalConductivity = 84.8.WattPerMeterKelvin(),
            ThermalExpansion = 46.56e-6.InverseKelvin(),
        },
        StandardDensity = 0.5334.GramPerCubicCentimeter(),
        Kinematics = new()
        {
            BrinellHardness = 5e6.Pascal(),
            BulkModulus = 11e9.Pascal(),
            ShearModulus = 4.2e9.Pascal(),
            YoungModulus = 4.9e9.Pascal(),
            SpeedOfSound = 6_000d.MeterPerSecond(),
        },
        ChemicalBonding = new()
        {
            CovalentRadius = 128e-12.Meter(),
            VanDerWaalsRadius = 182e-12.Meter(),
            MeanAtomicRadius = 152e-12.Meter(),
            ElectroNegativity = 0.98,
            OxidationStates = [1, 0],
            ElectronConfiguration = new([
                new(1, ElectronOrbital.S, 2),
                new(2, ElectronOrbital.S, 1),
            ]),
        },
        Electromagnetics = new()
        {
            CurieTemperature = null,
            ElectricalResistivity = 92.8e-9.OhmMeter(),
            MagneticOrdering = MagneticOrdering.Paramagnetic,
            MagneticSusceptibility = 14.2e6.CubicCentimeterPerMol(),
        },
        Optics = new()
        {
            RefractiveIndex = 1.000057,
            EmissionSpectrum = new SparseSpectrum([
                (149.293d.Nanometer(), 0.0008333333333333334),
                (149.297d.Nanometer(), 0.001388888888888889),
                (149.304d.Nanometer(), 0.0002777777777777778),
                (165.308d.Nanometer(), 0.0008333333333333334),
                (165.313d.Nanometer(), 0.001388888888888889),
                (165.321d.Nanometer(), 0.0002777777777777778),
                (233.688d.Nanometer(), 0.0008333333333333334),
                (233.691d.Nanometer(), 0.001388888888888889),
                (233.7d.Nanometer(), 0.0005555555555555556),
                (239.439d.Nanometer(), 0.0002777777777777778),
                (242.543d.Nanometer(), 0.0008333333333333334),
                (247.506d.Nanometer(), 0.002777777777777778),
                (255.17d.Nanometer(), 0.006666666666666667),
                (256.231d.Nanometer(), 0.004166666666666667),
                (265.729d.Nanometer(), 0.0005555555555555556),
                (265.73d.Nanometer(), 0.0008333333333333334),
                (272.829d.Nanometer(), 0.001388888888888889),
                (272.832d.Nanometer(), 0.0005555555555555556),
                (273.047d.Nanometer(), 0.0008333333333333334),
                (273.055d.Nanometer(), 0.0002777777777777778),
                (274.12d.Nanometer(), 0.001388888888888889),
                (293.402d.Nanometer(), 0.0005555555555555556),
                (293.407d.Nanometer(), 0.0005555555555555556),
                (293.412d.Nanometer(), 0.001388888888888889),
                (293.425d.Nanometer(), 0.0002777777777777778),
                (302.912d.Nanometer(), 0.0008333333333333334),
                (302.914d.Nanometer(), 0.0008333333333333334),
                (315.531d.Nanometer(), 0.0008333333333333334),
                (315.533d.Nanometer(), 0.0011111111111111111),
                (319.626d.Nanometer(), 0.0002777777777777778),
                (319.633d.Nanometer(), 0.0025),
                (319.636d.Nanometer(), 0.0011111111111111111),
                (319.933d.Nanometer(), 0.001388888888888889),
                (319.943d.Nanometer(), 0.0005555555555555556),
                (323.266d.Nanometer(), 0.004722222222222222),
                (371.4d.Nanometer(), 0.0002777777777777778),
                (371.416d.Nanometer(), 0.001388888888888889),
                (371.427d.Nanometer(), 0.0016666666666666668),
                (371.429d.Nanometer(), 0.0022222222222222222),
                (371.44d.Nanometer(), 0.0019444444444444444),
                (371.441d.Nanometer(), 0.002777777777777778),
                (371.451d.Nanometer(), 0.0002777777777777778),
                (371.87d.Nanometer(), 0.0008333333333333334),
                (379.472d.Nanometer(), 0.0016666666666666668),
                (391.53d.Nanometer(), 0.005555555555555556),
                (391.535d.Nanometer(), 0.005555555555555556),
                (398.548d.Nanometer(), 0.002777777777777778),
                (398.554d.Nanometer(), 0.002777777777777778),
                (413.256d.Nanometer(), 0.011111111111111112),
                (413.262d.Nanometer(), 0.011111111111111112),
                (427.307d.Nanometer(), 0.005555555555555556),
                (427.313d.Nanometer(), 0.005555555555555556),
                (432.542d.Nanometer(), 0.001388888888888889),
                (432.547d.Nanometer(), 0.001388888888888889),
                (432.554d.Nanometer(), 0.0002777777777777778),
                (460.283d.Nanometer(), 0.003611111111111111),
                (460.289d.Nanometer(), 0.003611111111111111),
                (467.165d.Nanometer(), 0.0016666666666666668),
                (467.17d.Nanometer(), 0.0005555555555555556),
                (467.806d.Nanometer(), 0.0008333333333333334),
                (467.829d.Nanometer(), 0.0002777777777777778),
                (488.132d.Nanometer(), 0.0011111111111111111),
                (488.139d.Nanometer(), 0.0011111111111111111),
                (488.149d.Nanometer(), 0.0002777777777777778),
                (497.166d.Nanometer(), 0.0022222222222222222),
                (497.175d.Nanometer(), 0.0022222222222222222),
                (548.355d.Nanometer(), 0.16666666666666666),
                (548.565d.Nanometer(), 0.16666666666666666),
                (610.354d.Nanometer(), 0.08888888888888889),
                (610.365d.Nanometer(), 0.08888888888888889),
                (670.776d.Nanometer(), 1),
                (670.791d.Nanometer(), 1),
                (812.623d.Nanometer(), 0.013333333333333334),
                (812.645d.Nanometer(), 0.013333333333333334),
            ]),
        },
    }).AddIsotopes([
        new()
        {
            NeutronCount = 1,
            Spin = 2,
            Decays = [
                new(DecayMode.ProtonEmission, 91e-24.Second()),
            ],
        },
        new()
        {
            NeutronCount = 2,
            Spin = 1.5,
            Decays = [
                new(DecayMode.ProtonEmission, 370e-24.Second()),
            ],
        },
        new()
        {
            NeutronCount = 3,
            Spin = 1,
            Decays = [],
            Abundance = .019,
        },
        new()
        {
            NeutronCount = 4,
            Spin = 0,
            Decays = [],
            Abundance = .922,
        },
        new()
        {
            NeutronCount = 5,
            Spin = 2,
            Decays = [
                new(DecayMode.Beta, .8387.Second()),
            ],
        },
        new()
        {
            NeutronCount = 6,
            Spin = 1.5,
            Decays = [
                new(DecayMode.BetaNeutronEmission, .1782.Second(), 50.5),
                new(DecayMode.Beta, .1782.Second(), 49.5),
            ],
        },
        new()
        {
            NeutronCount = 8,
            Spin = 1.5,
            Decays = [
                new(DecayMode.BetaNeutronEmission, .00875.Second(), .863),
                new(DecayMode.Beta, .00875.Second(), .06),
                new(DecayMode.BetaDoubleNeutronEmission, .00875.Second(), .041),
                new(DecayMode.BetaTripleNeutronEmission, .00875.Second(), .019),
                new(DecayMode.BetaAlpha, .00875.Second(), .017),
                new(DecayMode.BetaDeuteronEmission, .00875.Second(), .013),
                new(DecayMode.BetaTritonEmission, .00875.Second(), .0093),
            ],
        },
        new()
        {
            NeutronCount = 9,
            Spin = 1,
            Decays = [
                new(DecayMode.NeutronEmission, 3e-9.Second()),
            ],
        },
    ]);

    #endregion
    #region 4 Be - BERYLLIUM

    public static Element Beryllium { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Beryllium),
        Symbol = "Be",
        AtomicNumber = 4,
        Category = ElementCategory.AlkalineEarthMetal,
        Thermodynamics = new()
        {
            MeltingPoint = 1556d.Kelvin(),
            BoilingPoint = 2742d.Kelvin(),
            TriplePoint = null,
            CriticalPoint = (5205d.Kelvin(), 1.44e7.Pascal()),
            HeatOfFusion = 12.2e3.JoulePerMol(),
            HeatOfVaporization = 297e3.JoulePerMol(),
            IonizationEnergies = [
                899.5e3.JoulePerMol(),
                1_757.1e3.JoulePerMol(),
                14_848.7e3.JoulePerMol(),
                21_006.6e3.JoulePerMol(),
            ],
            ThermalCapacity = null,
            ThermalConductivity = 200d.WattPerMeterKelvin(),
            ThermalExpansion = 10.98e-6.InverseKelvin(),
        },
        StandardDensity = 1.845.GramPerCubicCentimeter(),
        Kinematics = new()
        {
            BrinellHardness = 5.8e9.Pascal(),
            BulkModulus = 130e9.Pascal(),
            ShearModulus = 132e9.Pascal(),
            YoungModulus = 287e9.Pascal(),
            SpeedOfSound = 12_890d.MeterPerSecond(),
            PoissonRatio = 0.032,
            VickersHardness = 1670e6.Pascal(),
        },
        ChemicalBonding = new()
        {
            CovalentRadius = 96e-12.Meter(),
            VanDerWaalsRadius = 153e-12.Meter(),
            MeanAtomicRadius = 112e-12.Meter(),
            ElectroNegativity = 1.57,
            OxidationStates = [2, 0, 1],
            ElectronConfiguration = new([
                new(1, ElectronOrbital.S, 2),
                new(2, ElectronOrbital.S, 2),
            ]),
        },
        Electromagnetics = new()
        {
            CurieTemperature = null,
            ElectricalResistivity = 36e-9.OhmMeter(),
            MagneticOrdering = MagneticOrdering.Diamagnetic,
            MagneticSusceptibility = -9e-6.CubicCentimeterPerMol(),
        },
        Optics = new()
        {
            RefractiveIndex = 3.3613,
            EmissionSpectrum = new SparseSpectrum([
                (7.61d.Nanometer(), 0.000423728813559322),
                (7.648d.Nanometer(), 0.000847457627118644),
                (7.853d.Nanometer(), 0.001271186440677966),
                (7.866d.Nanometer(), 0.001694915254237288),
                (7.892d.Nanometer(), 0.000423728813559322),
                (8.189d.Nanometer(), 0.00211864406779661),
                (8.238d.Nanometer(), 0.00423728813559322),
                (8.32d.Nanometer(), 0.00847457627118644),
                (8.476d.Nanometer(), 0.012711864406779662),
                (8.831d.Nanometer(), 0.0211864406779661),
                (9.253d.Nanometer(), 0.001694915254237288),
                (9.316d.Nanometer(), 0.004661016949152543),
                (9.343d.Nanometer(), 0.004661016949152543),
                (9.371d.Nanometer(), 0.0029661016949152543),
                (9.393d.Nanometer(), 0.000847457627118644),
                (9.456d.Nanometer(), 0.003389830508474576),
                (9.479d.Nanometer(), 0.008898305084745763),
                (9.534d.Nanometer(), 0.003389830508474576),
                (9.562d.Nanometer(), 0.00847457627118644),
                (9.5734d.Nanometer(), 0.01059322033898305),
                (9.577d.Nanometer(), 0.00847457627118644),
                (9.602d.Nanometer(), 0.00211864406779661),
                (9.625d.Nanometer(), 0.006355932203389831),
                (9.744d.Nanometer(), 0.001271186440677966),
                (9.786d.Nanometer(), 0.00211864406779661),
                (9.788d.Nanometer(), 0.0029661016949152543),
                (9.907d.Nanometer(), 0.00211864406779661),
                (10.025d.Nanometer(), 0.0423728813559322),
                (10.055d.Nanometer(), 0.01059322033898305),
                (10.0778d.Nanometer(), 0.01059322033898305),
                (10.086d.Nanometer(), 0.00211864406779661),
                (10.0949d.Nanometer(), 0.01694915254237288),
                (10.12d.Nanometer(), 0.002542372881355932),
                (10.175d.Nanometer(), 0.00423728813559322),
                (10.213d.Nanometer(), 0.00423728813559322),
                (10.235d.Nanometer(), 0.00211864406779661),
                (10.249d.Nanometer(), 0.00211864406779661),
                (10.401d.Nanometer(), 0.006355932203389831),
                (10.44d.Nanometer(), 0.0211864406779661),
                (10.465d.Nanometer(), 0.014830508474576272),
                (10.726d.Nanometer(), 0.00423728813559322),
                (10.738d.Nanometer(), 0.00423728813559322),
                (50.999d.Nanometer(), 0.001271186440677966),
                (54.931d.Nanometer(), 0.000847457627118644),
                (58.208d.Nanometer(), 0.002542372881355932),
                (60.15d.Nanometer(), 0.000423728813559322),
                (60.41d.Nanometer(), 0.000423728813559322),
                (60.96d.Nanometer(), 0.000423728813559322),
                (66.132d.Nanometer(), 0.001694915254237288),
                (66.45d.Nanometer(), 0.000423728813559322),
                (67.559d.Nanometer(), 0.003389830508474576),
                (71.42d.Nanometer(), 0.00211864406779661),
                (71.46d.Nanometer(), 0.00211864406779661),
                (71.64d.Nanometer(), 0.001271186440677966),
                (72.559d.Nanometer(), 0.001694915254237288),
                (72.571d.Nanometer(), 0.1059322033898305),
                (73.64d.Nanometer(), 0.00211864406779661),
                (74.2d.Nanometer(), 0.001271186440677966),
                (74.3579d.Nanometer(), 0.0635593220338983),
                (74.623d.Nanometer(), 0.0029661016949152543),
                (75.44d.Nanometer(), 0.001271186440677966),
                (76.775d.Nanometer(), 0.000847457627118644),
                (77.5375d.Nanometer(), 0.0847457627118644),
                (80.31d.Nanometer(), 0.001271186440677966),
                (81.3d.Nanometer(), 0.001271186440677966),
                (84.2057d.Nanometer(), 0.1483050847457627),
                (86.71d.Nanometer(), 0.007203389830508475),
                (87.75d.Nanometer(), 0.000423728813559322),
                (92.38d.Nanometer(), 0.001271186440677966),
                (92.5246d.Nanometer(), 0.1059322033898305),
                (94.3559d.Nanometer(), 0.0847457627118644),
                (94.9746d.Nanometer(), 0.0211864406779661),
                (96d.Nanometer(), 0.001271186440677966),
                (97.3266d.Nanometer(), 0.1059322033898305),
                (98.17d.Nanometer(), 0.0029661016949152543),
                (98.4025d.Nanometer(), 0.0423728813559322),
                (100.65d.Nanometer(), 0.001271186440677966),
                (102.01d.Nanometer(), 0.001271186440677966),
                (102.6926d.Nanometer(), 0.1271186440677966),
                (103.6271d.Nanometer(), 0.1694915254237288),
                (104.8234d.Nanometer(), 0.1271186440677966),
                (111.18d.Nanometer(), 0.0038135593220338985),
                (111.469d.Nanometer(), 0.000423728813559322),
                (114.2956d.Nanometer(), 0.1483050847457627),
                (114.303d.Nanometer(), 0.1483050847457627),
                (115.59d.Nanometer(), 0.01694915254237288),
                (118.75d.Nanometer(), 0.0038135593220338985),
                (119.719d.Nanometer(), 0.211864406779661),
                (121.312d.Nanometer(), 0.000847457627118644),
                (121.432d.Nanometer(), 0.000423728813559322),
                (136.225d.Nanometer(), 0.000847457627118644),
                (140.152d.Nanometer(), 0.000423728813559322),
                (142.126d.Nanometer(), 0.00423728813559322),
                (142.286d.Nanometer(), 0.00211864406779661),
                (142.6117d.Nanometer(), 0.001694915254237288),
                (143.517d.Nanometer(), 0.000423728813559322),
                (144.077d.Nanometer(), 0.000847457627118644),
                (149.1762d.Nanometer(), 0.003389830508474576),
                (151.2258d.Nanometer(), 0.3432203389830508),
                (151.2412d.Nanometer(), 0.4067796610169492),
                (166.1478d.Nanometer(), 0.012711864406779662),
                (175.469d.Nanometer(), 0.000847457627118644),
                (177.61d.Nanometer(), 0.2584745762711864),
                (177.6307d.Nanometer(), 0.3432203389830508),
                (190.712d.Nanometer(), 0.000847457627118644),
                (191.249d.Nanometer(), 0.001271186440677966),
                (191.703d.Nanometer(), 0.001271186440677966),
                (191.976d.Nanometer(), 0.00211864406779661),
                (192.967d.Nanometer(), 0.0029661016949152543),
                (194.368d.Nanometer(), 0.004661016949152543),
                (195.497d.Nanometer(), 0.025423728813559324),
                (195.663d.Nanometer(), 0.000847457627118644),
                (196.459d.Nanometer(), 0.008050847457627118),
                (198.513d.Nanometer(), 0.0029661016949152543),
                (199.801d.Nanometer(), 0.00847457627118644),
                (203.265d.Nanometer(), 0.0038135593220338985),
                (205.5902d.Nanometer(), 0.004661016949152543),
                (205.6012d.Nanometer(), 0.005508474576271186),
                (207.694d.Nanometer(), 0.03177966101694915),
                (208.038d.Nanometer(), 0.025423728813559324),
                (211.856d.Nanometer(), 0.01059322033898305),
                (212.227d.Nanometer(), 0.006355932203389831),
                (212.5568d.Nanometer(), 0.001271186440677966),
                (212.5685d.Nanometer(), 0.00211864406779661),
                (212.72d.Nanometer(), 0.006355932203389831),
                (213.725d.Nanometer(), 0.00211864406779661),
                (214.735d.Nanometer(), 0.000423728813559322),
                (216.1275d.Nanometer(), 0.0211864406779661),
                (217.4986d.Nanometer(), 0.005508474576271186),
                (217.5103d.Nanometer(), 0.006355932203389831),
                (219.157d.Nanometer(), 0.00211864406779661),
                (219.4249d.Nanometer(), 0.000847457627118644),
                (229.697d.Nanometer(), 0.1059322033898305),
                (232.46d.Nanometer(), 0.01694915254237288),
                (233.023d.Nanometer(), 0.000847457627118644),
                (233.65d.Nanometer(), 0.001271186440677966),
                (234.860415d.Nanometer(), 0.01694915254237288),
                (235.0661d.Nanometer(), 0.0029661016949152543),
                (235.0703d.Nanometer(), 0.004661016949152543),
                (235.0829d.Nanometer(), 0.006355932203389831),
                (241.334d.Nanometer(), 0.00423728813559322),
                (241.3455d.Nanometer(), 0.08898305084745763),
                (245.3844d.Nanometer(), 0.13135593220338984),
                (248.1319d.Nanometer(), 0.0038135593220338985),
                (249.4543d.Nanometer(), 0.005508474576271186),
                (249.4583d.Nanometer(), 0.007203389830508475),
                (249.4728d.Nanometer(), 0.00847457627118644),
                (250.7429d.Nanometer(), 0.08898305084745763),
                (256.29d.Nanometer(), 0.00211864406779661),
                (259.92d.Nanometer(), 0.004661016949152543),
                (261.7985d.Nanometer(), 0.046610169491525424),
                (261.8133d.Nanometer(), 0.13135593220338984),
                (265.0454d.Nanometer(), 0.005084745762711864),
                (265.055d.Nanometer(), 0.004661016949152543),
                (265.0613d.Nanometer(), 0.005084745762711864),
                (265.0619d.Nanometer(), 0.006355932203389831),
                (265.0694d.Nanometer(), 0.004661016949152543),
                (265.076d.Nanometer(), 0.005508474576271186),
                (269.7455d.Nanometer(), 0.046610169491525424),
                (269.7585d.Nanometer(), 0.13135593220338984),
                (272.8877d.Nanometer(), 0.13135593220338984),
                (273.805d.Nanometer(), 0.0038135593220338985),
                (276.42d.Nanometer(), 0.001271186440677966),
                (277.5d.Nanometer(), 0.000423728813559322),
                (282.88d.Nanometer(), 0.000423728813559322),
                (284.53d.Nanometer(), 0.001271186440677966),
                (289.8127d.Nanometer(), 0.00211864406779661),
                (289.8188d.Nanometer(), 0.001271186440677966),
                (289.8254d.Nanometer(), 0.0029661016949152543),
                (298.6062d.Nanometer(), 0.004661016949152543),
                (298.6418d.Nanometer(), 0.00423728813559322),
                (298.662d.Nanometer(), 0.0029661016949152543),
                (301.9333d.Nanometer(), 0.005084745762711864),
                (301.9492d.Nanometer(), 0.0038135593220338985),
                (301.9526d.Nanometer(), 0.0038135593220338985),
                (301.9599d.Nanometer(), 0.0029661016949152543),
                (304.6524d.Nanometer(), 0.08898305084745763),
                (304.6691d.Nanometer(), 0.17372881355932204),
                (308.9826d.Nanometer(), 0.001271186440677966),
                (309.0023d.Nanometer(), 0.00211864406779661),
                (309.013d.Nanometer(), 0.00211864406779661),
                (311.0814d.Nanometer(), 0.00211864406779661),
                (311.0918d.Nanometer(), 0.00211864406779661),
                (311.0986d.Nanometer(), 0.0029661016949152543),
                (311.1068d.Nanometer(), 0.000847457627118644),
                (311.1235d.Nanometer(), 0.000847457627118644),
                (311.142d.Nanometer(), 0.001271186440677966),
                (311.985d.Nanometer(), 0.000847457627118644),
                (311.9968d.Nanometer(), 0.000847457627118644),
                (312.002d.Nanometer(), 0.001271186440677966),
                (312.4993d.Nanometer(), 0.001271186440677966),
                (312.5119d.Nanometer(), 0.001271186440677966),
                (313.04219d.Nanometer(), 1),
                (313.10667d.Nanometer(), 0.9152542372881356),
                (313.4763d.Nanometer(), 0.00211864406779661),
                (313.606d.Nanometer(), 0.001271186440677966),
                (313.8685d.Nanometer(), 0.0029661016949152543),
                (314.5425d.Nanometer(), 0.00211864406779661),
                (315.008d.Nanometer(), 0.001694915254237288),
                (316.0768d.Nanometer(), 0.0038135593220338985),
                (316.384d.Nanometer(), 0.000423728813559322),
                (316.8602d.Nanometer(), 0.002542372881355932),
                (317.987d.Nanometer(), 0.01059322033898305),
                (318.734d.Nanometer(), 0.001271186440677966),
                (319.383d.Nanometer(), 0.003389830508474576),
                (319.7103d.Nanometer(), 0.13135593220338984),
                (319.7149d.Nanometer(), 0.17372881355932204),
                (320.86d.Nanometer(), 0.004661016949152543),
                (322.039d.Nanometer(), 0.001694915254237288),
                (322.962d.Nanometer(), 0.0038135593220338985),
                (323.1d.Nanometer(), 0.00847457627118644),
                (323.3519d.Nanometer(), 0.00423728813559322),
                (324d.Nanometer(), 0.00847457627118644),
                (324.1625d.Nanometer(), 0.08898305084745763),
                (324.1827d.Nanometer(), 0.17372881355932204),
                (326.9038d.Nanometer(), 0.002542372881355932),
                (327.4584d.Nanometer(), 0.2584745762711864),
                (327.467d.Nanometer(), 0.17372881355932204),
                (328.2905d.Nanometer(), 0.00423728813559322),
                (332.1011d.Nanometer(), 0.014830508474576272),
                (332.1079d.Nanometer(), 0.01694915254237288),
                (332.134d.Nanometer(), 0.019067796610169493),
                (334.543d.Nanometer(), 0.003389830508474576),
                (336.7633d.Nanometer(), 0.004661016949152543),
                (337.99d.Nanometer(), 0.0038135593220338985),
                (340.54d.Nanometer(), 0.0038135593220338985),
                (343.5d.Nanometer(), 0.00211864406779661),
                (345.1372d.Nanometer(), 0.000423728813559322),
                (345.5183d.Nanometer(), 0.007203389830508475),
                (347.6564d.Nanometer(), 0.004661016949152543),
                (351.052d.Nanometer(), 0.0211864406779661),
                (351.5539d.Nanometer(), 0.007203389830508475),
                (353d.Nanometer(), 0.00211864406779661),
                (356.131d.Nanometer(), 0.00211864406779661),
                (362.4d.Nanometer(), 0.00211864406779661),
                (363.6d.Nanometer(), 0.00211864406779661),
                (366d.Nanometer(), 0.001271186440677966),
                (370.8d.Nanometer(), 0.00211864406779661),
                (372.036d.Nanometer(), 0.0423728813559322),
                (373.6298d.Nanometer(), 0.005508474576271186),
                (374.93d.Nanometer(), 0.00847457627118644),
                (381.3454d.Nanometer(), 0.009322033898305085),
                (386.513d.Nanometer(), 0.001271186440677966),
                (386.5423d.Nanometer(), 0.00211864406779661),
                (386.5513d.Nanometer(), 0.000423728813559322),
                (386.5722d.Nanometer(), 0.000847457627118644),
                (386.6025d.Nanometer(), 0.001271186440677966),
                (399.55d.Nanometer(), 0.004661016949152543),
                (424.914d.Nanometer(), 0.038135593220338986),
                (425.21d.Nanometer(), 0.004661016949152543),
                (425.305d.Nanometer(), 0.002542372881355932),
                (425.376d.Nanometer(), 0.00211864406779661),
                (425.412d.Nanometer(), 0.000847457627118644),
                (432.955d.Nanometer(), 0.01694915254237288),
                (433.317d.Nanometer(), 0.00211864406779661),
                (436.0663d.Nanometer(), 0.3432203389830508),
                (436.0988d.Nanometer(), 0.4067796610169492),
                (437.11d.Nanometer(), 0.007203389830508475),
                (440.401d.Nanometer(), 0.005084745762711864),
                (440.7935d.Nanometer(), 0.008050847457627118),
                (446.778d.Nanometer(), 0.005084745762711864),
                (447.654d.Nanometer(), 0.010169491525423728),
                (448.552d.Nanometer(), 0.000847457627118644),
                (448.73d.Nanometer(), 0.0423728813559322),
                (449.509d.Nanometer(), 0.000423728813559322),
                (449.78d.Nanometer(), 0.059322033898305086),
                (452.6409d.Nanometer(), 0.0029661016949152543),
                (453.54d.Nanometer(), 0.009322033898305085),
                (454.053d.Nanometer(), 0.010169491525423728),
                (454.778d.Nanometer(), 0.000847457627118644),
                (457.266605d.Nanometer(), 0.012711864406779662),
                (467.3329d.Nanometer(), 0.4491525423728814),
                (467.3423d.Nanometer(), 0.4915254237288136),
                (470.257d.Nanometer(), 0.016101694915254237),
                (470.937d.Nanometer(), 0.000847457627118644),
                (480.778d.Nanometer(), 0.005932203389830509),
                (482.8159d.Nanometer(), 0.3008474576271186),
                (484.916d.Nanometer(), 0.001271186440677966),
                (485.219d.Nanometer(), 0.025423728813559324),
                (485.822d.Nanometer(), 0.046610169491525424),
                (508.775d.Nanometer(), 0.00211864406779661),
                (521.8115d.Nanometer(), 0.046610169491525424),
                (521.8326d.Nanometer(), 0.13135593220338984),
                (525.586d.Nanometer(), 0.08898305084745763),
                (526.1525d.Nanometer(), 0.00211864406779661),
                (527.0284d.Nanometer(), 0.3432203389830508),
                (527.0811d.Nanometer(), 0.4067796610169492),
                (540.304d.Nanometer(), 0.13135593220338984),
                (541.0206d.Nanometer(), 0.13135593220338984),
                (585.701d.Nanometer(), 0.001271186440677966),
                (614.201d.Nanometer(), 0.059322033898305086),
                (622.911d.Nanometer(), 0.001271186440677966),
                (627.9427d.Nanometer(), 0.08898305084745763),
                (627.973d.Nanometer(), 0.17372881355932204),
                (647.3539d.Nanometer(), 0.0029661016949152543),
                (654.7886d.Nanometer(), 0.21610169491525424),
                (655.8365d.Nanometer(), 0.21610169491525424),
                (656.4521d.Nanometer(), 0.0038135593220338985),
                (663.644d.Nanometer(), 0.046610169491525424),
                (672.6d.Nanometer(), 0.000847457627118644),
                (675.672d.Nanometer(), 0.00423728813559322),
                (675.713d.Nanometer(), 0.046610169491525424),
                (678.6559d.Nanometer(), 0.0038135593220338985),
                (688.422d.Nanometer(), 0.000423728813559322),
                (688.444d.Nanometer(), 0.000847457627118644),
                (698.2749d.Nanometer(), 0.005508474576271186),
                (715.44d.Nanometer(), 0.000847457627118644),
                (715.465d.Nanometer(), 0.001271186440677966),
                (720.9134d.Nanometer(), 0.005508474576271186),
                (730.817d.Nanometer(), 0.000423728813559322),
                (740.12d.Nanometer(), 0.08898305084745763),
                (740.143d.Nanometer(), 0.046610169491525424),
                (749.83d.Nanometer(), 0.000847457627118644),
                (755.1898d.Nanometer(), 0.001271186440677966),
                (761.868d.Nanometer(), 0.001271186440677966),
                (761.8881d.Nanometer(), 0.00211864406779661),
                (779.2d.Nanometer(), 0.000847457627118644),
                (809.0061d.Nanometer(), 0.004661016949152543),
                (815.8993d.Nanometer(), 0.000423728813559322),
                (815.9243d.Nanometer(), 0.001271186440677966),
                (825.407d.Nanometer(), 0.00847457627118644),
                (828.707d.Nanometer(), 0.001271186440677966),
                (854.7366d.Nanometer(), 0.0038135593220338985),
                (854.7659d.Nanometer(), 0.004661016949152543),
                (880.137d.Nanometer(), 0.007203389830508475),
                (888.218d.Nanometer(), 0.000847457627118644),
                (919.045d.Nanometer(), 0.001271186440677966),
                (924.3916d.Nanometer(), 0.00211864406779661),
                (934.389d.Nanometer(), 0.00423728813559322),
                (939.274d.Nanometer(), 0.001271186440677966),
                (947.6426d.Nanometer(), 0.00423728813559322),
                (947.7029d.Nanometer(), 0.08898305084745763),
                (984.732d.Nanometer(), 0.0029661016949152543),
                (989.563d.Nanometer(), 0.001271186440677966),
                (989.596d.Nanometer(), 0.00211864406779661),
                (993.978d.Nanometer(), 0.00211864406779661),
                (1009.552d.Nanometer(), 0.08898305084745763),
                (1009.573d.Nanometer(), 0.13135593220338984),
                (1011.992d.Nanometer(), 0.21610169491525424),
                (1033.103d.Nanometer(), 0.00211864406779661),
                (1106.606d.Nanometer(), 0.0029661016949152543),
                (1106.646d.Nanometer(), 0.0038135593220338985),
                (1117.373d.Nanometer(), 0.00423728813559322),
                (1149.639d.Nanometer(), 0.0029661016949152543),
                (1162.516d.Nanometer(), 0.046610169491525424),
                (1166.025d.Nanometer(), 0.046610169491525424),
                (1209.536d.Nanometer(), 0.2584745762711864),
                (1209.818d.Nanometer(), 0.17372881355932204),
                (1464.392d.Nanometer(), 0.005508474576271186),
                (1464.475d.Nanometer(), 0.004661016949152543),
                (1615.772d.Nanometer(), 0.004661016949152543),
                (1785.538d.Nanometer(), 0.00211864406779661),
                (1785.663d.Nanometer(), 0.0029661016949152543),
                (1814.354d.Nanometer(), 0.005508474576271186),
                (1976.529d.Nanometer(), 0.0038135593220338985),
                (3025.814d.Nanometer(), 0.0038135593220338985),
                (3178.372d.Nanometer(), 0.0038135593220338985),
                (3178.737d.Nanometer(), 0.004661016949152543),
            ]),
        }
    }).AddIsotopes([
        new()
        {
            NeutronCount = 2,
            Spin = 0,
            Decays = [
                new(DecayMode.DoubleProtonEmission, 5e-21.Second()),
            ],
        },
        new()
        {
            NeutronCount = 3,
            Spin = 1.5,
            Decays = [
                new(DecayMode.ElectronCapture, 53.22.StandardDay()),
            ],
        },
        new()
        {
            NeutronCount = 4,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 81.9e-21.Second()),
            ],
        },
        new()
        {
            NeutronCount = 5,
            Spin = 1.5,
            Decays = [],
            Abundance = 1,
        },
        new()
        {
            NeutronCount = 6,
            Spin = 0,
            Decays = [
                new(DecayMode.Beta, 1.25e-21.Second()),
            ],
        },
        new()
        {
            NeutronCount = 7,
            Spin = .5,
            Decays = [
                new(DecayMode.Beta, 13.76.Second(), .967),
                new(DecayMode.BetaAlpha, 13.76.Second(), .033),
                new(DecayMode.DeuteronEmission, 13.76.Second(), .000013),
            ],
        },
        new()
        {
            NeutronCount = 8,
            Spin = 0,
            Decays = [
                new(DecayMode.Beta, .02146.Second(), .995),
                new(DecayMode.BetaNeutronEmission, .02146.Second(), .005),
            ],
        },
        new()
        {
            NeutronCount = 9,
            Spin = .5,
            Decays = [
                new(DecayMode.NeutronEmission, 1e-24.Second()),
            ],
        },
        new()
        {
            NeutronCount = 10,
            Spin = 0,
            Decays = [
                new(DecayMode.BetaNeutronEmission, .00453.Second(), .86),
                new(DecayMode.Beta, .00453.Second(), .09),
                new(DecayMode.BetaDoubleNeutronEmission, .00453.Second(), .05),
                new(DecayMode.BetaTritonEmission, .00453.Second(), .0002),
                new(DecayMode.BetaAlpha, .00453.Second(), .00004),
            ],
        },
        new()
        {
            NeutronCount = 11,
            Spin = 2.5,
            Decays = [
                new(DecayMode.NeutronEmission, 790e-24.Second()),
            ],
        },
        new()
        {
            NeutronCount = 12,
            Spin = 0,
            Decays = [
                new(DecayMode.DoubleNeutronEmission, 650e-24.Second()),
            ],
        },
    ]);

    #endregion
    #region 5 B  - BORON
    #endregion
    #region 6 C  - CARBON
    #endregion
    #region 7 N  - NITROGEN
    #endregion
    #region 8 O  - OXYGEN
    #endregion
    #region 9 F  - FLUORINE
    #endregion
    #region 10 Ne - NEON
    #endregion
    #region 11 Na - SODIUM
    #endregion
    #region 12 Mg - MAGNESIUM
    #endregion
    #region 13 Al - ALUMINIUM
    #endregion
    #region 14 Si - SILICON
    #endregion
    #region 15 P  - PHOSPHORUS
    #endregion
    #region 16 S  - SULFUR
    #endregion
    #region 17 Cl - CHLORINE
    #endregion
    #region 18 Ar - ARGON
    #endregion
    #region 19 K  - POTASSIUM
    #endregion
    #region 20 Ca - CALCIUM
    #endregion
    #region 21 Sc - SCANDIUM
    #endregion
    #region 22 Ti - TITANIUM
    #endregion
    #region 23 V  - VANADIUM
    #endregion
}
