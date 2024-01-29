namespace Unknown6656.Units.Matter;


[KnownBaseUnit<Pressure, Pascal, Scalar>]
public partial record Pascal(Scalar Value)
    : BaseUnit<Pressure, Pascal, Scalar>(Value)
    , IBaseUnit<Pascal, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Pa";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Pressure, Atmosphere, Pascal, Scalar>]
public partial record Atmosphere(Scalar Value)
    : Pressure.AffineUnit<Atmosphere>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "atm";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)9.8692326671601e-6;
}

[KnownUnit<Pressure, Bar, Pascal, Scalar>]
public partial record Bar(Scalar Value)
    : Pressure.AffineUnit<Bar>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "bar";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-5;
}

[KnownUnit<Pressure, PoundForcePerSquareInch, Pascal, Scalar>]
public partial record PoundForcePerSquareInch(Scalar Value)
    : Pressure.AffineUnit<PoundForcePerSquareInch>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "psi";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["pound/in^2", "pound/inch^2", "pound/square in", "pound/square inch", "lb/in^2", "lb/inch^2", "lb/square in", "lb/square inch"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.00014503773773020923;
}

[KnownUnit<Pressure, Torr, Pascal, Scalar>]
public partial record Torr(Scalar Value)
    : Pressure.AffineUnit<Torr>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "torr";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0075006168270417;
}

[KnownUnit<Pressure, KilopoundForcePerSquareInch, Pascal, Scalar>]
public partial record KilopoundForcePerSquareInch(Scalar Value)
    : Pressure.AffineUnit<KilopoundForcePerSquareInch>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ksi";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kilolb/in^2", "kilolb/square in", "kilolb/square inch", "kilopound/inch^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.14503773773020923;
}

[KnownUnit<Pressure, MillimeterMercury, Pascal, Scalar>]
public partial record MillimeterMercury(Scalar Value)
    : Pressure.AffineUnit<MillimeterMercury>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "mmHg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["millimeter Hg", "mm mercury", "mm quecksilber", "millimeter quecksilber"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0075006168270417;
}

[KnownUnit<Pressure, InchMercury, Pascal, Scalar>]
public partial record InchMercury(Scalar Value)
    : Pressure.AffineUnit<InchMercury>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "inHg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["inch Hg", "in mercury", "in quecksilber", "inch quecksilber"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.00029529983071445;
}

[KnownUnit<Pressure, MillimeterWater, Pascal, Scalar>]
public partial record MillimeterWater(Scalar Value)
    : Pressure.AffineUnit<MillimeterWater>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "mmH₂O";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["millimeter H₂O", "mm H₂O", "mm H2O", "millimeter H2O"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.10197162129779;
}

[KnownUnit<Pressure, InchWater, Pascal, Scalar>]
public partial record InchWater(Scalar Value)
    : Pressure.AffineUnit<InchWater>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "inH₂O";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["inch H₂O", "in H₂O", "inch H2O", "in H2O"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0040146307866177;
}

[KnownUnit<Pressure, AtmosphereTechnical, Pascal, Scalar>]
public partial record AtmosphereTechnical(Scalar Value)
    : Pressure.AffineUnit<AtmosphereTechnical>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "at";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["technical atm", "atm technical"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)9.80665e-6;
}

[KnownUnit<Pressure, Barye, Pascal, Scalar>]
public partial record Barye(Scalar Value)
    : Pressure.AffineUnit<Barye>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Ba";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)10d;
}
