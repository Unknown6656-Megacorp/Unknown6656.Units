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
    public static Element Moscovium { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Moscovium),
        AlternateNames = ["Ununpentium"],
        Symbol = "Mc",
        CASNumber = "CAS54085-64-2",
        CIDNumber = null,
        DiscoveryYear = 2003,
        AtomicNumber = 115,
        Category = ElementCategory.PostTransitionMetal,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = 670.Kelvin,
            BoilingPoint = 1400.Kelvin,
            StandardDensity = 13.5.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = 5.94e3.JoulePerMol,
            HeatOfVaporization = 138e3.JoulePerMol,
            ThermalCapacity = null,
            IonizationEnergies = [
                .5383e6.JoulePerMol,
                1.76e6.JoulePerMol,
                2.65e6.JoulePerMol,
                4.68e6.JoulePerMol,
                5.72e6.JoulePerMol,
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
                new(7, ElectronOrbital.P, 3),
            ]),
            Valence = 3,
            OxidationStates = [],
            CommonOxidationStates = [1, 3],
            PaulingElectronegativity = null,
            AllenElectronegativity = null,
            MeanAtomicRadius = 187e-12.Meter,
            CovalentRadius = 157e-12.Meter,
            VanDerWaalsRadius = 187e-12.Meter,
        },
        Electromagnetics = ElectromagneticalElementProperties.Unknown[ElectricalElementType.Semiconductor],
        Kinematics = KinematicElementProperties.Unknown,
        Optics = OpticalElementProperties.Unknown,
    }).AddIsotopes([
        new()
        {
            NeutronCount = 171,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 108e-3.Second)],
        },
        new()
        {
            NeutronCount = 172,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 50e-3.Second)],
        },
        new()
        {
            NeutronCount = 173,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 195e-3.Second)],
        },
        new()
        {
            NeutronCount = 174,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 266e-3.Second)],
        },
        new()
        {
            NeutronCount = 175,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 0.84.Second)],
        },
    ]);
}
