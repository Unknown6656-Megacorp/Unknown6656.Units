namespace Unknown6656.Units.Energy;


[KnownBaseUnit<Power, Watt, Scalar>]
public partial record Watt(Scalar Value)
    : BaseUnit<Power, Watt, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "W";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}

[KnownUnit<Power, KilowattHour, Watt, Scalar>]
public partial record KilowattHour(Scalar Value)
    : Power.AffineUnit<KilowattHour>(Value)
    , ILinearUnit<Scalar>
    , IUnit<KilowattHour, Watt, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "kWh";
    public static UnitDisplay UnitDisplay { get; } = Unit.MetricSI_Shifted_k;
    public static Scalar ScalingFactor { get; } = (Scalar)2.777777777777778e-7;
}
