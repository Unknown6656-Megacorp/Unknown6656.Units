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
    public static Element Oganesson { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Oganesson),
        AlternateNames = ["Ununoctium"],
        Symbol = "Og",
        CASNumber = "CAS54144-19-3",
        CIDNumber = null,
        DiscoveryYear = 2006,
        AtomicNumber = 118,
        Category = ElementCategory.NobleGas,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = 325d.Kelvin,
            BoilingPoint = 450d.Kelvin,
            StandardDensity = 7.2.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = null,
            HeatOfVaporization = null,
            ThermalCapacity = null,
            IonizationEnergies = [
                .8601e6.JoulePerMol,
                1.56e6.JoulePerMol,
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
                new(7, ElectronOrbital.P, 6),
            ]),
            Valence = 0,
            OxidationStates = [],
            CommonOxidationStates = [-1, 1, 2, 4, 6],
            PaulingElectronegativity = null,
            AllenElectronegativity = null,
            MeanAtomicRadius = 152e-12.Meter,
            CovalentRadius = 157e-12.Meter,
            VanDerWaalsRadius = 152e-12.Meter,
        },
        Electromagnetics = ElectromagneticalElementProperties.Unknown[ElectricalElementType.Insulator],
        Kinematics = KinematicElementProperties.Unknown,
        Optics = OpticalElementProperties.Unknown,
    }).AddIsotopes([
        new()
        {
            NeutronCount = 176,
            Spin = 0,
            Decays = [new(DecayMode.Alpha, 6.8e-4.Second)],
        },
    ]);
}
