#if !USE_DIACRITICS
global using Пүү = Unknown6656.Units.International.Mongolia.Puu;
global using Жин = Unknown6656.Units.International.Mongolia.Jin;
global using Лан = Unknown6656.Units.International.Mongolia.Lan;
global using Цэн = Unknown6656.Units.International.Mongolia.Tsen;
#endif

using Unknown6656.Units.Matter;

namespace Unknown6656.Units.International.Mongolia;


// TODO : https://en.wikipedia.org/wiki/Mongolian_units


[KnownUnit<Mass, Пүү, Kilogram, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record Пүү
#else
public partial record Puu
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "puu";
#else
    public static string UnitSymbol { get; } = "пүү";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["puu", "püü"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0606060606060606060606061;
}

[KnownUnit<Mass, Жин, Kilogram, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record Жин
#else
public partial record Jin
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "jin";
#else
    public static string UnitSymbol { get; } = "жин";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["jin"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)1.6755582960242352751936945390204015978123910887107584247071124098;
}

[KnownUnit<Mass, Лан, Kilogram, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record Лан
#else
public partial record Lan
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lan";
#else
    public static string UnitSymbol { get; } = "лан";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["lan"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)26.808932736387764403099112624326425564998257419372134795313798557;
}

[KnownUnit<Mass, Цэн, Kilogram, Scalar>(KnownUnitType.Linear)]
#if USE_DIACRITICS
public partial record Цэн
#else
public partial record Tsen
#endif
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "tsen";
#else
    public static string UnitSymbol { get; } = "цэн";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["tsen", "tzen", "zen"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)268.08932736387764403099112624326425564998257419372134795313798557;
}
