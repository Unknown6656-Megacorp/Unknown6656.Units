namespace Unknown6656.Units.Movement;


[KnownBaseUnit<KinematicViscosity, SquareMeterPerSecond, Scalar>]
public partial record SquareMeterPerSecond(Scalar Value)
    : BaseUnit<KinematicViscosity, SquareMeterPerSecond, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "m²/s";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["square meter/second", "square m/s", "square meter/s", "meter^2/s", "meter^2/second", "m^2/second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
}
