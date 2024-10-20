using System.Collections.Generic;
using System.Linq;
using System;

using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;
using Unknown6656.Common;
using Unknown6656.Units.Kinematics;
using System.Drawing;

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

public record ThermodynamicElementProperties(
    Temperature MeltingPoint,
    Temperature BoilingPoint,
    PressureTemperaturePoint TriplePoint,
    PressureTemperaturePoint CriticalPoint,
    VolumetricMassDensity StandardDensity
)
{
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

public enum PeriodicTableBlock
{
    S = 1,
    P = 2,
    D = 3,
    F = 4,
}

public class Element
{
    private readonly HashSet<Isotope> _isotopes = [];

    public string Name { get; }
    public string Symbol { get; }
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
    public uint AtomicNumber { get; }
    public uint ProtonCount => AtomicNumber;
    public ElementCategory Category { get; }
    public ThermodynamicElementProperties ThermodynamicProperties { get; }

    // public double Electronegativity { get; }
    // public double IonizationEnergy { get; }
    // public double ElectronAffinity { get; }
    // public double AtomicRadius { get; }

    public Wavelength[] EmissionSpectrum { get; }
    public Wavelength[] AbsorptionSpectrum { get; }

    public Isotope MostAbundantIsotope => _isotopes.OrderByDescending(x => x.Abundance).First();
    public Isotope[] KnownIsotopes => [.. _isotopes];
    public bool IsStable => MostAbundantIsotope.IsStable;

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



    public Element(
        string name,
        string symbol,
        uint atomic_number,
        ElementCategory category,
        ThermodynamicElementProperties thermodynamic_properties,
        double? Electronegativity,
        ChemicalPotential IonizationEnergy,
        Length CovalentRadius,
        Length VanDerWaalsRadius,
        Speed SpeedOfSound,
        ChemicalPotential HeatOfFusion,
        ChemicalPotential HeatOfVaporization,
        Wavelength[] emission,
        Wavelength[] absorption
    )
    {
        Name = name;
        Symbol = symbol;
        AtomicNumber = atomic_number;
        ThermodynamicProperties = thermodynamic_properties;
        Category = category;
        EmissionSpectrum = emission;
        AbsorptionSpectrum = absorption;
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

public static class PeriodicTableOfElements
{
    public static Element Hydrogen { get; } = new Element(
        "Hydrogen",
        "H",
        1,
        ElementCategory.NonMetal,
        new ThermodynamicElementProperties(
            13.99.Kelvin(),
            20.271.Kelvin(),
            (13.8033.Kelvin(), 7_041d.Pascal()),
            (32.938.Kelvin(), 1_285_800d.Pascal()),
            0.08988.GramPerLiter()
        ),
        2.20,
        1_312e3.JoulePerMol(),
        31e-12.Meter(),
        120e-12.Meter(),
        1310d.MeterPerSecond(),
        117d.JoulePerMol(),
        904d.JoulePerMol(),
        [
            // TODO
        ],
        [
            // TODO
        ]
    ).AddIsotopes([
        ("Protium", 0, .999885, []),
        ("Deuterium", 1, .000115, []),
        ("Tritium", 2, .0000000000001, [new(DecayMode.BetaMinus, 12.32.SolarYear(), 0d.Kelvin())])
    ]);

    public static Element Helium { get; } = new Element(
        "Helium",
        "He",
        2,
        ElementCategory.NobleGas,
        new ThermodynamicElementProperties(
            0.95.Kelvin(),
            4.222.Kelvin(),
            (2.177.Kelvin(), 5.043e3.Pascal()),
            (5.1953.Kelvin(), 227.46e3.Pascal()),
            0.1786.GramPerLiter()
        ),
        null,
        2372.3e3.JoulePerMol(),
        28e-12.Meter(),
        140e-12.Meter(),
        972d.MeterPerSecond(),
        13.8.JoulePerMol(),
        82.9.JoulePerMol(),
        [
            // TODO
        ],
        [
            // TODO
        ]
    ).AddIsotopes([
        (3, .000002, []),
        (4, .999998, [])
    ]);

    // TODO : all other elements
}
