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
    public static Element Roentgenium { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Roentgenium),
        AlternateNames = ["Unununium"],
        Symbol = "Rg",
        CASNumber = "CAS54386-24-2",
        CIDNumber = null,
        DiscoveryYear = 1994,
        AtomicNumber = 111,
        Category = ElementCategory.TransitionMetal,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = null,
            BoilingPoint = null,
            StandardDensity = 23.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = null,
            HeatOfVaporization = null,
            ThermalCapacity = null,
            IonizationEnergies = [
                1.02e6.JoulePerMol,
                2.07e6.JoulePerMol,
                3.08e6.JoulePerMol,
                4.1e6.JoulePerMol,
                5.3e6.JoulePerMol,
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
                new(6, ElectronOrbital.D, 9),
                new(7, ElectronOrbital.S, 2),
            ]),
            Valence = 11,
            OxidationStates = [-2, 3, 5],
            CommonOxidationStates = [],
            PaulingElectronegativity = null,
            AllenElectronegativity = null,
            MeanAtomicRadius = 114e-12.Meter,
            CovalentRadius = 121e-12.Meter,
            VanDerWaalsRadius = 114e-12.Meter,
        },
        Electromagnetics = ElectromagneticalElementProperties.Unknown[ElectricalElementType.Conductor],
        Kinematics = KinematicElementProperties.Unknown,
        Optics = OpticalElementProperties.Unknown,
    }).AddIsotopes([
        new()
        {
            NeutronCount = 161,
            Spin = 5,
            Decays = [new(DecayMode.Alpha, 3.8e-3.Second)],
        },
        new()
        {
            NeutronCount = 163,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 20e-3.Second)],
        },
        new()
        {
            NeutronCount = 167,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 4.6e-3.Second)],
        },
        new()
        {
            NeutronCount = 168,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 90e-3.Second, .87),
                new(DecayMode.SpontaneousFission, 90e-3.Second, .13),
            ],
        },
        new()
        {
            NeutronCount = 169,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 3.9.Second, .87),
                new(DecayMode.ElectronCapture, 3.9.Second, .13),
            ],
        },
        new()
        {
            NeutronCount = 170,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 11.7.Second, .86),
                new(DecayMode.Alpha, 11.7.Second, .14),
            ],
        },
        new()
        {
            NeutronCount = 171,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 130.Second)],
        },
        new()
        {
            NeutronCount = 172,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 5.1.Minute)],
        },
        new()
        {
            NeutronCount = 175,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 10.7.Minute)],
        },
    ]);
}
