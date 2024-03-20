using Unknown6656.Units.Energy;

namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<LinearEnergyTransfer, JoulePerMeter, Scalar>]
public partial record JoulePerMeter
{
    public static string UnitSymbol { get; } = "J/m";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["joule/meter", "J/meter", "joule/m"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<LinearEnergyTransfer, ElectronVoltPerMeter, JoulePerMeter, Scalar>(KnownUnitType.Linear)]
public partial record ElectronVoltPerMeter
{
    public static string UnitSymbol { get; } = "eV/m";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["electronvolt/meter", "eV/meter", "electronvolt/m"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = ElectronVolt.ScalingFactor;
}

[KnownUnit<LinearEnergyTransfer, ElectronVoltPerMillimeter, JoulePerMeter, Scalar>(KnownUnitType.Linear)]
public partial record ElectronVoltPerMillimeter
{
    public static string UnitSymbol { get; } = "eV/mm";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["electronvolt/millimeter", "eV/millimeter", "electronvolt/mm"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = ElectronVolt.ScalingFactor / 1e3;
}

[KnownUnit<LinearEnergyTransfer, ElectronVoltPerMicrometer, JoulePerMeter, Scalar>(KnownUnitType.Linear)]
public partial record ElectronVoltPerMicrometer
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "eV/um";
#else
    public static string UnitSymbol { get; } = "eV/μm";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["electronvolt/micrometer", "eV/micrometer", "electronvolt/μm"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = ElectronVolt.ScalingFactor / 1e6;
}
