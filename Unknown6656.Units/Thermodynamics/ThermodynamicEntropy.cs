using Unknown6656.Units.Energy;

namespace Unknown6656.Units.Thermodynamics;


[KnownBaseUnit<ThermodynamicEntropy, JoulePerMolKelvin, Scalar>]
public partial record JoulePerMolKelvin(Scalar Value)
    : BaseUnit<ThermodynamicEntropy, JoulePerMolKelvin, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "J/K/mol";
#else
    public static string UnitSymbol { get; } = "J·K⁻¹·mol⁻¹";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["J/K/mol", "J/mol/K", "J/(mol*K)", "J/(K*mol)", "joule/K/mol",
        "joule/mol/K", "joule/(mol*K)", "joule/(K*mol)", "joule/kelvin/mol", "joule/mol/kelvin", "joule/(mol*kelvin)",
        "joule/(kelvin*mol)", "J/kelvin/mol", "J/mol/kelvin", "J/(mol*kelvin)", "J/(kelvin*mol)"
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<ThermodynamicEntropy, EntropyUnit, JoulePerMolKelvin, Scalar>]
public partial record EntropyUnit(Scalar Value)
    : ThermodynamicEntropy.AffineUnit<EntropyUnit>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "eU";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["e.u.", "entropy U", "cal/K/mol", "cal/mol/K", "cal/(K*mol)", "cal/(mol*K)",
        "cal/kelvin/mol", "cal/mol/kelvin", "cal/(kelvin*mol)", "cal/(mol*kelvin)", "calorie/K/mol", "calorie/mol/K", "calorie/(K*mol)",
        "calorie/(mol*K)", "calorie/kelvin/mol", "calorie/mol/kelvin", "calorie/(kelvin*mol)", "calorie/(mol*kelvin)",
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Calorie.ScalingFactor;
}
