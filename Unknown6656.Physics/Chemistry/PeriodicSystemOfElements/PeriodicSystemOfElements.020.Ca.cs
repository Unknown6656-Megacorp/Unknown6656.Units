using Unknown6656.Units.Thermodynamics;
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
    public static Element Calcium { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Calcium),
        Symbol = "Ca",
        CASNumber = "CAS7440-70-2",
        CIDNumber = 5460341,
        AtomicNumber = 20,
        Category = ElementCategory.AlkalineEarthMetal,
        Occurrence = ElementOccurrence.Primordial,
        Abundance = new()
        {
            UniverseAbundance = .00007,
            SolarAbundance = .00007,
            MeteoriteAbundance = .011,
            CrustalAbundance = .05,
            OceanAbundance = .0000042,
            HumanBodyAbundance = .014,
        },
        Thermodynamics = new()
        {
            MeltingPoint = 1115d.Kelvin(),
            BoilingPoint = 1757d.Kelvin(),
            StandardDensity = 1.526.GramPerCubicCentimeter(),
            TriplePoint = (1550d.Kelvin(), 32e9.Pascal()),
            CriticalPoint = null,
            HeatOfFusion = 8.54e3.JoulePerMol(),
            HeatOfVaporization = 154.7e3.JoulePerMol(),
            ThermalCapacity = 25.929.JoulePerMolKelvin(),
            IonizationEnergies = [
                57.11e6.JoulePerMol(),
                63.41e6.JoulePerMol(),
                70.11e6.JoulePerMol(),
                78.89e6.JoulePerMol(),
                86.31e6.JoulePerMol(),
                94e6.JoulePerMol(),
                104.9e6.JoulePerMol(),
                111.711e6.JoulePerMol(),
                494.85e6.JoulePerMol(),
                527.762e6.JoulePerMol(),
                .5898e6.JoulePerMol(),
                1.1454e6.JoulePerMol(),
                4.9124e6.JoulePerMol(),
                6.491e6.JoulePerMol(),
                8.153e6.JoulePerMol(),
                10.496e6.JoulePerMol(),
                12.27e6.JoulePerMol(),
                14.206e6.JoulePerMol(),
                18.191e6.JoulePerMol(),
                20.385e6.JoulePerMol(),
            ],
            ThermalExpansion = 0.0000223.InverseKelvin(),
            ThermalConductivity = 200d.WattPerMeterKelvin(),
        },
        ChemicalBonding = new()
        {
            ElectronConfiguration = new([
                new(1, ElectronOrbital.S, 2),
                new(2, ElectronOrbital.S, 2),
                new(2, ElectronOrbital.P, 6),
                new(3, ElectronOrbital.S, 2),
                new(3, ElectronOrbital.P, 6),
                new(4, ElectronOrbital.S, 2),
            ]),
            Valence = 2,
            OxidationStates = [1, 2],
            CommonOxidationStates = [2],
            PaulingElectronegativity = 1,
            AllenElectronegativity = 1.034,
            MeanAtomicRadius = 180e-12.Meter(),
            CovalentRadius = 171e-12.Meter(),
            VanDerWaalsRadius = 231e-12.Meter(),
        },
        Electromagnetics = new()
        {
            CuriePoint = null,
            SuperconductingPoint = null,
            BandGap = null,
            ElectricalResistivity = 33.6e-9.OhmMeter(),
            ElectricalType = ElectricalElementType.Conductor,
            MagneticOrdering = MagneticOrdering.Paramagnetic,
            MagneticSusceptibility = 40e-6.CubicCentimeterPerMol(),
        },
        Kinematics = new()
        {
            YoungModulus = 20e9.Pascal(),
            ShearModulus = 7.4e9.Pascal(),
            BulkModulus = 17e9.Pascal(),
            PoissonRatio = .31,
            BrinellHardness = 167e3.Pascal(),
            VickersHardness = null,
            MohsHardness = 1.75,
            SpeedOfSound = 3810d.MeterPerSecond(),
        },
        Optics = new()
        {
            RefractiveIndex = 0.42862,
            ExtinctionCoefficient = 1.1549,
            EmissionSpectrum = new SparseSpectrum([
                (27.3695d.Nanometer(), 0.0023333333333333335),
                (27.4461d.Nanometer(), 0.0011111111111111111),
                (29.6958d.Nanometer(), 0.010555555555555556),
                (30.1741d.Nanometer(), 0.006111111111111111),
                (30.433d.Nanometer(), 0.0044444444444444444),
                (30.491d.Nanometer(), 0.0044444444444444444),
                (35.798d.Nanometer(), 1),
                (40.3724d.Nanometer(), 0.12777777777777777),
                (40.9954d.Nanometer(), 0.06666666666666667),
                (43.9691d.Nanometer(), 0.0023333333333333335),
                (49.0549d.Nanometer(), 0.0001611111111111111),
                (55.2411d.Nanometer(), 0.0002666666666666667),
                (56.1959d.Nanometer(), 0.00038888888888888887),
                (56.2607d.Nanometer(), 0.0002),
                (58.0058d.Nanometer(), 0.00013333333333333334),
                (58.335d.Nanometer(), 0.00012222222222222221),
                (58.6547d.Nanometer(), 0.00011111111111111112),
                (58.7354d.Nanometer(), 0.0008333333333333334),
                (58.9013d.Nanometer(), 0.0002),
                (59.0987d.Nanometer(), 0.00018888888888888888),
                (59.1584d.Nanometer(), 0.00044444444444444447),
                (59.4978d.Nanometer(), 0.0003333333333333333),
                (59.6675d.Nanometer(), 0.0002777777777777778),
                (59.7291d.Nanometer(), 0.0003333333333333333),
                (60.0852d.Nanometer(), 0.00015555555555555556),
                (62.4821d.Nanometer(), 0.00017777777777777779),
                (62.8663d.Nanometer(), 0.0003333333333333333),
                (63.2017d.Nanometer(), 0.0001611111111111111),
                (63.3588d.Nanometer(), 0.0005),
                (63.9124d.Nanometer(), 0.00014444444444444444),
                (64.028d.Nanometer(), 0.00022777777777777778),
                (64.6343d.Nanometer(), 0.00018333333333333334),
                (67.2249d.Nanometer(), 0.00010555555555555555),
                (67.762d.Nanometer(), 0.00014444444444444444),
                (68.2632d.Nanometer(), 0.00017777777777777779),
                (68.4018d.Nanometer(), 0.0001388888888888889),
                (68.5408d.Nanometer(), 0.0002555555555555556),
                (68.9602d.Nanometer(), 0.00016666666666666666),
                (69.0963d.Nanometer(), 0.0001277777777777778),
                (69.1136d.Nanometer(), 0.00016666666666666666),
                (69.3487d.Nanometer(), 0.0002),
                (69.4898d.Nanometer(), 0.00012222222222222221),
                (69.4994d.Nanometer(), 0.00012222222222222221),
                (69.7551d.Nanometer(), 0.00023333333333333333),
                (69.9085d.Nanometer(), 0.00022777777777777778),
                (69.9891d.Nanometer(), 0.00022777777777777778),
                (70.139d.Nanometer(), 0.0006666666666666666),
                (70.3958d.Nanometer(), 0.0001611111111111111),
                (70.5426d.Nanometer(), 0.00014444444444444444),
                (72.7656d.Nanometer(), 0.0006111111111111111),
                (73.2894d.Nanometer(), 0.0003333333333333333),
                (73.6693d.Nanometer(), 0.0006111111111111111),
                (74.0553d.Nanometer(), 0.0017777777777777779),
                (74.2541d.Nanometer(), 0.0001388888888888889),
                (74.2672d.Nanometer(), 0.00011111111111111112),
                (74.6248d.Nanometer(), 0.0006111111111111111),
                (74.7978d.Nanometer(), 0.0001611111111111111),
                (74.9479d.Nanometer(), 0.00011111111111111112),
                (77.9608d.Nanometer(), 0.00013333333333333334),
                (80.0301d.Nanometer(), 0.00012222222222222221),
                (80.055d.Nanometer(), 0.0001),
                (80.3396d.Nanometer(), 0.0001),
                (80.993d.Nanometer(), 0.00011666666666666667),
                (81.7056d.Nanometer(), 0.0005555555555555556),
                (82.1572d.Nanometer(), 0.0003333333333333333),
                (84.0558d.Nanometer(), 0.00011666666666666667),
                (85.6791d.Nanometer(), 0.0012222222222222222),
                (128.6523d.Nanometer(), 0.00011111111111111112),
                (129.8035d.Nanometer(), 0.00011666666666666667),
                (133.5129d.Nanometer(), 0.0001),
                (138.5426d.Nanometer(), 0.00012222222222222221),
                (139.7687d.Nanometer(), 0.0001277777777777778),
                (145.3157d.Nanometer(), 0.0002722222222222222),
                (145.9787d.Nanometer(), 0.0002111111111111111),
                (146.1875d.Nanometer(), 0.0001611111111111111),
                (146.3335d.Nanometer(), 0.0005),
                (148.0425d.Nanometer(), 0.0001),
                (148.0527d.Nanometer(), 0.0001),
                (148.4869d.Nanometer(), 0.0006111111111111111),
                (149.6884d.Nanometer(), 0.00023333333333333333),
                (150.6876d.Nanometer(), 0.00017777777777777779),
                (152.8866d.Nanometer(), 0.00010555555555555555),
                (154.5294d.Nanometer(), 0.0012222222222222222),
                (155.5527d.Nanometer(), 0.0005555555555555556),
                (156.2473d.Nanometer(), 0.001),
                (157.1268d.Nanometer(), 0.0003333333333333333),
                (158.6125d.Nanometer(), 0.0003333333333333333),
                (159.5193d.Nanometer(), 0.00010555555555555555),
                (176.2259d.Nanometer(), 0.0001),
                (180.0208d.Nanometer(), 0.00015555555555555556),
                (180.7885d.Nanometer(), 0.00020555555555555556),
                (181.2153d.Nanometer(), 0.0002611111111111111),
                (181.3585d.Nanometer(), 0.00011666666666666667),
                (183.0059d.Nanometer(), 0.00014444444444444444),
                (187.0263d.Nanometer(), 0.00022777777777777778),
                (187.2367d.Nanometer(), 0.00022777777777777778),
                (194.8257d.Nanometer(), 0.00011111111111111112),
                (196.4614d.Nanometer(), 0.00014444444444444444),
                (196.7936d.Nanometer(), 0.00014444444444444444),
                (197.2823d.Nanometer(), 0.00010555555555555555),
                (207.8916d.Nanometer(), 0.00011666666666666667),
                (209.8497d.Nanometer(), 0.00011666666666666667),
                (211.4413d.Nanometer(), 0.00018888888888888888),
                (212.3029d.Nanometer(), 0.0002777777777777778),
                (212.9191d.Nanometer(), 0.00014444444444444444),
                (213.3953d.Nanometer(), 0.0001388888888888889),
                (214.0359d.Nanometer(), 0.00010555555555555555),
                (215.2435d.Nanometer(), 0.00022222222222222223),
                (231.2076d.Nanometer(), 0.00015),
                (254.1498d.Nanometer(), 0.00017777777777777779),
                (262.0817d.Nanometer(), 0.0001388888888888889),
                (263.4139d.Nanometer(), 0.0001388888888888889),
                (268.7764d.Nanometer(), 0.00019444444444444443),
                (270.4859d.Nanometer(), 0.0001388888888888889),
                (279.159d.Nanometer(), 0.00011666666666666667),
                (281.3877d.Nanometer(), 0.00018333333333333334),
                (286.6538d.Nanometer(), 0.00019444444444444443),
                (286.9945d.Nanometer(), 0.0002777777777777778),
                (288.1782d.Nanometer(), 0.0003333333333333333),
                (289.9785d.Nanometer(), 0.0007777777777777777),
                (292.4326d.Nanometer(), 0.00038888888888888887),
                (298.863d.Nanometer(), 0.0003333333333333333),
                (298.9274d.Nanometer(), 0.00023333333333333333),
                (302.8586d.Nanometer(), 0.00016666666666666666),
                (311.9665d.Nanometer(), 0.00038888888888888887),
                (336.7786d.Nanometer(), 0.0002777777777777778),
                (337.2671d.Nanometer(), 0.0005555555555555556),
                (353.777d.Nanometer(), 0.00014444444444444444),
            ]),
        }
    }).AddIsotopes([
        new()
        {
            NeutronCount = 15,
            Spin = 0.5,
            Decays = [
                new(DecayMode.PositronProtonEmission, 25.7e-3.Second(), 0.958),
                new(DecayMode.PositronDoubleProtonEmission, 25.7e-3.Second(), 0.042),
                new(DecayMode.PositronEmission, 25.7e-3.Second(), 1e-6)
            ],
        },
        new()
        {
            NeutronCount = 16,
            Spin = 0,
            Decays = [
                new(DecayMode.PositronProtonEmission, 100.9e-3.Second(), 0.512),
                new(DecayMode.PositronEmission, 100.9e-3.Second(), 0.488)
            ],
        },
        new()
        {
            NeutronCount = 17,
            Spin = 1.5,
            Decays = [
                new(DecayMode.PositronProtonEmission, 181.0e-3.Second(), 0.768),
                new(DecayMode.PositronEmission, 181.0e-3.Second(), 0.232)
            ],
        },
        new()
        {
            NeutronCount = 18,
            Spin = 0,
            Decays = [new(DecayMode.PositronEmission, 443.70e-3.Second())],
        },
        new()
        {
            NeutronCount = 19,
            Spin = 1.5,
            Decays = [new(DecayMode.PositronEmission, 860.3e-3.Second())],
        },
        new()
        {
            NeutronCount = 20,
            Spin = 0,
            Abundance = 0.9694,
            Decays = [],
        },
        new()
        {
            NeutronCount = 21,
            Spin = -3.5,
            Decays = [new(DecayMode.ElectronCapture, 9.94e4.SolarYear())],
        },
        new()
        {
            NeutronCount = 22,
            Spin = 0,
            Abundance = 0.00647,
            Decays = [],
        },
        new()
        {
            NeutronCount = 23,
            Spin = -3.5,
            Abundance = 0.00135,
            Decays = [],
        },
        new()
        {
            NeutronCount = 24,
            Spin = 0,
            Abundance = 0.0209,
            Decays = [],
        },
        new()
        {
            NeutronCount = 25,
            Spin = -3.5,
            Decays = [new(DecayMode.Beta, 162.61.StandardDay())],
        },
        new()
        {
            NeutronCount = 26,
            Spin = 0,
            Abundance = 4e-5,
            Decays = [],
        },
        new()
        {
            NeutronCount = 27,
            Spin = -3.5,
            Decays = [new(DecayMode.Beta, 4.536.StandardDay())],
        },
        new()
        {
            NeutronCount = 28,
            Spin = 0,
            Abundance = 0.00187,
            Decays = [new(DecayMode.DoubleBetaDecay, 5.6e19.SolarYear())],
        },
        new()
        {
            NeutronCount = 29,
            Spin = -1.5,
            Decays = [new(DecayMode.Beta, 8.718.Minute())],
        },
        new()
        {
            NeutronCount = 30,
            Spin = 0,
            Decays = [new(DecayMode.Beta, 13.45.Second())],
        },
        new()
        {
            NeutronCount = 31,
            Spin = -1.5,
            Decays = [new(DecayMode.Beta, 10.0.Second())],
        },
        new()
        {
            NeutronCount = 32,
            Spin = 0,
            Decays = [
                new(DecayMode.Beta, 4.6.Second(), .985),
                new(DecayMode.BetaNeutronEmission, 4.6.Second(), .015)
            ],
        },
    ]);
}
