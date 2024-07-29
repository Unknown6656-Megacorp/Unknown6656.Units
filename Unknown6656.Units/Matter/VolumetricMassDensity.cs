using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Matter;


[KnownBaseUnit<VolumetricMassDensity, KilogramPerCubicMeter, Scalar>]
public partial record KilogramPerCubicMeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "kg/m^3";
#else
    public static string UnitSymbol { get; } = "kg/m³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kilogram/meter^3", "kilogram/m^3", "kg/meter^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
}

[KnownUnit<VolumetricMassDensity, GramPerCubicMeter, KilogramPerCubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record GramPerCubicMeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "g/m^3";
#else
    public static string UnitSymbol { get; } = "g/m³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["gram/meter^3", "gram/m^3", "g/meter^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Gram.ScalingFactor;
}

[KnownUnit<VolumetricMassDensity, GramPerLiter, KilogramPerCubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record GramPerLiter
{
    public static string UnitSymbol { get; } = "g/L";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["g/liter", "gram/L"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Gram.ScalingFactor / Liter.ScalingFactor;
}

[KnownUnit<VolumetricMassDensity, GramPerCubicCentimeter, KilogramPerCubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record GramPerCubicCentimeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "g/cm^3";
#else
    public static string UnitSymbol { get; } = "g/cm³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["gram/centimeter^3", "gram/cm^3", "g/centimeter^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Gram.ScalingFactor / CubicCentimeter.ScalingFactor;
}

[KnownUnit<VolumetricMassDensity, PoundPerCubicInch, KilogramPerCubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record PoundPerCubicInch
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lb/in^3";
#else
    public static string UnitSymbol { get; } = "lb/in³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["pound/in^3", "pound/inch^3", "lb/inch^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Pound.ScalingFactor / CubicInch.ScalingFactor;
}

[KnownUnit<VolumetricMassDensity, PoundPerCubicFoot, KilogramPerCubicMeter, Scalar>(KnownUnitType.Linear)]
public partial record PoundPerCubicFoot
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lb/ft^3";
#else
    public static string UnitSymbol { get; } = "lb/ft³";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["pound/ft^3", "pound/foot^3", "lb/foot^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Pound.ScalingFactor / CubicFoot.ScalingFactor;
}
