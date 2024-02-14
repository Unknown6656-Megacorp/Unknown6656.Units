using Unknown6656.Units.Matter;

namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Impulse, NewtonSecond, Scalar>]
public partial record NewtonSecond(Scalar Value)
    : BaseUnit<Impulse, NewtonSecond, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "N*s";
#else
    public static string UnitSymbol { get; } = "N·s";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["newton s", "N second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Impulse, KilogramMeterPerSecond, NewtonSecond, Scalar>]
public partial record KilogramMeterPerSecond(Scalar Value)
    : Impulse.AffineUnit<KilogramMeterPerSecond>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Impulse, KilogramKilometerPerHour, NewtonSecond, Scalar>]
public partial record KilogramKilometerPerHour(Scalar Value)
    : Impulse.AffineUnit<KilogramKilometerPerHour>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Impulse, PoundFootPerSecond, NewtonSecond, Scalar>]
public partial record PoundFootPerSecond(Scalar Value)
    : Impulse.AffineUnit<PoundFootPerSecond>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Impulse, PoundMilePerHour, NewtonSecond, Scalar>]
public partial record PoundMilePerHour(Scalar Value)
    : Impulse.AffineUnit<PoundMilePerHour>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Impulse, PoundSecond, NewtonSecond, Scalar>]
public partial record PoundSecond(Scalar Value)
    : Impulse.AffineUnit<PoundSecond>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Impulse, SlugFootPerSecond, NewtonSecond, Scalar>]
public partial record SlugFootPerSecond(Scalar Value)
    : Impulse.AffineUnit<SlugFootPerSecond>(Value)
    , ILinearUnit<Scalar>
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
