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
        AtomicNumber = 3,
        Category = ElementCategory.AlkaliMetal,
        Thermodynamics = new()
        {
            StandardDensity = 0.5334.GramPerCubicCentimeter(),
            STPMeltingPoint = 453.65.Kelvin(),
            STPBoilingPoint = 1_603d.Kelvin(),
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
            ExtinctionCoefficient = 1.7522,
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
            Decays = [new(DecayMode.ProtonEmission, 91e-24.Second())],
        },
        new()
        {
            NeutronCount = 2,
            Spin = 1.5,
            Decays = [new(DecayMode.ProtonEmission, 370e-24.Second())],
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
            Decays = [new(DecayMode.Beta, .8387.Second())],
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
            Decays = [new(DecayMode.NeutronEmission, 3e-9.Second())],
        },
    ]);
}
