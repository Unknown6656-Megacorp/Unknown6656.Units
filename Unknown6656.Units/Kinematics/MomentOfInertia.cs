namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<MomentOfInertia, KilogramSquareMeter, Scalar>]
public partial record KilogramSquareMeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "kg*m^2";
#else
    public static string UnitSymbol { get; } = "kg·m²";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kilogram square meter", "kg square meter", "kilo square metre", "kilogram sqm", "kg sqm", "kilo sqm",
        "kilogram sq meter", "kg sq meter", "kilo sq metre", "kilogram meter squared", "kg meter squared", "kilo metre squared", "kilogram m^2", "kilo m^2",
    ];
}
