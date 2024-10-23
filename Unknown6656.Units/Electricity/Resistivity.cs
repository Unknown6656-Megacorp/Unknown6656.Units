namespace Unknown6656.Units.Electricity;


[KnownBaseUnit<Resistivity, OhmMeter, Scalar>]
public partial record OhmMeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Ohm*m";
#else
    public static string UnitSymbol { get; } = "Ω·m";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
