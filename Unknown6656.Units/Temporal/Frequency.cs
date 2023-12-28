namespace Unknown6656.Units.Temporal;


#pragma warning disable IDE0004 // Remove Unnecessary Cast


[KnownBaseUnit<Frequency, Hertz, Scalar>]
public partial record Hertz(Scalar Value)
    : BaseUnit<Frequency, Hertz, Scalar>(Value)
    , IBaseUnit<Hertz, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Hz";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricSI;
}

[KnownUnit<Frequency, Cesium133, Hertz, Scalar>]
public partial record Cesium133(Scalar Value)
    : Frequency.AffineUnit<Cesium133>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Cesium133, Hertz, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Δνcₛ";
    public static UnitSystem UnitSystem { get; } = UnitSystem.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1.087827757077667e-10; // 9.192631770e9;
}

