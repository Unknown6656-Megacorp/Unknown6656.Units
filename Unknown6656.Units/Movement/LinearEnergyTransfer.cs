using Unknown6656.Units.Energy;

namespace Unknown6656.Units.Movement;


[KnownBaseUnit<LinearEnergyTransfer, JoulePerMeter, Scalar>]
public partial record JoulePerMeter(Scalar Value)
    : BaseUnit<LinearEnergyTransfer, JoulePerMeter, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "J/m";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["joule/meter", "J/meter", "joule/m"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<LinearEnergyTransfer, ElectronVoltPerMeter, JoulePerMeter, Scalar>]
public partial record ElectronVoltPerMeter(Scalar Value)
    : LinearEnergyTransfer.AffineUnit<ElectronVoltPerMeter>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "eV/m";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["electronvolt/meter", "eV/meter", "electronvolt/m"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = ElectronVolt.ScalingFactor;
}

[KnownUnit<LinearEnergyTransfer, ElectronVoltPerMillimeter, JoulePerMeter, Scalar>]
public partial record ElectronVoltPerMillimeter(Scalar Value)
    : LinearEnergyTransfer.AffineUnit<ElectronVoltPerMillimeter>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "eV/mm";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["electronvolt/millimeter", "eV/millimeter", "electronvolt/mm"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = ElectronVolt.ScalingFactor / 1e3;
}

[KnownUnit<LinearEnergyTransfer, ElectronVoltPerMicrometer, JoulePerMeter, Scalar>]
public partial record ElectronVoltPerMicrometer(Scalar Value)
    : LinearEnergyTransfer.AffineUnit<ElectronVoltPerMicrometer>(Value)
    , ILinearUnit<Scalar>
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
