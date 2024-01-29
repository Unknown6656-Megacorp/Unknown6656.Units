namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Acceleration, MeterPerSecondSquared, Scalar>]
public partial record MeterPerSecondSquared(Scalar Value)
    : BaseUnit<Acceleration, MeterPerSecondSquared, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "m/s²";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["meter/s^2", "m/second^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Acceleration, FootPerSecondSquared, MeterPerSecondSquared, Scalar>]
public partial record FootPerSecondSquared(Scalar Value)
    : Acceleration.AffineUnit<FootPerSecondSquared>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ft/s²";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["feet/s^2", "ft/second^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)3.280839895013123;
}

[KnownUnit<Acceleration, Gal, MeterPerSecondSquared, Scalar>]
public partial record Gal(Scalar Value)
    : Acceleration.AffineUnit<Gal>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Gal";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e2;
}

[KnownUnit<Acceleration, G, MeterPerSecondSquared, Scalar>]
public partial record G(Scalar Value)
    : Acceleration.AffineUnit<G>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "g₀";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["g"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.1019716212977928242570092743189570342573661749934993091422657074;
}
