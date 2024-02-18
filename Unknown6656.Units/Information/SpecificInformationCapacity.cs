using Unknown6656.Units.Matter;

namespace Unknown6656.Units.Information;


[KnownBaseUnit<SpecificInformationCapacity, BitPerKilogram, Scalar>]
public partial record BitPerKilogram(Scalar Value)
    : BaseUnit<SpecificInformationCapacity, BitPerKilogram, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "bit/kg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/kilo"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<SpecificInformationCapacity, BitPerGram, BitPerKilogram, Scalar>]
public partial record BitPerGram(Scalar Value)
    : SpecificInformationCapacity.AffineUnit<BitPerGram>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "bit/g";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Gram.ScalingFactor;
}

[KnownUnit<SpecificInformationCapacity, BitPerMilligram, BitPerKilogram, Scalar>]
public partial record BitPerMilligram(Scalar Value)
    : SpecificInformationCapacity.AffineUnit<BitPerMilligram>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "bit/mg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/milligram"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1e6;
}

[KnownUnit<SpecificInformationCapacity, BytePerKilogram, BitPerKilogram, Scalar>]
public partial record BytePerKilogram(Scalar Value)
    : SpecificInformationCapacity.AffineUnit<BytePerKilogram>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "B/kg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/kg", "byte/kilo", "byte/kilogram", "B/kilo", "B/kilogram"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor;
}

[KnownUnit<SpecificInformationCapacity, BytePerGram, BitPerKilogram, Scalar>]
public partial record BytePerGram(Scalar Value)
    : SpecificInformationCapacity.AffineUnit<BytePerGram>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "B/g";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/g", "byte/gram", "B/gram"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor / Gram.ScalingFactor;
}

[KnownUnit<SpecificInformationCapacity, BytePerMilligram, BitPerKilogram, Scalar>]
public partial record BytePerMilligram(Scalar Value)
    : SpecificInformationCapacity.AffineUnit<BytePerMilligram>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "B/mg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/mg", "byte/milligram", "B/mg", "B/milligram"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor * 1e6;
}

[KnownUnit<SpecificInformationCapacity, BitPerPound, BitPerKilogram, Scalar>]
public partial record BitPerPound(Scalar Value)
    : SpecificInformationCapacity.AffineUnit<BitPerPound>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "bit/lb";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/pound"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Pound.ScalingFactor;
}

[KnownUnit<SpecificInformationCapacity, BytePerPound, BitPerKilogram, Scalar>]
public partial record BytePerPound(Scalar Value)
    : SpecificInformationCapacity.AffineUnit<BytePerPound>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "B/lb";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/lb", "byte/pound", "b/lb", "b/pound"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor / Pound.ScalingFactor;
}

[KnownUnit<SpecificInformationCapacity, BitPerOunce, BitPerKilogram, Scalar>]
public partial record BitPerOunce(Scalar Value)
    : SpecificInformationCapacity.AffineUnit<BitPerOunce>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "bit/oz";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/ounce"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Ounce.ScalingFactor;
}

[KnownUnit<SpecificInformationCapacity, BytePerOunce, BitPerKilogram, Scalar>]
public partial record BytePerOunce(Scalar Value)
    : SpecificInformationCapacity.AffineUnit<BytePerOunce>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "B/oz";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/oz", "byte/ounce", "b/oz", "b/ounce"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor / Ounce.ScalingFactor;
}
