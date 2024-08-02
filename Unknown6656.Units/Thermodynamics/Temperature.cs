#if !USE_DIACRITICS
global using Rømer = Unknown6656.Units.Thermodynamics.Romer;
global using Réaumur = Unknown6656.Units.Thermodynamics.Reaumur;
#endif

namespace Unknown6656.Units.Thermodynamics;


[KnownBaseUnit<Temperature, Kelvin, Scalar>]
public partial record Kelvin
{
    public static string UnitSymbol { get; } = "K";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["°K", "°" + nameof(Kelvin)];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Temperature, PlanckTemperature, Kelvin, Scalar>(KnownUnitType.Linear)]
public partial record PlanckTemperature
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Tp";
#else
    public static string UnitSymbol { get; } = "Tₚ";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["Tp"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.416808338416e32;
}

[KnownUnit<Temperature, Celsius, Kelvin, Scalar>(KnownUnitType.Affine)]
public partial record Celsius
{
    public static string UnitSymbol { get; } = "°C";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["C", "°" + nameof(Celsius)];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.0;
    public static Scalar PreScalingOffset { get; } = (Scalar)(-273.15);
    public static Scalar PostScalingOffset { get; }
}

[KnownUnit<Temperature, Fahrenheit, Kelvin, Scalar>(KnownUnitType.Affine)]
public partial record Fahrenheit
{
    public static string UnitSymbol { get; } = "°F";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["F", "°" + nameof(Fahrenheit)];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.8;
    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; } = (Scalar)(-459.67);
}

[KnownUnit<Temperature, Rankine, Kelvin, Scalar>(KnownUnitType.Affine)]
public partial record Rankine
{
    public static string UnitSymbol { get; } = "°R";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["R", "°" + nameof(Rankine)];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.5555555555555556;
    public static Scalar PreScalingOffset { get; }
    public static Scalar PostScalingOffset { get; } = (Scalar)459.67;
}

[KnownUnit<Temperature, Rømer, Kelvin, Scalar>(KnownUnitType.Affine)]
#if USE_DIACRITICS
public partial record Rømer
#else
public partial record Romer
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "°Ro";
#else
    public static string UnitSymbol { get; } = "°Rø";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["Rø", "°" + nameof(Rømer)];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.525;
    public static Scalar PreScalingOffset { get; } = (Scalar)(-273.15);
    public static Scalar PostScalingOffset { get; } = (Scalar)7.5;
}

[KnownUnit<Temperature, Réaumur, Kelvin, Scalar>(KnownUnitType.Affine)]
#if USE_DIACRITICS
public partial record Réaumur
#else
public partial record Reaumur
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "°Re";
#else
    public static string UnitSymbol { get; } = "°Ré";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["Ré", "°" + nameof(Réaumur)];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.8;
    public static Scalar PreScalingOffset { get; } = (Scalar)(-273.15);
    public static Scalar PostScalingOffset { get; }
}

[KnownUnit<Temperature, Delisle, Kelvin, Scalar>(KnownUnitType.Affine)]
public partial record Delisle
{
    public static string UnitSymbol { get; } = "°De";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["De", "°" + nameof(Delisle)];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.5;
    public static Scalar PreScalingOffset { get; } = (Scalar)(-273.15);
    public static Scalar PostScalingOffset { get; } = (Scalar)(-100.0);
}

[KnownUnit<Temperature, Leiden, Kelvin, Scalar>(KnownUnitType.Affine)]
public partial record Leiden
{
    public static string UnitSymbol { get; } = "°L";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["L", "°" + nameof(Leiden)];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.0;
    public static Scalar PreScalingOffset { get; } = (Scalar)20.15;
    public static Scalar PostScalingOffset { get; }
}

[KnownUnit<Temperature, Wedgwood, Kelvin, Scalar>(KnownUnitType.Affine)]
public partial record Wedgwood
{
    public static string UnitSymbol { get; } = "°We";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["We", "°" + nameof(Wedgwood)];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;

#warning TODO: fix the following conversion!
    public static Scalar ScalingFactor { get; } = (Scalar)0.5555555555555556;
    public static Scalar PreScalingOffset { get; } = (Scalar)(-273.15);
    public static Scalar PostScalingOffset { get; } = (Scalar)537.7777777777778;
}

[KnownUnit<Temperature, DegreesNewton, Kelvin, Scalar>(KnownUnitType.Affine)]
public partial record DegreesNewton
{
    public static string UnitSymbol { get; } = "°N";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["N"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
#warning TODO: verify the following conversion!
    public static Scalar ScalingFactor { get; } = (Scalar)0.33; // <-- TODO: 0.303 or 0.308 ????
    public static Scalar PreScalingOffset { get; } = (Scalar)(-273.15);
    public static Scalar PostScalingOffset { get; } = (Scalar)0;
}
