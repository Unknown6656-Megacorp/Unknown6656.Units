namespace Unknown6656.Units.Electricity;


[KnownBaseUnit<Inductance, Henry, Scalar>]
public partial record Henry
{
    public static string UnitSymbol { get; } = "H";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
