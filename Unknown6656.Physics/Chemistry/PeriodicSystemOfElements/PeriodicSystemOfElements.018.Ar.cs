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
    public static Element Argon { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Argon),
        Symbol = "Ar",
        CASNumber = "CAS7440-37-1",
        CIDNumber = 23968,
        AtomicNumber = 18,
        Category = ElementCategory.NobleGas,
        Occurrence = ElementOccurrence.Primordial,
        Abundance = new()
        {
            UniverseAbundance = .0002,
            SolarAbundance = .00007,
            MeteoriteAbundance = 0,
            CrustalAbundance = .0000015,
            OceanAbundance = .00000045,
            HumanBodyAbundance = 0,
        },
        Thermodynamics = new()
        {
            MeltingPoint = 83.81.Kelvin(),
            BoilingPoint = 87.302.Kelvin(),
            StandardDensity = 1.784.GramPerLiter(),
            TriplePoint = (83.8058.Kelvin(), 68.89e3.Pascal()),
            CriticalPoint = (150.687.Kelvin(), 4.863e6.Pascal()),
            HeatOfFusion = 1.18e3.JoulePerMol(),
            HeatOfVaporization = 6.53e3.JoulePerMol(),
            ThermalCapacity = 20.85.JoulePerMolKelvin(),
            IonizationEnergies = [
                1.5206e6.JoulePerMol(),
                2.6658e6.JoulePerMol(),
                3.931e6.JoulePerMol(),
                5.771e6.JoulePerMol(),
                7.238e6.JoulePerMol(),
                8.781e6.JoulePerMol(),
                11.995e6.JoulePerMol(),
                13.842e6.JoulePerMol(),
                40.76e6.JoulePerMol(),
                46.186e6.JoulePerMol(),
                52.002e6.JoulePerMol(),
                59.653e6.JoulePerMol(),
                66.199e6.JoulePerMol(),
                72.918e6.JoulePerMol(),
                82.473e6.JoulePerMol(),
                88.576e6.JoulePerMol(),
                397.605e6.JoulePerMol(),
                427.066e6.JoulePerMol(),
            ],
            ThermalExpansion = null,
            ThermalConductivity = .01772.WattPerMeterKelvin(),
        },
        ChemicalBonding = new()
        {
            ElectronConfiguration = new([
                new(1, ElectronOrbital.S, 2),
                new(2, ElectronOrbital.S, 2),
                new(2, ElectronOrbital.P, 6),
                new(3, ElectronOrbital.S, 2),
                new(3, ElectronOrbital.P, 6),
            ]),
            Valence = 0,
            OxidationStates = [0],
            CommonOxidationStates = [],
            PaulingElectronegativity = null,
            AllenElectronegativity = 3.242,
            MeanAtomicRadius = 71e-12.Meter(),
            CovalentRadius = 96e-12.Meter(),
            VanDerWaalsRadius = 188e-12.Meter(),
        },
        Electromagnetics = new()
        {
            CuriePoint = null,
            SuperconductingPoint = null,
            BandGap = null,
            ElectricalResistivity = null,
            ElectricalType = ElectricalElementType.Insulator,
            MagneticOrdering = MagneticOrdering.Diamagnetic,
            MagneticSusceptibility = -19.6e-6.CubicCentimeterPerMol(),
        },
        Kinematics = new()
        {
            YoungModulus = null,
            ShearModulus = null,
            BulkModulus = null,
            PoissonRatio = null,
            BrinellHardness = null,
            VickersHardness = null,
            MohsHardness = null,
            SpeedOfSound = 319d.MeterPerSecond(),
        },
        Optics = new()
        {
            RefractiveIndex = 1.000281,
            ExtinctionCoefficient = 0,
            EmissionSpectrum = new SparseSpectrum([
                (487.2272.Nanometer(), .001343183344526528),
                (490.6495.Nanometer(), .0020147750167897917),
                (490.7013.Nanometer(), .001343183344526528),
                (519.3270.Nanometer(), .001343183344526528),
                (542.9124.Nanometer(), .001343183344526528),
                (543.2033.Nanometer(), .009402283411685695),
                (547.4606.Nanometer(), .0033579583613163196),
                (556.8170.Nanometer(), .0033579583613163196),
                (573.3619.Nanometer(), .0033579583613163196),
                (576.7364.Nanometer(), .001343183344526528),
                (580.2632.Nanometer(), .0033579583613163196),
                (583.4371.Nanometer(), .001343183344526528),
                (597.7001.Nanometer(), .0033579583613163196),
                (602.8584.Nanometer(), .001343183344526528),
                (612.3716.Nanometer(), .001343183344526528),
                (661.8690.Nanometer(), .020147750167897917),
                (664.5623.Nanometer(), .001343183344526528),
                (666.0109.Nanometer(), .009402283411685695),
                (670.9455.Nanometer(), .040295500335795834),
                (671.8513.Nanometer(), .1343183344526528),
                (676.2425.Nanometer(), .0033579583613163196),
                (677.9518.Nanometer(), .001343183344526528),
                (679.2184.Nanometer(), .001343183344526528),
                (679.4006.Nanometer(), .009402283411685695),
                (718.0899.Nanometer(), .009402283411685695),
                (723.3606.Nanometer(), .1343183344526528),
                (725.5485.Nanometer(), .020147750167897917),
                (730.9297.Nanometer(), .0033579583613163196),
                (740.2692.Nanometer(), .009402283411685695),
                (744.9248.Nanometer(), .009402283411685695),
                (745.3223.Nanometer(), .0033579583613163196),
                (802.85896.Nanometer(), .002686366689053056),
                (806.4710.Nanometer(), .013431833445265278),
                (806.86887.Nanometer(), .008059100067159167),
                (807.21842.Nanometer(), .004029550033579583),
                (807.6529.Nanometer(), .005372733378106112),
                (809.92660.Nanometer(), .006715916722632639),
                (816.23193.Nanometer(), .016118200134318333),
                (816.46391.Nanometer(), .009402283411685695),
                (820.12352.Nanometer(), .010745466756212223),
                (825.34592.Nanometer(), .016118200134318333),
                (826.36484.Nanometer(), .016118200134318333),
                (834.3918.Nanometer(), .020147750167897917),
                (835.00210.Nanometer(), .013431833445265278),
                (842.80506.Nanometer(), .013431833445265278),
                (866.79997.Nanometer(), .0241773002014775),
                (869.75411.Nanometer(), .020147750167897917),
                (876.05767.Nanometer(), .0241773002014775),
                (879.94656.Nanometer(), .0241773002014775),
                (894.31013.Nanometer(), .020147750167897917),
                (919.7810.Nanometer(), .040295500335795834),
                (932.0537.Nanometer(), .040295500335795834),
                (1048.21987.Nanometer(), .1343183344526528),
                (1066.65980.Nanometer(), .067159167226326),
            ]),
        }
    }).AddIsotopes([
        new()
        {
            NeutronCount = 12,
            Spin = 0,
            Decays = [new(DecayMode.DoubleProtonEmission, 10e-12.Second())],
        },
        new()
        {
            NeutronCount = 13,
            Spin = 2.5,
            Decays = [
                new(DecayMode.PositronProtonEmission, 15.0e-3.Second(), .683),
                new(DecayMode.PositronEmission, 15.0e-3.Second(), .2263),
                new(DecayMode.PositronDoubleProtonEmission, 15.0e-3.Second(), .09),
                new(DecayMode.PositronTripleProtonEmission, 15.0e-3.Second(), .0007),
                new(DecayMode.PositronProtonEmission, 15.0e-3.Second(), .0038),
                new(DecayMode.PositronAlphaEmission, 15.0e-3.Second(), .00003),
                new(DecayMode.DoubleProtonEmission, 15.0e-3.Second(), .00003)
            ],
        },
        new ()
        {
            NeutronCount = 14,
            Spin = 0,
            Decays = [
                new (DecayMode.PositronEmission, 98e-3.Second(), .6442),
                new (DecayMode.PositronProtonEmission, 98e-3.Second(), .3558),
            ],
        },
        new()
        {
            NeutronCount = 15,
            Spin = 0.5,
            Decays = [
                new(DecayMode.PositronEmission, 173.0e-3.Second(), .613),
                new(DecayMode.PositronProtonEmission, 173.0e-3.Second(), .387),
            ],
        },
        new()
        {
            NeutronCount = 16,
            Spin = 0,
            Decays = [new(DecayMode.PositronEmission, 846.46e-3.Second())],
        },
        new()
        {
            NeutronCount = 17,
            Spin = 1.5,
            Decays = [new(DecayMode.PositronEmission, 1.7756.Second())],
        },
        new()
        {
            NeutronCount = 18,
            Spin = 0,
            Abundance = 0.003336,
            Decays = [],
        },
        new()
        {
            NeutronCount = 19,
            Spin = 1.5,
            Abundance = 1e-6,
            Decays = [new(DecayMode.ElectronCapture, 35.011d)],
        },
        new()
        {
            NeutronCount = 20,
            Spin = 0,
            Abundance = 0.000629,
            Decays = [],
        },
        new()
        {
            NeutronCount = 21,
            Spin = -2.5,
            Abundance = 8e-16,
            Decays = [new(DecayMode.Beta, 268.2.SolarYear())],
        },
        new()
        {
            NeutronCount = 22,
            Spin = 0,
            Abundance = 0.996035,
            Decays = [],
        },
        new()
        {
            NeutronCount = 23,
            Spin = -2.5,
            Abundance = 1e-6,
            Decays = [new(DecayMode.Beta, 109.61.Minute())],
        },
        new()
        {
            NeutronCount = 24,
            Spin = 0,
            Decays = [new(DecayMode.Beta, 32.9.SolarYear())],
        },
        new()
        {
            NeutronCount = 25,
            Spin = -2.5,
            Decays = [new(DecayMode.Beta, 5.37.Minute())],
        },
        new()
        {
            NeutronCount = 26,
            Spin = 0,
            Decays = [new(DecayMode.Beta, 11.87.Minute())],
        },
        new()
        {
            NeutronCount = 27,
            Spin = -2.5,
            Decays = [new(DecayMode.Beta, 21.48.Second())],
        },
        new()
        {
            NeutronCount = 28,
            Spin = 0,
            Decays = [new(DecayMode.Beta, 8.4.Second())],
        },
        new()
        {
            NeutronCount = 29,
            Spin = -1.5,
            Decays = [
                new(DecayMode.Beta, 1.23.Second(), .998),
                new(DecayMode.BetaNeutronEmission, 1.23.Second(), .002)
            ],
        },
        new()
        {
            NeutronCount = 30,
            Spin = 0,
            Decays = [
                new(DecayMode.Beta, 415e-3.Second(),.62),
                new(DecayMode.BetaNeutronEmission, 415e-3.Second(),.38),
            ],
        },
        new()
        {
            NeutronCount = 31,
            Spin = -1.5,
            Decays = [
                new(DecayMode.Beta, 236e-3.Second(), .355),
                new(DecayMode.BetaNeutronEmission, 236e-3.Second(), .29),
                new(DecayMode.BetaDeuteronEmission, 236e-3.Second(), .355)
            ],
        },
        new()
        {
            NeutronCount = 32,
            Spin = 0,
            Decays = [
                new(DecayMode.Beta, 106e-3.Second(), .63),
                new(DecayMode.BetaNeutronEmission, 106e-3.Second(), .37),
                new(DecayMode.BetaDoubleNeutronEmission, 106e-3.Second()),
            ],
        },
        new()
        {
            NeutronCount = 33,
            Spin = -.5,
            Decays = [
                new(DecayMode.Beta, .03.Second()),
                new(DecayMode.BetaNeutronEmission, .03.Second()),
                new(DecayMode.BetaDoubleNeutronEmission, .03.Second()),
            ],
        },
        new()
        {
            NeutronCount = 34,
            Spin = 0,
            Decays = [
                new(DecayMode.Beta, .04.Second()),
                new(DecayMode.BetaNeutronEmission, .04.Second()),
                new(DecayMode.BetaDoubleNeutronEmission, .04.Second())
            ],
        },
        new()
        {
            NeutronCount = 35,
            Spin = -2.5,
            Decays = [
                new(DecayMode.Beta, .02.Second()),
                new(DecayMode.BetaNeutronEmission, .02.Second()),
                new(DecayMode.BetaDoubleNeutronEmission, .02.Second())
            ],
        },
        new()
        {
            NeutronCount = 36,
            Spin = 0,
            Decays = [
                new(DecayMode.Beta, .005.Second()),
                new(DecayMode.BetaNeutronEmission, .005.Second()),
                new(DecayMode.BetaDoubleNeutronEmission, .005.Second())
            ],
        },
    ]);
}
