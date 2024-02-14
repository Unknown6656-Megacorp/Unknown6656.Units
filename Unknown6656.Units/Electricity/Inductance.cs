namespace Unknown6656.Units.Electricity;


[KnownBaseUnit<Inductance, Henry, Scalar>]
public partial record Henry(Scalar Value)
    : BaseUnit<Inductance, Henry, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "H";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
