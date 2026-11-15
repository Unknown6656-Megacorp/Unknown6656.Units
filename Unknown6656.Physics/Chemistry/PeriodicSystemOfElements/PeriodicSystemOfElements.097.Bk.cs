using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;

using Unknown6656.Physics.Optics;

namespace Unknown6656.Physics.Chemistry;


public partial class Element
{
    public static Element Berkelium => field ??= PeriodicTableOfElements.RegisterElement(new()
    {
        Name = nameof(Berkelium),
        Symbol = "Bk",
        CASNumber = "CAS7440-40-6",
        CIDNumber = null,
        DiscoveryYear = 1949,
        AtomicNumber = 97,
        Category = ElementCategory.Actinide,
        Occurrence = ElementOccurrence.Synthetic,
        Abundance = ElementAbundance.Zero,
        Thermodynamics = new()
        {
            MeltingPoint = 1259.Kelvin,
            BoilingPoint = 2900.Kelvin,
            StandardDensity = 14.78.GramPerCubicCentimeter,
            TriplePoint = null,
            CriticalPoint = null,
            HeatOfFusion = 7.92e3.JoulePerMol,
            HeatOfVaporization = null,
            ThermalCapacity = null,
            IonizationEnergies = [
                .601e6.JoulePerMol,
                1.186e6.JoulePerMol,
                2.152e6.JoulePerMol,
                3.434e6.JoulePerMol,
            ],
            ThermalExpansion = null,
            ThermalConductivity = 10.WattPerMeterKelvin,
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
                new(5, ElectronOrbital.F, 9),
                new(6, ElectronOrbital.S, 2),
                new(6, ElectronOrbital.P, 6),
                new(7, ElectronOrbital.S, 2),
            ]),
            Valence = 11,
            OxidationStates = [2, 3, 4, 5],
            CommonOxidationStates = [3],
            PaulingElectronegativity = 1.3,
            AllenElectronegativity = null,
            MeanAtomicRadius = 170e-9.Meter,
            CovalentRadius = 170e-9.Meter,
            VanDerWaalsRadius = 170e-9.Meter,
        },
        Electromagnetics = ElectromagneticalElementProperties.Unknown[ElectricalElementType.Conductor],
        Kinematics = KinematicElementProperties.Unknown,
        Optics = new()
        {
            RefractiveIndex = null,
            ExtinctionCoefficient = 1,
            EmissionSpectrum = new SparseSpectrum([
                (274.802.Nanometer, 1),
                (282.757.Nanometer, 1),
                (287.211.Nanometer, 1),
                (287.857.Nanometer, 1),
                (288.477.Nanometer, 1),
                (288.98.Nanometer, 1),
                (289.366.Nanometer, 1),
                (291.065.Nanometer, 1),
                (294.171.Nanometer, 1),
                (295.176.Nanometer, 1),
                (296.913.Nanometer, 1),
                (298.776.Nanometer, 1),
                (317.847.Nanometer, 1),
                (323.972.Nanometer, 1),
                (324.726.Nanometer, 1),
                (325.219.Nanometer, 1),
                (326.347.Nanometer, 1),
                (328.875.Nanometer, 1),
                (328.935.Nanometer, 1),
                (330.235.Nanometer, 1),
                (333.526.Nanometer, 1),
                (338.745.Nanometer, 1),
                (340.828.Nanometer, 1),
                (341.213.Nanometer, 1),
                (342.695.Nanometer, 1),
                (343.262.Nanometer, 1),
                (343.747.Nanometer, 1),
                (344.266.Nanometer, 1),
                (345.39.Nanometer, 1),
                (346.124.Nanometer, 1),
                (346.413.Nanometer, 1),
                (347.202.Nanometer, 1),
                (347.762.Nanometer, 1),
                (352.872.Nanometer, 1),
                (353.14.Nanometer, 1),
                (353.573.Nanometer, 1),
                (354.219.Nanometer, 1),
                (355.36.Nanometer, 1),
                (355.588.Nanometer, 1),
                (355.652.Nanometer, 1),
                (356.725.Nanometer, 1),
                (359.032.Nanometer, 1),
                (359.588.Nanometer, 1),
                (360.112.Nanometer, 1),
                (360.32.Nanometer, 1),
                (362.761.Nanometer, 1),
                (363.705.Nanometer, 1),
                (364.026.Nanometer, 1),
                (364.093.Nanometer, 1),
                (367.559.Nanometer, 1),
                (368.122.Nanometer, 1),
                (368.443.Nanometer, 1),
                (368.521.Nanometer, 1),
                (368.674.Nanometer, 1),
                (369.273.Nanometer, 1),
                (369.537.Nanometer, 1),
                (370.328.Nanometer, 1),
                (370.402.Nanometer, 1),
                (370.526.Nanometer, 1),
                (371.114.Nanometer, 1),
                (371.293.Nanometer, 1),
                (372.539.Nanometer, 1),
                (373.992.Nanometer, 1),
                (374.305.Nanometer, 1),
                (374.54.Nanometer, 1),
                (375.008.Nanometer, 1),
                (375.191.Nanometer, 1),
                (375.735.Nanometer, 1),
                (375.785.Nanometer, 1),
                (377.106.Nanometer, 1),
                (378.072.Nanometer, 1),
                (378.117.Nanometer, 1),
                (378.538.Nanometer, 1),
                (378.821.Nanometer, 1),
                (379.142.Nanometer, 1),
                (379.621.Nanometer, 1),
                (379.863.Nanometer, 1),
                (380.108.Nanometer, 1),
                (380.235.Nanometer, 1),
                (380.247.Nanometer, 1),
                (381.529.Nanometer, 1),
                (382.31.Nanometer, 1),
                (382.408.Nanometer, 1),
                (382.519.Nanometer, 1),
                (382.584.Nanometer, 1),
                (382.741.Nanometer, 1),
                (383.055.Nanometer, 1),
                (383.157.Nanometer, 1),
                (383.597.Nanometer, 1),
                (384.219.Nanometer, 1),
                (384.662.Nanometer, 1),
                (384.763.Nanometer, 1),
                (385.503.Nanometer, 1),
                (385.989.Nanometer, 1),
                (387.794.Nanometer, 1),
                (388.011.Nanometer, 1),
                (388.26.Nanometer, 1),
                (389.455.Nanometer, 1),
                (390.609.Nanometer, 1),
                (391.216.Nanometer, 1),
                (391.637.Nanometer, 1),
                (392.142.Nanometer, 1),
                (392.805.Nanometer, 1),
                (414.713.Nanometer, 1),
                (418.969.Nanometer, 1),
                (419.744.Nanometer, 1),
                (432.958.Nanometer, 1),
                (435.15.Nanometer, 1),
                (436.364.Nanometer, 1),
                (442.301.Nanometer, 1),
                (446.646.Nanometer, 1),
                (505.673.Nanometer, 1),
                (511.824.Nanometer, 1),
                (513.553.Nanometer, 1),
                (517.061.Nanometer, 1),
                (519.755.Nanometer, 1),
                (521.253.Nanometer, 1),
                (527.195.Nanometer, 1),
                (539.203.Nanometer, 1),
                (539.424.Nanometer, 1),
                (540.462.Nanometer, 1),
                (544.963.Nanometer, 1),
                (546.747.Nanometer, 1),
                (548.458.Nanometer, 1),
                (551.222.Nanometer, 1),
                (553.793.Nanometer, 1),
                (555.68.Nanometer, 1),
                (555.709.Nanometer, 1),
                (558.121.Nanometer, 1),
                (565.654.Nanometer, 1),
                (565.903.Nanometer, 1),
                (570.224.Nanometer, 1),
                (591.071.Nanometer, 1),
                (704.085.Nanometer, 1),
                (710.785.Nanometer, 1),
                (717.622.Nanometer, 1),
                (725.25.Nanometer, 1),
                (725.721.Nanometer, 1),
                (730.694.Nanometer, 1),
                (751.126.Nanometer, 1),
                (755.112.Nanometer, 1),
                (757.977.Nanometer, 1),
                (772.993.Nanometer, 1),
                (790.39.Nanometer, 1),
                (931.93.Nanometer, 1),
                (942.913.Nanometer, 1),
                (980.118.Nanometer, 1),
                (986.239.Nanometer, 1),
                (987.929.Nanometer, 1),
                (989.238.Nanometer, 1),
                (1012.62.Nanometer, 1),
                (1018.658.Nanometer, 1),
                (1029.244.Nanometer, 1),
                (1052.771.Nanometer, 1),
                (1057.053.Nanometer, 1),
                (1129.314.Nanometer, 1),
                (1150.03.Nanometer, 1),
                (1157.534.Nanometer, 1),
                (1179.309.Nanometer, 1),
                (1215.905.Nanometer, 1),
                (1306.113.Nanometer, 1),
                (1349.836.Nanometer, 1),
                (1419.693.Nanometer, 1),
                (1513.61.Nanometer, 1),
                (1927.387.Nanometer, 1),
                (1965.322.Nanometer, 1),
                (2390.937.Nanometer, 1),
                (2419.922.Nanometer, 1),
            ]),
        }
    }).AddIsotopes([
        new()
        {
            NeutronCount = 136,
            Spin = -1.5,
            Decays = [
                new(DecayMode.Alpha, 40.Second, .82),
                new(DecayMode.PositronEmission, 40.Second, .18)
            ],
        },
        new()
        {
            NeutronCount = 137,
            Spin = -3,
            Decays = [
                new(DecayMode.Alpha, 20.Second, .8),
                new(DecayMode.PositronEmission, 20.Second, .2)
            ],
        },
        new ()
        {
            NeutronCount = 138,
            Spin = -1.5,
            Decays = [
                new(DecayMode.Alpha, 1.Minute),
                new(DecayMode.PositronEmission, 1.Minute)
            ],
        },
        new()
        {
            NeutronCount = 139,
            Spin = 4,
            Decays = [
                new(DecayMode.PositronEmission, 26.Second, .9996),
                new(DecayMode.SpontaneousFission, 26.Second, .0004)
            ],
        },
        new()
        {
            NeutronCount = 141,
            Spin = 1,
            Decays = [
                new(DecayMode.PositronEmission, 2.40.Minute, .99952),
                new(DecayMode.SpontaneousFission, 2.40.Minute, .00048)
            ],
        },
        new()
        {
            NeutronCount = 142,
            Spin = 3.5,
            Decays = [new(DecayMode.PositronEmission, 100.Second)],
        },
        new()
        {
            NeutronCount = 143,
            Spin = -7,
            Decays = [
                new(DecayMode.PositronEmission, 4.8.Minute, .5),
                new(DecayMode.Alpha, 4.8.Minute, .5),
                new(DecayMode.SpontaneousFission, 4.8.Minute, .000013)
            ],
        },
        new()
        {
            NeutronCount = 144,
            Spin = 3.5,
            Decays = [new(DecayMode.PositronEmission, 4.6.Minute)],
        },
        new()
        {
            NeutronCount = 145,
            Spin = 3,
            Decays = [
                new(DecayMode.PositronEmission, 7.0.Minute, 1),
                new(DecayMode.SpontaneousFission, 7.0.Minute, 3e-7)
            ],
        },
        new()
        {
            NeutronCount = 146,
            Spin = -1.5,
            Decays = [
                new(DecayMode.PositronEmission, 4.6.Hour, .9985),
                new(DecayMode.Alpha, 4.6.Hour, .0015)
            ],
        },
        new()
        {
            NeutronCount = 147,
            Spin = -4,
            Decays = [
                new(DecayMode.PositronEmission, 5.02.Hour, .99994),
                new(DecayMode.Alpha, 5.02.Hour, 6e-5)
            ],
        },
        new()
        {
            NeutronCount = 148,
            Spin = -1.5,
            Decays = [
                new(DecayMode.ElectronCapture, 4.95.StandardDay, .9988),
                new(DecayMode.Alpha, 4.95.StandardDay, .0012)
            ],
        },
        new()
        {
            NeutronCount = 149,
            Spin = -2,
            Decays = [new(DecayMode.PositronEmission, 1.80.StandardDay)],
        },
        new()
        {
            NeutronCount = 150,
            Spin = -1.5,
            Decays = [
                new(DecayMode.Alpha, 1.38e3.SolarYear),
                new(DecayMode.SpontaneousFission, 1.38e3.SolarYear)
            ],
        },
        new()
        {
            NeutronCount = 151,
            Spin = 6,
            Decays = [
                new(DecayMode.Alpha, 9.SolarYear),
                new(DecayMode.ElectronCapture, 9.SolarYear),
                new(DecayMode.Beta, 9.SolarYear)
            ],
        },
        new()
        {
            NeutronCount = 152,
            Spin = 3.5,
            Decays = [
                new(DecayMode.Beta, 327.2.StandardDay, .9999854995299999),
                new(DecayMode.Alpha, 327.2.StandardDay, 1.45e-5),
                new(DecayMode.SpontaneousFission, 327.2.StandardDay, 4.7e-10)
            ],
        },
        new()
        {
            NeutronCount = 153,
            Spin = -2,
            Decays = [new(DecayMode.Beta, 3.212.Hour)],
        },
        new()
        {
            NeutronCount = 154,
            Spin = -1.5,
            Decays = [new(DecayMode.Beta, 55.6.Minute)],
        },
        new()
        {
            NeutronCount = 155,
            Spin = 0,
            Decays = [new(DecayMode.Beta, 1.8.Minute)],
        },
        new()
        {
            NeutronCount = 156,
            Spin = -1.5,
            Decays = [new(DecayMode.Beta, 60.Minute)],
        },
    ]);
}
