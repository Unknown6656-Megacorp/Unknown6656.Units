namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<SpecificImpulse, NewtonSecondPerKilogram, Scalar>]
public partial record NewtonSecondPerKilogram
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "N*s/kg";
#else
    public static string UnitSymbol { get; } = "N·s/kg";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["newton s/kg", "N second/kg", "newton s/kilo", "N second/kilo", "newton s/kilogram", "N second/kilogram"];
}
