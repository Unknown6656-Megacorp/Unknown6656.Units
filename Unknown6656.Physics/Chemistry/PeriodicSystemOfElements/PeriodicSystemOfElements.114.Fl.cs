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
    public static Element Flerovium { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Flerovium),
        AlternateNames = ["Ununquadium"],
        Symbol = "Fl",
        CASNumber = "CAS54085-16-4",
        CIDNumber = null,
        DiscoveryYear = 1999,
        AtomicNumber = 114,
        Category = ElementCategory.PostTransitionMetal,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = 284.Kelvin,
            BoilingPoint = null,
            StandardDensity = 11.4.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = null,
            HeatOfVaporization = 38e3.JoulePerMol,
            ThermalCapacity = null,
            IonizationEnergies = [
                .8322e6.JoulePerMol,
                1.6e6.JoulePerMol,
                3.37e6.JoulePerMol,
                4.4e6.JoulePerMol,
                5.85e6.JoulePerMol,
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
                new(7, ElectronOrbital.P, 2),
            ]),
            Valence = 4,
            OxidationStates = [],
            CommonOxidationStates = [],
            PaulingElectronegativity = null,
            AllenElectronegativity = null,
            MeanAtomicRadius = 180e-12.Meter,
            CovalentRadius = 174e-12.Meter,
            VanDerWaalsRadius = 180e-12.Meter,
        },
        Electromagnetics = new()
        {
            CuriePoint = null,
            SuperconductingPoint = null,
            BandGap = 0.8.ElectronVolt,
            ElectricalResistivity = null,
            ElectricalType = ElectricalElementType.Semiconductor,
            MagneticOrdering = MagneticOrdering.Paramagnetic,
            MagneticSusceptibility = null,
        },
        Kinematics = KinematicElementProperties.Unknown,
        Optics = OpticalElementProperties.Unknown,
    }).AddIsotopes([
        new()
        {
            NeutronCount = 170,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 3.1e-3.Second, 0.76),
                new(DecayMode.Alpha, 3.1e-3.Second, 0.24)
            ],
        },
        new()
        {
            NeutronCount = 171,
            Spin = 1.5,
            Decays = [new(DecayMode.Alpha, 108e-3.Second)],
        },
        new()
        {
            NeutronCount = 172,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 109e-3.Second, 0.55),
                new(DecayMode.SpontaneousFission, 109e-3.Second, 0.45)
            ],
        },
        new()
        {
            NeutronCount = 173,
            Spin = 0,
            Decays = [
                new(DecayMode.Alpha, 360e-3.Second),
                new(DecayMode.ElectronCapture, 360e-3.Second)
            ],
        },
        new()
        {
            NeutronCount = 174,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 653e-3.Second)],
        },
        new()
        {
            NeutronCount = 175,
            Spin = 2.5,
            Decays = [new(DecayMode.Alpha, 2.1.Second)],
        },
        new()
        {
            NeutronCount = 176,
            Spin = 0,
            Decays = [
                new(DecayMode.ElectronCapture, 19.0.Second),
                new(DecayMode.Alpha, 19.0.Second)
            ],
        },
    ]);
}
