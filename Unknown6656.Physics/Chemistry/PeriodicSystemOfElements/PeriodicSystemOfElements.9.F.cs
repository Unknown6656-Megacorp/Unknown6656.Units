﻿using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Electricity;
using Unknown6656.Units.Kinematics;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Magnetism;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;

using Unknown6656.Physics.Optics;

namespace Unknown6656.Physics.Chemistry;


public sealed partial class PeriodicTableOfElements
{
    public static Element Flourine { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Flourine),
        Symbol = "F",
        AtomicNumber = 9,
        Category = ElementCategory.Halogen,
        Thermodynamics = new()
        {
            STPMeltingPoint = 53.48.Kelvin(),
            STPBoilingPoint = 85.03.Kelvin(),
            StandardDensity = 1.696.GramPerLiter(),
            TriplePoint = (53.48.Kelvin(), 252d.Pascal()),
            CriticalPoint = (144.41.Kelvin(), 5.1724e6.Pascal()),
            HeatOfFusion = null,
            HeatOfVaporization = 6.51e3.JoulePerMol(),
            ThermalCapacity = 31d.JoulePerMolKelvin(),
            IonizationEnergies = [
                1.6810e3.JoulePerMol(),
                3.3742e3.JoulePerMol(),
                6.0504e3.JoulePerMol(),
                8.4077e3.JoulePerMol(),
                11.0227e3.JoulePerMol(),
                15.1641e3.JoulePerMol(),
                17.868e3.JoulePerMol(),
                92.0381e3.JoulePerMol(),
                106.4343e3.JoulePerMol(),
            ],
            ThermalConductivity = .02591.WattPerMeterKelvin(),
            ThermalExpansion = null,
        },
        ChemicalBonding = new()
        {
            ElectronConfiguration = new([
                new(1, ElectronOrbital.S, 2),
                new(2, ElectronOrbital.S, 2),
                new(2, ElectronOrbital.P, 5),
            ]),
            OxidationStates = [-1, 0],
            ElectroNegativity = 3.98,
            CovalentRadius = 64e-12.Meter(),
            VanDerWaalsRadius = 135e-12.Meter(),
            MeanAtomicRadius = 50e-12.Meter(),
        },
        Electromagnetics = new()
        {
            CurieTemperature = null,
            ElectricalResistivity = null,
            MagneticOrdering = MagneticOrdering.Diamagnetic,
            MagneticSusceptibility = null,
        },
        Kinematics = new()
        {
            YoungModulus = null,
            ShearModulus = null,
            BulkModulus = null,
            SpeedOfSound = 332d.MeterPerSecond(),
        },
        Optics = new()
        {
            RefractiveIndex = 1.000108,
            EmissionSpectrum = new SparseSpectrum([
                (13.454d.Nanometer(), 0.0008),
                (14.795d.Nanometer(), 0.0008),
                (14.8d.Nanometer(), 0.001),
                (15.251d.Nanometer(), 0.0008),
                (15.854d.Nanometer(), 0.0008),
                (16.227d.Nanometer(), 0.0008),
                (16.35d.Nanometer(), 0.0008),
                (16.356d.Nanometer(), 0.001),
                (16.598d.Nanometer(), 0.0018),
                (16.618d.Nanometer(), 0.002),
                (16.979d.Nanometer(), 0.0006),
                (16.984d.Nanometer(), 0.0006),
                (17.107d.Nanometer(), 0.0006),
                (17.47d.Nanometer(), 0.0008),
                (17.637d.Nanometer(), 0.0008),
                (17.843d.Nanometer(), 0.001),
                (17.859d.Nanometer(), 0.0008),
                (18.152d.Nanometer(), 0.0008),
                (18.157d.Nanometer(), 0.0008),
                (18.298d.Nanometer(), 0.0008),
                (18.672d.Nanometer(), 0.0008),
                (18.679d.Nanometer(), 0.0008),
                (18.684d.Nanometer(), 0.001),
                (18.697d.Nanometer(), 0.0008),
                (18.701d.Nanometer(), 0.0008),
                (18.724d.Nanometer(), 0.0006),
                (19.057d.Nanometer(), 0.0012),
                (19.084d.Nanometer(), 0.0014),
                (19.197d.Nanometer(), 0.0008),
                (19.639d.Nanometer(), 0.001),
                (19.645d.Nanometer(), 0.0012),
                (19.976d.Nanometer(), 0.001),
                (19.98d.Nanometer(), 0.001),
                (19.985d.Nanometer(), 0.001),
                (19.993d.Nanometer(), 0.001),
                (20d.Nanometer(), 0.001),
                (20.009d.Nanometer(), 0.0014),
                (20.101d.Nanometer(), 0.0012),
                (20.106d.Nanometer(), 0.0014),
                (20.11d.Nanometer(), 0.0012),
                (20.116d.Nanometer(), 0.0016),
                (20.122d.Nanometer(), 0.0012),
                (20.555d.Nanometer(), 0.0008),
                (20.825d.Nanometer(), 0.0018),
                (21.385d.Nanometer(), 0.0014),
                (21.406d.Nanometer(), 0.0014),
                (22.077d.Nanometer(), 0.0014),
                (22.694d.Nanometer(), 0.0012),
                (22.71d.Nanometer(), 0.001),
                (23.012d.Nanometer(), 0.001),
                (23.322d.Nanometer(), 0.0012),
                (23.339d.Nanometer(), 0.001),
                (23.986d.Nanometer(), 0.0014),
                (24.002d.Nanometer(), 0.0014),
                (24.008d.Nanometer(), 0.0018),
                (24.015d.Nanometer(), 0.0014),
                (24.028d.Nanometer(), 0.0014),
                (24.037d.Nanometer(), 0.0014),
                (25.103d.Nanometer(), 0.002),
                (25.572d.Nanometer(), 0.001),
                (25.577d.Nanometer(), 0.0012),
                (25.586d.Nanometer(), 0.0014),
                (26.171d.Nanometer(), 0.0014),
                (26.175d.Nanometer(), 0.0012),
                (26.381d.Nanometer(), 0.0016),
                (27.023d.Nanometer(), 0.0012),
                (27.969d.Nanometer(), 0.0014),
                (31.522d.Nanometer(), 0.0016),
                (31.554d.Nanometer(), 0.0014),
                (31.575d.Nanometer(), 0.0012),
                (37.53d.Nanometer(), 0.0006),
                (38.09d.Nanometer(), 0.0006),
                (40.704d.Nanometer(), 0.0008),
                (41.965d.Nanometer(), 0.0028),
                (42.005d.Nanometer(), 0.003),
                (42.073d.Nanometer(), 0.0032),
                (42.951d.Nanometer(), 0.002),
                (43.015d.Nanometer(), 0.0022),
                (43.022d.Nanometer(), 0.0016),
                (43.076d.Nanometer(), 0.003),
                (43.091d.Nanometer(), 0.001),
                (43.155d.Nanometer(), 0.0008),
                (43.564d.Nanometer(), 0.0008),
                (45.718d.Nanometer(), 0.0014),
                (46.429d.Nanometer(), 0.0018),
                (46.437d.Nanometer(), 0.002),
                (46.511d.Nanometer(), 0.002),
                (46.537d.Nanometer(), 0.0022),
                (46.598d.Nanometer(), 0.0024),
                (46.699d.Nanometer(), 0.002),
                (47.195d.Nanometer(), 0.0008),
                (47.2d.Nanometer(), 0.0012),
                (47.271d.Nanometer(), 0.001),
                (47.302d.Nanometer(), 0.0008),
                (48.46d.Nanometer(), 0.0018),
                (49.057d.Nanometer(), 0.0026),
                (49.1d.Nanometer(), 0.0032),
                (49.738d.Nanometer(), 0.001),
                (49.783d.Nanometer(), 0.0012),
                (49.88d.Nanometer(), 0.0014),
                (50.616d.Nanometer(), 0.0018),
                (50.808d.Nanometer(), 0.002),
                (50.839d.Nanometer(), 0.0024),
                (51.364d.Nanometer(), 0.001),
                (51.397d.Nanometer(), 0.0014),
                (51.408d.Nanometer(), 0.0012),
                (51.494d.Nanometer(), 0.0014),
                (52.459d.Nanometer(), 0.0016),
                (52.529d.Nanometer(), 0.0018),
                (52.63d.Nanometer(), 0.002),
                (54.685d.Nanometer(), 0.0014),
                (54.787d.Nanometer(), 0.0012),
                (54.832d.Nanometer(), 0.001),
                (54.852d.Nanometer(), 0.0008),
                (56.769d.Nanometer(), 0.0024),
                (56.775d.Nanometer(), 0.0022),
                (57.064d.Nanometer(), 0.0028),
                (57.13d.Nanometer(), 0.0028),
                (57.139d.Nanometer(), 0.003),
                (57.266d.Nanometer(), 0.0032),
                (60.567d.Nanometer(), 0.0018),
                (60.629d.Nanometer(), 0.0016),
                (60.68d.Nanometer(), 0.002),
                (60.692d.Nanometer(), 0.0014),
                (60.747d.Nanometer(), 0.0016),
                (60.806d.Nanometer(), 0.0018),
                (63.014d.Nanometer(), 0.0016),
                (63.02d.Nanometer(), 0.0018),
                (64.767d.Nanometer(), 0.0014),
                (64.777d.Nanometer(), 0.002),
                (64.787d.Nanometer(), 0.0022),
                (64.797d.Nanometer(), 0.0014),
                (65.403d.Nanometer(), 0.0026),
                (65.612d.Nanometer(), 0.0024),
                (65.687d.Nanometer(), 0.0026),
                (65.723d.Nanometer(), 0.0022),
                (65.733d.Nanometer(), 0.0028),
                (65.833d.Nanometer(), 0.0028),
                (67.612d.Nanometer(), 0.0028),
                (67.715d.Nanometer(), 0.0026),
                (67.722d.Nanometer(), 0.003),
                (67.899d.Nanometer(), 0.0026),
                (67.921d.Nanometer(), 0.0032),
                (75.704d.Nanometer(), 0.0012),
                (78.039d.Nanometer(), 0.0003),
                (78.0519d.Nanometer(), 0.0002),
                (78.2378d.Nanometer(), 0.0002),
                (79.1875d.Nanometer(), 0.00024),
                (79.2536d.Nanometer(), 0.0002),
                (79.4417d.Nanometer(), 0.0002),
                (80.697d.Nanometer(), 0.003),
                (80.9607d.Nanometer(), 0.0025),
                (95.1871d.Nanometer(), 0.01),
                (95.4825d.Nanometer(), 0.02),
                (95.5545d.Nanometer(), 0.015),
                (95.8524d.Nanometer(), 0.01),
                (97.2401d.Nanometer(), 0.0004),
                (97.3895d.Nanometer(), 0.007),
                (97.6217d.Nanometer(), 0.002),
                (97.6505d.Nanometer(), 0.0008),
                (97.7745d.Nanometer(), 0.002),
                (108.231d.Nanometer(), 0.0012),
                (108.839d.Nanometer(), 0.0014),
                (112.976d.Nanometer(), 0.0008),
                (121.903d.Nanometer(), 0.0016),
                (126.687d.Nanometer(), 0.0016),
                (126.771d.Nanometer(), 0.0018),
                (129.754d.Nanometer(), 0.0014),
                (132.706d.Nanometer(), 0.0008),
                (132.811d.Nanometer(), 0.001),
                (133.359d.Nanometer(), 0.0008),
                (134.36d.Nanometer(), 0.001),
                (134.404d.Nanometer(), 0.0008),
                (135.992d.Nanometer(), 0.0014),
                (140.061d.Nanometer(), 0.001),
                (140.714d.Nanometer(), 0.0008),
                (149.309d.Nanometer(), 0.0012),
                (149.324d.Nanometer(), 0.001),
                (149.331d.Nanometer(), 0.0008),
                (149.893d.Nanometer(), 0.0022),
                (150.201d.Nanometer(), 0.0024),
                (150.418d.Nanometer(), 0.0022),
                (150.479d.Nanometer(), 0.0028),
                (150.63d.Nanometer(), 0.0026),
                (150.677d.Nanometer(), 0.0022),
                (155.302d.Nanometer(), 0.002),
                (155.759d.Nanometer(), 0.0022),
                (156.373d.Nanometer(), 0.002),
                (156.554d.Nanometer(), 0.002),
                (162.34d.Nanometer(), 0.002),
                (165.076d.Nanometer(), 0.002),
                (167.039d.Nanometer(), 0.0026),
                (167.74d.Nanometer(), 0.0028),
                (170.213d.Nanometer(), 0.0008),
                (171.699d.Nanometer(), 0.002),
                (174.475d.Nanometer(), 0.0008),
                (174.555d.Nanometer(), 0.001),
                (174.739d.Nanometer(), 0.0012),
                (177.009d.Nanometer(), 0.0024),
                (177.067d.Nanometer(), 0.003),
                (177.293d.Nanometer(), 0.0022),
                (177.336d.Nanometer(), 0.0028),
                (179.165d.Nanometer(), 0.0032),
                (180.303d.Nanometer(), 0.0022),
                (180.47d.Nanometer(), 0.002),
                (180.59d.Nanometer(), 0.0034),
                (183.93d.Nanometer(), 0.0022),
                (183.997d.Nanometer(), 0.0024),
                (184.014d.Nanometer(), 0.0022),
                (190.076d.Nanometer(), 0.0016),
                (202.744d.Nanometer(), 0.002),
                (203.032d.Nanometer(), 0.0024),
                (217.144d.Nanometer(), 0.0008),
                (221.717d.Nanometer(), 0.0024),
                (222.918d.Nanometer(), 0.0002),
                (225.272d.Nanometer(), 0.0004),
                (229.829d.Nanometer(), 0.001),
                (245.063d.Nanometer(), 0.0004),
                (245.158d.Nanometer(), 0.0008),
                (245.207d.Nanometer(), 0.0024),
                (245.692d.Nanometer(), 0.001),
                (246.133d.Nanometer(), 0.0002),
                (246.485d.Nanometer(), 0.0026),
                (247.029d.Nanometer(), 0.0026),
                (247.873d.Nanometer(), 0.0024),
                (248.437d.Nanometer(), 0.003),
                (254.277d.Nanometer(), 0.0024),
                (255.611d.Nanometer(), 0.002),
                (258.004d.Nanometer(), 0.0024),
                (258.381d.Nanometer(), 0.0026),
                (259.323d.Nanometer(), 0.0024),
                (259.553d.Nanometer(), 0.0026),
                (259.928d.Nanometer(), 0.0028),
                (262.501d.Nanometer(), 0.0026),
                (262.97d.Nanometer(), 0.0028),
                (265.644d.Nanometer(), 0.0024),
                (269.398d.Nanometer(), 0.0002),
                (270.23d.Nanometer(), 0.0002),
                (270.396d.Nanometer(), 0.0002),
                (270.717d.Nanometer(), 0.0004),
                (275.555d.Nanometer(), 0.0026),
                (275.963d.Nanometer(), 0.0032),
                (278.815d.Nanometer(), 0.0024),
                (281.145d.Nanometer(), 0.0032),
                (282.074d.Nanometer(), 0.0008),
                (282.613d.Nanometer(), 0.001),
                (283.399d.Nanometer(), 0.0028),
                (283.563d.Nanometer(), 0.003),
                (286.033d.Nanometer(), 0.003),
                (286.286d.Nanometer(), 0.0024),
                (287.14d.Nanometer(), 0.002),
                (288.758d.Nanometer(), 0.0028),
                (288.945d.Nanometer(), 0.003),
                (290.53d.Nanometer(), 0.0024),
                (291.329d.Nanometer(), 0.0028),
                (291.634d.Nanometer(), 0.0032),
                (293.249d.Nanometer(), 0.0028),
                (299.428d.Nanometer(), 0.0028),
                (299.721d.Nanometer(), 0.0024),
                (299.753d.Nanometer(), 0.0026),
                (299.947d.Nanometer(), 0.0024),
                (303.925d.Nanometer(), 0.0026),
                (303.975d.Nanometer(), 0.0024),
                (304.28d.Nanometer(), 0.0032),
                (304.914d.Nanometer(), 0.003),
                (305.999d.Nanometer(), 0.0024),
                (311.362d.Nanometer(), 0.0028),
                (311.57d.Nanometer(), 0.0032),
                (312.154d.Nanometer(), 0.0036),
                (312.479d.Nanometer(), 0.0028),
                (313.423d.Nanometer(), 0.0028),
                (314.699d.Nanometer(), 0.0028),
                (315.349d.Nanometer(), 0.0028),
                (317.417d.Nanometer(), 0.0036),
                (317.476d.Nanometer(), 0.0034),
                (320.276d.Nanometer(), 0.0034),
                (321.4d.Nanometer(), 0.0024),
                (326.408d.Nanometer(), 0.0028),
                (341.465d.Nanometer(), 0.0028),
                (341.645d.Nanometer(), 0.003),
                (341.68d.Nanometer(), 0.0028),
                (341.7d.Nanometer(), 0.0032),
                (347.296d.Nanometer(), 0.0032),
                (347.331d.Nanometer(), 0.003),
                (347.478d.Nanometer(), 0.0034),
                (350.139d.Nanometer(), 0.0038),
                (350.145d.Nanometer(), 0.004),
                (350.157d.Nanometer(), 0.004),
                (350.284d.Nanometer(), 0.0036),
                (350.296d.Nanometer(), 0.004),
                (350.311d.Nanometer(), 0.0042),
                (350.537d.Nanometer(), 0.0034),
                (350.552d.Nanometer(), 0.004),
                (350.563d.Nanometer(), 0.0044),
                (352.289d.Nanometer(), 0.0032),
                (353.687d.Nanometer(), 0.003),
                (354.177d.Nanometer(), 0.0032),
                (359.052d.Nanometer(), 0.0032),
                (359.4103d.Nanometer(), 0.00012),
                (359.869d.Nanometer(), 0.0034),
                (360.139d.Nanometer(), 0.0036),
                (360.284d.Nanometer(), 0.0038),
                (366.8174d.Nanometer(), 0.00024),
                (370.453d.Nanometer(), 0.0036),
                (371.035d.Nanometer(), 0.0032),
                (373.957d.Nanometer(), 0.0032),
                (380.583d.Nanometer(), 0.0028),
                (384.709d.Nanometer(), 0.0054),
                (384.999d.Nanometer(), 0.0052),
                (385.167d.Nanometer(), 0.005),
                (389.8478d.Nanometer(), 0.0001),
                (389.883d.Nanometer(), 0.0038),
                (390.193d.Nanometer(), 0.0036),
                (390.382d.Nanometer(), 0.0034),
                (393.0689d.Nanometer(), 0.00016),
                (393.4262d.Nanometer(), 0.0001),
                (394.8563d.Nanometer(), 0.0001),
                (397.204d.Nanometer(), 0.003),
                (397.267d.Nanometer(), 0.0032),
                (397.478d.Nanometer(), 0.0034),
                (402.473d.Nanometer(), 0.0048),
                (402.501d.Nanometer(), 0.0044),
                (402.549d.Nanometer(), 0.0046),
                (408.391d.Nanometer(), 0.0032),
                (410.307d.Nanometer(), 0.0038),
                (410.322d.Nanometer(), 0.0034),
                (410.351d.Nanometer(), 0.004),
                (410.371d.Nanometer(), 0.0036),
                (410.387d.Nanometer(), 0.0034),
                (410.916d.Nanometer(), 0.0034),
                (411.654d.Nanometer(), 0.0032),
                (411.921d.Nanometer(), 0.003),
                (420.715d.Nanometer(), 0.0028),
                (422.516d.Nanometer(), 0.0034),
                (424.412d.Nanometer(), 0.003),
                (424.623d.Nanometer(), 0.004),
                (424.639d.Nanometer(), 0.0038),
                (424.659d.Nanometer(), 0.0036),
                (424.677d.Nanometer(), 0.0034),
                (424.684d.Nanometer(), 0.0032),
                (427.536d.Nanometer(), 0.0034),
                (427.753d.Nanometer(), 0.0032),
                (427.893d.Nanometer(), 0.0032),
                (429.917d.Nanometer(), 0.004),
                (442.03d.Nanometer(), 0.0028),
                (442.735d.Nanometer(), 0.0024),
                (443.232d.Nanometer(), 0.0024),
                (444.653d.Nanometer(), 0.0032),
                (444.672d.Nanometer(), 0.0034),
                (444.719d.Nanometer(), 0.0036),
                (447.999d.Nanometer(), 0.0028),
                (473.438d.Nanometer(), 0.0028),
                (485.939d.Nanometer(), 0.0034),
                (493.326d.Nanometer(), 0.0032),
                (496.065d.Nanometer(), 0.00012),
                (500.2d.Nanometer(), 0.0028),
                (501.254d.Nanometer(), 0.003),
                (511.099d.Nanometer(), 0.0032),
                (517.325d.Nanometer(), 0.003),
                (523.041d.Nanometer(), 0.0003),
                (527.901d.Nanometer(), 0.00024),
                (554.052d.Nanometer(), 0.00036),
                (555.243d.Nanometer(), 0.00024),
                (557.733d.Nanometer(), 0.0002),
                (558.927d.Nanometer(), 0.0032),
                (562.406d.Nanometer(), 0.0004),
                (562.693d.Nanometer(), 0.00024),
                (565.915d.Nanometer(), 0.0003),
                (566.7532d.Nanometer(), 0.0008),
                (567.1668d.Nanometer(), 0.0018),
                (568.914d.Nanometer(), 0.00036),
                (570.082d.Nanometer(), 0.0005),
                (570.731d.Nanometer(), 0.0005),
                (575.317d.Nanometer(), 0.0028),
                (576.12d.Nanometer(), 0.0024),
                (595.0147d.Nanometer(), 0.00024),
                (595.9187d.Nanometer(), 0.0005),
                (596.528d.Nanometer(), 0.0014),
                (599.4425d.Nanometer(), 0.001),
                (601.5828d.Nanometer(), 0.003),
                (603.804d.Nanometer(), 0.0016),
                (604.754d.Nanometer(), 0.018),
                (608.0113d.Nanometer(), 0.002),
                (609.182d.Nanometer(), 0.003),
                (612.55d.Nanometer(), 0.0028),
                (614.976d.Nanometer(), 0.016),
                (621.087d.Nanometer(), 0.008),
                (623.357d.Nanometer(), 0.0026),
                (623.9651d.Nanometer(), 0.26),
                (624.79d.Nanometer(), 0.0028),
                (634.8508d.Nanometer(), 0.2),
                (636.305d.Nanometer(), 0.0028),
                (641.3651d.Nanometer(), 0.16),
                (646.35d.Nanometer(), 0.014),
                (656.9694d.Nanometer(), 0.009),
                (658.0389d.Nanometer(), 0.006),
                (665.0405d.Nanometer(), 0.008),
                (669.0481d.Nanometer(), 0.036),
                (670.8282d.Nanometer(), 0.008),
                (677.3984d.Nanometer(), 0.14),
                (679.5528d.Nanometer(), 0.03),
                (683.4264d.Nanometer(), 0.18),
                (685.603d.Nanometer(), 1),
                (687.0215d.Nanometer(), 0.16),
                (690.2475d.Nanometer(), 0.3),
                (690.9816d.Nanometer(), 0.12),
                (696.6349d.Nanometer(), 0.08),
                (703.7469d.Nanometer(), 0.9),
                (712.789d.Nanometer(), 0.6),
                (717.99d.Nanometer(), 0.0026),
                (720.236d.Nanometer(), 0.3),
                (721.179d.Nanometer(), 0.0026),
                (729.898d.Nanometer(), 0.03),
                (730.9033d.Nanometer(), 0.02),
                (731.1019d.Nanometer(), 0.3),
                (731.4303d.Nanometer(), 0.014),
                (733.1957d.Nanometer(), 0.1),
                (733.677d.Nanometer(), 0.0024),
                (735.494d.Nanometer(), 0.0026),
                (739.8688d.Nanometer(), 0.2),
                (742.5645d.Nanometer(), 0.08),
                (747.654d.Nanometer(), 0.014),
                (748.2723d.Nanometer(), 0.044),
                (748.9155d.Nanometer(), 0.05),
                (751.4919d.Nanometer(), 0.018),
                (755.2235d.Nanometer(), 0.1),
                (757.3384d.Nanometer(), 0.1),
                (760.717d.Nanometer(), 0.14),
                (775.4696d.Nanometer(), 0.36),
                (780.022d.Nanometer(), 0.3),
                (782.259d.Nanometer(), 0.016),
                (787.918d.Nanometer(), 0.006),
                (789.8588d.Nanometer(), 0.01),
                (793.093d.Nanometer(), 0.044),
                (793.6314d.Nanometer(), 0.007),
                (795.409d.Nanometer(), 0.012),
                (795.632d.Nanometer(), 0.006),
                (801.601d.Nanometer(), 0.0016),
                (804.0931d.Nanometer(), 0.02),
                (807.5519d.Nanometer(), 0.018),
                (807.7521d.Nanometer(), 0.007),
                (812.656d.Nanometer(), 0.007),
                (812.926d.Nanometer(), 0.012),
                (815.951d.Nanometer(), 0.006),
                (817.9339d.Nanometer(), 0.012),
                (819.1241d.Nanometer(), 0.006),
                (819.7734d.Nanometer(), 0.012),
                (820.8634d.Nanometer(), 0.007),
                (821.4726d.Nanometer(), 0.05),
                (823.0773d.Nanometer(), 0.06),
                (823.219d.Nanometer(), 0.01),
                (827.4615d.Nanometer(), 0.03),
                (829.8581d.Nanometer(), 0.04),
                (830.24d.Nanometer(), 0.012),
                (834.5556d.Nanometer(), 0.024),
                (860.447d.Nanometer(), 0.00028),
                (867.262d.Nanometer(), 0.007),
                (873.727d.Nanometer(), 0.028),
                (876.661d.Nanometer(), 0.002),
                (877.773d.Nanometer(), 0.024),
                (879.936d.Nanometer(), 0.014),
                (880.7582d.Nanometer(), 0.018),
                (883.1232d.Nanometer(), 0.02),
                (884.4502d.Nanometer(), 0.024),
                (884.906d.Nanometer(), 0.014),
                (890.092d.Nanometer(), 0.02),
                (891.027d.Nanometer(), 0.028),
                (891.278d.Nanometer(), 0.006),
                (891.443d.Nanometer(), 0.0014),
                (891.689d.Nanometer(), 0.0004),
                (896.366d.Nanometer(), 0.0008),
                (898.118d.Nanometer(), 0.0025),
                (898.365d.Nanometer(), 0.0007),
                (900.619d.Nanometer(), 0.01),
                (901.685d.Nanometer(), 0.006),
                (902.549d.Nanometer(), 0.007),
                (904.21d.Nanometer(), 0.008),
                (910.233d.Nanometer(), 0.01),
                (915.178d.Nanometer(), 0.036),
                (917.868d.Nanometer(), 0.007),
                (923.285d.Nanometer(), 0.0012),
                (923.538d.Nanometer(), 0.01),
                (924.457d.Nanometer(), 0.003),
                (931.434d.Nanometer(), 0.012),
                (938.496d.Nanometer(), 0.008),
                (943.367d.Nanometer(), 0.004),
                (950.53d.Nanometer(), 0.0005),
                (957.48d.Nanometer(), 0.0006),
                (966.204d.Nanometer(), 0.00024),
                (969.94d.Nanometer(), 0.0014),
                (972.057d.Nanometer(), 0.00024),
                (973.434d.Nanometer(), 0.0005),
                (973.67d.Nanometer(), 0.0018),
                (979.48d.Nanometer(), 0.0012),
                (982.211d.Nanometer(), 0.0003),
                (988.358d.Nanometer(), 0.0016),
                (990.265d.Nanometer(), 0.00024),
                (1004.798d.Nanometer(), 0.0016),
                (1008.713d.Nanometer(), 0.0012),
                (1018.615d.Nanometer(), 0.001),
                (1020.957d.Nanometer(), 0.0008),
                (1028.545d.Nanometer(), 0.0003),
                (1029.301d.Nanometer(), 0.0007),
                (1038.084d.Nanometer(), 0.0014),
                (1042.629d.Nanometer(), 0.0012),
                (1086.231d.Nanometer(), 0.0004),
            ]),
        }
    }).AddIsotopes([
        new()
        {
            NeutronCount = 5,
            Spin = -2,
            Decays = [new(DecayMode.ProtonEmission, 500e-24.Second())],
        },
        new()
        {
            NeutronCount = 6,
            Spin = 0.5,
            Decays = [new(DecayMode.ProtonEmission, 1.1e-21.Second())],
        },
        new()
        {
            NeutronCount = 7,
            Spin = 0,
            Decays = [new(DecayMode.ProtonEmission, 21e-21.Second())],
        },
        new()
        {
            NeutronCount = 8,
            Spin = 2.5,
            Decays = [new(DecayMode.PositronEmission, 64.370.Second())],
        },
        new()
        {
            NeutronCount = 9,
            Spin = 1,
            Abundance = 1e-6,
            Decays = [new(DecayMode.PositronEmission, 109.734.Minute())],
        },
        new()
        {
            NeutronCount = 10,
            Spin = 0.5,
            Abundance = 1,
            Decays = [],
        },
        new()
        {
            NeutronCount = 11,
            Spin = 2,
            Decays = [new(DecayMode.Beta, 11.0062.Second())],
        },
        new()
        {
            NeutronCount = 12,
            Spin = 2.5,
            Decays = [new(DecayMode.Beta, 4.158.Second())],
        },
        new()
        {
            NeutronCount = 13,
            Spin = 4,
            Decays = [
                new(DecayMode.Beta, 4.23.Second(), .89),
                new(DecayMode.BetaNeutronEmission, 4.23.Second(), .11)
            ],
        },
        new ()
        {
            NeutronCount = 14,
            Spin = 2.5,
            Decays = [
                new(DecayMode.Beta, 2.23.Second(), .86),
                new(DecayMode.BetaNeutronEmission, 2.23.Second(), .14)
            ],
        },
        new()
        {
            NeutronCount = 15,
            Spin = 3,
            Decays = [
                new(DecayMode.Beta, 384e-3.Second(), .941),
                new(DecayMode.BetaNeutronEmission, 384e-3.Second(), .059)
            ],
        },
        new()
        {
            NeutronCount = 16,
            Spin = 2.5,
            Decays = [
                new(DecayMode.Beta, 80e-3.Second(), .769),
                new(DecayMode.BetaNeutronEmission, 80e-3.Second(), .231),
                new(DecayMode.BetaDoubleNeutronEmission, 80e-3.Second(), .00001)
            ],
        },
        new()
        {
            NeutronCount = 17,
            Spin = 1,
            Decays = [
                new(DecayMode.Beta, 8.2e-3.Second(), .865),
                new(DecayMode.BetaNeutronEmission, 8.2e-3.Second(), .135),
                new(DecayMode.BetaDoubleNeutronEmission, 8.2e-3.Second(), .00001)
            ],
        },
        new()
        {
            NeutronCount = 18,
            Spin = 2.5,
            Decays = [
                new(DecayMode.BetaNeutronEmission, 5.0e-3.Second(), .77),
                new(DecayMode.Beta, 5.0e-3.Second(), .23),
                new(DecayMode.BetaDoubleNeutronEmission, 5.0e-3.Second(), .00001)
            ],
        },
        new()
        {
            NeutronCount = 19,
            Spin = -4,
            Decays = [new(DecayMode.NeutronEmission, 46e-21.Second())],
        },
        new()
        {
            NeutronCount = 20,
            Spin = 2.5,
            Decays = [
                new(DecayMode.BetaNeutronEmission, 2.5e-3.Second(), .6),
                new(DecayMode.Beta, 2.5e-3.Second(), .4),
                new(DecayMode.BetaDoubleNeutronEmission, 2.5e-3.Second(), .00001)
            ],
        },
        new()
        {
            NeutronCount = 21,
            Spin = 0,
            Decays = [new(DecayMode.NeutronEmission, 0.96+0.56-0.41e-21.Second())],
        },
        new()
        {
            NeutronCount = 22,
            Spin = 2.5,
            Decays = [
                new(DecayMode.Beta, .002.Second()),
                new(DecayMode.BetaNeutronEmission, .002.Second()),
                new(DecayMode.BetaDoubleNeutronEmission, .002.Second()),
            ],
        },
    ]);
}