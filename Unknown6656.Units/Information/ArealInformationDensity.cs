using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Information;


[KnownBaseUnit<ArealInformationDensity, BitPerSquareMeter, Scalar>]
public partial record BitPerSquareMeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "bit/m^2";
#else
    public static string UnitSymbol { get; } = "bit/m²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/sqm", "bit/sq meter", "bit/meter^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<ArealInformationDensity, BitPerSquareMillimeter, BitPerSquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record BitPerSquareMillimeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "bit/mm^2";
#else
    public static string UnitSymbol { get; } = "bit/mm²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/millimeter^2", "bit/Square millimeter"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / SquareMillimeter.ScalingFactor;
}

[KnownUnit<ArealInformationDensity, BytePerSquareMeter, BitPerSquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record BytePerSquareMeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "B/m^2";
#else
    public static string UnitSymbol { get; } = "B/m²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/meter^2", "byte/Square meter", "B/meter^2", "B/Square meter"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor;
}

[KnownUnit<ArealInformationDensity, BytePerSquareMillimeter, BitPerSquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record BytePerSquareMillimeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "B/mm^2";
#else
    public static string UnitSymbol { get; } = "B/mm²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/millimeter^2", "byte/Square millimeter", "B/millimeter^2", "B/Square millimeter"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor / SquareMillimeter.ScalingFactor;
}

[KnownUnit<ArealInformationDensity, BitPerSquareInch, BitPerSquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record BitPerSquareInch
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "bit/in^2";
#else
    public static string UnitSymbol { get; } = "bit/in²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/inch^2", "bit/Square inch", "bit/Square in"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / SquareInch.ScalingFactor;
}

[KnownUnit<ArealInformationDensity, BytePerSquareInch, BitPerSquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record BytePerSquareInch
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "B/in^2";
#else
    public static string UnitSymbol { get; } = "B/in²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/inch^2", "byte/Square inch", "B/inch^2", "B/Square inch", "B/Square in"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor / SquareInch.ScalingFactor;
}

[KnownUnit<ArealInformationDensity, BitPerSquareFoot, BitPerSquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record BitPerSquareFoot
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "bit/ft^2";
#else
    public static string UnitSymbol { get; } = "bit/ft²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/foot^2", "bit/Square foot", "bit/Square ft"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / SquareFoot.ScalingFactor;
}

[KnownUnit<ArealInformationDensity, BytePerSquareFoot, BitPerSquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record BytePerSquareFoot
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "B/ft^2";
#else
    public static string UnitSymbol { get; } = "B/ft²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["byte/foot^2", "byte/Square foot", "b/foot^2", "b/Square foot", "b/Square ft"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = Byte.ScalingFactor / SquareFoot.ScalingFactor;
}
