using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System;

using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Electricity;
using Unknown6656.Units.Kinematics;
using Unknown6656.Units.Magnetism;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;

using Unknown6656.Physics.Nuclear;
using Unknown6656.Physics.Optics;

using Unknown6656.Generics;
using Unknown6656.Common;

namespace Unknown6656.Physics.Chemistry;


/// <summary>
/// Represents the various modes of radioactive decay.
/// </summary>
public enum DecayMode
{
    /// <summary>
    /// Indicates that the element is stable and does not undergo radioactive decay.
    /// </summary>
    Stable = 0,
    /// <summary>
    /// Alpha decay, where the nucleus emits an alpha particle (2 protons and 2 neutrons).
    /// </summary>
    Alpha,
    /// <summary>
    /// Beta-minus decay, where a neutron is converted into a proton, an electron, and an antineutrino.
    /// </summary>
    Beta,
    BetaAlpha,
    BetaNeutronEmission,
    BetaDoubleNeutronEmission,
    BetaTripleNeutronEmission,
    BetaQuadrupleNeutronEmission,
    DeuteronEmission,
    BetaDeuteronEmission,
    BetaTritonEmission,
    /// <summary>
    /// Beta-plus decay, where a proton is converted into a neutron, a positron, and a neutrino.
    /// </summary>
    PositronEmission,
    PositronProtonEmission,
    PositronAlphaEmission,
    /// <summary>
    /// Electron capture, where an inner orbital electron is captured by the nucleus.
    /// </summary>
    ElectronCapture,
    /// <summary>
    /// Isomeric transition, where the nucleus changes from a higher to a lower energy state.
    /// </summary>
    IsomericTransition,
    /// <summary>
    /// Spontaneous fission, where the nucleus splits into two or more smaller nuclei and other particles.
    /// </summary>
    SpontaneousFission,
    /// <summary>
    /// Cluster decay, where the nucleus emits a small "cluster" of neutrons and protons.
    /// </summary>
    ClusterDecay,
    /// <summary>
    /// Neutron emission, where the nucleus emits a neutron.
    /// </summary>
    NeutronEmission,
    /// <summary>
    /// Double neutron emission, where two neutrons are emitted by the nucleus.
    /// </summary>
    DoubleNeutronEmission,
    /// <summary>
    /// Proton emission, where the nucleus emits a proton.
    /// </summary>
    ProtonEmission,
    /// <summary>
    /// Double proton emission, where two protons are emitted by the nucleus.
    /// </summary>
    DoubleProtonEmission,
    /// <summary>
    /// Double beta decay, where two neutrons are converted into two protons, two electrons, and two antineutrinos.
    /// </summary>
    DoubleBetaDecay,
    /// <summary>
    /// Double beta-plus decay, where two protons are converted into two neutrons, two positrons, and two neutrinos.
    /// </summary>
    DoublePositronEmission,
    /// <summary>
    /// Beta-gamma decay, where beta decay is followed by gamma emission.
    /// </summary>
    BetaGammaDecay,
    /// <summary>
    /// Gamma decay, where the nucleus emits a gamma ray.
    /// </summary>
    Gamma,
    /// <summary>
    /// Neutron capture, where the nucleus captures a neutron.
    /// </summary>
    NeutronCapture,
}

/// <summary>
/// Represents the category of a chemical element.
/// </summary>
public enum ElementCategory
{
    /// <summary>
    /// The category of the element is unknown.
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// Alkali metal.
    /// </summary>
    AlkaliMetal = 1,

    /// <summary>
    /// Alkaline earth metal.
    /// </summary>
    AlkalineEarthMetal = 2,

    /// <summary>
    /// Lanthanide.
    /// </summary>
    Lanthanide = 3,

    /// <summary>
    /// Actinide.
    /// </summary>
    Actinide = 4,

    /// <summary>
    /// Transition metal.
    /// </summary>
    TransitionMetal = 5,

    /// <summary>
    /// Post-transition metal.
    /// </summary>
    PostTransitionMetal = 6,

    /// <summary>
    /// Metalloid.
    /// </summary>
    Metalloid = 7,

    /// <summary>
    /// Non-metal.
    /// </summary>
    NonMetal = 8,

    /// <summary>
    /// Halogen.
    /// </summary>
    Halogen = 9,

    /// <summary>
    /// Noble gas.
    /// </summary>
    NobleGas = 10,
}

/// <summary>
/// Represents the fundamental state of matter.
/// </summary>
public enum FundamentalState
{
    /// <summary>
    /// Solid state.
    /// </summary>
    Solid = 0,

    /// <summary>
    /// Liquid state.
    /// </summary>
    Liquid = 1,

    /// <summary>
    /// Gaseous state.
    /// </summary>
    Gas = 2,

    /// <summary>
    /// Plasma state.
    /// </summary>
    Plasma = 3,
}

/// <summary>
/// Represents the magnetic ordering of a material.
/// </summary>
public enum MagneticOrdering
{
    /// <summary>
    /// Material is diamagnetic.
    /// </summary>
    Diamagnetic,
    /// <summary>
    /// Material is paramagnetic.
    /// </summary>
    Paramagnetic,
    /// <summary>
    /// Material is ferromagnetic.
    /// </summary>
    Ferromagnetic,
}

/// <summary>
/// Represents the electron orbitals.
/// </summary>
public enum ElectronOrbital
{
    /// <summary>
    /// S orbital.
    /// </summary>
    S = 1,
    /// <summary>
    /// P orbital.
    /// </summary>
    P = 2,
    /// <summary>
    /// D orbital.
    /// </summary>
    D = 3,
    /// <summary>
    /// F orbital.
    /// </summary>
    F = 4,
    /// <summary>
    /// G orbital.
    /// </summary>
    G = 5,
    /// <summary>
    /// H orbital.
    /// </summary>
    H = 6,
}

/// <summary>
/// Represents the blocks of the periodic table.
/// </summary>
public enum PeriodicTableBlock
{
    /// <summary>
    /// S block.
    /// </summary>
    S = 1,
    /// <summary>
    /// P block.
    /// </summary>
    P = 2,
    /// <summary>
    /// D block.
    /// </summary>
    D = 3,
    /// <summary>
    /// F block.
    /// </summary>
    F = 4,
}

public record ThermodynamicElementProperties
{
    public Temperature? STPMeltingPoint { get; init; } = null;
    public Temperature? STPBoilingPoint { get; init; } = null;
    public Temperature? STPSublimationPoint { get; init; } = null;
    public required PressureTemperaturePoint? TriplePoint { get; init; }
    public required PressureTemperaturePoint? CriticalPoint { get; init; }
    public required VolumetricMassDensity StandardDensity { get; init; }
    public required ChemicalPotential[] IonizationEnergies { get; init; }
    public required ChemicalPotential HeatOfFusion { get; init; }
    public required ChemicalPotential HeatOfVaporization { get; init; }
    public required ThermalExpansion? ThermalExpansion { get; init; }
    public required ThermalConductivity ThermalConductivity { get; init; }
    public required ThermodynamicEntropy? ThermalCapacity { get; init; }


    public FundamentalState State => GetFundamentalStateAt(PressureTemperaturePoint.NormalNTP);


    public FundamentalState GetFundamentalStateAt(PressureTemperaturePoint point) => GetFundamentalStateAt(point.Temperature, point.Pressure);

    public FundamentalState GetFundamentalStateAt(Pressure pressure, Temperature temperature) => GetFundamentalStateAt(temperature, pressure);

    public FundamentalState GetFundamentalStateAt(Temperature temperature, Pressure pressure)
    {
        // TODO : implement sublimation
        // TODO : implement triple point
        // TODO : implement critical point

        throw null;

        //= MeltingPoint >= Temperature.RoomTemperature ? FundamentalState.Solid
        //                                   : BoilingPoint <= Temperature.RoomTemperature ? FundamentalState.Gas : FundamentalState.Liquid;
    }
}

public record OpticalElementProperties
{
    public required Spectrum? EmissionSpectrum { get; init; }
    //public required Spectrum? AbsorptionSpectrum { get; init; }
    public required double? RefractiveIndex { get; init; } = null;
    public double ExtinctionCoefficient { get; init; } = 0;

    public Speed? SpeedOfLight => RefractiveIndex is double n ? Speed.C0 / n : null;


    public bool CreatesCherenkovRadiation(Speed speed) => SpeedOfLight is Speed c && speed > c;
}

public record ElectromagneticalElementProperties
{
    public required Resistivity? ElectricalResistivity { get; init; }
    public required MolarMagneticSusceptibility MagneticSusceptibility { get; init; }
    public required MagneticOrdering MagneticOrdering { get; init; }
    public required Temperature? CurieTemperature { get; init; }

    public Conductivity? ElectricalConductivity => ElectricalResistivity is { } r ? 1 / r : null;
}

public record ElectronOrbitalConfiguration(ElectronOrbital Orbital, uint Subshell, uint Electrons)
{
#if USE_PURE_ASCII
    public override string ToString() => $"{Subshell}{Orbital}^{Electrons}";
#else
    public override string ToString() => $"{Subshell}{Orbital}{Electrons.ToString().ToSuperScript()}";
#endif

    public ElectronOrbitalConfiguration(uint Subshell, ElectronOrbital Orbital, uint Electrons)
        : this(Orbital, Subshell, Electrons)
    {
    }
}

public record ElectronConfiguration(IEnumerable<ElectronOrbitalConfiguration> Shells)
    : IEnumerable<ElectronOrbitalConfiguration>
{
    public override string ToString() => $"[{string.Join(" ", Shells)}]";


    public IEnumerator<ElectronOrbitalConfiguration> GetEnumerator() => Shells.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Shells).GetEnumerator();
}

public record ChemicalBondingElementProperties
{
    /// <summary>
    /// The element's electronegativity on the Pauling scale.
    /// </summary>
    public required double? ElectroNegativity { get; init; } = null;
    public required int[] OxidationStates { get; init; } = [0];
    public required Length CovalentRadius { get; init; }
    public required Length VanDerWaalsRadius { get; init; }
    public required Length MeanAtomicRadius { get; init; }
    public required ElectronConfiguration ElectronConfiguration { get; init; }
}

public record KinematicElementProperties
{
    public required Speed SpeedOfSound { get; init; }
    public Pressure? YoungModulus { get; init; } = null;
    public Pressure? ShearModulus { get; init; } = null;
    public Pressure? BulkModulus { get; init; } = null;
    public Pressure? BrinellHardness { get; init; } = null;
    public Pressure? VickersHardness { get; init; } = null;
    public double? PoissonRatio { get; init; } = null;
}

public record IsotopeDecayConfig(DecayMode Mode, Time HalfTime, double Probability = 1);

public record IsotopeConfig
{
    public required uint NeutronCount { get; init; }
    public required IEnumerable<IsotopeDecayConfig>? Decays { get; init; }
    public string? Name { get; init; } = null;
    public double Abundance { get; init; } = 0;
    public required Spin Spin { get; init; }
}

/// <summary>
/// Represents a chemical element.
/// </summary>
public class Element
{
    private readonly HashSet<Isotope> _isotopes = [];


    public PeriodicTableOfElements PeriodicTable { get; }

    /// <summary>
    /// The name of the element.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// The element's chemical symbol.
    /// </summary>
    public required string Symbol { get; init; }

    public uint ElementPeriod => AtomicNumber switch
    {
        < 1 => 0,
        <= 2 => 1,
        <= 10 => 2,
        <= 18 => 3,
        <= 36 => 4,
        <= 54 => 5,
        <= 86 => 6,
        <= 118 => 7,
        _ => throw new NotImplementedException($"Unknown atomic element {this}")
    };

    public uint? ElementGroup => AtomicNumber switch
    {
        0 => 0,
        2 => 18,
        1 or 3 or 11 or 19 or 37 or 55 or 87 => 1,
        4 or 12 or 20 or 38 or 56 or 88 => 2,
        (>= 57 and <= 70) or (>= 89 and <= 102) => null,
        >= 21 and <= 36 => AtomicNumber - 18,
        >= 39 and <= 54 => AtomicNumber - 36,
        >= 71 and <= 86 => AtomicNumber - 68,
        >= 103 and <= 118 => AtomicNumber - 100,
        <= 10 => AtomicNumber + 8,
        <= 18 => AtomicNumber,
        _ => throw new NotImplementedException($"Unknown atomic element {this}")
    };

    public PeriodicTableBlock ElementBlock => AtomicNumber switch
    {
        (>= 5 and <= 10) or (>= 13 and <= 18) or (>= 31 and <= 36) or (>= 49 and <= 54) or (>= 81 and <= 86) or (>= 113 and <= 118) => PeriodicTableBlock.P,
        (>= 21 and <= 30) or (>= 39 and <= 48) or (>= 71 and <= 80) or (>= 103 and <= 112) => PeriodicTableBlock.D,
        (>= 57 and <= 70) or (>= 89 and <= 102) => PeriodicTableBlock.F,
        <= 88 => PeriodicTableBlock.S,
        _ => throw new NotImplementedException($"Unknown atomic element {this}")
    };

    /// <summary>
    /// The category of the element, e.g. metal, non-metal, etc.
    /// </summary>
    public required ElementCategory Category { get; init; }

    /// <summary>
    /// The element's atomic number. This is equivalent to the number of protons in the element's nucleus.
    /// </summary>
    public required uint AtomicNumber { get; init; }

    /// <summary>
    /// The number of protons in the element's nucleus.
    /// This property will always return the same value as <see cref="AtomicNumber"/>.
    /// </summary>
    public uint ProtonCount => AtomicNumber;

    public required ThermodynamicElementProperties Thermodynamics { get; init; }

    public required OpticalElementProperties Optics { get; init; }

    public required ElectromagneticalElementProperties Electromagnetics { get; init; }

    public required KinematicElementProperties Kinematics { get; init; }

    public required ChemicalBondingElementProperties ChemicalBonding { get; init; }

    /// <summary>
    /// The most abundant <see cref="Isotope"/> of the element.
    /// </summary>
    public Isotope MostAbundantIsotope => _isotopes.OrderByDescending(x => x.Abundance).First();

    /// <summary>
    /// The known <see cref="Isotope"/>s of the element.
    /// </summary>
    public Isotope[] KnownIsotopes => [.. _isotopes];

    /// <summary>
    /// Indicates whether the element is stable.
    /// </summary>
    public bool IsStable => MostAbundantIsotope.IsStable;

    /// <summary>
    /// The element's standard atomic weight.
    /// This is the weighted average of the atomic masses of the element's <see cref="KnownIsotopes"/>.
    /// </summary>
    public Dalton StandardAtomicMass
    {
        get
        {
            Dalton mass = Dalton.Zero;

            foreach (Isotope isotope in _isotopes)
                mass += isotope.AtomicMass * isotope.Abundance;

            return mass;
        }
    }

    public Isotope? this[uint neutron_or_hadron_count] => GetIsotopeByNeutronCount(neutron_or_hadron_count) ?? GetIsotopeByHadronCount(neutron_or_hadron_count);


    internal Element(PeriodicTableOfElements table) => PeriodicTable = table;

    internal Element AddIsotope(IsotopeConfig isotope)
    {
        _isotopes.Add(new(this, isotope));

#warning TODO : normalize abundances

        return this;
    }

    internal Element AddIsotopes(IEnumerable<IsotopeConfig> isotopes)
    {
        isotopes.Do(AddIsotope);

        return this;
    }

    public Isotope? GetIsotopeByHadronCount(uint hadron_count) => _isotopes.FirstOrDefault(x => x.HadronCount == hadron_count);

    public Isotope? GetIsotopeByNeutronCount(uint neutron_count) => _isotopes.FirstOrDefault(x => x.NeutronCount == neutron_count);

    public override int GetHashCode() => (int)AtomicNumber;

    public override bool Equals(object? obj) => obj is Element other && other.AtomicNumber == AtomicNumber;

    public override string ToString() => $"{Name} ({AtomicNumber}, {Symbol})";
}

public class Isotope
{
    public string Name { get; }
    public Element Element { get; }
    public PeriodicTableOfElements PeriodicTable => Element.PeriodicTable;
    public uint NeutronCount { get; }
    public Dalton AtomicMass { get; }
    public double Abundance { get; }
    public uint HadronCount => NeutronCount + Element.ProtonCount;
    public Spin Spin { get; }
    public IsotopeDecay[] KnownDecays { get; }
    public bool IsStable => KnownDecays.Count(d => d.Mode != DecayMode.Stable) > 0;


    internal Isotope(Element element, IsotopeConfig config)
    {
        Element = element;
        Spin = config.Spin;
        Name = config.Name ?? element.Name;
        NeutronCount = config.NeutronCount;
        AtomicMass = Mass.AtomicMass(element.ProtonCount, config.NeutronCount);
        Abundance = double.Clamp(config.Abundance, 0, 1);

        double total_prob = config.Decays?.Sum(d => d.Probability) ?? 0;

        if (total_prob <= 0)
            total_prob = 1; // prevent div by zero

        KnownDecays = config.Decays?.Select(d => new IsotopeDecay(this, d with { Probability = d.Probability / total_prob }))?.ToArray() ?? [];
    }

    public override int GetHashCode() => HashCode.Combine(Element.ProtonCount, NeutronCount);

    public override bool Equals(object? obj) => obj is Isotope other && other.Element == Element && other.NeutronCount == NeutronCount;

    public override string ToString() => $"{Name} ({Element.AtomicNumber}, {Element.Symbol}-{Element.AtomicNumber + NeutronCount})";
}

public class IsotopeDecay
{
    private readonly (int P, int N) _target;

    public Isotope SourceIsotope { get; }
    public DecayMode Mode { get; }
    public Time HalfTime { get; }
    public double Probability { get; }
    public Element SourceElement => SourceIsotope.Element;
    public Isotope? TargetIsotope => PeriodicTable[_target.P, _target.N];
    public Element? TargetElement => TargetIsotope?.Element;
    public PeriodicTableOfElements PeriodicTable => SourceElement.PeriodicTable;
    public int ProtonDifference => _target.P - (int)SourceElement.ProtonCount;
    public int NeutronDifference => _target.N - (int)SourceIsotope.NeutronCount;
    public int HadronDifference => ProtonDifference + NeutronDifference;


    internal IsotopeDecay(Isotope source, IsotopeDecayConfig config)
    {
        Mode = config.Mode;
        HalfTime = config.HalfTime;
        Probability = config.Probability;
        SourceIsotope = source;

        (int P, int N) = config.Mode switch
        {
            DecayMode.Stable or
            DecayMode.IsomericTransition => (0, 0),
            DecayMode.Alpha => (-2, -2),
            DecayMode.PositronAlphaEmission => (-3, -1),
            DecayMode.PositronProtonEmission => (-2, -1),
            DecayMode.ProtonEmission => (-1, 0),
            DecayMode.DoubleProtonEmission => (-2, 0),
            DecayMode.NeutronEmission => (0, -1),
            DecayMode.DoubleNeutronEmission or
            DecayMode.BetaDeuteronEmission => (0, -2),
            DecayMode.NeutronCapture => (0, 1),
            DecayMode.ElectronCapture or
            DecayMode.PositronEmission => (-1, 1),
            DecayMode.Beta or
            DecayMode.BetaGammaDecay => (1, -1),
            DecayMode.DoubleBetaDecay => (2, -2),
            DecayMode.DoublePositronEmission => (-2, 2),
            DecayMode.DeuteronEmission => (-1, -1),
            DecayMode.BetaAlpha => (-1, -3),
            DecayMode.BetaTritonEmission => (0, -3),
            DecayMode.BetaNeutronEmission => (1, -2),
            DecayMode.BetaDoubleNeutronEmission => (1, -3),
            DecayMode.BetaTripleNeutronEmission => (1, -4),
            DecayMode.BetaQuadrupleNeutronEmission => (1, -5),

            //DecayMode.ClusterDecay => (, ),
            //DecayMode.SpontaneousFission => (, ),
            //DecayMode.Gamma => (, ),

            _ => throw new NotImplementedException($"I'm terribly sorry, but I haven't yet implemented the decay mode {config.Mode}. it's on my TODO list.")
        };

        P += (int)source.Element.ProtonCount;
        N += (int)source.NeutronCount;

        _target = (P, N);
    }
}

/* DECAY MODES:

  \ P|     |     |     |     |     |     |     |     |
 N \ |  -4 |  -3 |  -2 |  -1 |  0  |  +1 |  +2 |  +3 |
----\+-----+-----+-----+-----+-----+-----+-----+-----+
  -5 |     |     |     |     |     | β4n |     |     |
-----+-----+-----+-----+-----+-----+-----+-----+-----+
  -4 |     |     |     |     |     | β3n |     |     |
-----+-----+-----+-----+-----+-----+-----+-----+-----+
  -3 |     |     |     |  βα |  βt | β2n |     |     |
-----+-----+-----+-----+-----+-----+-----+-----+-----+
  -2 |     |     |  α  |     |2n,βd|  βn |  2β |     |
-----+-----+-----+-----+-----+-----+-----+-----+-----+
  -1 |     | β+α | β+p |β+,>ε|  n  |  β  |     |     |
-----+-----+-----+-----+-----+-----+-----+-----+-----+
   0 |     |     |  2p |  p  | S,IT|     |     |     |
-----+-----+-----+-----+-----+-----+-----+-----+-----+
  +1 |     |     |     |  d  |  >n |     |     |     |
-----+-----+-----+-----+-----+-----+-----+-----+-----+
  +2 |     |     | 2β+ |     |     |     |     |     |
-----+-----+-----+-----+-----+-----+-----+-----+-----+
  +3 |     |     |     |     |     |     |     |     |
-----+-----+-----+-----+-----+-----+-----+-----+-----+
*/