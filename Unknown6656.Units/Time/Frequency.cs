namespace Unknown6656.Units.Time;


#pragma warning disable IDE0004 // Remove Unnecessary Cast


[KnownBaseUnit<Frequency, Hertz, Scalar>]
public partial record Hertz(Scalar Value)
    : BaseUnit<Frequency, Hertz, Scalar>(Value)
    , IBaseUnit<Hertz, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Hz";
    public static UnitSystem UnitSystem { get; } = UnitSystem.Metric;
}

// Frequency
//      - hertz
//      - cesium frequency
