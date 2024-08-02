namespace Unknown6656.Units.Energy;


[KnownBaseUnit<Power, Watt, Scalar>]
public partial record Watt
{
    public static string UnitSymbol { get; } = "W";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Power, MetricHorsepower, Watt, Scalar>(KnownUnitType.Linear)]
public partial record MetricHorsepower
{
    public static string UnitSymbol { get; } = "hp";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ps", "cv", "hl", "pk", "ks", "ch"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0013596216;
}

[KnownUnit<Power, ElectricalHorsepower, Watt, Scalar>(KnownUnitType.Linear)]
public partial record ElectricalHorsepower
{
    public static string UnitSymbol { get; } = "hp";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0013404825737265415549597855227882037533512064343163538873994638;
}

[KnownUnit<Power, BoilerHorsepower, Watt, Scalar>(KnownUnitType.Linear)]
public partial record BoilerHorsepower
{
    public static string UnitSymbol { get; } = "BHP";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["hp"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0001019419950048422447627300066262296753147459095774504307049288;
}

#warning TODO : Hydraulic horsepower
#warning TODO : Drawbar power
#warning TODO : Nominal horsepower

[KnownUnit<Power, UKHorsepower, Watt, Scalar>(KnownUnitType.Linear)]
public partial record UKHorsepower
{
    public static string UnitSymbol { get; } = "UK hp";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["hp UK", "hp"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.001341022089595027;
}

[KnownUnit<Power, Lusec, Watt, Scalar>(KnownUnitType.Linear)]
public partial record Lusec
{
    public static string UnitSymbol { get; } = "lusec";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)7501.8754688672168042010502625656414103525881470367591897974493623;
}

[KnownUnit<Power, Poncelet, Watt, Scalar>(KnownUnitType.Linear)]
public partial record Poncelet
{
    public static string UnitSymbol { get; } = "p";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.001359621617303904;
}

[KnownUnit<Power, TonAirConditioningEquivalent, Watt, Scalar>(KnownUnitType.Linear)]
public partial record TonAirConditioningEquivalent
{
    public static string UnitSymbol { get; } = "t AC";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["AC ton", "ton AC"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.00028434513626109;
}

[KnownUnit<Power, TonRefrigerationEquivalent, Watt, Scalar>(KnownUnitType.Linear)]
public partial record TonRefrigerationEquivalent
{
    public static string UnitSymbol { get; } = "t ice";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ton of ice", "ton ice"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.00028434513626109;
}
