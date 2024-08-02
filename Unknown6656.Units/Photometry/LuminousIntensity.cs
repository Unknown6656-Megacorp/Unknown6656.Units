namespace Unknown6656.Units.Photometry;


[KnownBaseUnit<LuminousIntensity, Candela, Scalar>]
public partial record Candela
{
    public static string UnitSymbol { get; } = "cd";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<LuminousIntensity, CandlePower, Candela, Scalar>(KnownUnitType.Linear)]
public partial record CandlePower
{
    public static string UnitSymbol { get; } = "cp";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.0193679918450560652395514780835881753312945973496432212028542303;
}

[KnownUnit<LuminousIntensity, HefnerLamp, Candela, Scalar>(KnownUnitType.Linear)]
public partial record HefnerLamp
{
    public static string UnitSymbol { get; } = "HK";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.08695652173913;
}
