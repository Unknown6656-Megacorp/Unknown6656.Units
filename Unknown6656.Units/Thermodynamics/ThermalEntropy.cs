namespace Unknown6656.Units.Thermodynamics;


[KnownBaseUnit<ThermalEntropy, JoulePerKelvin, Scalar>]
public partial record JoulePerKelvin
{
    public static string UnitSymbol { get; } = "J/K";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["joule/K", "J/kelvin", "joule/kelvin"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
