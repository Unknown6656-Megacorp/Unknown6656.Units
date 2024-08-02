using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Information;


[KnownBaseUnit<VolumetricInformationDensity, BitPerCubicMeter, Scalar>]
public partial record BitPerCubicMeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "bit/m^3";
#else
    public static string UnitSymbol { get; } = "bit/m³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/cb meter", "bit/meter^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<VolumetricInformationDensity, BitPerCubicMillimeter, BitPerCubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record BitPerCubicMillimeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "bit/mm^3";
#else
    public static string UnitSymbol { get; } = "bit/mm³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/millimeter^3", "bit/cubic millimeter"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / CubicMillimeter.ScalingFactor;
}

[KnownUnit<VolumetricInformationDensity, BytePerCubicMeter, BitPerCubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record BytePerCubicMeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "B/m^3";
#else
    public static string UnitSymbol { get; } = "B/m³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/meter^3", "byte/cubic meter", "B/meter^3", "B/cubic meter"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor;
}

[KnownUnit<VolumetricInformationDensity, BytePerCubicMillimeter, BitPerCubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record BytePerCubicMillimeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "B/mm^3";
#else
    public static string UnitSymbol { get; } = "B/mm³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/millimeter^3", "byte/cubic millimeter", "B/millimeter^3", "B/cubic millimeter"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor / CubicMillimeter.ScalingFactor;
}

[KnownUnit<VolumetricInformationDensity, BitPerCubicInch, BitPerCubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record BitPerCubicInch
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "bit/in^3";
#else
    public static string UnitSymbol { get; } = "bit/in³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/inch^3", "bit/cubic inch", "bit/cubic in"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / CubicInch.ScalingFactor;
}

[KnownUnit<VolumetricInformationDensity, BytePerCubicInch, BitPerCubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record BytePerCubicInch
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "B/in^3";
#else
    public static string UnitSymbol { get; } = "B/in³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/inch^3", "byte/cubic inch", "B/inch^3", "B/cubic inch", "B/cubic in"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor / CubicInch.ScalingFactor;
}

[KnownUnit<VolumetricInformationDensity, BitPerCubicFoot, BitPerCubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record BitPerCubicFoot
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "bit/ft^3";
#else
    public static string UnitSymbol { get; } = "bit/ft³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/foot^3", "bit/cubic foot", "bit/cubic ft"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / CubicFoot.ScalingFactor;
}

[KnownUnit<VolumetricInformationDensity, BytePerCubicFoot, BitPerCubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record BytePerCubicFoot
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "B/ft^3";
#else
    public static string UnitSymbol { get; } = "B/ft³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/foot^3", "byte/cubic foot", "b/foot^3", "b/cubic foot", "b/cubic ft"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor / CubicFoot.ScalingFactor;
}
