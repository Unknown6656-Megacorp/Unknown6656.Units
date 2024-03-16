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

[KnownUnit<Length, ImperialHáo, Meter, Scalar>]
#if USE_DIACRITICS
public partial record ImperialHáo(Scalar Value)
#else
public partial record Hao(Scalar Value)
#endif
    : Length.AffineUnit<ImperialHáo>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Length, ImperialLí, Meter, Scalar>]
#if USE_DIACRITICS
public partial record ImperialLí(Scalar Value)
#else
public partial record Li(Scalar Value)
#endif
    : Length.AffineUnit<ImperialLí>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Length, ImperialFēn, Meter, Scalar>]
#if USE_DIACRITICS
public partial record ImperialFēn(Scalar Value)
#else
public partial record Fen(Scalar Value)
#endif
    : Length.AffineUnit<ImperialFēn>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Length, ImperialCùn, Meter, Scalar>]
#if USE_DIACRITICS
public partial record ImperialCùn(Scalar Value)
#else
public partial record Cun(Scalar Value)
#endif
    : Length.AffineUnit<ImperialCùn>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Length, ImperialChǐ, Meter, Scalar>]
#if USE_DIACRITICS
public partial record ImperialChǐ(Scalar Value)
#else
public partial record Chi(Scalar Value)
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

[KnownUnit<Length, ImperialBù, Meter, Scalar>]
#if USE_DIACRITICS
public partial record ImperialBù(Scalar Value)
#else
public partial record Bu(Scalar Value)
#endif
    : Length.AffineUnit<ImperialBù>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Length, ImperialZhàng, Meter, Scalar>]
#if USE_DIACRITICS
public partial record ImperialZhàng(Scalar Value)
#else
public partial record Zhang(Scalar Value)
#endif
    : Length.AffineUnit<ImperialZhàng>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Length, ImperialYǐn, Meter, Scalar>]
#if USE_DIACRITICS
public partial record ImperialYǐn(Scalar Value)
#else
public partial record Yin(Scalar Value)
#endif
    : Length.AffineUnit<ImperialYǐn>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Length, ImperialLǐ, Meter, Scalar>]
#if USE_DIACRITICS
public partial record ImperialLǐ(Scalar Value)
#else
public partial record ChineseMile(Scalar Value)
#endif
    : Length.AffineUnit<ImperialLǐ>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Length, MetricHū, Meter, Scalar>]
#if USE_DIACRITICS
public partial record MetricHū(Scalar Value)
#else
public partial record MetricHu(Scalar Value)
#endif
    : Length.AffineUnit<MetricHū>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Length, MetricSī, Meter, Scalar>]
#if USE_DIACRITICS
public partial record MetricSī(Scalar Value)
#else
public partial record MetricSi(Scalar Value)
#endif
    : Length.AffineUnit<MetricSī>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Length, MetricHáo, Meter, Scalar>]
#if USE_DIACRITICS
public partial record MetricHáo(Scalar Value)
#else
public partial record MetrichHao(Scalar Value)
#endif
    : Length.AffineUnit<MetricHáo>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Length, MetricLí, Meter, Scalar>]
#if USE_DIACRITICS
public partial record MetricLí(Scalar Value)
#else
public partial record MetricLi(Scalar Value)
#endif
    : Length.AffineUnit<MetricLí>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Length, MetricFēn, Meter, Scalar>]
#if USE_DIACRITICS
public partial record MetricFēn(Scalar Value)
#else
public partial record MetricFen(Scalar Value)
#endif
    : Length.AffineUnit<MetricFēn>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Length, MetricCùn, Meter, Scalar>]
#if USE_DIACRITICS
public partial record MetricCùn(Scalar Value)
#else
public partial record MetricCun(Scalar Value)
#endif
    : Length.AffineUnit<MetricCùn>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Length, MetricChǐ, Meter, Scalar>]
#if USE_DIACRITICS
public partial record MetricChǐ(Scalar Value)
#else
public partial record MetricChi(Scalar Value)
#endif
    : Length.AffineUnit<MetricChǐ>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Length, MetricZhàng, Meter, Scalar>]
#if USE_DIACRITICS
public partial record MetricZhàng(Scalar Value)
#else
public partial record MetricZhang(Scalar Value)
#endif
    : Length.AffineUnit<MetricZhàng>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Length, MetricYǐn, Meter, Scalar>]
#if USE_DIACRITICS
public partial record MetricYǐn(Scalar Value)
#else
public partial record MetricYin(Scalar Value)
#endif
    : Length.AffineUnit<MetricYǐn>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Length, MetricLǐ, Meter, Scalar>]
#if USE_DIACRITICS
public partial record MetricLǐ(Scalar Value)
#else
public partial record MetricLi(Scalar Value)
#endif
    : Length.AffineUnit<MetricLǐ>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Area, FāngCùn, SquareMeter, Scalar>]
#if USE_DIACRITICS
public partial record FāngCùn(Scalar Value)
#else
public partial record FangCun(Scalar Value)
#endif
    : Area.AffineUnit<FāngCùn>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Area, FāngChǐ, SquareMeter, Scalar>]
#if USE_DIACRITICS
public partial record FāngChǐ(Scalar Value)
#else
public partial record FangChi(Scalar Value)
#endif
    : Area.AffineUnit<FāngChǐ>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Area, FāngZhàng, SquareMeter, Scalar>]
#if USE_DIACRITICS
public partial record FāngZhàng(Scalar Value)
#else
public partial record FangZhang(Scalar Value)
#endif
    : Area.AffineUnit<FāngZhàng>(Value)
    , ILinearUnit<Scalar>
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
