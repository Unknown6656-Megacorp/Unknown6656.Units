using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;

using Unknown6656.Physics.Optics;

namespace Unknown6656.Physics.Chemistry;


public partial class Element
{
    public static Element Californium => field ??= PeriodicTableOfElements.RegisterElement(new()
    {
        Name = nameof(Californium),
        Symbol = "Cf",
        CASNumber = "CAS7440-71-3",
        CIDNumber = null,
        DiscoveryYear = 1974,
        AtomicNumber = 98,
        Category = ElementCategory.Actinide,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = 1173.Kelvin,
            BoilingPoint = 1743.Kelvin,
            StandardDensity = 15.1.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = null,
            HeatOfVaporization = null,
            ThermalCapacity = null,
            IonizationEnergies = [
                .608e6.JoulePerMol,
                1.206e6.JoulePerMol,
                2.267e6.JoulePerMol,
                3.599e6.JoulePerMol,
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
                new(5, ElectronOrbital.F, 10),
                new(6, ElectronOrbital.S, 2),
                new(6, ElectronOrbital.P, 6),
                new(7, ElectronOrbital.S, 2),
            ]),
            Valence = 12,
            OxidationStates = [2, 3, 4, 5],
            CommonOxidationStates = [3],
            PaulingElectronegativity = 1.3,
            AllenElectronegativity = null,
            MeanAtomicRadius = 186e-9.Meter,
            CovalentRadius = 186e-9.Meter,
            VanDerWaalsRadius = 186e-9.Meter,
        },
        Electromagnetics = ElectromagneticalElementProperties.Unknown[ElectricalElementType.Conductor],
        Kinematics = KinematicElementProperties.Unknown with
        {
            MohsHardness = 3.5,
        },
        Optics = new()
        {
            RefractiveIndex = null,
            ExtinctionCoefficient = 1,
            EmissionSpectrum = new SparseSpectrum([
                (339.222.Nanometer, 1),
                (353.149.Nanometer, 1),
                (354.098.Nanometer, 1),
                (359.877.Nanometer, 1),
                (360.532.Nanometer, 1),
                (361.211.Nanometer, 1),
                (361.749.Nanometer, 1),
                (362.676.Nanometer, 1),
                (366.27.Nanometer, 1),
                (372.211.Nanometer, 1),
                (373.935.Nanometer, 1),
                (378.561.Nanometer, 1),
                (378.904.Nanometer, 1),
                (389.323.Nanometer, 1),
                (399.357.Nanometer, 1),
                (409.912.Nanometer, 1),
                (424.238.Nanometer, 1),
                (432.903.Nanometer, 1),
                (433.522.Nanometer, 1),
                (517.396.Nanometer, 1),
                (517.908.Nanometer, 1),
                (521.924.Nanometer, 1),
                (540.888.Nanometer, 1),
                (572.605.Nanometer, 1),
                (662.283.Nanometer, 1),
                (663.126.Nanometer, 1),
                (667.79.Nanometer, 1),
                (689.459.Nanometer, 1),
                (692.71.Nanometer, 1),
                (707.452.Nanometer, 1),
                (730.79.Nanometer, 1),
                (814.129.Nanometer, 1),
                (824.177.Nanometer, 1),
                (833.385.Nanometer, 1),
                (842.349.Nanometer, 1),
                (856.883.Nanometer, 1),
            ]),
        }
    }).AddIsotopes([
        new()
        {
            NeutronCount = 139,
            Spin = 2.5,
            Decays = [
                new(DecayMode.Alpha, 0.8.Second, .7),
                new(DecayMode.SpontaneousFission, 0.8.Second, .3),
            ],
        },
        new()
        {
            NeutronCount = 140,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 21.1e-3.Second, .975),
                new(DecayMode.Alpha, 21.1e-3.Second, .025)
            ],
        },
        new()
        {
            NeutronCount = 141,
            Spin = 2.5,
            Decays = [
                new(DecayMode.Alpha, 28.Second, .65),
                new(DecayMode.PositronEmission, 28.Second, .35)
            ],
        },
        new()
        {
            NeutronCount = 142,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 40.3.Second, .985),
                new(DecayMode.SpontaneousFission, 40.3.Second, .015)
            ],
        },
        new()
        {
            NeutronCount = 143,
            Spin = -3.5,
            Decays = [
                new(DecayMode.PositronEmission, 2.35.Minute, .85),
                new(DecayMode.Alpha, 2.35.Minute, .15)
            ],
        },
        new()
        {
            NeutronCount = 144,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 3.49.Minute, .61),
                new(DecayMode.PositronEmission, 3.49.Minute, .39),
                new(DecayMode.SpontaneousFission, 3.49.Minute, 0.00014)
            ],
        },
        new ()
        {
            NeutronCount = 145,
            Spin = 0.5,
            Decays = [
                new(DecayMode.PositronEmission, 10.8.Minute, .86),
                new (DecayMode.Alpha, 10.8.Minute, .14)
            ],
        },
        new()
        {
            NeutronCount = 146,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 19.5.Minute, .75),
                new(DecayMode.ElectronCapture, 19.5.Minute, .25)
            ],
        },
        new()
        {
            NeutronCount = 147,
            Spin = 0.5,
            Decays = [
                new(DecayMode.PositronEmission, 45.0.Minute, .647),
                new(DecayMode.Alpha, 45.0.Minute, .353)
            ],
        },
        new()
        {
            NeutronCount = 148,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 35.7.Hour, .999976),
                new(DecayMode.SpontaneousFission, 35.7.Hour, 0.000024)
            ],
        },
        new()
        {
            NeutronCount = 149,
            Spin = 3.5,
            Decays = [
                new(DecayMode.ElectronCapture, 3.11.Hour, .99965),
                new(DecayMode.Alpha, 3.11.Hour, 0.00035)
            ],
        },
        new()
        {
            NeutronCount = 150,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 333.5.StandardDay, .999971),
                new(DecayMode.SpontaneousFission, 333.5.StandardDay, 0.000029)
            ],
        },
        new()
        {
            NeutronCount = 151,
            Spin = -4.5,
            Decays = [
                new(DecayMode.Alpha, 351.SolarYear, .999995),
                new(DecayMode.SpontaneousFission, 351.SolarYear, 0.000005)
            ],
        },
        new()
        {
            NeutronCount = 152,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 13.08.SolarYear, .99923),
                new(DecayMode.SpontaneousFission, 13.08.SolarYear, 0.00077)
            ],
        },
        new()
        {
            NeutronCount = 153,
            Spin = 0.5,
            Decays = [new(DecayMode.Alpha, 898.SolarYear)],
        },
        new()
        {
            NeutronCount = 154,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 2.645.SolarYear, .968972),
                new(DecayMode.SpontaneousFission, 2.645.SolarYear, 0.031028)
            ],
        },
        new()
        {
            NeutronCount = 155,
            Spin = 3.5,
            Decays = [
                new(DecayMode.Beta, 17.81.StandardDay, .9969),
                new(DecayMode.Alpha, 17.81.StandardDay, .0031)
            ],
        },
        new()
        {
            NeutronCount = 156,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 60.5.StandardDay, .9969),
                new(DecayMode.Alpha, 60.5.StandardDay, .0031)
            ],
        },
        new()
        {
            NeutronCount = 157,
            Spin = 3.5,
            Decays = [new(DecayMode.Beta, 85.Minute)],
        },
        new()
        {
            NeutronCount = 158,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 12.3.Minute)],
        },
    ]);
}
