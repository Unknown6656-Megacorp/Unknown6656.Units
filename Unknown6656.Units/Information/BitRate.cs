namespace Unknown6656.Units.Information;


[KnownBaseUnit<BitRate, BitPerSecond, Scalar>]
public partial record BitPerSecond
{
    public static string UnitSymbol { get; } = "bps";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/s", "bit/sec"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<BitRate, BytePerSecond, BitPerSecond, Scalar>(KnownUnitType.Linear)]
public partial record BytePerSecond
{
    public static string UnitSymbol { get; } = "B/s";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/s", "B/second", "byte/second", "byte/sec", "B/sec"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor;
}

// TODO : baud
// TODO : bogomips https://en.wikipedia.org/wiki/BogoMips