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
    public static Element Tennessine { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Tennessine),
        AlternateNames = ["Ununseptium"],
        Symbol = "Ts",
        CASNumber = "CAS54101-14-3",
        CIDNumber = null,
        DiscoveryYear = 2010,
        AtomicNumber = 117,
        Category = ElementCategory.Halogen,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = 623d.Kelvin(),
            BoilingPoint = 883d.Kelvin(),
            StandardDensity = 7.17.GramPerCubicCentimeter(),
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = null,
            HeatOfVaporization = null,
            ThermalCapacity = null,
            IonizationEnergies = [
                .7369e6.JoulePerMol(),
                1.4354e6.JoulePerMol(),
                2.1619e6.JoulePerMol(),
                4.0129e6.JoulePerMol(),
                5.0764e6.JoulePerMol(),
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
                new(5, ElectronOrbital.S, 2),
                new(5, ElectronOrbital.P, 6),
                new(4, ElectronOrbital.F, 14),
                new(5, ElectronOrbital.D, 10),
                new(6, ElectronOrbital.S, 2),
                new(6, ElectronOrbital.P, 6),
                new(5, ElectronOrbital.F, 14),
                new(6, ElectronOrbital.D, 10),
                new(7, ElectronOrbital.S, 2),
                new(7, ElectronOrbital.P, 5),
            ]),
            Valence = 1,
            OxidationStates = [],
            CommonOxidationStates = [-1, 1, 3, 5],
            PaulingElectronegativity = null,
            AllenElectronegativity = null,
            MeanAtomicRadius = 138e-12.Meter(),
            CovalentRadius = 156.5e-12.Meter(),
            VanDerWaalsRadius = 138e-12.Meter(),
        },
        Electromagnetics = ElectromagneticalElementProperties.Unknown[ElectricalElementType.Insulator],
        Kinematics = KinematicElementProperties.Unknown,
        Optics = OpticalElementProperties.Unknown,
    }).AddIsotopes([
        new()
        {
            NeutronCount = 176,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 22.2e-3.Second())],
        },
        new()
        {
            NeutronCount = 177,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 51.11e-3.Second())],
        },
    ]);
}
