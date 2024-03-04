namespace Unknown6656.Units.Thermodynamics;


[KnownBaseUnit<SpecificEntropy, JoulePerKilogramKelvin, Scalar>]
public partial record JoulePerKilogramKelvin(Scalar Value)
    : BaseUnit<SpecificEntropy, JoulePerKilogramKelvin, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "J/kg/mol";
#else
    public static string UnitSymbol { get; } = "J·kg⁻¹·mol⁻¹";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["J/kg/mol", "J/mol/kg", "J/(mol*kg)", "J/(kg*mol)", "joule/kg/mol",
        "joule/mol/kg", "joule/(mol*kg)", "joule/(kg*mol)", "joule/kilo/mol", "joule/mol/kilo", "joule/(mol*kilo)", "joule/(kilo*mol)",
        "J/kilo/mol", "J/mol/kilo", "J/(mol*kilo)", "J/(kilo*mol)", "joule/kilogram/mol", "joule/mol/kilogram", "joule/(mol*kilogram)",
        "joule/(kilogram*mol)", "J/kilogram/mol", "J/mol/kilogram", "J/(mol*kilogram)", "J/(kilogram*mol)",
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
