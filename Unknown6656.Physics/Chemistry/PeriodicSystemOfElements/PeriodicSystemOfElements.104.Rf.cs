using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;

namespace Unknown6656.Physics.Chemistry;


public partial class Element
{
    public static Element Rutherfordium => field ??= PeriodicTableOfElements.RegisterElement(new()
    {
        Name = nameof(Rutherfordium),
        AlternateNames = ["Unnilquadium", "Kurchatovium"],
        Symbol = "Rf",
        CASNumber = "CAS53850-36-5",
        CIDNumber = null,
        DiscoveryYear = 1969,
        AtomicNumber = 104,
        Category = ElementCategory.TransitionMetal,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = 2400.Kelvin,
            BoilingPoint = 5800.Kelvin,
            StandardDensity = 17.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = null,
            HeatOfVaporization = null,
            ThermalCapacity = null,
            IonizationEnergies = [
                .58e6.JoulePerMol,
                1.39e6.JoulePerMol,
                2.3e6.JoulePerMol,
                3.08e6.JoulePerMol,
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
                new(5, ElectronOrbital.F, 14),
                new(6, ElectronOrbital.S, 2),
                new(6, ElectronOrbital.P, 6),
                new(6, ElectronOrbital.D, 2),
                new(7, ElectronOrbital.S, 2),
            ]),
            Valence = 4,
            OxidationStates = [3, 4],
            CommonOxidationStates = [4],
            PaulingElectronegativity = null,
            AllenElectronegativity = null,
            MeanAtomicRadius = 139e-12.Meter,
            CovalentRadius = 149e-12.Meter,
            VanDerWaalsRadius = 139e-12.Meter,
        },
        Electromagnetics = ElectromagneticalElementProperties.Unknown[ElectricalElementType.Conductor],
        Kinematics = KinematicElementProperties.Unknown,
        Optics = OpticalElementProperties.Unknown,
    }).AddIsotopes([
        new()
        {
            NeutronCount = 148,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 60e-9.Second)],
        },
        new()
        {
            NeutronCount = 149,
            Spin = 0.5,
            Decays = [
                new(DecayMode.SpontaneousFission, 9.9e-3.Second, .83),
                new(DecayMode.Alpha, 9.9e-3.Second, .17)
            ],
        },
        new()
        {
            NeutronCount = 150,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 22.9e-6.Second)],
        },
        new()
        {
            NeutronCount = 151,
            Spin = -4.5,
            Decays = [
                new(DecayMode.SpontaneousFission, 1.69.Second, .509),
                new(DecayMode.Alpha, 1.69.Second, .491),
                new(DecayMode.PositronEmission, 1.69.Second, .06),
            ],
        },
        new ()
        {
            NeutronCount = 152,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 6.60e-3.Second, .9969),
                new(DecayMode.Alpha, 6.60e-3.Second, .0031),
            ],
        },
        new()
        {
            NeutronCount = 153,
            Spin = 0.5,
            Decays = [
                new(DecayMode.Alpha, 6.2.Second, .893),
                new(DecayMode.PositronEmission, 6.2.Second, .094),
                new(DecayMode.SpontaneousFission, 6.2.Second, .013),
            ],
        },
        new()
        {
            NeutronCount = 154,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 12.5e-3.Second, .951),
                new(DecayMode.Alpha, 12.5e-3.Second, .049)
            ],
        },
        new()
        {
            NeutronCount = 155,
            Spin = 1.5,
            Decays = [
                new(DecayMode.Alpha, 2.63.Second, .85),
                new(DecayMode.PositronEmission, 2.63.Second, .15),
            ],
        },
        new()
        {
            NeutronCount = 156,
            Spin = 0,
            Decays = [
                new(DecayMode.SpontaneousFission, 21e-3.Second, .8),
                new(DecayMode.Alpha, 21e-3.Second, .2),
            ],
        },
        new()
        {
            NeutronCount = 157,
            Spin = 1.5,
            Decays = [
                new(DecayMode.SpontaneousFission, 2.1.Second, .82),
                new(DecayMode.Alpha, 2.1.Second, .18),
            ],
        },
        new()
        {
            NeutronCount = 158,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, .25.Second)],
        },
        new()
        {
            NeutronCount = 159,
            Spin = 1.5,
            Decays = [new(DecayMode.SpontaneousFission, 11.Minute)],
        },
        new()
        {
            NeutronCount = 161,
            Spin = 4.5,
            Decays = [new(DecayMode.SpontaneousFission, 1.3.Minute)],
        },
        new()
        {
            NeutronCount = 162,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 23.Second)],
        },
        new()
        {
            NeutronCount = 163,
            Spin = -11.5,
            Decays = [new(DecayMode.SpontaneousFission, 48.Minute)],
        },
        new()
        {
            NeutronCount = 164,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, 1.4.Second)],
        },
        new()
        {
            NeutronCount = 166,
            Spin = 0,
            Decays = [new(DecayMode.SpontaneousFission, .02.Second)],
        },
    ]);
}
