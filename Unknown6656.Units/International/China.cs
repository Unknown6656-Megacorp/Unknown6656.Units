#if !USE_DIACRITICS
global using Háo = Unknown6656.Units.International.China.Hao;
global using Lí = Unknown6656.Units.International.China.Li;
global using Fēn = Unknown6656.Units.International.China.Fen;
global using Cùn = Unknown6656.Units.International.China.Cun;
global using Chǐ = Unknown6656.Units.International.China.Chi;
global using Bù = Unknown6656.Units.International.China.Bu;
global using Zhàng = Unknown6656.Units.International.China.Zhang;
global using Yǐn = Unknown6656.Units.International.China.Yin;
global using Lǐ = Unknown6656.Units.International.China.ChineseMile;
global using  = Unknown6656.Units.International.China.;
global using  = Unknown6656.Units.International.China.;
global using  = Unknown6656.Units.International.China.;
#endif

using System;

using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Matter;

namespace Unknown6656.Units.International.China;


// https://en.wikipedia.org/wiki/Chinese_units_of_measurement

[KnownUnit<Length, Háo, Meter, Scalar>]
#if USE_DIACRITICS
public partial record Háo(Scalar Value)
#else
public partial record Hao(Scalar Value)
#endif
    : Length.AffineUnit<Háo>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "hao";
#else
    public static string UnitSymbol { get; } = "毫";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["hao", "chinese mil", "china mil", "PRC mil", "mil PRC", "CN mil", "mil CN"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Chǐ.ScalingFactor * 10000;
}

[KnownUnit<Length, Lí, Meter, Scalar>]
#if USE_DIACRITICS
public partial record Lí(Scalar Value)
#else
public partial record Li(Scalar Value)
#endif
    : Length.AffineUnit<Lí>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "li";
#else
    public static string UnitSymbol { get; } = "厘";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["li", "chinese calibre", "chinese cal", "china cal", "china calibre", "PRC cal", "cal PRC", "PRC calibre", "calibre PRC", "CN calibre", "calibre CN", "CN cal", "cal CN"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Chǐ.ScalingFactor * 1000;
}

[KnownUnit<Length, Fēn, Meter, Scalar>]
#if USE_DIACRITICS
public partial record Fēn(Scalar Value)
#else
public partial record Fen(Scalar Value)
#endif
    : Length.AffineUnit<Fēn>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "fen";
#else
    public static string UnitSymbol { get; } = "市分";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["fen", "chinese line", "china line", "PRC line", "line PRC", "CN line", "line CN"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Chǐ.ScalingFactor * 100;
}

[KnownUnit<Length, Cùn, Meter, Scalar>]
#if USE_DIACRITICS
public partial record Cùn(Scalar Value)
#else
public partial record Cun(Scalar Value)
#endif
    : Length.AffineUnit<Cùn>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "cun";
#else
    public static string UnitSymbol { get; } = "市寸";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["chinese inch", "chinese in", "china in", "china inch", "PRC in", "in PRC", "PRC inch", "inch PRC", "cun", "CN inch", "inch CN", "CN in", "in CN"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Chǐ.ScalingFactor * 10;
}

[KnownUnit<Length, Chǐ, Meter, Scalar>]
#if USE_DIACRITICS
public partial record Chǐ(Scalar Value)
#else
public partial record Chi(Scalar Value)
#endif
    : Length.AffineUnit<Chǐ>(Value)
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

[KnownUnit<Length, Bù, Meter, Scalar>]
#if USE_DIACRITICS
public partial record Bù(Scalar Value)
#else
public partial record Bu(Scalar Value)
#endif
    : Length.AffineUnit<Bù>(Value)
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

[KnownUnit<Length, Zhàng, Meter, Scalar>]
#if USE_DIACRITICS
public partial record Zhàng(Scalar Value)
#else
public partial record Zhang(Scalar Value)
#endif
    : Length.AffineUnit<Zhàng>(Value)
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

[KnownUnit<Length, Yǐn, Meter, Scalar>]
#if USE_DIACRITICS
public partial record Yǐn(Scalar Value)
#else
public partial record Yin(Scalar Value)
#endif
    : Length.AffineUnit<Yǐn>(Value)
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

[KnownUnit<Length, Lǐ, Meter, Scalar>]
#if USE_DIACRITICS
public partial record Lǐ(Scalar Value)
#else
public partial record ChineseMile(Scalar Value)
#endif
    : Length.AffineUnit<Lǐ>(Value)
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
