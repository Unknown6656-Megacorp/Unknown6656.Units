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
