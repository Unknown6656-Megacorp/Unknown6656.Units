namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<KinematicViscosity, SquareMeterPerSecond, Scalar>]
public partial record SquareMeterPerSecond
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "m^2/s";
#else
    public static string UnitSymbol { get; } = "m³/s";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["square meter/second", "square m/s", "square meter/s", "meter^2/s", "meter^2/second", "m^2/second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
}
