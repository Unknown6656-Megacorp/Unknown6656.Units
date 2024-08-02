using Unknown6656.Units.Matter;

namespace Unknown6656.Units.Information;


[KnownBaseUnit<SpecificInformationCapacity, BitPerKilogram, Scalar>]
public partial record BitPerKilogram
{
    public static string UnitSymbol { get; } = "bit/kg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/kilo"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<SpecificInformationCapacity, BitPerGram, BitPerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record BitPerGram
{
    public static string UnitSymbol { get; } = "bit/g";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Gram.ScalingFactor;
}

[KnownUnit<SpecificInformationCapacity, BitPerMilligram, BitPerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record BitPerMilligram
{
    public static string UnitSymbol { get; } = "bit/mg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/milligram"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1e6;
}

[KnownUnit<SpecificInformationCapacity, BytePerKilogram, BitPerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record BytePerKilogram
{
    public static string UnitSymbol { get; } = "B/kg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/kg", "byte/kilo", "byte/kilogram", "B/kilo", "B/kilogram"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor;
}

[KnownUnit<SpecificInformationCapacity, BytePerGram, BitPerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record BytePerGram
{
    public static string UnitSymbol { get; } = "B/g";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/g", "byte/gram", "B/gram"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor / Gram.ScalingFactor;
}

[KnownUnit<SpecificInformationCapacity, BytePerMilligram, BitPerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record BytePerMilligram
{
    public static string UnitSymbol { get; } = "B/mg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/mg", "byte/milligram", "B/mg", "B/milligram"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor * 1e6;
}

[KnownUnit<SpecificInformationCapacity, BitPerPound, BitPerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record BitPerPound
{
    public static string UnitSymbol { get; } = "bit/lb";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/pound"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Pound.ScalingFactor;
}

[KnownUnit<SpecificInformationCapacity, BytePerPound, BitPerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record BytePerPound
{
    public static string UnitSymbol { get; } = "B/lb";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/lb", "byte/pound", "b/lb", "b/pound"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor / Pound.ScalingFactor;
}

[KnownUnit<SpecificInformationCapacity, BitPerOunce, BitPerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record BitPerOunce
{
    public static string UnitSymbol { get; } = "bit/oz";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/ounce"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Ounce.ScalingFactor;
}

[KnownUnit<SpecificInformationCapacity, BytePerOunce, BitPerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record BytePerOunce
{
    public static string UnitSymbol { get; } = "B/oz";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/oz", "byte/ounce", "b/oz", "b/ounce"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor / Ounce.ScalingFactor;
}
