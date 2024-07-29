namespace Unknown6656.Units.Matter;


[KnownBaseUnit<Pressure, Pascal, Scalar>]
public partial record Pascal
{
    public static string UnitSymbol { get; } = "Pa";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Pressure, Atmosphere, Pascal, Scalar>(KnownUnitType.Linear)]
public partial record Atmosphere
{
    public static string UnitSymbol { get; } = "atm";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)9.8692326671601e-6;
}

[KnownUnit<Pressure, Bar, Pascal, Scalar>(KnownUnitType.Linear)]
public partial record Bar
{
    public static string UnitSymbol { get; } = "bar";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-5;
}

[KnownUnit<Pressure, PoundForcePerSquareInch, Pascal, Scalar>(KnownUnitType.Linear)]
public partial record PoundForcePerSquareInch
{
    public static string UnitSymbol { get; } = "psi";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["pound/in^2", "pound/inch^2", "pound/square in", "pound/square inch", "lb/in^2", "lb/inch^2", "lb/square in", "lb/square inch"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.00014503773773020923;
}

[KnownUnit<Pressure, Torr, Pascal, Scalar>(KnownUnitType.Linear)]
public partial record Torr
{
    public static string UnitSymbol { get; } = "torr";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0075006168270417;
}

[KnownUnit<Pressure, KilopoundForcePerSquareInch, Pascal, Scalar>(KnownUnitType.Linear)]
public partial record KilopoundForcePerSquareInch
{
    public static string UnitSymbol { get; } = "ksi";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kilolb/in^2", "kilolb/square in", "kilolb/square inch", "kilopound/inch^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = PoundForcePerSquareInch.ScalingFactor * 1e3;
}

[KnownUnit<Pressure, MillimeterMercury, Pascal, Scalar>(KnownUnitType.Linear)]
public partial record MillimeterMercury
{
    public static string UnitSymbol { get; } = "mm Hg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["millimeter Hg", "mm mercury", "mm quecksilber", "millimeter quecksilber"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0075006168270417;
}

[KnownUnit<Pressure, InchMercury, Pascal, Scalar>(KnownUnitType.Linear)]
public partial record InchMercury
{
    public static string UnitSymbol { get; } = "in Hg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["inch Hg", "in mercury", "in quecksilber", "inch quecksilber"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.00029529983071445;
}

[KnownUnit<Pressure, MillimeterWater, Pascal, Scalar>(KnownUnitType.Linear)]
public partial record MillimeterWater
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "mm H2O";
#else
    public static string UnitSymbol { get; } = "mm H₂O";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["millimeter H₂O", "mm H₂O", "mm H2O", "millimeter H2O"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.10197162129779;
}

[KnownUnit<Pressure, InchWater, Pascal, Scalar>(KnownUnitType.Linear)]
public partial record InchWater
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "in H2O";
#else
    public static string UnitSymbol { get; } = "inH₂O";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["inch H₂O", "in H₂O", "inch H2O", "in H2O"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0040146307866177;
}

[KnownUnit<Pressure, AtmosphereTechnical, Pascal, Scalar>(KnownUnitType.Linear)]
public partial record AtmosphereTechnical
{
    public static string UnitSymbol { get; } = "at";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["technical atm", "atm technical"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)9.80665e-6;
}

[KnownUnit<Pressure, Barye, Pascal, Scalar>(KnownUnitType.Linear)]
public partial record Barye
{
    public static string UnitSymbol { get; } = "Ba";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)10d;
}
