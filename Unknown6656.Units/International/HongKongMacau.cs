using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.International.HongKongMacau;


// TODO : https://en.wikipedia.org/wiki/Hong_Kong_units_of_measurement

[KnownUnit<Length, LengthFan, Meter, Scalar>(KnownUnitType.Linear)]
public partial record LengthFan
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "fan";
#else
    public static string UnitSymbol { get; } = "分";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["fan1", "fan", "condorim"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)269.19711959082037822195302510263140184400026919711959082037822195;
}

[KnownUnit<Length, Tsun, Meter, Scalar>(KnownUnitType.Linear)]
public partial record Tsun
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "tsun";
#else
    public static string UnitSymbol { get; } = "寸";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = [
        "tsun3", "cyun3", "cyun", "ponto", "hongkong in", "hk in", "hk inch", "hongkong inch", "macao in", "macau in", "macao inch", "macau inch"
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)26.919711959082037822195302510263140184400026919711959082037822195;
}

[KnownUnit<Length, Chek, Meter, Scalar>(KnownUnitType.Linear)]
public partial record Chek
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "chek";
#else
    public static string UnitSymbol { get; } = "尺";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = [
        "cek3", "cek", "covado", "hongkong ft", "hk ft", "hk foot", "hongkong foot", "macao ft", "macau ft", "macao foot", "macau foot",
        "length cek3", "length cek", "length chek"
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)2.6919711959082037822195302510263140184400026919711959082037822195;
}


[KnownUnit<Area, Cek, SquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record Cek
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "cek";
#else
    public static string UnitSymbol { get; } = "尺";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = [
        "cek3", "cek", "covado", "area cek", "area cek3", "area chek"
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = Pou.ScalingFactor * 25;
}

[KnownUnit<Area, Pou, SquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record Pou
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "pou";
#else
    public static string UnitSymbol { get; } = "鋪";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["pou3"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = Zoeng.ScalingFactor * 4;
}

[KnownUnit<Area, Zoeng, SquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record Zoeng
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "zoeng";
#else
    public static string UnitSymbol { get; } = "丈";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = [
        "zoeng6", "zoeng", "braca", "area zoeng", "area zoeng6"
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = AreaFan.ScalingFactor * 6;
}

[KnownUnit<Area, AreaFan, SquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record AreaFan
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "fan";
#else
    public static string UnitSymbol { get; } = "分";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["fan1", "condorim", "fan", "area fan1"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = Mau.ScalingFactor * 10;
}

[KnownUnit<Area, Mau, SquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record Mau
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "mau";
#else
    public static string UnitSymbol { get; } = "畝";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["mau5", "maz", "area mau", "area mau5"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0013133701076963488311006041502495403204623062779091147885474126;
}


[KnownUnit<Time, Ji, Second, Scalar>(KnownUnitType.Linear)]
public partial record Ji
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "ji";
#else
    public static string UnitSymbol { get; } = "字";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ji6"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0033333333333333333333333333333333333333333333333333333333333333;
}

[KnownUnit<Time, Gwat, Second, Scalar>(KnownUnitType.Linear)]
public partial record Gwat
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "gwat";
#else
    public static string UnitSymbol { get; } = "骨";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["gwat1", "quarter"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = Ji.ScalingFactor / 3;
}
