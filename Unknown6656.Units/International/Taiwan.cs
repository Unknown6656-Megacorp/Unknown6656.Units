#if !USE_DIACRITICS
global using Chhùn = Unknown6656.Units.International.Taiwan.Chhun;
global using Tn̄g = Unknown6656.Units.International.Taiwan.Tng;
global using Pêⁿ = Unknown6656.Units.International.Taiwan.Pen;
global using Bó = Unknown6656.Units.International.Taiwan.Bo;
global using Lê = Unknown6656.Units.International.Taiwan.Le;
global using Lî = Unknown6656.Units.International.Taiwan.Li;
global using Chîⁿ = Unknown6656.Units.International.Taiwan.Chin;
global using Tàⁿ = Unknown6656.Units.International.Taiwan.Tan;
#endif

using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Matter;

namespace Unknown6656.Units.International.Taiwan;


// https://en.wikipedia.org/wiki/Taiwanese_units_of_measurement

[KnownUnit<Length, Chhioh, Meter, Scalar>(KnownUnitType.Linear)]
public partial record Chhioh
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

[KnownUnit<Length, Chhùn, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record Chhùn
#else
public partial record Chhun
#endif
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

[KnownUnit<Length, HunLength, Meter, Scalar>(KnownUnitType.Linear)]
public partial record HunLength
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

[KnownUnit<Length, Tn̄g, Meter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record Tn̄g
#else
public partial record Tng
#endif
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

[KnownUnit<Area, Pêⁿ, SquareMeter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record Pêⁿ
#else
public partial record Pen
#endif
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

[KnownUnit<Area, Bó, SquareMeter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record Bó
#else
public partial record Bo
#endif
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

[KnownUnit<Area, HunArea, SquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record HunArea
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

[KnownUnit<Area, Kah, SquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record Kah
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

[KnownUnit<Area, Lê, SquareMeter, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record Lê
#else
public partial record Le
#endif
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

[KnownUnit<Mass, Lî, Kilogram, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record Lî
#else
public partial record Li
#endif
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

[KnownUnit<Mass, HunMass, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record HunMass
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

[KnownUnit<Mass, Chîⁿ, Kilogram, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record Chîⁿ
#else
public partial record Chin
#endif
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

[KnownUnit<Mass, Niú, Kilogram, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record Niú
#else
public partial record Niu
#endif
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

[KnownUnit<Mass, Kin, Kilogram, Scalar>(KnownUnitType.Linear)]
public partial record Kin
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

[KnownUnit<Mass, Tàⁿ, Kilogram, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record Tàⁿ
#else
public partial record Tan
#endif
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
