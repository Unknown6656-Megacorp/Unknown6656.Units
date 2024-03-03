namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<Absement, MeterSecond, Scalar>]
public partial record MeterSecond(Scalar Value)
    : BaseUnit<Absement, MeterSecond, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "m*s";
#else
    public static string UnitSymbol { get; } = "m·s";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["meter*s", "meter second", "meter sec", "meter*sec", "m*sec", "m*second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

// TODO : imperial equivalents
