using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Kinematics;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Magnetism;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Energy;
using Unknown6656.Units.Matter;

using Unknown6656.Physics.Optics;

namespace Unknown6656.Physics.Chemistry;


public sealed partial class PeriodicTableOfElements
{
    public static Element Neutronium { get; } = Table.RegisterElement(new(Table)
    {
        Name = nameof(Neutronium),
        Symbol = "-",
        CASNumber = null,
        CIDNumber = null,
        DiscoveryYear = 1932,
        AtomicNumber = 0,
        Category = ElementCategory.NonMetal,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            StandardDensity = 4e14.GramPerCubicCentimeter,
            MeltingPoint = 5e9.Kelvin,
            BoilingPoint = null,
            TriplePoint = null,
            CriticalPoint = null,
            IonizationEnergies = [],
            HeatOfFusion = null,
            HeatOfVaporization = null,
            ThermalConductivity = 1e16.WattPerMeterKelvin,
            ThermalCapacity = null,
            ThermalExpansion = null,
        },
        Kinematics = new()
        {
            BrinellHardness = null,
            VickersHardness = null,
            MohsHardness = null,
            PoissonRatio = .5,
            BulkModulus = 1e34.Pascal,
            ShearModulus = 1e29.Pascal,
            YoungModulus = 1e30.Pascal,
            SpeedOfSound = Speed.C0 / double.Sqrt(3),
        },
        ChemicalBonding = new()
        {
            Valence = 1,
            PaulingElectronegativity = null,
            AllenElectronegativity = null,
            CovalentRadius = .8e-15.Meter,
            VanDerWaalsRadius = .8e-15.Meter,
            MeanAtomicRadius = .8e-15.Meter,
            OxidationStates = [1],
            CommonOxidationStates = [1],
            ElectronConfiguration = new([
                new(1, ElectronOrbital.S, 1),
            ])
        },
        Electromagnetics = new()
        {
            ElectricalType = ElectricalElementType.Insulator,
            MagneticOrdering = MagneticOrdering.Diamagnetic,
            MagneticSusceptibility = null,
            SuperconductingPoint = null,
            BandGap = null,
            ElectricalResistivity = null,
            CuriePoint = null,
        },
        Optics = OpticalElementProperties.Unknown,
    }).AddIsotopes([
        new()
        {
            Name = "Neutronium",
            NeutronCount = 1,
            Spin = .5,
            Decays = [new(DecayMode.Beta, 879.4.Second, 1)],
        },
    ]);
}
