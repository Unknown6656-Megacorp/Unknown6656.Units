namespace Unknown6656.Units.Electricity;


[KnownBaseUnit<Conductance, Siemens, Scalar>]
public partial record Siemens(Scalar Value)
    : BaseUnit<Conductance, Siemens, Scalar>(Value)
{
    private static volatile bool _omega_unit_symbol = false;


    public static bool UseInvertedOmegaAsUnitSymbol
    {
        get => _omega_unit_symbol;
        set => _omega_unit_symbol = value;
    }

    public static string UnitSymbol => _omega_unit_symbol ? "℧" : "S";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}
