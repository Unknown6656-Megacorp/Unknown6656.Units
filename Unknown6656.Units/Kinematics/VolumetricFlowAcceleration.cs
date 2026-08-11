namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<VolumetricFlowAcceleration, CubicMeterPerSecondSquared, Scalar>]
public partial record CubicMeterPerSecondSquared
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "m^3/s^2";
#else
    public static string UnitSymbol { get; } = "m³/s²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = [
        "cubic meter per square second", "cubic meter/square second", "cubic m/square second", "meter^3/square second", "m^3/square second",
        "cubic meter per second^2", "cubic meter/second^2", "cubic m/second^2", "meter^3/second^2", "m^3/second^2",
        "cubic meter per sec^2", "cubic meter/sec^2", "cubic m/sec^2", "meter^3/sec^2", "m^3/sec^2",
        "cubic meter per s^2", "cubic meter/s^2", "cubic m/s^2", "meter^3/s^2", "m^3/s^2",
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
}
