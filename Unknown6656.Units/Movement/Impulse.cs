namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Impulse, NewtonSecond, Scalar>]
public partial record NewtonSecond(Scalar Value)
    : BaseUnit<Impulse, NewtonSecond, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "N·s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Impulse, KilogramMeterPerSecond, NewtonSecond, Scalar>]
public partial record KilogramMeterPerSecond(Scalar Value)
    : Impulse.AffineUnit<KilogramMeterPerSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "kg·m/s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
    public static Scalar ScalingFactor { get; } = (Scalar)1;
}

[KnownUnit<Impulse, KilogramKilometerPerHour, NewtonSecond, Scalar>]
public partial record KilogramKilometerPerHour(Scalar Value)
    : Impulse.AffineUnit<KilogramKilometerPerHour>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "kg·km/h";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
    public static Scalar ScalingFactor { get; } = (Scalar)3.6;
}

[KnownUnit<Impulse, PoundFootPerSecond, NewtonSecond, Scalar>]
public partial record PoundFootPerSecond(Scalar Value)
    : Impulse.AffineUnit<PoundFootPerSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lb·ft/s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)7.2330138512098932361330729835111;
}

[KnownUnit<Impulse, PoundMilePerHour, NewtonSecond, Scalar>]
public partial record PoundMilePerHour(Scalar Value)
    : Impulse.AffineUnit<PoundMilePerHour>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lb·mi/h";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)7.3390298295748105473483674240075;
}

[KnownUnit<Impulse, PoundSecond, NewtonSecond, Scalar>]
public partial record PoundSecond(Scalar Value)
    : Impulse.AffineUnit<PoundSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "lbf·s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.224808943099717;
}

[KnownUnit<Impulse, SlugFootPerSecond, NewtonSecond, Scalar>]
public partial record SlugFootPerSecond(Scalar Value)
    : Impulse.AffineUnit<SlugFootPerSecond>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "sl·ft/s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.224735720691;
}
