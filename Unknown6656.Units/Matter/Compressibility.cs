namespace Unknown6656.Units.Matter;


[KnownBaseUnit<Compressibility, SquareMeterPerNewton, Scalar>]
public partial record SquareMeterPerNewton(Scalar Value)
    : BaseUnit<Compressibility, SquareMeterPerNewton, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "m^2/N";
#else
    public static string UnitSymbol { get; } = "m²/N";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["sq meter/N", "square meter/N", "meter^2/N", "m^2/newton", "sqm/newton", "sq meter/newton"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
}

// TODO : imperial equivalents