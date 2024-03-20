namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<Jerk, MeterPerSecondCubed, Scalar>]
public partial record MeterPerSecondCubed
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "m/s^2";
#else
    public static string UnitSymbol { get; } = "m/s³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["meter/cube second", "m/second^3", "meter/s^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Jerk, FootPerSecondCubed, MeterPerSecondCubed, Scalar>(KnownUnitType.Linear)]
public partial record FootPerSecondCubed
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "ft/s^2";
#else
    public static string UnitSymbol { get; } = "ft/s³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["feet/cube second", "ft/second^3", "feet/s^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)3.280839895013123;
}
