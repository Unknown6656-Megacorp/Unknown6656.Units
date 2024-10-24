namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<AngularMomentum, KilogramSquareMeterPerSecond, Scalar>]
public partial record KilogramSquareMeterPerSecond
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "kg*m^2/s";
#else
    public static string UnitSymbol { get; } = "kg·m²·s⁻¹";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
    static string[] IUnit.AlternativeUnitSymbols { get; } = [
        "kg m^2/s", "kilo m^2/s", "kilogram m^2/s", "kg sqm/s", "kilo sqm/s", "kilogram sqm/s", "kg sq meter/s", "kilo sq meter/s", "kilogram sq meter/s",
        "kg square meter/s", "kilo square meter/s", "kilogram square meter/s", "kg meter squared/s", "kilo meter squared/s", "kilogram meter squared/s",
        "kg m^2/sec", "kilo m^2/sec", "kilogram m^2/sec", "kg sqm/sec", "kilo sqm/sec", "kilogram sqm/sec", "kg sq meter/sec", "kilo sq meter/sec",
        "kilogram sq meter/sec", "kg square meter/sec", "kilo square meter/sec", "kilogram square meter/sec", "kg meter squared/sec", "kilo meter squared/sec",
        "kilogram meter squared/sec", "kg m^2/second", "kilo m^2/second", "kilogram m^2/second", "kg sqm/second", "kilo sqm/second", "kilogram sqm/second",
        "kg sq meter/second", "kilo sq meter/second", "kilogram sq meter/second", "kg square meter/second", "kilo square meter/second", "kilogram square meter/second",
        "kg meter squared/second", "kilo meter squared/second", "kilogram meter squared/second",
    ];
}
