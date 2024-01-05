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

[KnownUnit<SpecificEnergy, JoulePerPound, JoulePerKilogram, Scalar>]
public partial record JoulePerPound(Scalar Value)
    : SpecificEnergy.AffineUnit<JoulePerPound>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "J/lb";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.4535923700000000220620937651506710730691552468135436985417567652;
}

[KnownUnit<SpecificEnergy, CaloriePerPound, JoulePerKilogram, Scalar>]
public partial record CaloriePerPound(Scalar Value)
    : SpecificEnergy.AffineUnit<CaloriePerPound>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "cal/lb";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1897.8304760800000923078003133904077697213455526678668346987103055;
}

[KnownUnit<SpecificEnergy, WattHourPerPound, JoulePerKilogram, Scalar>]
public partial record WattHourPerPound(Scalar Value)
    : SpecificEnergy.AffineUnit<WattHourPerPound>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Wh/lb";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1632.9325320000000794235375545424158630489588885287573147503243547;
}
