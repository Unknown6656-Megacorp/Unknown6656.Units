using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Information;


[KnownBaseUnit<ArealInformationDensity, BitPerSquareMeter, Scalar>]
public partial record BitPerSquareMeter(Scalar Value)
    : BaseUnit<ArealInformationDensity, BitPerSquareMeter, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "bit/m^2";
#else
    public static string UnitSymbol { get; } = "bit/m²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bit/sqm", "bit/sq meter", "bit/meter^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<ArealInformationDensity, BitPerSquareMillimeter, BitPerSquareMeter, Scalar>]
public partial record BitPerSquareMillimeter(Scalar Value)
    : ArealInformationDensity.AffineUnit<BitPerSquareMillimeter>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<ArealInformationDensity, BytePerSquareMeter, BitPerSquareMeter, Scalar>]
public partial record BytePerSquareMeter(Scalar Value)
    : ArealInformationDensity.AffineUnit<BytePerSquareMeter>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<ArealInformationDensity, BytePerSquareMillimeter, BitPerSquareMeter, Scalar>]
public partial record BytePerSquareMillimeter(Scalar Value)
    : ArealInformationDensity.AffineUnit<BytePerSquareMillimeter>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<ArealInformationDensity, BitPerSquareInch, BitPerSquareMeter, Scalar>]
public partial record BitPerSquareInch(Scalar Value)
    : ArealInformationDensity.AffineUnit<BitPerSquareInch>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<ArealInformationDensity, BytePerSquareInch, BitPerSquareMeter, Scalar>]
public partial record BytePerSquareInch(Scalar Value)
    : ArealInformationDensity.AffineUnit<BytePerSquareInch>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<ArealInformationDensity, BitPerSquareFoot, BitPerSquareMeter, Scalar>]
public partial record BitPerSquareFoot(Scalar Value)
    : ArealInformationDensity.AffineUnit<BitPerSquareFoot>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<ArealInformationDensity, BytePerSquareFoot, BitPerSquareMeter, Scalar>]
public partial record BytePerSquareFoot(Scalar Value)
    : ArealInformationDensity.AffineUnit<BytePerSquareFoot>(Value)
    , ILinearUnit<Scalar>
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
