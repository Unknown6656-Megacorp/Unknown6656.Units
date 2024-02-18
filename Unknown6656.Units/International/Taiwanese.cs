#if !USE_DIACRITICS
global using Chhùn = Unknown6656.Units.International.Taiwanese.Chhun;
global using Tn̄g = Unknown6656.Units.International.Taiwanese.Tng;
global using Pêⁿ = Unknown6656.Units.International.Taiwanese.Pen;
global using Bó = Unknown6656.Units.International.Taiwanese.Bo;
global using Lê = Unknown6656.Units.International.Taiwanese.Le;
global using Lî = Unknown6656.Units.International.Taiwanese.Li;
global using Chîⁿ = Unknown6656.Units.International.Taiwanese.Chin;
global using Tàⁿ = Unknown6656.Units.International.Taiwanese.Tan;
#endif

using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Matter;

namespace Unknown6656.Units.International.Taiwanese;


// https://en.wikipedia.org/wiki/Taiwanese_units_of_measurement

[KnownUnit<Length, Chhioh, Meter, Scalar>]
public partial record Chhioh(Scalar Value)
    : Length.AffineUnit<Chhioh>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Chi";
#else
    public static string UnitSymbol { get; } = "尺";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["taiwanese foot", "taiwanese ft", "taiwan ft", "taiwan foot", "ROC ft", "ft ROC", "ROC foot", "foot ROC", "chhak", "chi"];
    public static Scalar ScalingFactor { get; } = (Scalar)3.3;
}

[KnownUnit<Length, Chhùn, Meter, Scalar>]
#if USE_DIACRITICS
public partial record Chhùn(Scalar Value)
#else
public partial record Chhun(Scalar Value)
#endif
    : Length.AffineUnit<Chhùn>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Cun";
#else
    public static string UnitSymbol { get; } = "寸";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["cun", "taiwanese inch", "taiwanese in", "taiwan in", "taiwan inch", "ROC in", "in ROC", "ROC inch", "inch ROC"];
    public static Scalar ScalingFactor { get; } = Chhioh.ScalingFactor * 10;
}

[KnownUnit<Length, HunLength, Meter, Scalar>]
public partial record HunLength(Scalar Value)
    : Length.AffineUnit<HunLength>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Fen";
#else
    public static string UnitSymbol { get; } = "分";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["fun", "fen", "hun"];
    public static Scalar ScalingFactor { get; } = Chhioh.ScalingFactor * 100;
}

[KnownUnit<Length, Tn̄g, Meter, Scalar>]
#if USE_DIACRITICS
public partial record Tn̄g(Scalar Value)
#else
public partial record Tng(Scalar Value)
#endif
    : Length.AffineUnit<Tn̄g>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Zhang";
#else
    public static string UnitSymbol { get; } = "丈";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["zhang", "chhong", "taiwanese fathom", "taiwanese ftm", "taiwan ftm", "taiwan fathom", "ROC ftm", "ftm ROC", "ROC fathom", "fathom ROC"];
    public static Scalar ScalingFactor { get; } = Chhioh.ScalingFactor * .1;
}

[KnownUnit<Area, Pêⁿ, SquareMeter, Scalar>]
#if USE_DIACRITICS
public partial record Pêⁿ(Scalar Value)
#else
public partial record Pen(Scalar Value)
#endif
    : Area.AffineUnit<Pêⁿ>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Ping";
#else
    public static string UnitSymbol { get; } = "坪";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["pen", "ping", "phiang"];
    public static Scalar ScalingFactor { get; } = (Scalar).3025;
}

[KnownUnit<Area, Bó, SquareMeter, Scalar>]
#if USE_DIACRITICS
public partial record Bó(Scalar Value)
#else
public partial record Bo(Scalar Value)
#endif
    : Area.AffineUnit<Bó>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Mu";
#else
    public static string UnitSymbol { get; } = "畝";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["bo", "mu", "meu"];
    public static Scalar ScalingFactor { get; } = Pêⁿ.ScalingFactor / 30;
}

[KnownUnit<Area, HunArea, SquareMeter, Scalar>]
public partial record HunArea(Scalar Value)
    : Area.AffineUnit<HunArea>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Fen";
#else
    public static string UnitSymbol { get; } = "分";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["fun", "fen", "hun"];
    public static Scalar ScalingFactor { get; } = Kah.ScalingFactor * 10;
}

[KnownUnit<Area, Kah, SquareMeter, Scalar>]
public partial record Kah(Scalar Value)
    : Area.AffineUnit<Kah>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Jia";
#else
    public static string UnitSymbol { get; } = "甲";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kap", "jia"];
    public static Scalar ScalingFactor { get; } = Pêⁿ.ScalingFactor / 2934;
}

[KnownUnit<Area, Lê, SquareMeter, Scalar>]
#if USE_DIACRITICS
public partial record Lê(Scalar Value)
#else
public partial record Le(Scalar Value)
#endif
    : Area.AffineUnit<Lê>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Li";
#else
    public static string UnitSymbol { get; } = "犁";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["li", "lai"];
    public static Scalar ScalingFactor { get; } = Pêⁿ.ScalingFactor / 14670;
}

[KnownUnit<Mass, Lî, Kilogram, Scalar>]
#if USE_DIACRITICS
public partial record Lî(Scalar Value)
#else
public partial record Li(Scalar Value)
#endif
    : Mass.AffineUnit<Lî>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Li";
#else
    public static string UnitSymbol { get; } = "釐";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["cash"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Niú.ScalingFactor * 1000;
}

[KnownUnit<Mass, HunMass, Kilogram, Scalar>]
public partial record HunMass(Scalar Value)
    : Mass.AffineUnit<HunMass>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Fen";
#else
    public static string UnitSymbol { get; } = "分";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["candareen", "hun", "fun", "fen"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Niú.ScalingFactor * 100;
}

[KnownUnit<Mass, Chîⁿ, Kilogram, Scalar>]
#if USE_DIACRITICS
public partial record Chîⁿ(Scalar Value)
#else
public partial record Chin(Scalar Value)
#endif
    : Mass.AffineUnit<Chîⁿ>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Quian";
#else
    public static string UnitSymbol { get; } = "錢";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["chin", "mace", "chhien", "quian"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Niú.ScalingFactor * 10;
}

[KnownUnit<Mass, Niú, Kilogram, Scalar>]
#if USE_DIACRITICS
public partial record Niú(Scalar Value)
#else
public partial record Niu(Scalar Value)
#endif
    : Mass.AffineUnit<Niú>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Liang";
#else
    public static string UnitSymbol { get; } = "兩";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["niu", "liang", "liong", "tael", "tahil"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)26.6666666666666666666666666666666666666666666666666666;
}

[KnownUnit<Mass, Kin, Kilogram, Scalar>]
public partial record Kin(Scalar Value)
    : Mass.AffineUnit<Kin>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Jin";
#else
    public static string UnitSymbol { get; } = "斤";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kun", "jin", "catty", "kati", "gan"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Niú.ScalingFactor / 16;
}

[KnownUnit<Mass, Tàⁿ, Kilogram, Scalar>]
#if USE_DIACRITICS
public partial record Tàⁿ(Scalar Value)
#else
public partial record Tan(Scalar Value)
#endif
    : Mass.AffineUnit<Tàⁿ>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "Dan";
#else
    public static string UnitSymbol { get; } = "";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["tan", "dan", "tam", "picul"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Niú.ScalingFactor / 1600;
}
