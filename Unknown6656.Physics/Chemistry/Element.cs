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

using Unknown6656.Physics.Optics;
using Unknown6656.Common;

namespace Unknown6656.Physics.Chemistry;


public enum DecayMode
{
    Stable = 0,
    Alpha = 1,
    BetaMinus = 2,
    BetaPlus = 3,
    ElectronCapture = 4,
    IsomericTransition = 5,
    SpontaneousFission = 6,
    ClusterDecay = 7,
    NeutronEmission = 8,
    ProtonEmission = 9,
    DoubleBetaDecay = 10,
    DoubleElectronCapture = 11,
    DoubleBetaPlusDecay = 12,
    BetaGammaDecay = 13,
    InternalConversion = 14,
    Gamma = 15,
    PositronEmission = 16,
    NeutronCapture = 17,
    Spallation = 18,
    Photodisintegration = 19,
    Photofission = 20,
}

public enum ElementCategory
{
    Unknown = 0,
    AlkaliMetal = 1,
    AlkalineEarthMetal = 2,
    Lanthanide = 3,
    Actinide = 4,
    TransitionMetal = 5,
    PostTransitionMetal = 6,
    Metalloid = 7,
    NonMetal = 8,
    Halogen = 9,
    NobleGas = 10,
}

public enum FundamentalState
{
    Solid = 0,
    Liquid = 1,
    Gas = 2,
    Plasma = 3,
}

public record ThermodynamicElementProperties
{
    public required Temperature MeltingPoint { get; init; }
    public required Temperature BoilingPoint { get; init; }
    public required PressureTemperaturePoint? TriplePoint { get; init; }
    public required PressureTemperaturePoint? CriticalPoint { get; init; }
    public required ChemicalPotential[] IonizationEnergies { get; init; }
    public required ChemicalPotential HeatOfFusion { get; init; }
    public required ChemicalPotential HeatOfVaporization { get; init; }
    public required ThermalExpansion? ThermalExpansion { get; init; }
    public required ThermalConductivity ThermalConductivity { get; init; }
    public required ThermodynamicEntropy ThermalCapacity { get; init; }


    public FundamentalState State => GetFundamentalStateAt(PressureTemperaturePoint.NormalNTP);


    public FundamentalState GetFundamentalStateAt(PressureTemperaturePoint point) => GetFundamentalStateAt(point.Temperature, point.Pressure);

    public FundamentalState GetFundamentalStateAt(Pressure pressure, Temperature temperature) => GetFundamentalStateAt(temperature, pressure);

    public FundamentalState GetFundamentalStateAt(Temperature temperature, Pressure pressure)
    {
        throw null;

        //= MeltingPoint >= Temperature.RoomTemperature ? FundamentalState.Solid
        //                                   : BoilingPoint <= Temperature.RoomTemperature ? FundamentalState.Gas : FundamentalState.Liquid;
    }
}

public record OpticalElementProperties
{
    public required Spectrum? EmissionSpectrum { get; init; }
    public required Spectrum? AbsorptionSpectrum { get; init; }
    public required double? RefractiveIndex { get; init; }

    public Speed? SpeedOfLight => RefractiveIndex is double n ? Speed.C0 / n : null;


    public bool CreatesCherenkovRadiation(Speed speed) => SpeedOfLight is Speed c && speed > c;
}

public enum MagneticOrdering
{
    Diamagnetic,
    Paramagnetic,
    Ferromagnetic,
}

public record ElectromagneticalElementProperties
{
    public required ElectricalResistivity ElectricalResistivity { get; init; }
    public required MolarMagneticSusceptibility MagneticSusceptibility { get; init; }
    public required MagneticOrdering MagneticOrdering { get; init; }
    public required Temperature? CurieTemperature { get; init; }
}

public enum ElectronOrbital
{
    S = 1,
    P = 2,
    D = 3,
    F = 4,
    G = 5,
    H = 6,
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
    public required Length? MeanAtomicRadius { get; init; }
    public required ElectronConfiguration ElectronConfiguration { get; init; }
}

public record KinematicElementProperties
{
    public required Speed SpeedOfSound { get; init; }
    public required Pressure? YoungModulus { get; init; }
    public required Pressure? ShearModulus { get; init; }
    public required Pressure? BulkModulus { get; init; }
    public required Pressure? BrinellHardness { get; init; }
}


    public enum PeriodicTableBlock
{
    S = 1,
    P = 2,
    D = 3,
    F = 4,
}

/// <summary>
/// Represents a chemical element.
/// </summary>
public class Element
{
    private readonly HashSet<Isotope> _isotopes = [];


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

    public required VolumetricMassDensity StandardDensity { get; init; }

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



    internal Element AddIsotope(uint neutron_count, double abundance, IEnumerable<IsotopeDecay>? decays = null) => AddIsotope(null, neutron_count, abundance, decays);

    internal Element AddIsotope(string? name, uint neutron_count, double abundance, IEnumerable<IsotopeDecay>? decays = null)
    {
        _isotopes.Add(new(this, name, neutron_count, abundance, decays));

        return this;
    }

    internal Element AddIsotopes(IEnumerable<(uint neutron_count, double abundance, IEnumerable<IsotopeDecay>? decays)> isotopes)
    {
        foreach ((uint neutron_count, double abundance, IEnumerable<IsotopeDecay>? decays) in isotopes)
            AddIsotope(neutron_count, abundance, decays);

        return this;
    }

    internal Element AddIsotopes(IEnumerable<(string? name, uint neutron_count, double abundance, IEnumerable<IsotopeDecay>? decays)> isotopes)
    {
        foreach ((string? name, uint neutron_count, double abundance, IEnumerable<IsotopeDecay>? decays) in isotopes)
            AddIsotope(name, neutron_count, abundance, decays);

        return this;
    }

    public override int GetHashCode() => (int)AtomicNumber;

    public override bool Equals(object? obj) => obj is Element other && other.AtomicNumber == AtomicNumber;

    public override string ToString() => $"{Name} ({AtomicNumber}, {Symbol})";
}

public record IsotopeDecay(DecayMode Mode, Time HalfTime, Temperature Temperature)
{
    // public override string ToString() => ;
}

public class Isotope
{
    public string Name { get; }
    public Element Element { get; }
    public uint NeutronCount { get; }
    public Dalton AtomicMass { get; }
    public double Abundance { get; }
    public IsotopeDecay[] KnownDecays { get; }
    public bool IsStable => KnownDecays.Length == 0;


    internal Isotope(Element element, string? override_name, uint neutron_count, double abundance, IEnumerable<IsotopeDecay>? decays = null)
    {
        Element = element;
        Name = override_name ?? element.Name;
        NeutronCount = neutron_count;
        AtomicMass = Mass.AtomicMass(element.ProtonCount, neutron_count);
        Abundance = double.Clamp(abundance, 0, 1);
        KnownDecays = decays?.ToArray() ?? [];
    }

    public override int GetHashCode() => HashCode.Combine(Element.ProtonCount, NeutronCount);

    public override bool Equals(object? obj) => obj is Isotope other && other.Element == Element && other.NeutronCount == NeutronCount;

    public override string ToString() => $"{Name} ({Element.AtomicNumber}, {Element.Symbol}-{Element.AtomicNumber + NeutronCount})";
}
