namespace Unknown6656.Units.Energy;


[KnownBaseUnit<SpecificEnergy, JoulePerKilogram, Scalar>]
public partial record JoulePerKilogram(Scalar Value)
    : BaseUnit<SpecificEnergy, JoulePerKilogram, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "J/kg";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<SpecificEnergy, CaloriePerKilogram, JoulePerKilogram, Scalar>]
public partial record CaloriePerKilogram(Scalar Value)
    : SpecificEnergy.AffineUnit<CaloriePerKilogram>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "cal/kg";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)4.184e3;
}

[KnownUnit<SpecificEnergy, WattHourPerKilogram, JoulePerKilogram, Scalar>]
public partial record WattHourPerKilogram(Scalar Value)
    : SpecificEnergy.AffineUnit<WattHourPerKilogram>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Wh/kg";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3.6e3;
}

[KnownUnit<SpecificEnergy, BritishThermalUnitPerPound, JoulePerKilogram, Scalar>]
public partial record BritishThermalUnitPerPound(Scalar Value)
    : SpecificEnergy.AffineUnit<BritishThermalUnitPerPound>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "BTU/lb";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)2.326e3;
}
