namespace Unknown6656.Units.Electricity;


[KnownBaseUnit<Resistance, Ohm, Scalar>]
public partial record Ohm(Scalar Value)
    : BaseUnit<Resistance, Ohm, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "Ω";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
