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
using Unknown6656.Physics.Optics;

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

    public Spectrum? EmissionSpectrum { get; }
    public Spectrum? AbsorptionSpectrum { get; }

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
        Spectrum? emission,
        Spectrum? absorption
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
        new SparseSpectrum([
            (91.8125d.Nanometer(), 0.006666666666666667),
            (91.9342d.Nanometer(), 0.007261904761904762),
            (92.0947d.Nanometer(), 0.008809523809523809),
            (92.3148d.Nanometer(), 0.014285714285714285),
            (92.6249d.Nanometer(), 0.013095238095238096),
            (93.0751d.Nanometer(), 0.006666666666666667),
            (93.7814d.Nanometer(), 0.02261904761904762),
            (94.9742d.Nanometer(), 0.039285714285714285),
            (97.2517d.Nanometer(), 0.0988095238095238),
            (102.5728d.Nanometer(), 0.2976190476190476),
            (121.56701d.Nanometer(), 1),
            (365.665d.Nanometer(), 0.0008333333333333334),
            (365.725d.Nanometer(), 0.0008333333333333334),
            (365.804d.Nanometer(), 0.0008333333333333334),
            (365.865d.Nanometer(), 0.0008333333333333334),
            (365.941d.Nanometer(), 0.0008333333333333334),
            (366.032d.Nanometer(), 0.0008333333333333334),
            (366.127d.Nanometer(), 0.0009523809523809524),
            (366.222d.Nanometer(), 0.0013095238095238095),
            (366.341d.Nanometer(), 0.0010714285714285715),
            (366.465d.Nanometer(), 0.0011904761904761906),
            (366.608d.Nanometer(), 0.0010714285714285715),
            (366.773d.Nanometer(), 0.0011904761904761906),
            (366.945d.Nanometer(), 0.0015476190476190477),
            (367.132d.Nanometer(), 0.0014285714285714286),
            (367.381d.Nanometer(), 0.0015476190476190477),
            (367.6376d.Nanometer(), 0.0016666666666666668),
            (367.937d.Nanometer(), 0.0020238095238095236),
            (368.2823d.Nanometer(), 0.0020238095238095236),
            (368.6831d.Nanometer(), 0.002380952380952381),
            (369.1551d.Nanometer(), 0.0027380952380952383),
            (369.7157d.Nanometer(), 0.0027380952380952383),
            (370.3859d.Nanometer(), 0.0033333333333333335),
            (371.1978d.Nanometer(), 0.003928571428571429),
            (372.1946d.Nanometer(), 0.005952380952380952),
            (373.4369d.Nanometer(), 0.007142857142857143),
            (375.0151d.Nanometer(), 0.009523809523809525),
            (377.0633d.Nanometer(), 0.010714285714285714),
            (379.7909d.Nanometer(), 0.02023809523809524),
            (383.5397d.Nanometer(), 0.03571428571428571),
            (388.9064d.Nanometer(), 0.08333333333333333),
            (397.0075d.Nanometer(), 0.03571428571428571),
            (410.1734d.Nanometer(), 0.08333333333333333),
            (434.0472d.Nanometer(), 0.10714285714285714),
            (486.135d.Nanometer(), 0.21428571428571427),
            (656.279d.Nanometer(), 0.5952380952380952),
            (824.999d.Nanometer(), 0.00010714285714285714),
            (825.229d.Nanometer(), 0.00010714285714285714),
            (825.499d.Nanometer(), 0.00010714285714285714),
            (825.789d.Nanometer(), 0.00013095238095238096),
            (826.089d.Nanometer(), 0.00013095238095238096),
            (826.428d.Nanometer(), 0.00013095238095238096),
            (826.794d.Nanometer(), 0.00013095238095238096),
            (827.194d.Nanometer(), 0.00016666666666666666),
            (827.632d.Nanometer(), 0.00016666666666666666),
            (828.113d.Nanometer(), 0.00016666666666666666),
            (828.642d.Nanometer(), 0.00016666666666666666),
            (829.23d.Nanometer(), 0.0002023809523809524),
            (829.883d.Nanometer(), 0.00025),
            (830.61d.Nanometer(), 0.00029761904761904765),
            (831.426d.Nanometer(), 0.00034523809523809523),
            (832.342d.Nanometer(), 0.00034523809523809523),
            (833.378d.Nanometer(), 0.00044047619047619046),
            (834.554d.Nanometer(), 0.0005952380952380953),
            (835.9d.Nanometer(), 0.0005952380952380953),
            (837.448d.Nanometer(), 0.0007142857142857143),
            (839.24d.Nanometer(), 0.0008333333333333334),
            (841.332d.Nanometer(), 0.0008333333333333334),
            (843.795d.Nanometer(), 0.0008333333333333334),
            (846.726d.Nanometer(), 0.0008333333333333334),
            (859.839d.Nanometer(), 0.0027380952380952383),
            (875.046d.Nanometer(), 0.002619047619047619),
            (1093.817d.Nanometer(), 0.016666666666666666),
            (1281.8072d.Nanometer(), 0.0380952380952381),
            (1555.621d.Nanometer(), 0.0009523809523809524),
            (1640.688d.Nanometer(), 0.0016666666666666668),
            (1680.651d.Nanometer(), 0.0019047619047619048),
            (1736.2143d.Nanometer(), 0.0036904761904761906),
            (1817.424d.Nanometer(), 0.0033333333333333335),
            (2166.1178d.Nanometer(), 0.009523809523809525),
            (3740.576d.Nanometer(), 0.002976190476190476),
            (4052.279d.Nanometer(), 0.013095238095238096),
            (4653.78d.Nanometer(), 0.005),
            (7502.44d.Nanometer(), 0.0007380952380952381),
            (8154.84d.Nanometer(), 0.00014285714285714287),
            (8664.46d.Nanometer(), 0.00021428571428571427),
            (8760.064d.Nanometer(), 0.0005),
            (9392.03d.Nanometer(), 7.142857142857143E-05),
            (10503.507d.Nanometer(), 0.00022619047619047618),
            (10803.59d.Nanometer(), 9.523809523809524E-05),
            (11308.681d.Nanometer(), 0.0005),
            (11539.54d.Nanometer(), 0.00013095238095238096),
            (12371.912d.Nanometer(), 0.0004880952380952381),
            (12387.153d.Nanometer(), 0.0004047619047619048),
            (12587.05d.Nanometer(), 0.00025),
            (19061.96d.Nanometer(), 0.0006428571428571428),
            (69071.7d.Nanometer(), 1.6666666666666667E-05),
            (88761d.Nanometer(), 1.0714285714285714E-05),
            (111863d.Nanometer(), 1.6666666666666667E-05),
            (138750d.Nanometer(), 2.261904761904762E-05),
            (169423d.Nanometer(), 1.9047619047619046E-05),
        ]),
        null // TODO
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
        new SparseSpectrum([
            (32.02926d.Nanometer(), 0.005),
            (50.561d.Nanometer(), 0.001),
            (50.575d.Nanometer(), 0.0015),
            (50.59d.Nanometer(), 0.002),
            (50.631d.Nanometer(), 0.0025),
            (50.656d.Nanometer(), 0.0035),
            (50.708d.Nanometer(), 0.005),
            (50.771d.Nanometer(), 0.0075),
            (50.863d.Nanometer(), 0.01),
            (50.997d.Nanometer(), 0.0125),
            (51.207d.Nanometer(), 0.0175),
            (51.5596d.Nanometer(), 0.025),
            (52.2186d.Nanometer(), 0.05),
            (53.70293d.Nanometer(), 0.2),
            (58.43339d.Nanometer(), 0.5),
            (59.14121d.Nanometer(), 0.025),
            (257.76d.Nanometer(), 0.025),
            (267.7135d.Nanometer(), 0.0005),
            (269.6119d.Nanometer(), 0.0005),
            (272.3191d.Nanometer(), 0.0005),
            (276.3801583d.Nanometer(), 0.001),
            (276.3803097d.Nanometer(), 0.001),
            (276.3803221d.Nanometer(), 0.001),
            (281.82d.Nanometer(), 0.005),
            (282.9078411d.Nanometer(), 0.002),
            (282.9080951d.Nanometer(), 0.002),
            (282.9081157d.Nanometer(), 0.002),
            (294.5106d.Nanometer(), 0.005),
            (301.37d.Nanometer(), 0.02),
            (318.7745d.Nanometer(), 0.01),
            (325.8275d.Nanometer(), 0.0005),
            (335.4555098d.Nanometer(), 0.0005),
            (344.7589034d.Nanometer(), 0.001),
            (355.4415d.Nanometer(), 0.0005),
            (358.727d.Nanometer(), 0.0005),
            (361.3643d.Nanometer(), 0.0015),
            (363.4230767d.Nanometer(), 0.001),
            (363.4231071d.Nanometer(), 0.001),
            (363.4231092d.Nanometer(), 0.001),
            (363.4240864d.Nanometer(), 0.001),
            (363.4241168d.Nanometer(), 0.001),
            (365.199d.Nanometer(), 0.0005),
            (370.5005d.Nanometer(), 0.0015),
            (373.2863477d.Nanometer(), 0.0005),
            (373.287413d.Nanometer(), 0.0005),
            (381.96074d.Nanometer(), 0.005),
            (381.975731d.Nanometer(), 0.0005),
            (386.7472343d.Nanometer(), 0.0015),
            (386.7483778d.Nanometer(), 0.0015),
            (386.7631595d.Nanometer(), 0.0005),
            (387.1791d.Nanometer(), 0.0005),
            (388.8648d.Nanometer(), 0.25),
            (392.6544387d.Nanometer(), 0.0005),
            (396.47291d.Nanometer(), 0.01),
            (400.9256516d.Nanometer(), 0.0005),
            (402.3973d.Nanometer(), 0.0005),
            (402.61914d.Nanometer(), 0.025),
            (402.6356959d.Nanometer(), 0.0025),
            (412.08154d.Nanometer(), 0.006),
            (412.0991564d.Nanometer(), 0.001),
            (414.3761d.Nanometer(), 0.0015),
            (416.8967d.Nanometer(), 0.0005),
            (438.79296d.Nanometer(), 0.005),
            (443.7551d.Nanometer(), 0.0015),
            (447.14802d.Nanometer(), 0.1),
            (447.1683251d.Nanometer(), 0.0125),
            (471.31457d.Nanometer(), 0.015),
            (471.3375684d.Nanometer(), 0.002),
            (492.19313d.Nanometer(), 0.01),
            (501.56783d.Nanometer(), 0.05),
            (504.7738d.Nanometer(), 0.005),
            (587.5621d.Nanometer(), 0.25),
            (587.596628d.Nanometer(), 0.05),
            (667.8151d.Nanometer(), 0.05),
            (706.519d.Nanometer(), 0.1),
            (706.571d.Nanometer(), 0.015),
            (728.1349d.Nanometer(), 0.025),
            (781.612468d.Nanometer(), 0.0005),
            (781.61368d.Nanometer(), 0.0005),
            (781.613778d.Nanometer(), 0.0005),
            (836.171342d.Nanometer(), 0.001),
            (836.173561d.Nanometer(), 0.001),
            (836.173742d.Nanometer(), 0.001),
            (906.328214d.Nanometer(), 0.001),
            (906.328403d.Nanometer(), 0.001),
            (906.328417d.Nanometer(), 0.001),
            (906.330021d.Nanometer(), 0.001),
            (906.33021d.Nanometer(), 0.001),
            (921.0337d.Nanometer(), 0.001),
            (946.353679d.Nanometer(), 0.005),
            (946.358646d.Nanometer(), 0.005),
            (946.359051d.Nanometer(), 0.005),
            (951.65622d.Nanometer(), 0.002),
            (951.656532d.Nanometer(), 0.002),
            (951.656554d.Nanometer(), 0.002),
            (951.658212d.Nanometer(), 0.002),
            (951.658524d.Nanometer(), 0.002),
            (951.682735d.Nanometer(), 0.0005),
            (952.617d.Nanometer(), 0.0015),
            (952.927d.Nanometer(), 0.0005),
            (960.344084d.Nanometer(), 0.0005),
            (970.261409d.Nanometer(), 0.0015),
            (970.26348d.Nanometer(), 0.0015),
            (1002.773d.Nanometer(), 0.003),
            (1003.116d.Nanometer(), 0.001),
            (1013.842357d.Nanometer(), 0.0005),
            (1031.12211d.Nanometer(), 0.005),
            (1031.122691d.Nanometer(), 0.005),
            (1031.122731d.Nanometer(), 0.005),
            (1031.124448d.Nanometer(), 0.005),
            (1031.125029d.Nanometer(), 0.005),
            (1031.153237d.Nanometer(), 0.001),
            (1066.766206d.Nanometer(), 0.0015),
            (1066.768709d.Nanometer(), 0.0015),
            (1082.909115d.Nanometer(), 0.15),
            (1083.025011d.Nanometer(), 0.5),
            (1083.033978d.Nanometer(), 1),
            (1091.292d.Nanometer(), 0.006),
            (1091.305d.Nanometer(), 0.0045),
            (1091.71d.Nanometer(), 0.0015),
            (1101.307135d.Nanometer(), 0.001),
            (1104.498297d.Nanometer(), 0.001),
            (1196.904506d.Nanometer(), 0.022),
            (1196.905861d.Nanometer(), 0.022),
            (1196.905953d.Nanometer(), 0.022),
            (1196.907657d.Nanometer(), 0.022),
            (1196.912d.Nanometer(), 0.015),
            (1252.752d.Nanometer(), 0.01),
            (1278.479d.Nanometer(), 0.0405),
            (1278.499d.Nanometer(), 0.025),
            (1279.057d.Nanometer(), 0.01),
            (1284.596d.Nanometer(), 0.0035),
            (1296.845d.Nanometer(), 0.005),
            (1298.489d.Nanometer(), 0.001),
            (1508.364d.Nanometer(), 0.006),
            (1700.247d.Nanometer(), 0.1),
            (1855.557348d.Nanometer(), 0.0005),
            (1868.534d.Nanometer(), 0.25),
            (1869.723d.Nanometer(), 0.1),
            (1908.938d.Nanometer(), 0.05),
            (1954.308d.Nanometer(), 0.01),
            (2058.692d.Nanometer(), 0.5),
            (2112.583d.Nanometer(), 0.04),
            (2112.72d.Nanometer(), 0.005),
            (2113.78d.Nanometer(), 0.01),
        ]),
        null
    ).AddIsotopes([
        (3, .000002, []),
        (4, .999998, [])
    ]);

    // TODO : all other elements
}
