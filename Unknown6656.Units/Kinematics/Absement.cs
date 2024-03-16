using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Kinematics;


[KnownBaseUnit<Absement, MeterSecond, Scalar>]
public partial record MeterSecond(Scalar Value)
    : BaseUnit<Absement, MeterSecond, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "m*s";
#else
    public static string UnitSymbol { get; } = "m·s";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["meter*s", "meter second", "meter sec", "meter s", "meter*sec", "m*sec", "m*second"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Absement, MeterHour, MeterSecond, Scalar>]
public partial record MeterHour(Scalar Value)
    : Absement.AffineUnit<MeterHour>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Absement, InchSecond, MeterSecond, Scalar>]
public partial record InchSecond(Scalar Value)
    : Absement.AffineUnit<InchSecond>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Absement, FootSecond, MeterSecond, Scalar>]
public partial record FootSecond(Scalar Value)
    : Absement.AffineUnit<FootSecond>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Absement, YardSecond, MeterSecond, Scalar>]
public partial record YardSecond(Scalar Value)
    : Absement.AffineUnit<YardSecond>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Absement, MileSecond, MeterSecond, Scalar>]
public partial record MileSecond(Scalar Value)
    : Absement.AffineUnit<MileSecond>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Absement, InchHour, MeterSecond, Scalar>]
public partial record InchHour(Scalar Value)
    : Absement.AffineUnit<InchHour>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Absement, FootHour, MeterSecond, Scalar>]
public partial record FootHour(Scalar Value)
    : Absement.AffineUnit<FootHour>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Absement, YardHour, MeterSecond, Scalar>]
public partial record YardHour(Scalar Value)
    : Absement.AffineUnit<YardHour>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Absement, MileHour, MeterSecond, Scalar>]
public partial record MileHour(Scalar Value)
    : Absement.AffineUnit<MileHour>(Value)
    , ILinearUnit<Scalar>
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
