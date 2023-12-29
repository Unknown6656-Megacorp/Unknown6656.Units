namespace Unknown6656.Units.Temporal;


#pragma warning disable IDE0004 // Remove Unnecessary Cast


[KnownBaseUnit<Frequency, Hertz, Scalar>]
public partial record Hertz(Scalar Value)
    : BaseUnit<Frequency, Hertz, Scalar>(Value)
    , IBaseUnit<Hertz, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Hz";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}

[KnownUnit<Frequency, Cesium133Frequency, Hertz, Scalar>]
public partial record Cesium133Frequency(Scalar Value)
    : Frequency.AffineUnit<Cesium133Frequency>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Cesium133Frequency, Hertz, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Δνcₛ";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1.087827757077667e-10; // 9.192631770e9;
}

