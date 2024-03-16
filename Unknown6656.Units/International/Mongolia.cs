#if !USE_DIACRITICS
global using Пүү = Unknown6656.Units.International.Mongolia.Puu;
global using Жин = Unknown6656.Units.International.Mongolia.Jin;
global using Лан = Unknown6656.Units.International.Mongolia.Lan;
global using Цэн = Unknown6656.Units.International.Mongolia.Tsen;
#endif

using Unknown6656.Units.Matter;

namespace Unknown6656.Units.International.Mongolia;


// TODO : https://en.wikipedia.org/wiki/Mongolian_units


[KnownUnit<Mass, Пүү, Kilogram, Scalar>]
#if USE_DIACRITICS
public partial record Пүү(Scalar Value)
#else
public partial record Puu(Scalar Value)
#endif
    : Mass.AffineUnit<Пүү>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Mass, Жин, Kilogram, Scalar>]
#if USE_DIACRITICS
public partial record Жин(Scalar Value)
#else
public partial record Jin(Scalar Value)
#endif
    : Mass.AffineUnit<Жин>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Mass, Лан, Kilogram, Scalar>]
#if USE_DIACRITICS
public partial record Лан(Scalar Value)
#else
public partial record Lan(Scalar Value)
#endif
    : Mass.AffineUnit<Лан>(Value)
    , ILinearUnit<Scalar>
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

[KnownUnit<Mass, Цэн, Kilogram, Scalar>]
#if USE_DIACRITICS
public partial record Цэн(Scalar Value)
#else
public partial record Tsen(Scalar Value)
#endif
    : Mass.AffineUnit<Цэн>(Value)
    , ILinearUnit<Scalar>
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
