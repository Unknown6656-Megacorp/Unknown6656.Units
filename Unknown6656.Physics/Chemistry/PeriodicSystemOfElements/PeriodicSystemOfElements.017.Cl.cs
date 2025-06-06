﻿using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Electricity;
using Unknown6656.Units.Kinematics;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Magnetism;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;
using Unknown6656.Units.Energy;

using Unknown6656.Physics.Optics;

namespace Unknown6656.Physics.Chemistry;


public sealed partial class PeriodicTableOfElements
{
    public static Element Chlorine { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Chlorine),
        Symbol = "Cl",
        CASNumber = "CAS7782-50-5",
        CIDNumber = 24526,
        AtomicNumber = 17,
        Category = ElementCategory.NonMetal,
        Occurrence = ElementOccurrence.Primordial,
        Abundance = new()
        {
            UniverseAbundance = .000001,
            SolarAbundance = .000008,
            MeteoriteAbundance = .00037,
            CrustalAbundance = .00017,
            OceanAbundance = .02,
            HumanBodyAbundance = .0012,
        },
        Thermodynamics = new()
        {
            MeltingPoint = 171.6.Kelvin(),
            BoilingPoint = 239.11.Kelvin(),
            StandardDensity = 3.2.GramPerLiter(),
            TriplePoint = (172.22.Kelvin(), 1392d.Pascal()),
            CriticalPoint = (416.9.Kelvin(), 7.991e6.Pascal()),
            HeatOfFusion = 6406d.JoulePerMol(),
            HeatOfVaporization = 20.41e3.JoulePerMol(),
            ThermalCapacity = 33.949.JoulePerMolKelvin(),
            IonizationEnergies = [
                1.2512e6.JoulePerMol(),
                2.298e6.JoulePerMol(),
                3.822e6.JoulePerMol(),
                5.1586e6.JoulePerMol(),
                6.542e6.JoulePerMol(),
                9.362e6.JoulePerMol(),
                11.018e6.JoulePerMol(),
                33.604e6.JoulePerMol(),
                38.6e6.JoulePerMol(),
                43.961e6.JoulePerMol(),
                51.068e6.JoulePerMol(),
                57.119e6.JoulePerMol(),
                63.363e6.JoulePerMol(),
                72.341e6.JoulePerMol(),
                78.095e6.JoulePerMol(),
                352.994e6.JoulePerMol(),
                380.76e6.JoulePerMol(),
            ],
            ThermalExpansion = null,
            ThermalConductivity = .0089.WattPerMeterKelvin(),
        },
        ChemicalBonding = new()
        {
            ElectronConfiguration = new([
                new(1, ElectronOrbital.S, 2),
                new(2, ElectronOrbital.S, 2),
                new(2, ElectronOrbital.P, 6),
                new(3, ElectronOrbital.S, 2),
                new(3, ElectronOrbital.P, 5),
            ]),
            Valence = 5,
            OxidationStates = [-1, 1, 2, 3, 4, 5, 6, 7],
            CommonOxidationStates = [-1, 1, 3, 5, 7],
            PaulingElectronegativity = 3.16,
            AllenElectronegativity = 2.869,
            MeanAtomicRadius = 100e-12.Meter(),
            CovalentRadius = 99e-12.Meter(),
            VanDerWaalsRadius = 175e-12.Meter(),
        },
        Electromagnetics = new()
        {
            CuriePoint = null,
            SuperconductingPoint = null,
            BandGap = null,
            ElectricalResistivity = 10d.OhmMeter(),
            ElectricalType = ElectricalElementType.Insulator,
            MagneticOrdering = MagneticOrdering.Diamagnetic,
            MagneticSusceptibility = -40.5e-6.CubicCentimeterPerMol(),
        },
        Kinematics = new()
        {
            YoungModulus = null,
            ShearModulus = null,
            BulkModulus = 1.1e9.Pascal(),
            PoissonRatio = null,
            BrinellHardness = null,
            VickersHardness = null,
            MohsHardness = null,
            SpeedOfSound = 206d.MeterPerSecond(),
        },
        Optics = new()
        {
            RefractiveIndex = 1.000773,
            ExtinctionCoefficient = 0,
            EmissionSpectrum = new SparseSpectrum([
                (28.733d.Nanometer(), 0.003003003003003003),
                (31.962d.Nanometer(), 0.003003003003003003),
                (33.184d.Nanometer(), 0.002002002002002002),
                (37.378d.Nanometer(), 0.003003003003003003),
                (39.015d.Nanometer(), 0.004004004004004004),
                (39.243d.Nanometer(), 0.005005005005005005),
                (40.627d.Nanometer(), 0.001001001001001001),
                (41.137d.Nanometer(), 0.004004004004004004),
                (41.181d.Nanometer(), 0.004004004004004004),
                (43.783d.Nanometer(), 0.004004004004004004),
                (46.486d.Nanometer(), 0.004004004004004004),
                (48.617d.Nanometer(), 0.008008008008008008),
                (53.473d.Nanometer(), 0.008008008008008008),
                (53.567d.Nanometer(), 0.007007007007007007),
                (53.615d.Nanometer(), 0.006006006006006006),
                (53.653d.Nanometer(), 0.003003003003003003),
                (53.701d.Nanometer(), 0.004004004004004004),
                (53.746d.Nanometer(), 0.003003003003003003),
                (53.761d.Nanometer(), 0.009009009009009009),
                (53.803d.Nanometer(), 0.005005005005005005),
                (53.812d.Nanometer(), 0.006006006006006006),
                (53.868d.Nanometer(), 0.004004004004004004),
                (54.223d.Nanometer(), 0.008008008008008008),
                (54.23d.Nanometer(), 0.006006006006006006),
                (54.287d.Nanometer(), 0.004004004004004004),
                (54.511d.Nanometer(), 0.01001001001001001),
                (54.633d.Nanometer(), 0.006006006006006006),
                (54.763d.Nanometer(), 0.01001001001001001),
                (54.922d.Nanometer(), 0.005005005005005005),
                (55.002d.Nanometer(), 0.004004004004004004),
                (55.202d.Nanometer(), 0.007007007007007007),
                (55.33d.Nanometer(), 0.006006006006006006),
                (55.462d.Nanometer(), 0.007007007007007007),
                (55.623d.Nanometer(), 0.006006006006006006),
                (55.661d.Nanometer(), 0.007007007007007007),
                (55.712d.Nanometer(), 0.007007007007007007),
                (55.9305d.Nanometer(), 0.0035035035035035035),
                (56.153d.Nanometer(), 0.007007007007007007),
                (56.168d.Nanometer(), 0.007007007007007007),
                (56.174d.Nanometer(), 0.007007007007007007),
                (57.1904d.Nanometer(), 0.004004004004004004),
                (57.4406d.Nanometer(), 0.008008008008008008),
                (58.624d.Nanometer(), 0.005005005005005005),
                (60.15d.Nanometer(), 0.005005005005005005),
                (60.459d.Nanometer(), 0.005005005005005005),
                (60.635d.Nanometer(), 0.005005005005005005),
                (60.89d.Nanometer(), 0.004004004004004004),
                (61.207d.Nanometer(), 0.004004004004004004),
                (61.8057d.Nanometer(), 0.007007007007007007),
                (61.9982d.Nanometer(), 0.006006006006006006),
                (62.0298d.Nanometer(), 0.008008008008008008),
                (62.128d.Nanometer(), 0.004004004004004004),
                (62.6735d.Nanometer(), 0.007007007007007007),
                (63.319d.Nanometer(), 0.004004004004004004),
                (63.532d.Nanometer(), 0.004004004004004004),
                (63.5881d.Nanometer(), 0.008008008008008008),
                (63.6626d.Nanometer(), 0.01001001001001001),
                (65.0894d.Nanometer(), 0.01001001001001001),
                (65.37d.Nanometer(), 0.004004004004004004),
                (65.9811d.Nanometer(), 0.01001001001001001),
                (66.1841d.Nanometer(), 0.013013013013013013),
                (66.3074d.Nanometer(), 0.02002002002002002),
                (67.038d.Nanometer(), 0.003003003003003003),
                (67.313d.Nanometer(), 0.003003003003003003),
                (68.192d.Nanometer(), 0.004004004004004004),
                (68.2053d.Nanometer(), 0.015015015015015015),
                (68.317d.Nanometer(), 0.004004004004004004),
                (68.7656d.Nanometer(), 0.015015015015015015),
                (68.893d.Nanometer(), 0.004004004004004004),
                (69.3594d.Nanometer(), 0.015015015015015015),
                (72.5271d.Nanometer(), 0.02002002002002002),
                (72.8951d.Nanometer(), 0.025025025025025027),
                (74.521d.Nanometer(), 0.004004004004004004),
                (77.7562d.Nanometer(), 0.02002002002002002),
                (78.758d.Nanometer(), 0.05005005005005005),
                (78.874d.Nanometer(), 0.05005005005005005),
                (79.3342d.Nanometer(), 0.05005005005005005),
                (83.143d.Nanometer(), 0.004004004004004004),
                (83.484d.Nanometer(), 0.005005005005005005),
                (83.497d.Nanometer(), 0.005005005005005005),
                (83.9297d.Nanometer(), 0.06006006006006006),
                (83.9599d.Nanometer(), 0.08008008008008008),
                (84.081d.Nanometer(), 0.004004004004004004),
                (84.093d.Nanometer(), 0.006006006006006006),
                (84.141d.Nanometer(), 0.07007007007007007),
                (85.1691d.Nanometer(), 0.05005005005005005),
                (88.313d.Nanometer(), 0.004004004004004004),
                (88.8026d.Nanometer(), 0.02002002002002002),
                (89.3549d.Nanometer(), 0.02002002002002002),
                (89.434d.Nanometer(), 0.004004004004004004),
                (89.491d.Nanometer(), 0.001001001001001001),
                (93.628d.Nanometer(), 0.001001001001001001),
                (96.1499d.Nanometer(), 0.02002002002002002),
                (96.992d.Nanometer(), 0.0003003003003003003),
                (97.321d.Nanometer(), 0.005005005005005005),
                (97.756d.Nanometer(), 0.006006006006006006),
                (97.79d.Nanometer(), 0.004004004004004004),
                (97.8284d.Nanometer(), 0.0004004004004004004),
                (98.495d.Nanometer(), 0.007007007007007007),
                (98.575d.Nanometer(), 0.004004004004004004),
                (99.8372d.Nanometer(), 0.00025025025025025025),
                (99.8432d.Nanometer(), 0.00025025025025025025),
                (100.2346d.Nanometer(), 0.0007507507507507507),
                (100.528d.Nanometer(), 0.005005005005005005),
                (100.878d.Nanometer(), 0.006006006006006006),
                (101.3664d.Nanometer(), 0.0015015015015015015),
                (101.502d.Nanometer(), 0.007007007007007007),
                (102.5553d.Nanometer(), 0.0009009009009009009),
                (106.3831d.Nanometer(), 0.06006006006006006),
                (106.7945d.Nanometer(), 0.03003003003003003),
                (107.1036d.Nanometer(), 0.09009009009009009),
                (107.1767d.Nanometer(), 0.06006006006006006),
                (107.523d.Nanometer(), 0.05005005005005005),
                (107.908d.Nanometer(), 0.05005005005005005),
                (108.4667d.Nanometer(), 0.002002002002002002),
                (108.5171d.Nanometer(), 0.002002002002002002),
                (108.5304d.Nanometer(), 0.0025025025025025025),
                (108.806d.Nanometer(), 0.004004004004004004),
                (109.0271d.Nanometer(), 0.0035035035035035035),
                (109.0982d.Nanometer(), 0.0025025025025025025),
                (109.2437d.Nanometer(), 0.0025025025025025025),
                (109.4769d.Nanometer(), 0.004004004004004004),
                (109.5148d.Nanometer(), 0.0035035035035035035),
                (109.5662d.Nanometer(), 0.0035035035035035035),
                (109.5797d.Nanometer(), 0.004004004004004004),
                (109.681d.Nanometer(), 0.0025025025025025025),
                (109.7369d.Nanometer(), 0.003003003003003003),
                (109.8068d.Nanometer(), 0.002002002002002002),
                (109.9523d.Nanometer(), 0.002002002002002002),
                (110.7528d.Nanometer(), 0.005005005005005005),
                (113.9214d.Nanometer(), 0.008008008008008008),
                (116.7148d.Nanometer(), 0.008008008008008008),
                (117.9293d.Nanometer(), 0.03003003003003003),
                (118.8774d.Nanometer(), 0.012012012012012012),
                (120.1353d.Nanometer(), 0.009009009009009009),
                (133.5726d.Nanometer(), 0.03003003003003003),
                (134.724d.Nanometer(), 0.1001001001001001),
                (135.1657d.Nanometer(), 0.05005005005005005),
                (136.3447d.Nanometer(), 0.12012012012012012),
                (137.3116d.Nanometer(), 0.025025025025025027),
                (137.9528d.Nanometer(), 0.2002002002002002),
                (138.9693d.Nanometer(), 0.2502502502502503),
                (138.9957d.Nanometer(), 0.2002002002002002),
                (139.6527d.Nanometer(), 0.12012012012012012),
                (144.147d.Nanometer(), 0.005005005005005005),
                (152.8569d.Nanometer(), 0.005005005005005005),
                (153.721d.Nanometer(), 0.003003003003003003),
                (153.93d.Nanometer(), 0.002002002002002002),
                (154.2942d.Nanometer(), 0.005005005005005005),
                (154.519d.Nanometer(), 0.002002002002002002),
                (154.915d.Nanometer(), 0.002002002002002002),
                (155.8144d.Nanometer(), 0.005005005005005005),
                (156.505d.Nanometer(), 0.005005005005005005),
                (162.286d.Nanometer(), 0.002002002002002002),
                (182.25d.Nanometer(), 0.006006006006006006),
                (182.84d.Nanometer(), 0.005005005005005005),
                (185.7488d.Nanometer(), 0.005005005005005005),
                (190.161d.Nanometer(), 0.005005005005005005),
                (198.361d.Nanometer(), 0.005005005005005005),
                (199.737d.Nanometer(), 0.0045045045045045045),
                (200.684d.Nanometer(), 0.004004004004004004),
                (203.2116d.Nanometer(), 0.0045045045045045045),
                (208.8583d.Nanometer(), 0.0035035035035035035),
                (209.1458d.Nanometer(), 0.0035035035035035035),
                (225.307d.Nanometer(), 0.007007007007007007),
                (226.895d.Nanometer(), 0.005005005005005005),
                (227.834d.Nanometer(), 0.005005005005005005),
                (228.393d.Nanometer(), 0.007007007007007007),
                (232.35d.Nanometer(), 0.006006006006006006),
                (233.645d.Nanometer(), 0.005005005005005005),
                (234.064d.Nanometer(), 0.006006006006006006),
                (235.967d.Nanometer(), 0.006006006006006006),
                (237.037d.Nanometer(), 0.006006006006006006),
                (241.642d.Nanometer(), 0.007007007007007007),
                (242.779d.Nanometer(), 0.0017017017017017016),
                (243.407d.Nanometer(), 0.0036036036036036037),
                (244.714d.Nanometer(), 0.006006006006006006),
                (244.858d.Nanometer(), 0.006006006006006006),
                (248.691d.Nanometer(), 0.005005005005005005),
                (249.853d.Nanometer(), 0.0034034034034034033),
                (250.274d.Nanometer(), 0.004704704704704705),
                (253.248d.Nanometer(), 0.005005005005005005),
                (254.696d.Nanometer(), 0.0026026026026026027),
                (254.988d.Nanometer(), 0.005005005005005005),
                (256.484d.Nanometer(), 0.004604604604604604),
                (258.067d.Nanometer(), 0.006006006006006006),
                (260.331d.Nanometer(), 0.0032032032032032033),
                (260.359d.Nanometer(), 0.005005005005005005),
                (263.267d.Nanometer(), 0.005005005005005005),
                (263.318d.Nanometer(), 0.005005005005005005),
                (265.872d.Nanometer(), 0.00950950950950951),
                (266.554d.Nanometer(), 0.006006006006006006),
                (267.695d.Nanometer(), 0.0075075075075075074),
                (268.804d.Nanometer(), 0.012012012012012012),
                (270.136d.Nanometer(), 0.004004004004004004),
                (271.037d.Nanometer(), 0.007007007007007007),
                (272.403d.Nanometer(), 0.005005005005005005),
                (275.123d.Nanometer(), 0.005005005005005005),
                (277.064d.Nanometer(), 0.004004004004004004),
                (278.247d.Nanometer(), 0.007007007007007007),
                (283.54d.Nanometer(), 0.004004004004004004),
                (291.205d.Nanometer(), 0.004104104104104104),
                (296.556d.Nanometer(), 0.006006006006006006),
                (299.665d.Nanometer(), 0.00950950950950951),
                (300.606d.Nanometer(), 0.005005005005005005),
                (305.796d.Nanometer(), 0.00950950950950951),
                (306.313d.Nanometer(), 0.005005005005005005),
                (307.132d.Nanometer(), 0.013013013013013013),
                (307.668d.Nanometer(), 0.006006006006006006),
                (309.219d.Nanometer(), 0.014014014014014014),
                (310.446d.Nanometer(), 0.006006006006006006),
                (312.372d.Nanometer(), 0.012012012012012012),
                (313.934d.Nanometer(), 0.008008008008008008),
                (316.787d.Nanometer(), 0.002002002002002002),
                (319.145d.Nanometer(), 0.009009009009009009),
                (328.98d.Nanometer(), 0.007007007007007007),
                (331.543d.Nanometer(), 0.01901901901901902),
                (332.057d.Nanometer(), 0.007007007007007007),
                (332.906d.Nanometer(), 0.008008008008008008),
                (332.91d.Nanometer(), 0.012012012012012012),
                (334.042d.Nanometer(), 0.009009009009009009),
                (335.335d.Nanometer(), 0.025025025025025027),
                (339.289d.Nanometer(), 0.008008008008008008),
                (339.345d.Nanometer(), 0.008008008008008008),
                (353.003d.Nanometer(), 0.009009009009009009),
                (356.068d.Nanometer(), 0.008008008008008008),
                (360.21d.Nanometer(), 0.009009009009009009),
                (361.285d.Nanometer(), 0.008008008008008008),
                (362.269d.Nanometer(), 0.007007007007007007),
                (365.695d.Nanometer(), 0.007007007007007007),
                (367.028d.Nanometer(), 0.007007007007007007),
                (368.205d.Nanometer(), 0.007007007007007007),
                (370.545d.Nanometer(), 0.006006006006006006),
                (370.734d.Nanometer(), 0.006006006006006006),
                (372.045d.Nanometer(), 0.008008008008008008),
                (372.654d.Nanometer(), 0.0002002002002002002),
                (374.881d.Nanometer(), 0.008008008008008008),
                (374.996d.Nanometer(), 0.012012012012012012),
                (377.935d.Nanometer(), 0.005005005005005005),
                (379.876d.Nanometer(), 0.015015015015015015),
                (380.518d.Nanometer(), 0.01901901901901902),
                (380.946d.Nanometer(), 0.013013013013013013),
                (382.02d.Nanometer(), 0.01701701701701702),
                (382.759d.Nanometer(), 0.028028028028028028),
                (383.335d.Nanometer(), 0.04504504504504504),
                (384.537d.Nanometer(), 0.031031031031031032),
                (384.565d.Nanometer(), 0.03903903903903904),
                (384.58d.Nanometer(), 0.015015015015015015),
                (385.099d.Nanometer(), 0.1001001001001001),
                (385.137d.Nanometer(), 0.07907907907907907),
                (385.165d.Nanometer(), 0.012012012012012012),
                (386.083d.Nanometer(), 0.2502502502502503),
                (386.099d.Nanometer(), 0.044044044044044044),
                (386.137d.Nanometer(), 0.01001001001001001),
                (391.387d.Nanometer(), 0.015015015015015015),
                (391.663d.Nanometer(), 0.011011011011011011),
                (392.587d.Nanometer(), 0.005005005005005005),
                (394.482d.Nanometer(), 0.0002002002002002002),
                (399.15d.Nanometer(), 0.007007007007007007),
                (401.85d.Nanometer(), 0.006006006006006006),
                (405.907d.Nanometer(), 0.006006006006006006),
                (410.423d.Nanometer(), 0.005005005005005005),
                (410.479d.Nanometer(), 0.0002002002002002002),
                (410.683d.Nanometer(), 0.005005005005005005),
                (413.25d.Nanometer(), 0.1001001001001001),
                (420.967d.Nanometer(), 0.0006506506506506507),
                (422.642d.Nanometer(), 0.0005005005005005005),
                (426.458d.Nanometer(), 0.0006006006006006006),
                (436.327d.Nanometer(), 0.001001001001001001),
                (436.95d.Nanometer(), 0.001001001001001001),
                (437.091d.Nanometer(), 0.004004004004004004),
                (437.293d.Nanometer(), 0.05005005005005005),
                (437.99d.Nanometer(), 0.001001001001001001),
                (438.975d.Nanometer(), 0.001001001001001001),
                (439.04d.Nanometer(), 0.0009009009009009009),
                (440.303d.Nanometer(), 0.0009009009009009009),
                (443.849d.Nanometer(), 0.001001001001001001),
                (447.53d.Nanometer(), 0.0009009009009009009),
                (448.991d.Nanometer(), 0.015015015015015015),
                (452.619d.Nanometer(), 0.001001001001001001),
                (460.098d.Nanometer(), 0.0008008008008008008),
                (460.821d.Nanometer(), 0.005005005005005005),
                (462.3938d.Nanometer(), 0.0004004004004004004),
                (465.404d.Nanometer(), 0.0005005005005005005),
                (466.1208d.Nanometer(), 0.0008008008008008008),
                (469.1523d.Nanometer(), 0.00045045045045045046),
                (470.314d.Nanometer(), 0.003003003003003003),
                (472.1255d.Nanometer(), 0.0004004004004004004),
                (474.0729d.Nanometer(), 0.00045045045045045046),
                (476.865d.Nanometer(), 0.043043043043043044),
                (478.132d.Nanometer(), 0.13013013013013014),
                (479.455d.Nanometer(), 0.990990990990991),
                (481.006d.Nanometer(), 0.2902902902902903),
                (481.947d.Nanometer(), 0.16016016016016016),
                (486.375d.Nanometer(), 0.001001001001001001),
                (489.677d.Nanometer(), 0.8108108108108109),
                (490.478d.Nanometer(), 0.47047047047047047),
                (491.773d.Nanometer(), 0.2602602602602603),
                (497.164d.Nanometer(), 0.0001001001001001001),
                (499.548d.Nanometer(), 0.1001001001001001),
                (507.826d.Nanometer(), 0.2602602602602603),
                (509.9789d.Nanometer(), 0.0003003003003003003),
                (521.794d.Nanometer(), 0.5605605605605606),
                (522.136d.Nanometer(), 0.23023023023023023),
                (539.212d.Nanometer(), 0.15015015015015015),
                (542.323d.Nanometer(), 0.990990990990991),
                (542.351d.Nanometer(), 0.1001001001001001),
                (544.337d.Nanometer(), 0.19019019019019018),
                (544.421d.Nanometer(), 0.1001001001001001),
                (545.702d.Nanometer(), 0.056056056056056056),
                (553.2162d.Nanometer(), 0.0004004004004004004),
                (579.6305d.Nanometer(), 0.0005005005005005005),
                (579.9914d.Nanometer(), 0.00045045045045045046),
                (585.6742d.Nanometer(), 0.0003003003003003003),
                (594.858d.Nanometer(), 0.001001001001001001),
                (601.9812d.Nanometer(), 0.0005005005005005005),
                (608.261d.Nanometer(), 0.0003503503503503503),
                (609.469d.Nanometer(), 0.01901901901901902),
                (611.443d.Nanometer(), 0.0016016016016016017),
                (614.0245d.Nanometer(), 0.002002002002002002),
                (619.4757d.Nanometer(), 0.0016016016016016017),
                (639.866d.Nanometer(), 0.0016016016016016017),
                (643.4833d.Nanometer(), 0.0015015015015015015),
                (653.143d.Nanometer(), 0.0015015015015015015),
                (666.167d.Nanometer(), 0.014014014014014014),
                (667.843d.Nanometer(), 0.0015015015015015015),
                (668.602d.Nanometer(), 0.013013013013013013),
                (671.341d.Nanometer(), 0.012012012012012012),
                (684.029d.Nanometer(), 0.0015015015015015015),
                (693.2903d.Nanometer(), 0.003003003003003003),
                (698.1886d.Nanometer(), 0.003003003003003003),
                (708.6814d.Nanometer(), 0.006006006006006006),
                (725.662d.Nanometer(), 0.07507507507507508),
                (741.411d.Nanometer(), 0.05005005005005005),
                (746.237d.Nanometer(), 0.0055055055055055055),
                (748.947d.Nanometer(), 0.0055055055055055055),
                (749.2118d.Nanometer(), 0.007007007007007007),
                (754.7072d.Nanometer(), 0.11011011011011011),
                (767.242d.Nanometer(), 0.023023023023023025),
                (770.2828d.Nanometer(), 0.0045045045045045045),
                (771.7581d.Nanometer(), 0.07007007007007007),
                (774.497d.Nanometer(), 0.1001001001001001),
                (776.916d.Nanometer(), 0.022022022022022022),
                (777.109d.Nanometer(), 0.0065065065065065065),
                (782.136d.Nanometer(), 0.022022022022022022),
                (783.075d.Nanometer(), 0.01701701701701702),
                (787.822d.Nanometer(), 0.03003003003003003),
                (789.334d.Nanometer(), 0.0022022022022022024),
                (789.931d.Nanometer(), 0.023023023023023025),
                (791.508d.Nanometer(), 0.018018018018018018),
                (792.4645d.Nanometer(), 0.03003003003003003),
                (793.389d.Nanometer(), 0.021021021021021023),
                (793.5012d.Nanometer(), 0.01701701701701702),
                (795.252d.Nanometer(), 0.0065065065065065065),
                (797.472d.Nanometer(), 0.015015015015015015),
                (797.697d.Nanometer(), 0.013013013013013013),
                (798.06d.Nanometer(), 0.006006006006006006),
                (799.785d.Nanometer(), 0.02902902902902903),
                (801.561d.Nanometer(), 0.022022022022022022),
                (802.333d.Nanometer(), 0.011011011011011011),
                (805.107d.Nanometer(), 0.004004004004004004),
                (808.451d.Nanometer(), 0.01701701701701702),
                (808.556d.Nanometer(), 0.022022022022022022),
                (808.667d.Nanometer(), 0.03003003003003003),
                (808.773d.Nanometer(), 0.013013013013013013),
                (809.467d.Nanometer(), 0.0025025025025025025),
                (819.442d.Nanometer(), 0.025025025025025027),
                (819.913d.Nanometer(), 0.022022022022022022),
                (820.021d.Nanometer(), 0.022022022022022022),
                (820.378d.Nanometer(), 0.008008008008008008),
                (821.204d.Nanometer(), 0.18018018018018017),
                (822.045d.Nanometer(), 0.03003003003003003),
                (822.174d.Nanometer(), 0.2002002002002002),
                (833.331d.Nanometer(), 0.18018018018018017),
                (836.071d.Nanometer(), 0.01001001001001001),
                (836.184d.Nanometer(), 0.005605605605605605),
                (837.594d.Nanometer(), 1),
                (838.267d.Nanometer(), 0.0018018018018018018),
                (839.202d.Nanometer(), 0.001001001001001001),
                (840.6199d.Nanometer(), 0.004004004004004004),
                (842.825d.Nanometer(), 0.15015015015015015),
                (846.734d.Nanometer(), 0.022022022022022022),
                (855.044d.Nanometer(), 0.022022022022022022),
                (857.524d.Nanometer(), 0.2002002002002002),
                (857.802d.Nanometer(), 0.0075075075075075074),
                (858.597d.Nanometer(), 0.7507507507507507),
                (862.854d.Nanometer(), 0.0045045045045045045),
                (864.171d.Nanometer(), 0.003003003003003003),
                (868.626d.Nanometer(), 0.035035035035035036),
                (891.292d.Nanometer(), 0.022022022022022022),
                (894.806d.Nanometer(), 0.03003003003003003),
                (903.8982d.Nanometer(), 0.02002002002002002),
                (904.543d.Nanometer(), 0.025025025025025027),
                (906.9656d.Nanometer(), 0.01001001001001001),
                (907.317d.Nanometer(), 0.02002002002002002),
                (912.115d.Nanometer(), 0.07507507507507508),
                (919.1731d.Nanometer(), 0.03003003003003003),
                (919.7596d.Nanometer(), 0.005005005005005005),
                (928.886d.Nanometer(), 0.04004004004004004),
                (939.3862d.Nanometer(), 0.015015015015015015),
                (945.21d.Nanometer(), 0.035035035035035036),
                (948.6964d.Nanometer(), 0.005005005005005005),
                (958.4801d.Nanometer(), 0.01001001001001001),
                (959.222d.Nanometer(), 0.035035035035035036),
                (963.2509d.Nanometer(), 0.0025025025025025025),
                (970.2439d.Nanometer(), 0.01001001001001001),
                (974.4426d.Nanometer(), 0.0025025025025025025),
                (980.7057d.Nanometer(), 0.002002002002002002),
                (987.597d.Nanometer(), 0.004004004004004004),
                (1039.2549d.Nanometer(), 0.0033133133133133132),
                (1043.283d.Nanometer(), 0.0003803803803803804),
                (1050.662d.Nanometer(), 0.0001001001001001001),
                (1050.912d.Nanometer(), 0.00014014014014014013),
                (1051.246d.Nanometer(), 0.0001901901901901902),
                (1051.417d.Nanometer(), 0.00025025025025025025),
                (1112.305d.Nanometer(), 0.003003003003003003),
                (1139.262d.Nanometer(), 0.0023123123123123123),
                (1140.969d.Nanometer(), 0.0026926926926926927),
                (1143.633d.Nanometer(), 0.01001001001001001),
                (1172.056d.Nanometer(), 0.0018018018018018018),
                (1186.676d.Nanometer(), 0.001951951951951952),
                (1202.17d.Nanometer(), 0.0017217217217217217),
                (1324.38d.Nanometer(), 0.0035035035035035035),
                (1329.6d.Nanometer(), 0.003103103103103103),
                (1334.68d.Nanometer(), 0.0055055055055055055),
                (1382.17d.Nanometer(), 0.005255255255255256),
                (1436.97d.Nanometer(), 0.0014814814814814814),
                (1493.17d.Nanometer(), 0.002942942942942943),
                (1510.8d.Nanometer(), 0.0026926926926926927),
                (1546.51d.Nanometer(), 0.0038138138138138137),
                (1546.76d.Nanometer(), 0.0016916916916916917),
                (1552.03d.Nanometer(), 0.010950950950950951),
                (1573.01d.Nanometer(), 0.014884884884884885),
                (1581.84d.Nanometer(), 0.001931931931931932),
                (1586.97d.Nanometer(), 0.027827827827827827),
                (1588.33d.Nanometer(), 0.0027727727727727726),
                (1592.89d.Nanometer(), 0.0034234234234234236),
                (1596d.Nanometer(), 0.007357357357357357),
                (1597.05d.Nanometer(), 0.0028328328328328326),
                (1607.76d.Nanometer(), 0.0012912912912912912),
                (1619.85d.Nanometer(), 0.0025925925925925925),
                (1937.03d.Nanometer(), 0.002272272272272272),
                (1975.53d.Nanometer(), 0.007177177177177177),
                (1976.68d.Nanometer(), 0.001851851851851852),
                (2020.49d.Nanometer(), 0.002272272272272272),
                (2037.57d.Nanometer(), 0.0008508508508508508),
                (2447.67d.Nanometer(), 0.001001001001001001),
            ]),
        }
    }).AddIsotopes([
        new()
        {
            NeutronCount = 12,
            Spin = 0.5,
            Decays = [new(DecayMode.ProtonEmission, 5.4e-21.Second())],
        },
        new()
        {
            NeutronCount = 13,
            Spin = 3,
            Decays = [new(DecayMode.ProtonEmission, 25e-7.Second())],
        },
        new()
        {
            NeutronCount = 14,
            Spin = 1.5,
            Decays = [
                new(DecayMode.PositronEmission, 190e-3.Second(), .976),
                new(DecayMode.PositronProtonEmission, 190e-3.Second(), .024)
            ],
        },
        new()
        {
            NeutronCount = 15,
            Spin = 1,
            Decays = [
                new(DecayMode.PositronEmission, 298e-3.Second(), .9992),
                new(DecayMode.PositronEmission, 298e-3.Second(), .00054),
                new(DecayMode.Alpha, 298e-3.Second(), .00054),
                new(DecayMode.PositronProtonEmission, 298e-3.Second(), .00026)
            ],
        },
        new()
        {
            NeutronCount = 16,
            Spin = 1.5,
            Decays = [new(DecayMode.PositronEmission, 2.5038.Second())],
        },
        new()
        {
            NeutronCount = 17,
            Spin = 0,
            Decays = [new(DecayMode.PositronEmission, 1.5267.Second())],
        },
        new()
        {
            NeutronCount = 18,
            Spin = 1.5,
            Abundance = 0.758,
            Decays = [],
        },
        new()
        {
            NeutronCount = 19,
            Spin = 2,
            Abundance = 7e-13,
            Decays = [
                new(DecayMode.Beta, 3.013e5.SolarYear(), .981),
                new(DecayMode.PositronEmission, 3.013e5.SolarYear(), .019)
            ],
        },
        new()
        {
            NeutronCount = 20,
            Spin = 1.5,
            Abundance = 0.242,
            Decays = [],
        },
        new()
        {
            NeutronCount = 21,
            Spin = -2,
            Decays = [new(DecayMode.Beta, 37.230.Minute())],
        },
        new()
        {
            NeutronCount = 22,
            Spin = 1.5,
            Decays = [new(DecayMode.Beta, 56.2.Minute())],
        },
        new()
        {
            NeutronCount = 23,
            Spin = -2,
            Decays = [new(DecayMode.Beta, 1.35.Minute())],
        },
        new()
        {
            NeutronCount = 24,
            Spin = 0.5,
            Decays = [
                new(DecayMode.Beta, 38.4.Second())],
        },
        new()
        {
            NeutronCount = 25,
            Spin = -2,
            Decays = [
                new(DecayMode.Beta, 6.8.Second()),
                new(DecayMode.BetaNeutronEmission, 6.8.Second())
            ],
        },
        new()
        {
            NeutronCount = 26,
            Spin = 1.5,
            Decays = [
                new(DecayMode.Beta, 3.13.Second()),
                new(DecayMode.BetaNeutronEmission, 3.13.Second())
            ],
        },
        new()
        {
            NeutronCount = 27,
            Spin = -2,
            Decays = [
                new(DecayMode.Beta, 0.56.Second(), .92),
                new(DecayMode.BetaNeutronEmission, 0.56.Second(), .08)
            ],
        },
        new ()
        {
            NeutronCount = 28,
            Spin = 1.5,
            Decays = [
                new (DecayMode.Beta, .513.Second(), .76),
                new (DecayMode.BetaNeutronEmission, .513.Second(), .24)
            ],
        },
        new()
        {
            NeutronCount = 29,
            Spin = -2,
            Decays = [
                new(DecayMode.BetaNeutronEmission, 232e-3.Second(), .6),
                new(DecayMode.Beta, 232e-3.Second(), .4),
                new(DecayMode.BetaDoubleNeutronEmission, 232e-3.Second(), 1e-6)
            ],
        },
        new()
        {
            NeutronCount = 30,
            Spin = 1.5,
            Decays = [
                new(DecayMode.Beta, 101e-3.Second(), .97),
                new(DecayMode.BetaNeutronEmission, 101e-3.Second(), .03),
                new(DecayMode.BetaDoubleNeutronEmission, 101e-3.Second(), 1e-6)
            ],
        },
        new()
        {
            NeutronCount = 31,
            Spin = 0,
            Decays = [
                new(DecayMode.Beta, .03.Second()),
                new(DecayMode.BetaNeutronEmission, .03.Second()),
                new(DecayMode.BetaDoubleNeutronEmission, .03.Second())
            ],
        },
        new()
        {
            NeutronCount = 32,
            Spin = 1.5,
            Decays = [
                new(DecayMode.Beta, .035.Second()),
                new(DecayMode.BetaNeutronEmission, .035.Second()),
                new(DecayMode.BetaDoubleNeutronEmission, .035.Second())
            ],
        },
        new()
        {
            NeutronCount = 33,
            Spin = 0,
            Decays = [
                new(DecayMode.Beta, 6.2e-7.Second()),
                new(DecayMode.BetaNeutronEmission, 6.2e-7.Second()),
                new(DecayMode.BetaDoubleNeutronEmission, 6.2e-7.Second())
            ],
        },
        new()
        {
            NeutronCount = 34,
            Spin = 1.5,
            Decays = [
                new(DecayMode.Beta, 1e-4.Second()),
                new(DecayMode.BetaNeutronEmission, 1e-4.Second()),
                new(DecayMode.BetaDoubleNeutronEmission, 1e-4.Second())
            ],
        },
        new()
        {
            NeutronCount = 35,
            Spin = 0,
            Decays = [
                new(DecayMode.Beta, 1e-4.Second()),
                new(DecayMode.BetaNeutronEmission, 1e-4.Second()),
                new(DecayMode.BetaDoubleNeutronEmission, 1e-4.Second())
            ],
        },
    ]);
}
