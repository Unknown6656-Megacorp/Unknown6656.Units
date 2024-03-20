namespace Unknown6656.Units.Energy;


[KnownBaseUnit<SpecificEnergy, JoulePerKilogram, Scalar>]
public partial record JoulePerKilogram
{
    public static string UnitSymbol { get; } = "J/kg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["joule/kg", "j/kilogram"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<SpecificEnergy, CaloriePerKilogram, JoulePerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record CaloriePerKilogram
{
    public static string UnitSymbol { get; } = "cal/kg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["calorie/kg", "cal/kilogram"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)4.184e3;
}

[KnownUnit<SpecificEnergy, WattHourPerKilogram, JoulePerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record WattHourPerKilogram
{
    public static string UnitSymbol { get; } = "Wh/kg";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["whr/kg", "wh/kilogram", "whr/kilogram", "watthour/kg", "watth/kg", "watthr/kg"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3.6e3;
}

[KnownUnit<SpecificEnergy, BritishThermalUnitPerPound, JoulePerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record BritishThermalUnitPerPound
{
    public static string UnitSymbol { get; } = "BTU/lb";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["BTU/lbs", "british thermal unit/pound", "british thermal unit/lb", "british TU/lb", "british TU/pound"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)2.326e3;
}

[KnownUnit<SpecificEnergy, JoulePerPound, JoulePerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record JoulePerPound
{
    public static string UnitSymbol { get; } = "J/lb";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["j/lbs", "j/pound", "joule/lb"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.4535923700000000220620937651506710730691552468135436985417567652;
}

[KnownUnit<SpecificEnergy, CaloriePerPound, JoulePerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record CaloriePerPound
{
    public static string UnitSymbol { get; } = "cal/lb";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["cal/lbs", "cal/pound", "calorie/lb"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1897.8304760800000923078003133904077697213455526678668346987103055;
}

[KnownUnit<SpecificEnergy, WattHourPerPound, JoulePerKilogram, Scalar>(KnownUnitType.Linear)]
public partial record WattHourPerPound
{
    public static string UnitSymbol { get; } = "Wh/lb";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["whr/lb", "wh/pound", "whr/pound", "watthour/lb", "watth/lb", "watthr/lb"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1632.9325320000000794235375545424158630489588885287573147503243547;
}
