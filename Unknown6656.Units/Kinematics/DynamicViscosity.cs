namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<DynamicViscosity, PascalSecond, Scalar>]
public partial record PascalSecond
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Pa*s";
#else
    public static string UnitSymbol { get; } = "Pa·s";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["pascal*s", "pa*second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<DynamicViscosity, Poise, PascalSecond, Scalar>(KnownUnitType.Linear)]
public partial record Poise
{
    public static string UnitSymbol { get; } = "P";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)10;
}

[KnownUnit<DynamicViscosity, PoundPerFootHour, PascalSecond, Scalar>(KnownUnitType.Linear)]
public partial record PoundPerFootHour
{
    public static string UnitSymbol { get; } = "lb/(ft·h)";
#warning TODO : static string[] IUnit.AlternativeUnitSymbols { get; } = [];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)2419.0883117531746717979948626934303921235955375010178616457740451;
}

[KnownUnit<DynamicViscosity, PoundPerFootSecond, PascalSecond, Scalar>(KnownUnitType.Linear)]
public partial record PoundPerFootSecond
{
    public static string UnitSymbol { get; } = "lb/(ft·s)";
#warning TODO : static string[] IUnit.AlternativeUnitSymbols { get; } = [];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.6719689496587741673632744778129292201665945419994032915727030085;
}

[KnownUnit<DynamicViscosity, PoundForceSecondPerSquareFoot, PascalSecond, Scalar>(KnownUnitType.Linear)]
public partial record PoundForceSecondPerSquareFoot
{
    public static string UnitSymbol { get; } = "lbf·s/ft²";
#warning TODO : static string[] IUnit.AlternativeUnitSymbols { get; } = [];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0208854342331504945325150491558934224155020579943155272083681678;
}

[KnownUnit<DynamicViscosity, PoundForceSecondPerSquareInch, PascalSecond, Scalar>(KnownUnitType.Linear)]
public partial record PoundForceSecondPerSquareInch
{
    public static string UnitSymbol { get; } = "lbf·s/in²";
#warning TODO : static string[] IUnit.AlternativeUnitSymbols { get; } = [];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0001450377438972831094699929236084752515570889590452571424924765;
}
