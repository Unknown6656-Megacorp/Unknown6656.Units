using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.International.HongKong;


// TODO : https://en.wikipedia.org/wiki/Hong_Kong_units_of_measurement

[KnownUnit<Length, Fan, Meter, Scalar>]
public partial record Fan(Scalar Value)
    : Length.AffineUnit<Fan>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "fan";
#else
    public static string UnitSymbol { get; } = "分";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["fan1", "condorim"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)269.19711959082037822195302510263140184400026919711959082037822195;
}

[KnownUnit<Length, Tsun, Meter, Scalar>]
public partial record Tsun(Scalar Value)
    : Length.AffineUnit<Tsun>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Length, Chek, Meter, Scalar>]
public partial record Chek(Scalar Value)
    : Length.AffineUnit<Chek>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "chek";
#else
    public static string UnitSymbol { get; } = "尺";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = [
        "cek3", "cek", "covado", "hongkong ft", "hk ft", "hk foot", "hongkong foot", "macao ft", "macau ft", "macao foot", "macau foot"
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)2.6919711959082037822195302510263140184400026919711959082037822195;
}
