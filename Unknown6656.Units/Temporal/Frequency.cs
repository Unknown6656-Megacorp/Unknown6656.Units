namespace Unknown6656.Units.Temporal;


#pragma warning disable IDE0004 // Remove Unnecessary Cast


[KnownBaseUnit<Frequency, Hertz, Scalar>]
public partial record Hertz
{
    public static string UnitSymbol { get; } = "Hz";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Frequency, BeatsPerMinute, Hertz, Scalar>(KnownUnitType.Linear)]
public partial record BeatsPerMinute
{
    public static string UnitSymbol { get; } = "BPM";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["beat/min", "beat/minute"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = 1 / Minute.ScalingFactor;
}

[KnownUnit<Frequency, Cesium133Frequency, Hertz, Scalar>(KnownUnitType.Linear)]
public partial record Cesium133Frequency
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "f_Cs";
#else
    public static string UnitSymbol { get; } = "Δνcₛ";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["Cs 133", "Cs 133 Freq", "Cs 133 Frequency", "delta v Cs", "delta v Cs 133"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.087827757077667e-10; // 9.192631770e9;
}
