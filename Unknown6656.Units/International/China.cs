#if !USE_DIACRITICS
global using ImperialHáo = Unknown6656.Units.International.China.ImperialHao;
global using ImperialLí = Unknown6656.Units.International.China.ImperialLi;
global using ImperialFēn = Unknown6656.Units.International.China.ImperialFen;
global using ImperialCùn = Unknown6656.Units.International.China.ImperialCun;
global using ImperialChǐ = Unknown6656.Units.International.China.ImperialChi;
global using ImperialBù = Unknown6656.Units.International.China.ImperialBu;
global using ImperialZhàng = Unknown6656.Units.International.China.ImperialZhang;
global using ImperialYǐn = Unknown6656.Units.International.China.ImperialYin;
global using ImperialLǐ = Unknown6656.Units.International.China.ImperialChineseMile;
global using MetricHū = Unknown6656.Units.International.China.MetricHu;
global using MetricSī = Unknown6656.Units.International.China.MetricSi;
global using MetricHáo = Unknown6656.Units.International.China.MetricHao;
global using MetricLí = Unknown6656.Units.International.China.MetricLi;
global using MetricFēn = Unknown6656.Units.International.China.MetricFen;
global using MetricCùn = Unknown6656.Units.International.China.MetricCun;
global using MetricChǐ = Unknown6656.Units.International.China.MetricChi;
global using MetricZhàng = Unknown6656.Units.International.China.MetricZhang;
global using MetricYǐn = Unknown6656.Units.International.China.MetricYin;
global using MetricLǐ = Unknown6656.Units.International.China.MetricLi;
global using FāngCùn = Unknown6656.Units.International.China.FangCun;
global using FāngChǐ = Unknown6656.Units.International.China.FangChi;
global using FāngZhàng = Unknown6656.Units.International.China.FangZhang;
#endif

using System;

using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Matter;

namespace Unknown6656.Units.International.China;


// https://en.wikipedia.org/wiki/Chinese_units_of_measurement

[KnownUnit<Length, ImperialHáo, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record ImperialHáo
#else
public partial record Hao
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "hao";
#else
    public static string UnitSymbol { get; } = "毫";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["hao", "chinese mil", "china mil", "PRC mil", "mil PRC", "CN mil", "mil CN"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = ImperialChǐ.ScalingFactor * 10000;
}

[KnownUnit<Length, ImperialLí, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record ImperialLí
#else
public partial record Li
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "li";
#else
    public static string UnitSymbol { get; } = "厘";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["li", "chinese calibre", "chinese cal", "china cal", "china calibre", "PRC cal", "cal PRC", "PRC calibre", "calibre PRC", "CN calibre", "calibre CN", "CN cal", "cal CN"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = ImperialChǐ.ScalingFactor * 1000;
}

[KnownUnit<Length, ImperialFēn, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record ImperialFēn
#else
public partial record Fen
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "fen";
#else
    public static string UnitSymbol { get; } = "市分";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["fen", "chinese line", "china line", "PRC line", "line PRC", "CN line", "line CN"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = ImperialChǐ.ScalingFactor * 100;
}

[KnownUnit<Length, ImperialCùn, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record ImperialCùn
#else
public partial record Cun
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "cun";
#else
    public static string UnitSymbol { get; } = "市寸";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["chinese inch", "chinese in", "china in", "china inch", "PRC in", "in PRC", "PRC inch", "inch PRC", "cun", "CN inch", "inch CN", "CN in", "in CN"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = ImperialChǐ.ScalingFactor * 10;
}

[KnownUnit<Length, ImperialChǐ, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record ImperialChǐ
#else
public partial record Chi
#endif
    : Length.AffineUnit<ImperialChǐ>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "chi";
#else
    public static string UnitSymbol { get; } = "市尺";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["chinese foot", "chinese ft", "china ft", "china foot", "PRC ft", "ft PRC", "PRC foot", "foot PRC", "chi", "CN foot", "foot CN", "CN ft", "ft CN"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)3;
}

[KnownUnit<Length, ImperialBù, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record ImperialBù
#else
public partial record Bu
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "bu";
#else
    public static string UnitSymbol { get; } = "步";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["chinese pace", "chinese pc", "china pc", "china pace", "PRC pc", "pc PRC", "PRC pace", "pace PRC", "chi"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar).625;
}

[KnownUnit<Length, ImperialZhàng, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record ImperialZhàng
#else
public partial record Zhang
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "zhang";
#else
    public static string UnitSymbol { get; } = "市丈";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["chinese yard", "chinese yd", "china yd", "china yard", "PRC yd", "yd PRC", "PRC yard", "yard PRC", "zhang", "CN yard", "yard CN", "CN yd", "yd CN"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar).3;
}

[KnownUnit<Length, ImperialYǐn, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record ImperialYǐn
#else
public partial record Yin
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "yin";
#else
    public static string UnitSymbol { get; } = "引";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["chinese chain", "chinese ch", "china ch", "china chain", "PRC ch", "ch PRC", "PRC chain", "chain PRC", "zhang", "CN chain", "chain CN", "CN ch", "ch CN"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar).3;
}

[KnownUnit<Length, ImperialLǐ, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record ImperialLǐ
#else
public partial record ChineseMile
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "CN mile";
#else
    public static string UnitSymbol { get; } = "市里";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["chinese mile", "chinese mi", "china mi", "china mile", "PRC mi", "mi PRC", "PRC mile", "mile PRC", "CN mile", "mile CN", "CN mi", "mi CN", "zhang"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar).002;
}

[KnownUnit<Length, MetricHū, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record MetricHū
#else
public partial record MetricHu
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "hu";
#else
    public static string UnitSymbol { get; } = "忽";
#endif
    static string[] IUnit.AlternativeUnitSymbols{ get; } = ["hu", "hu metric"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e6;
}

[KnownUnit<Length, MetricSī, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record MetricSī
#else
public partial record MetricSi
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "si";
#else
    public static string UnitSymbol { get; } = "絲";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["si", "si metric"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e5;
}

[KnownUnit<Length, MetricHáo, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record MetricHáo
#else
public partial record MetrichHao
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "hao";
#else
    public static string UnitSymbol { get; } = "毫";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["hao", "hao metric"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e4;
}

[KnownUnit<Length, MetricLí, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record MetricLí
#else
public partial record MetricLi
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "li";
#else
    public static string UnitSymbol { get; } = "釐";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["li", "li metric"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e3;
}

[KnownUnit<Length, MetricFēn, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record MetricFēn
#else
public partial record MetricFen
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "fen";
#else
    public static string UnitSymbol { get; } = "公分";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["fen", "fen metric"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)100d;
}

[KnownUnit<Length, MetricCùn, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record MetricCùn
#else
public partial record MetricCun
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "cun";
#else
    public static string UnitSymbol { get; } = "公寸";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["cun", "cun metric"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)10d;
}

[KnownUnit<Length, MetricChǐ, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record MetricChǐ
#else
public partial record MetricChi
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "chi";
#else
    public static string UnitSymbol { get; } = "公尺";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["chi", "chi metric"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = Meter.ScalingFactor;
}

[KnownUnit<Length, MetricZhàng, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record MetricZhàng
#else
public partial record MetricZhang
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "zhang";
#else
    public static string UnitSymbol { get; } = "公丈";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["zhang", "zhang metric"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar).1;
}

[KnownUnit<Length, MetricYǐn, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record MetricYǐn
#else
public partial record MetricYin
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "yin";
#else
    public static string UnitSymbol { get; } = "公引"; // 百米
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["yin", "yin metric"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar).01;
}

[KnownUnit<Length, MetricLǐ, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record MetricLǐ
#else
public partial record MetricLi
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "li";
#else
    public static string UnitSymbol { get; } = "公里";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["li", "li metric"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-3;
}

[KnownUnit<Area, FāngCùn, SquareMeter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record FāngCùn
#else
public partial record FangCun
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "fang cun";
#else
    public static string UnitSymbol { get; } = "方寸";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["fang cun", "square cun", "sq cun", "cun^2", "cun squared"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = FāngChǐ.ScalingFactor * 100;
}

[KnownUnit<Area, FāngChǐ, SquareMeter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record FāngChǐ
#else
public partial record FangChi
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "fang chi";
#else
    public static string UnitSymbol { get; } = "方尺";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["fang chi", "square chi", "sq chi", "chi^2", "chi squared"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)9;
}

[KnownUnit<Area, FāngZhàng, SquareMeter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record FāngZhàng
#else
public partial record FangZhang
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "fang zhang";
#else
    public static string UnitSymbol { get; } = "方丈";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["fang zhang", "square zhang", "sq zhang", "zhang^2", "zhang squared"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = FāngChǐ.ScalingFactor * .01;
}
