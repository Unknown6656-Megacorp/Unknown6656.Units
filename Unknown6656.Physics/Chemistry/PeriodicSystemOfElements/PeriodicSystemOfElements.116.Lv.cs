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
    public static Element Livermorium { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Livermorium),
        AlternateNames = ["Ununhexium"],
        Symbol = "Lv",
        CASNumber = "CAS54100-71-9",
        CIDNumber = null,
        DiscoveryYear = 2000,
        AtomicNumber = 116,
        Category = ElementCategory.PostTransitionMetal,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = 637d.Kelvin(),
            BoilingPoint = 1035d.Kelvin(),
            StandardDensity = 12.9.GramPerCubicCentimeter(),
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = 7.61e3.JoulePerMol(),
            HeatOfVaporization = 42e3.JoulePerMol(),
            ThermalCapacity = null,
            IonizationEnergies = [
                .6639e6.JoulePerMol(),
                1.33e6.JoulePerMol(),
                2.85e6.JoulePerMol(),
                3.81e6.JoulePerMol(),
                6.08e6.JoulePerMol(),
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
                new(7, ElectronOrbital.P, 4),
            ]),
            Valence = 2,
            OxidationStates = [],
            CommonOxidationStates = [-2, 2, 4],
            PaulingElectronegativity = null,
            AllenElectronegativity = null,
            MeanAtomicRadius = 138e-12.Meter(),
            CovalentRadius = 164e-12.Meter(),
            VanDerWaalsRadius = 138e-12.Meter(),
        },
        Electromagnetics = ElectromagneticalElementProperties.Unknown[ElectricalElementType.Semiconductor],
        Kinematics = KinematicElementProperties.Unknown,
        Optics = OpticalElementProperties.Unknown,
    }).AddIsotopes([
        new()
        {
            NeutronCount = 172,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 3e-3.Second())],
        },
        new()
        {
            NeutronCount = 173,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 5.4e-3.Second())],
        },
        new()
        {
            NeutronCount = 174,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 8.3e-3.Second())],
        },
        new()
        {
            NeutronCount = 175,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 26e-3.Second())],
        },
        new()
        {
            NeutronCount = 176,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 16e-3.Second())],
        },
        new()
        {
            NeutronCount = 177,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 70e-3.Second())],
        },
        new()
        {
            NeutronCount = 178,
            Spin = 0,
            Decays = [new(DecayMode.Alpha , 54e-3.Second())],
        },
    ]);
}
