namespace Unknown6656.Units.Photometry;


[KnownBaseUnit<Illuminance, Lux, Scalar>]
public partial record Lux
{
    public static string UnitSymbol { get; } = "lx";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lm/meter^2", "lumen/m^2", "lm*m^-2", "lumen*m^-2", "lm*meter^-2", "lumen*meter^-2","lumen/sq meter", "lumen/sqm", "lm/m^2", "lumen/square meter"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Illuminance, FootCandle, Lux, Scalar>(KnownUnitType.Linear)]
public partial record FootCandle
{
    public static string UnitSymbol { get; } = "fc";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ftc", "ft candle", "foot c"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0929030400000000026612187291648000762309298431731979596441330692;
}

[KnownUnit<Illuminance, Phot, Lux, Scalar>(KnownUnitType.Linear)]
public partial record Phot
{
    public static string UnitSymbol { get; } = "ph";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-4;
}
