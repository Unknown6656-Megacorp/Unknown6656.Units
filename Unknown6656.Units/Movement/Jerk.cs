namespace Unknown6656.Units.Movement;


[KnownBaseUnit<Jerk, MeterPerSecondCubed, Scalar>]
public partial record MeterPerSecondCubed(Scalar Value)
    : BaseUnit<Jerk, MeterPerSecondCubed, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "m/s³";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["meter/cube second", "m/second^3", "meter/s^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Jerk, FootPerSecondCubed, MeterPerSecondCubed, Scalar>]
public partial record FootPerSecondCubed(Scalar Value)
    : Jerk.AffineUnit<FootPerSecondCubed>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ft/s³";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["feet/cube second", "ft/second^3", "feet/s^3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)3.280839895013123;
}
