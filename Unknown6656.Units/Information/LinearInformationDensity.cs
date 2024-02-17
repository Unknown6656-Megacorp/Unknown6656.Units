using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Information;


[KnownBaseUnit<LinearInformationDensity, BitPerMeter, Scalar>]
public partial record BitPerMeter(Scalar Value)
    : BaseUnit<LinearInformationDensity, BitPerMeter, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "bit/m";
    static string[] IUnit.AlternativeUnitSymbols { get; } = [];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<LinearInformationDensity, BitPerMillimeter, BitPerMeter, Scalar>]
public partial record BitPerMillimeter(Scalar Value)
    : LinearInformationDensity.AffineUnit<BitPerMillimeter>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "bit/mm";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/millimeter"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e3;
}

[KnownUnit<LinearInformationDensity, BytePerMeter, BitPerMeter, Scalar>]
public partial record BytePerMeter(Scalar Value)
    : LinearInformationDensity.AffineUnit<BytePerMeter>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "B/m";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/meter", "B/meter"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor;
}

[KnownUnit<LinearInformationDensity, BytePerMillimeter, BitPerMeter, Scalar>]
public partial record BytePerMillimeter(Scalar Value)
    : LinearInformationDensity.AffineUnit<BytePerMillimeter>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "B/mm";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/millimeter", "B/millimeter", "byte/mm"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor / 1e3;
}

[KnownUnit<LinearInformationDensity, BitPerInch, BitPerMeter, Scalar>]
public partial record BitPerInch(Scalar Value)
    : LinearInformationDensity.AffineUnit<BitPerInch>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "bit/in";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/inch"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Inch.ScalingFactor;
}

[KnownUnit<LinearInformationDensity, BytePerInch, BitPerMeter, Scalar>]
public partial record BytePerInch(Scalar Value)
    : LinearInformationDensity.AffineUnit<BytePerInch>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "B/in";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/inch", "B/inch", "byte/in"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor / Inch.ScalingFactor;
}

[KnownUnit<LinearInformationDensity, BitPerFoot, BitPerMeter, Scalar>]
public partial record BitPerFoot(Scalar Value)
    : LinearInformationDensity.AffineUnit<BitPerFoot>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "bit/ft";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/foot"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Foot.ScalingFactor;
}

[KnownUnit<LinearInformationDensity, BytePerFoot, BitPerMeter, Scalar>]
public partial record BytePerFoot(Scalar Value)
    : LinearInformationDensity.AffineUnit<BytePerFoot>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "B/ft";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/foot", "B/foot", "byte/ft"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor / Foot.ScalingFactor;
}
