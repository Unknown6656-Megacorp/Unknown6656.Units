namespace Unknown6656.Units.Euclidean;


[KnownBaseUnit<SolidAngle, Steradian, Scalar>]
public partial record Steradian(Scalar Value)
    : BaseUnit<SolidAngle, Steradian, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "sr";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["rad^2", "radian^2", "sq rad", "square rad", "sq radian"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<SolidAngle, SquareDegree, Steradian, Scalar>]
public partial record SquareDegree(Scalar Value)
    : SolidAngle.AffineUnit<SquareDegree>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "deg^2";
#else
    public static string UnitSymbol { get; } = "deg²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["degree^2", "sq deg", "square deg", "sq degree"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = Degree.ScalingFactor * Degree.ScalingFactor;
}