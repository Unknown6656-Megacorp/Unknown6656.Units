using Unknown6656.Units.Thermodynamics;
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
    public static Element Lithium { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Lithium),
        Symbol = "Li",
        CASNumber = "CAS7439-93-2",
        CIDNumber = 3028194,
        DiscoveryYear = 1817,
        AtomicNumber = 3,
        Category = ElementCategory.AlkaliMetal,
        Occurrence = ElementOccurrence.Primordial,
        Abundance = new()
        {
            UniverseAbundance = 6e-9,
            SolarAbundance = 6e-11,
            MeteoriteAbundance = .0000017,
            CrustalAbundance = .000017,
            OceanAbundance = 1.8e-6,
            HumanBodyAbundance = 3e-8,
        },
        Thermodynamics = new()
        {
            StandardDensity = 0.5334.GramPerCubicCentimeter,
            MeltingPoint = 453.65.Kelvin,
            BoilingPoint = 1_603.Kelvin,
            TriplePoint = null,
            CriticalPoint = (3_220.Kelvin, 67e6.Pascal),
            HeatOfFusion = 3e3.JoulePerMol,
            HeatOfVaporization = 136e3.JoulePerMol,
            IonizationEnergies = [
                520.2e3.JoulePerMol,
                7298.1e3.JoulePerMol,
                11815.0e3.JoulePerMol,
            ],
            ThermalCapacity = 24.860.JoulePerMolKelvin,
            ThermalConductivity = 84.8.WattPerMeterKelvin,
            ThermalExpansion = 46.56e-6.InverseKelvin,
        },
        Kinematics = new()
        {
            BrinellHardness = 5e6.Pascal,
            BulkModulus = 11e9.Pascal,
            ShearModulus = 4.2e9.Pascal,
            YoungModulus = 4.9e9.Pascal,
            MohsHardness = .6,
            PoissonRatio = null,
            VickersHardness = null,
            SpeedOfSound = 6_000.MeterPerSecond,
        },
        ChemicalBonding = new()
        {
            Valence = 1,
            CovalentRadius = 128e-12.Meter,
            VanDerWaalsRadius = 182e-12.Meter,
            MeanAtomicRadius = 152e-12.Meter,
            PaulingElectronegativity = 0.98,
            AllenElectronegativity = 0.912,
            OxidationStates = [1, 0],
            CommonOxidationStates = [1],
            ElectronConfiguration = new([
                new(1, ElectronOrbital.S, 2),
                new(2, ElectronOrbital.S, 1),
            ]),
        },
        Electromagnetics = new()
        {
            CuriePoint = null,
            SuperconductingPoint = 4e-4.Kelvin,
            BandGap = null,
            ElectricalResistivity = 92.8e-9.OhmMeter,
            ElectricalType = ElectricalElementType.Conductor,
            MagneticOrdering = MagneticOrdering.Paramagnetic,
            MagneticSusceptibility = 14.2e6.CubicCentimeterPerMol,
        },
        Optics = new()
        {
            RefractiveIndex = 1.000057,
            ExtinctionCoefficient = 1.7522,
            EmissionSpectrum = new SparseSpectrum([
                (149.293.Nanometer, 0.0008333333333333334),
                (149.297.Nanometer, 0.001388888888888889),
                (149.304.Nanometer, 0.0002777777777777778),
                (165.308.Nanometer, 0.0008333333333333334),
                (165.313.Nanometer, 0.001388888888888889),
                (165.321.Nanometer, 0.0002777777777777778),
                (233.688.Nanometer, 0.0008333333333333334),
                (233.691.Nanometer, 0.001388888888888889),
                (233.7.Nanometer, 0.0005555555555555556),
                (239.439.Nanometer, 0.0002777777777777778),
                (242.543.Nanometer, 0.0008333333333333334),
                (247.506.Nanometer, 0.002777777777777778),
                (255.17.Nanometer, 0.006666666666666667),
                (256.231.Nanometer, 0.004166666666666667),
                (265.729.Nanometer, 0.0005555555555555556),
                (265.73.Nanometer, 0.0008333333333333334),
                (272.829.Nanometer, 0.001388888888888889),
                (272.832.Nanometer, 0.0005555555555555556),
                (273.047.Nanometer, 0.0008333333333333334),
                (273.055.Nanometer, 0.0002777777777777778),
                (274.12.Nanometer, 0.001388888888888889),
                (293.402.Nanometer, 0.0005555555555555556),
                (293.407.Nanometer, 0.0005555555555555556),
                (293.412.Nanometer, 0.001388888888888889),
                (293.425.Nanometer, 0.0002777777777777778),
                (302.912.Nanometer, 0.0008333333333333334),
                (302.914.Nanometer, 0.0008333333333333334),
                (315.531.Nanometer, 0.0008333333333333334),
                (315.533.Nanometer, 0.0011111111111111111),
                (319.626.Nanometer, 0.0002777777777777778),
                (319.633.Nanometer, 0.0025),
                (319.636.Nanometer, 0.0011111111111111111),
                (319.933.Nanometer, 0.001388888888888889),
                (319.943.Nanometer, 0.0005555555555555556),
                (323.266.Nanometer, 0.004722222222222222),
                (371.4.Nanometer, 0.0002777777777777778),
                (371.416.Nanometer, 0.001388888888888889),
                (371.427.Nanometer, 0.0016666666666666668),
                (371.429.Nanometer, 0.0022222222222222222),
                (371.44.Nanometer, 0.0019444444444444444),
                (371.441.Nanometer, 0.002777777777777778),
                (371.451.Nanometer, 0.0002777777777777778),
                (371.87.Nanometer, 0.0008333333333333334),
                (379.472.Nanometer, 0.0016666666666666668),
                (391.53.Nanometer, 0.005555555555555556),
                (391.535.Nanometer, 0.005555555555555556),
                (398.548.Nanometer, 0.002777777777777778),
                (398.554.Nanometer, 0.002777777777777778),
                (413.256.Nanometer, 0.011111111111111112),
                (413.262.Nanometer, 0.011111111111111112),
                (427.307.Nanometer, 0.005555555555555556),
                (427.313.Nanometer, 0.005555555555555556),
                (432.542.Nanometer, 0.001388888888888889),
                (432.547.Nanometer, 0.001388888888888889),
                (432.554.Nanometer, 0.0002777777777777778),
                (460.283.Nanometer, 0.003611111111111111),
                (460.289.Nanometer, 0.003611111111111111),
                (467.165.Nanometer, 0.0016666666666666668),
                (467.17.Nanometer, 0.0005555555555555556),
                (467.806.Nanometer, 0.0008333333333333334),
                (467.829.Nanometer, 0.0002777777777777778),
                (488.132.Nanometer, 0.0011111111111111111),
                (488.139.Nanometer, 0.0011111111111111111),
                (488.149.Nanometer, 0.0002777777777777778),
                (497.166.Nanometer, 0.0022222222222222222),
                (497.175.Nanometer, 0.0022222222222222222),
                (548.355.Nanometer, 0.16666666666666666),
                (548.565.Nanometer, 0.16666666666666666),
                (610.354.Nanometer, 0.08888888888888889),
                (610.365.Nanometer, 0.08888888888888889),
                (670.776.Nanometer, 1),
                (670.791.Nanometer, 1),
                (812.623.Nanometer, 0.013333333333333334),
                (812.645.Nanometer, 0.013333333333333334),
            ]),
        },
    }).AddIsotopes([
        new()
        {
            NeutronCount = 1,
            Spin = -2,
            Decays = [new(DecayMode.ProtonEmission, 91e-24.Second)],
        },
        new()
        {
            NeutronCount = 2,
            Spin = -1.5,
            Decays = [new(DecayMode.ProtonEmission, 370e-24.Second)],
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
            Spin = -1.5,
            Decays = [],
            Abundance = .922,
        },
        new()
        {
            NeutronCount = 5,
            Spin = 2,
            Decays = [new(DecayMode.Beta, .8387.Second)],
        },
        new()
        {
            NeutronCount = 6,
            Spin = -1.5,
            Decays = [
                new(DecayMode.BetaNeutronEmission, .1782.Second, 50.5),
                new(DecayMode.Beta, .1782.Second, 49.5),
            ],
        },
        new()
        {
            NeutronCount = 8,
            Spin = -1.5,
            Decays = [
                new(DecayMode.BetaNeutronEmission, .00875.Second, .863),
                new(DecayMode.Beta, .00875.Second, .06),
                new(DecayMode.BetaDoubleNeutronEmission, .00875.Second, .041),
                new(DecayMode.BetaTripleNeutronEmission, .00875.Second, .019),
                new(DecayMode.BetaAlpha, .00875.Second, .017),
                new(DecayMode.BetaDeuteronEmission, .00875.Second, .013),
                new(DecayMode.BetaTritonEmission, .00875.Second, .0093),
            ],
        },
        new()
        {
            NeutronCount = 9,
            Spin = -1,
            Decays = [new(DecayMode.NeutronEmission, 3e-9.Second)],
        },
    ]);
}
