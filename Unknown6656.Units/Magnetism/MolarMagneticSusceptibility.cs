using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Magnetism;


[KnownBaseUnit<MolarMagneticSusceptibility, CubicMeterPerMol, Scalar>]
public partial record CubicMeterPerMol
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "m^3/mol";
#else
    public static string UnitSymbol { get; } = "m³·mol⁻¹";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["m^3/mol", "m cubed/mol", "meter cubed/mol", "cubic m/mol"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
}

[KnownUnit<MolarMagneticSusceptibility, CubicCentimeterPerMol, CubicMeterPerMol, Scalar>(KnownUnitType.Linear)]
public partial record CubicCentimeterPerMol
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "cm^3/mol";
#else
    public static string UnitSymbol { get; } = "cm³·mol⁻¹";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["cm^3/mol", "cm cubed/mol", "centimeter cubed/mol", "cubic cm/mol"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = CubicCentimeter.ScalingFactor;
}

[KnownUnit<MolarMagneticSusceptibility, CubicMillimeterPerMol, CubicMeterPerMol, Scalar>(KnownUnitType.Linear)]
public partial record CubicMillimeterPerMol
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "mm^3/mol";
#else
    public static string UnitSymbol { get; } = "mm³·mol⁻¹";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["millimeter^3/mol", "mm cubed/mol", "millimeter cubed/mol", "cubic mm/mol"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = CubicMillimeter.ScalingFactor;
}

[KnownUnit<MolarMagneticSusceptibility, LiterPerMol, CubicMeterPerMol, Scalar>(KnownUnitType.Linear)]
public partial record LiterPerMol
{
    public static string UnitSymbol { get; } = "L/mol";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Liter.ScalingFactor;
}
