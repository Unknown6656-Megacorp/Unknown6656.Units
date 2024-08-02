using Unknown6656.Units.Matter;

namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<Impulse, NewtonSecond, Scalar>]
#warning TODO implement alias with custom UnitDisplay
//#if USE_PURE_ASCII
//[KnownAlias<Impulse, NewtonSecond, Scalar>("KilogramMeterPerSecond", "kg*m/s")]
//#else
//[KnownAlias<Impulse, NewtonSecond, Scalar>("KilogramMeterPerSecond", "kg·m/s")]
//#endif
public partial record NewtonSecond
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "N*s";
#else
    public static string UnitSymbol { get; } = "N·s";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["newton s", "N second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Impulse, KilogramMeterPerSecond, NewtonSecond, Scalar>(KnownUnitType.Linear)]
public partial record KilogramMeterPerSecond
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "kg*m/s";
#else
    public static string UnitSymbol { get; } = "kg·m/s";
#endif
#warning TODO    static string[] IUnit.AlternativeUnitSymbols { get; } = [];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
    public static Scalar ScalingFactor { get; } = (Scalar)1;
}

[KnownUnit<Impulse, KilogramKilometerPerHour, NewtonSecond, Scalar>(KnownUnitType.Linear)]
public partial record KilogramKilometerPerHour
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "kg*km/h";
#else
    public static string UnitSymbol { get; } = "kg·km/h";
#endif
#warning TODO    static string[] IUnit.AlternativeUnitSymbols { get; } = [];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
    public static Scalar ScalingFactor { get; } = KilometerPerHour.ScalingFactor;
}

[KnownUnit<Impulse, PoundFootPerSecond, NewtonSecond, Scalar>(KnownUnitType.Linear)]
public partial record PoundFootPerSecond
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lb*ft/s";
#else
    public static string UnitSymbol { get; } = "lb·ft/s";
#endif
#warning TODO    static string[] IUnit.AlternativeUnitSymbols { get; } = [];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Pound.ScalingFactor / FootPerSecond.ScalingFactor;
}

[KnownUnit<Impulse, PoundMilePerHour, NewtonSecond, Scalar>(KnownUnitType.Linear)]
public partial record PoundMilePerHour
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lb*mi/h";
#else
    public static string UnitSymbol { get; } = "lb·mi/h";
#endif
#warning TODO    static string[] IUnit.AlternativeUnitSymbols { get; } = [];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Pound.ScalingFactor / MilePerHour.ScalingFactor;
}

[KnownUnit<Impulse, PoundSecond, NewtonSecond, Scalar>(KnownUnitType.Linear)]
public partial record PoundSecond
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lbf*s";
#else
    public static string UnitSymbol { get; } = "lbf·s";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lb s", "lbf second", "lbf s", "pound second", "pound s", "pound force second", "pound force s", "pound f second", "lb force second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.224808943099717;
}

[KnownUnit<Impulse, SlugFootPerSecond, NewtonSecond, Scalar>(KnownUnitType.Linear)]
public partial record SlugFootPerSecond
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "sl*ft/s";
#else
    public static string UnitSymbol { get; } = "sl·ft/s";
#endif
#warning TODO    static string[] IUnit.AlternativeUnitSymbols { get; } = [];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.224735720691;
}
