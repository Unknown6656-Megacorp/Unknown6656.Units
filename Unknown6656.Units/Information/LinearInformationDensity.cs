using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Information;


[KnownBaseUnit<LinearInformationDensity, BitPerMeter, Scalar>]
public partial record BitPerMeter
{
    public static string UnitSymbol { get; } = "bit/m";
    static string[] IUnit.AlternativeUnitSymbols { get; } = [];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<LinearInformationDensity, BitPerMillimeter, BitPerMeter, Scalar>(KnownUnitType.Linear)]
public partial record BitPerMillimeter
{
    public static string UnitSymbol { get; } = "bit/mm";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/millimeter"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e3;
}

[KnownUnit<LinearInformationDensity, BytePerMeter, BitPerMeter, Scalar>(KnownUnitType.Linear)]
public partial record BytePerMeter
{
    public static string UnitSymbol { get; } = "B/m";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/meter", "B/meter"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor;
}

[KnownUnit<LinearInformationDensity, BytePerMillimeter, BitPerMeter, Scalar>(KnownUnitType.Linear)]
public partial record BytePerMillimeter
{
    public static string UnitSymbol { get; } = "B/mm";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/millimeter", "B/millimeter", "byte/mm"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor / 1e3;
}

[KnownUnit<LinearInformationDensity, BitPerInch, BitPerMeter, Scalar>(KnownUnitType.Linear)]
public partial record BitPerInch
{
    public static string UnitSymbol { get; } = "bit/in";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/inch"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Inch.ScalingFactor;
}

[KnownUnit<LinearInformationDensity, BytePerInch, BitPerMeter, Scalar>(KnownUnitType.Linear)]
public partial record BytePerInch
{
    public static string UnitSymbol { get; } = "B/in";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/inch", "B/inch", "byte/in"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor / Inch.ScalingFactor;
}

[KnownUnit<LinearInformationDensity, BitPerFoot, BitPerMeter, Scalar>(KnownUnitType.Linear)]
public partial record BitPerFoot
{
    public static string UnitSymbol { get; } = "bit/ft";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/foot"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Foot.ScalingFactor;
}

[KnownUnit<LinearInformationDensity, BytePerFoot, BitPerMeter, Scalar>(KnownUnitType.Linear)]
public partial record BytePerFoot
{
    public static string UnitSymbol { get; } = "B/ft";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/foot", "B/foot", "byte/ft"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor / Foot.ScalingFactor;
}
