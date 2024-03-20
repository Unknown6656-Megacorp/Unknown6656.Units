using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<Absement, MeterSecond, Scalar>]
public partial record MeterSecond
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "m*s";
#else
    public static string UnitSymbol { get; } = "m·s";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["meter*s", "meter second", "meter sec", "meter s", "meter*sec", "m*sec", "m*second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Absement, MeterHour, MeterSecond, Scalar>(KnownUnitType.Linear)]
public partial record MeterHour
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "m*h";
#else
    public static string UnitSymbol { get; } = "m·h";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["meter*h", "meter*hou", "meter*hr", "meter hour", "meter hou", "meter hr", "m*hou", "m*hour", "m*hr", "m hour", "m hou", "m hr"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = 1 / Hour.ScalingFactor;
}

[KnownUnit<Absement, InchSecond, MeterSecond, Scalar>(KnownUnitType.Linear)]
public partial record InchSecond
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "in*s";
#else
    public static string UnitSymbol { get; } = "in·s";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["inch*s", "inch*second", "inch*sec", "inch second", "inch sec", "inch s", "in*sec", "in*second", "in second", "in sec", "in s"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Inch.ScalingFactor;
}

[KnownUnit<Absement, FootSecond, MeterSecond, Scalar>(KnownUnitType.Linear)]
public partial record FootSecond
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "ft*s";
#else
    public static string UnitSymbol { get; } = "ft·s";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["foot*s", "foot*second", "foot*sec", "foot second", "foot sec", "foot s", "ft*sec", "ft*second", "ft second", "ft sec", "ft s"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Foot.ScalingFactor;
}

[KnownUnit<Absement, YardSecond, MeterSecond, Scalar>(KnownUnitType.Linear)]
public partial record YardSecond
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "yd*s";
#else
    public static string UnitSymbol { get; } = "yd·s";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["yard*s", "yard*second", "yard*sec", "yard second", "yard sec", "yard s", "yd*sec", "yd*second", "yd second", "yd sec", "yd s"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Yard.ScalingFactor;
}

[KnownUnit<Absement, MileSecond, MeterSecond, Scalar>(KnownUnitType.Linear)]
public partial record MileSecond
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "mi*s";
#else
    public static string UnitSymbol { get; } = "mi·s";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["mile*s", "mile*second", "mile*sec", "mile second", "mile sec", "mile s", "mi*sec", "mi*second", "mi second", "mi sec", "mi s"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Mile.ScalingFactor;
}

[KnownUnit<Absement, InchHour, MeterSecond, Scalar>(KnownUnitType.Linear)]
public partial record InchHour
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "in*h";
#else
    public static string UnitSymbol { get; } = "in·h";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["inch*h", "inch*hou", "inch*hr", "inch hour", "inch hou", "inch hr", "in*hou", "in*hour", "in*hr", "in hour", "in hou", "in hr"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Inch.ScalingFactor / Hour.ScalingFactor;
}

[KnownUnit<Absement, FootHour, MeterSecond, Scalar>(KnownUnitType.Linear)]
public partial record FootHour
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "ft*h";
#else
    public static string UnitSymbol { get; } = "ft·h";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["foot*h", "foot*hou", "foot*hr", "foot hour", "foot hou", "foot hr", "ft*hou", "ft*hour", "ft*hr", "ft hour", "ft hou", "ft hr"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Foot.ScalingFactor / Hour.ScalingFactor;
}

[KnownUnit<Absement, YardHour, MeterSecond, Scalar>(KnownUnitType.Linear)]
public partial record YardHour
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "yd*h";
#else
    public static string UnitSymbol { get; } = "yd·h";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["yard*h", "yard*hou", "yard*hr", "yard hour", "yard hou", "yard hr", "yd*hou", "yd*hour", "yd*hr", "yd hour", "yd hou", "yd hr"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Yard.ScalingFactor / Hour.ScalingFactor;
}

[KnownUnit<Absement, MileHour, MeterSecond, Scalar>(KnownUnitType.Linear)]
public partial record MileHour
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "mi*h";
#else
    public static string UnitSymbol { get; } = "mi·h";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["mile*h", "mile*hou", "mile*hr", "mile hour", "mile hou", "mile hr", "mi*hou", "mi*hour", "mi*hr", "mi hour", "mi hou", "mi hr"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Mile.ScalingFactor / Hour.ScalingFactor;
}
