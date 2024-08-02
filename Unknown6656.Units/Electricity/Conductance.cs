namespace Unknown6656.Units.Electricity;


[KnownBaseUnit<Conductance, Siemens, Scalar>]
public partial record Siemens
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "S";
#else
    private static volatile bool _omega_unit_symbol = false;


    public static bool UseInvertedOmegaAsUnitSymbol
    {
        get => _omega_unit_symbol;
        set => _omega_unit_symbol = value;
    }

    public static string UnitSymbol => _omega_unit_symbol ? "℧" : "S";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["mho"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
