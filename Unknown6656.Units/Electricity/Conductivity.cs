namespace Unknown6656.Units.Electricity;


[KnownBaseUnit<Conductivity, SiemensPerMeter, Scalar>]
public partial record SiemensPerMeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = $"{Siemens.UnitSymbol}/m";
#else
    public static bool UseInvertedOmegaAsUnitSymbol
    {
        get => Siemens.UseInvertedOmegaAsUnitSymbol;
        set => Siemens.UseInvertedOmegaAsUnitSymbol = value;
    }

    public static string UnitSymbol => $"{Siemens.UnitSymbol}·m⁻¹";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["mho/m", "s/m", "siemens/m", "mho/meter", "s/meter"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
