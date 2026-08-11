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
    public static Element Nihonium { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Nihonium),
        AlternateNames = ["Ununtrium"],
        Symbol = "Nh",
        CASNumber = "CAS54084-70-7",
        CIDNumber = null,
        DiscoveryYear = 2003,
        AtomicNumber = 113,
        Category = ElementCategory.PostTransitionMetal,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = 700.Kelvin,
            BoilingPoint = 1430.Kelvin,
            StandardDensity = 16.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = 7.61e3.JoulePerMol,
            HeatOfVaporization = 130e3.JoulePerMol,
            ThermalCapacity = null,
            IonizationEnergies = [
                .7072e6.JoulePerMol,
                2.309e6.JoulePerMol,
                3.02e6.JoulePerMol,
                4.382e6.JoulePerMol,
                5.638e6.JoulePerMol,
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
                new(7, ElectronOrbital.P, 1),
            ]),
            Valence = 3,
            OxidationStates = [],
            CommonOxidationStates = [],
            PaulingElectronegativity = null,
            AllenElectronegativity = null,
            MeanAtomicRadius = 170e-12.Meter,
            CovalentRadius = 176e-12.Meter,
            VanDerWaalsRadius = 170e-12.Meter,
        },
        Electromagnetics = ElectromagneticalElementProperties.Unknown[ElectricalElementType.Semiconductor],
        Kinematics = KinematicElementProperties.Unknown,
        Optics = OpticalElementProperties.Unknown,
    }).AddIsotopes([
        new()
        {
            NeutronCount = 165,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 2.3e-3.Second)],
        },
        new()
        {
            NeutronCount = 169,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 61e-3.Second)],
        },
        new()
        {
            NeutronCount = 170,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 123e-3.Second)],
        },
        new()
        {
            NeutronCount = 171,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 0.9.Second, .99),
                new(DecayMode.ElectronCapture, 0.9.Second, .1)
            ],
        },
        new()
        {
            NeutronCount = 172,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 2.1.Second, .82),
                new(DecayMode.SpontaneousFission, 2.1.Second, .18)
            ],
        },
        new()
        {
            NeutronCount = 173,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 12.0.Second)],
        },
        new()
        {
            NeutronCount = 174,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 5.5.Second)],
        },
        new()
        {
            NeutronCount = 177,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 8.0.Second, .5),
                new(DecayMode.SpontaneousFission, 8.0.Second, .5)
            ],
        },
    ]);
}
