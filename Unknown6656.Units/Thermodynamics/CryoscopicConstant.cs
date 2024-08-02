namespace Unknown6656.Units.Thermodynamics;


[KnownBaseUnit<CryoscopicConstant, KilogramKelvinPerMol, Scalar>]
public partial record KilogramKelvinPerMol
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "kg*K/mol";
#else
    public static string UnitSymbol { get; } = "kg·K·mol⁻¹";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kg*K/mol", "kilo*K/mol", "kilogram*K/mol", "kg*kelvin/mol", "kilo*kelvin/mol", "kilogram*kelvin/mol"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
}

// TODO : imperial equivalents