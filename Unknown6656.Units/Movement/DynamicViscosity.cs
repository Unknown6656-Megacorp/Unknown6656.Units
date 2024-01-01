namespace Unknown6656.Units.Movement;


[KnownBaseUnit<DynamicViscosity, PascalSecond, Scalar>]
public partial record PascalSecond(Scalar Value)
    : BaseUnit<DynamicViscosity, PascalSecond, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "Pa·s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}

[KnownUnit<DynamicViscosity, Poise, PascalSecond, Scalar>]
public partial record Poise(Scalar Value)
    : DynamicViscosity.AffineUnit<Poise>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "P";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)10;
}

[KnownUnit<DynamicViscosity, PoundPerFootHour, PascalSecond, Scalar>]
public partial record PoundPerFootHour(Scalar Value)
    : DynamicViscosity.AffineUnit<PoundPerFootHour>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lb/ft·h";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)2419.0883117531746717979948626934303921235955375010178616457740451;
}

[KnownUnit<DynamicViscosity, PoundPerFootSecond, PascalSecond, Scalar>]
public partial record PoundPerFootSecond(Scalar Value)
    : DynamicViscosity.AffineUnit<PoundPerFootSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lb/ft·s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.6719689496587741673632744778129292201665945419994032915727030085;
}

[KnownUnit<DynamicViscosity, PoundForceSecondPerSquareFoot, PascalSecond, Scalar>]
public partial record PoundForceSecondPerSquareFoot(Scalar Value)
    : DynamicViscosity.AffineUnit<PoundForceSecondPerSquareFoot>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lbf·s/ft²";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0208854342331504945325150491558934224155020579943155272083681678;
}

[KnownUnit<DynamicViscosity, PoundForceSecondPerSquareInch, PascalSecond, Scalar>]
public partial record PoundForceSecondPerSquareInch(Scalar Value)
    : DynamicViscosity.AffineUnit<PoundForceSecondPerSquareInch>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lbf·s/in²";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0001450377438972831094699929236084752515570889590452571424924765;
}
