// #define IGNORE_CS0695
#define IMPLICT_SCALAR_TO_UNIT
#define SI_PREFIX_IGNORE_CASE


using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Numerics;
using System.Linq;
using System.Text;
using System;

namespace Unknown6656.Units;


////////////////////////////////////////////////////////////////////////////////////////////////
///                                                                                          ///
/// THIS ENTIRE CODE BASE WILL ENORMOUSLY BENEFIT FROM C# 13 "SHAPES AND EXTENSIONS" FEATURE ///
///                                                                                          ///
////////////////////////////////////////////////////////////////////////////////////////////////


public enum UnitDisplay
    : uint
{
    MetricUseSIPrefixes,
    MetricUseSIPrefixesOnlyOnMultiples,
    MetricUseSIPrefixesOnlyOnSubmultiples,
    MetricNoSIPrefixes,
    MetricSI_Shifted_k,
    MetricSI_Shifted_M,
    MetricSI_Shifted_m,
    MetricSI_Shifted_μ,

    Imperial,
    ImperialWithSIPrefixes,

    PrefixedUnitNotation,
    UseFormatStrings,
    UseInverseFormatStrings,
}

public interface IUnit
{
    public static abstract string UnitSymbol { get; }
    public static abstract UnitDisplay UnitDisplay { get; }
    public static virtual string[] AlternativeUnitSymbols { get; } = [];
}

public interface IUnit<TUnit, TBaseUnit, TScalar>
    where TUnit : class, IUnit<TUnit, TBaseUnit, TScalar>, IUnit
    where TBaseUnit : class, IBaseUnit<TBaseUnit, TScalar>, IUnit
    where TScalar : INumber<TScalar>
{
    public TBaseUnit ToBaseUnit();

    public static abstract TUnit FromBaseUnit(TBaseUnit base_unit);
}

public interface IBaseUnit<TBaseUnit, TScalar>
    : IUnit<TBaseUnit, TBaseUnit, TScalar>
    where TBaseUnit : class, IBaseUnit<TBaseUnit, TScalar>, IUnit
    where TScalar : INumber<TScalar>
{
}

public enum SIUnitScale
    : int
{
    Base_1000 = 1000,
    Base_1024 = 1024,
}

public static partial class Unit
{
    private static readonly Dictionary<string, string> _DIACRITICS_MAPPING = new()
    {
        ["äæǽ"] = "ae",
        ["öœ"] = "oe",
        ["ü"] = "ue",
        ["Ä"] = "Ae",
        ["Ü"] = "Ue",
        ["Ö"] = "Oe",
        ["ÀÁÂÃÄÅǺĀĂĄǍΑΆẢẠẦẪẨẬẰẮẴẲẶА"] = "A",
        ["àáâãåǻāăąǎªαάảạầấẫẩậằắẵẳặа"] = "a",
        ["Б"] = "B",
        ["б"] = "b",
        ["ÇĆĈĊČ"] = "C",
        ["çćĉċč"] = "c",
        ["Д"] = "D",
        ["д"] = "d",
        ["ÐĎĐΔ"] = "Dj",
        ["ðďđδ"] = "dj",
        ["ÈÉÊËĒĔĖĘĚΕΈẼẺẸỀẾỄỂỆЕЭ"] = "E",
        ["èéêëēĕėęěέεẽẻẹềếễểệеэ"] = "e",
        ["Ф"] = "F",
        ["ф"] = "f",
        ["ĜĞĠĢΓГҐ"] = "G",
        ["ĝğġģγгґ"] = "g",
        ["ĤĦ"] = "H",
        ["ĥħ"] = "h",
        ["ÌÍÎÏĨĪĬǏĮİΗΉΊΙΪỈỊИЫ"] = "I",
        ["ìíîïĩīĭǐįıηήίιϊỉịиыї"] = "i",
        ["Ĵ"] = "J",
        ["ĵ"] = "j",
        ["ĶΚК"] = "K",
        ["ķκк"] = "k",
        ["ĹĻĽĿŁΛЛ"] = "L",
        ["ĺļľŀłλл"] = "l",
        ["М"] = "M",
        ["м"] = "m",
        ["ÑŃŅŇΝН"] = "N",
        ["ñńņňŉνн"] = "n",
        ["ÒÓÔÕŌŎǑŐƠØǾΟΌΩΏỎỌỒỐỖỔỘỜỚỠỞỢО"] = "O",
        ["òóôõōŏǒőơøǿºοόωώỏọồốỗổộờớỡởợо"] = "o",
        ["П"] = "P",
        ["п"] = "p",
        ["ŔŖŘΡР"] = "R",
        ["ŕŗřρр"] = "r",
        ["ŚŜŞȘŠΣС"] = "S",
        ["śŝşșšſσςс"] = "s",
        ["ȚŢŤŦτТ"] = "T",
        ["țţťŧт"] = "t",
        ["ÙÚÛŨŪŬŮŰŲƯǓǕǗǙǛŨỦỤỪỨỮỬỰУ"] = "U",
        ["ùúûũūŭůűųưǔǖǘǚǜυύϋủụừứữửựу"] = "u",
        ["ÝŸŶΥΎΫỲỸỶỴЙ"] = "Y",
        ["ýÿŷỳỹỷỵй"] = "y",
        ["В"] = "V",
        ["в"] = "v",
        ["Ŵ"] = "W",
        ["ŵ"] = "w",
        ["ŹŻŽΖЗ"] = "Z",
        ["źżžζз"] = "z",
        ["ÆǼ"] = "AE",
        ["ß"] = "ss",
        ["Ĳ"] = "IJ",
        ["ĳ"] = "ij",
        ["Œ"] = "OE",
        ["ƒ"] = "f",
        ["ξ"] = "ks",
        ["π"] = "p",
        ["β"] = "v",
        ["μ"] = "m",
        ["ψ"] = "ps",
        ["Ё"] = "Yo",
        ["ё"] = "yo",
        ["Є"] = "Ye",
        ["є"] = "ye",
        ["Ї"] = "Yi",
        ["Ж"] = "Zh",
        ["ж"] = "zh",
        ["Х"] = "Kh",
        ["х"] = "kh",
        ["Ц"] = "Ts",
        ["ц"] = "ts",
        ["Ч"] = "Ch",
        ["ч"] = "ch",
        ["Ш"] = "Sh",
        ["ш"] = "sh",
        ["Щ"] = "Shch",
        ["щ"] = "shch",
        ["ЪъЬь"] = "",
        ["Ю"] = "Yu",
        ["ю"] = "yu",
        ["Я"] = "Ya",
        ["я"] = "ya",
    };
    private static readonly Dictionary<Type, string[]> _cached_alternative_unit_symbols = [];
    private static readonly (string key, string value)[] _normalization_replacements = new[]
    {
        ("¹", "^1"),
        ("²", "^2"),
        ("³", "^3"),
        ("⁴", "^4"),
        ("⁵", "^5"),
        ("⁶", "^6"),
        ("⁷", "^7"),
        ("⁸", "^8"),
        ("⁹", "^9"),
        ("⁻¹", "^-1"),
        ("⁻²", "^-2"),
        ("⁻³", "^-3"),
        ("⁻⁴", "^-4"),
        ("⁻⁵", "^-5"),
        ("⁻⁶", "^-6"),
        ("⁻⁷", "^-7"),
        ("⁻⁸", "^-8"),
        ("⁻⁹", "^-9"),
        ("₀", "_0"),
        ("₁", "_1"),
        ("₂", "_2"),
        ("₃", "_3"),
        ("₄", "_4"),
        ("₅", "_5"),
        ("₆", "_6"),
        ("₇", "_7"),
        ("₈", "_8"),
        ("₉", "_9"),
        ("ₐ", "_a"),
        ("ₑ", "_e"),
        ("ₒ", "_o"),
        ("ₓ", "_x"),
        ("ₔ", "_e"),
        ("ₕ", "_h"),
        ("ₖ", "_k"),
        ("ₗ", "_l"),
        ("ₘ", "_m"),
        ("ₙ", "_n"),
        ("ₚ", "_p"),
        ("ₛ", "_s"),
        ("ₜ", "_t"),
        ("/", "per"),
        (".", ""),
        ("·", "*"),
        ("*", ""), // <-- TODO : verify whether that makes sense.
        ("(", ""), // <-- TODO : verify whether that makes sense.
        (")", ""), // <-- TODO : verify whether that makes sense.
        ("squared", "^2"),
        ("cubed", "^3"),
        ("degrees", "°"),
        ("degree", "°"),
        ("inchs", "inches"),
        ("feets", "feet"),
        ("foots", "feet"),
        ("feet", "foot"),
        ("metre", "meter"),
        ("litre", "liter"),
        
        /*
        ₊₋₌₍₎ ⁰ ⁺⁻⁼⁽⁾ ⁿⁱ
         */

    };
    private static readonly Regex _REGEX_FORMATTED_NUMBER = new("""
    ^
    (?<sign>[+\-])?
    \s*
    (?<value>
        (?<const>pi|tau|e|phi|zero|one|nan|\[nan\]|(p(os(itive)?)?|n(eg(ative)?)?)?inf(inity|ty)?)
       |(?<number>(\d+(\s*\.\s*\d*)?|\.\s*\d+)((e|x\s*10\s*\^)\s*[+\-]?\s*\d+)?)
    )
    \s*
    (?<unit>.*$)
    """, RegexOptions.CultureInvariant | RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace | RegexOptions.NonBacktracking);
    private static readonly Regex _REGEX_WORD_TOKENS = new(@"[\p{Ll}\p{Lt}\p{Lu}\p{Lo}\p{Lm}\p{Nd}]*[\p{Ll}\p{Lu}\p{Lt}\p{Lo}\p{Lm}]", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace | RegexOptions.NonBacktracking);
    private static readonly Regex _REGEX_SUBSCRIPT = new(@"(_[\p{Ll}\p{Lt}\p{Lu}\p{Lo}\p{Lm}\p{Nd}])+", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace | RegexOptions.NonBacktracking);

    public static IReadOnlyList<string> MetricSIPrefixesMultiple { get; } = ["k", "M", "G", "T", "P", "E", "Z", "Y", "R", "Q"];
    public static IReadOnlyList<string> MetricSIPrefixesSubmultiple { get; } = ["m", "μ", "n", "p", "f", "a", "z", "y", "r", "q"];
    public static IReadOnlyDictionary<string, string> MetricSIMapping { get; } = new Dictionary<string, string>
    {
        ["quecto"] = "q",
        ["ronto"] = "r",
        ["yocto"] = "y",
        ["zepto"] = "z",
        ["atto"] = "a",
        ["femto"] = "f",
        ["pico"] = "p",
        ["nano"] = "n",
        ["micro"] = "μ",
        ["milli"] = "m",
        ["centi"] = "c",
        ["deci"] = "d",
        ["deca"] = "da",
        ["hecto"] = "h",
        ["kilo"] = "k",
        ["mega"] = "M",
        ["giga"] = "G",
        ["tera"] = "T",
        ["peta"] = "P",
        ["exa"] = "E",
        ["zetta"] = "Z",
        ["yotta"] = "Y",
        ["ronna"] = "R",
        ["quetta"] = "Q",
    };
    public static NumberFormatInfo DefaultNumberFormat { get; set; } = new()
    {
        CurrencyDecimalSeparator = ".",
        NumberDecimalSeparator = ".",
        PercentDecimalSeparator = ".",
        CurrencyGroupSeparator = "'",
        NumberGroupSeparator = "'",
        PercentGroupSeparator = "'",
        CurrencyDecimalDigits = 2,
        PercentDecimalDigits = 2,
        NumberDecimalDigits = 3,
        PercentSymbol = "%",
        PerMilleSymbol = "‰",
        NaNSymbol = "NaN",
    };


    public static bool IsMetric(this UnitDisplay display) => display is UnitDisplay.MetricUseSIPrefixes
                                                                     or UnitDisplay.MetricUseSIPrefixesOnlyOnMultiples
                                                                     or UnitDisplay.MetricUseSIPrefixesOnlyOnSubmultiples
                                                                     or UnitDisplay.MetricNoSIPrefixes
                                                                     or UnitDisplay.MetricSI_Shifted_k
                                                                     or UnitDisplay.MetricSI_Shifted_M
                                                                     or UnitDisplay.MetricSI_Shifted_m
                                                                     or UnitDisplay.MetricSI_Shifted_μ;

    public static bool IsImperial(this UnitDisplay display) => display is UnitDisplay.Imperial or UnitDisplay.ImperialWithSIPrefixes;

    private static bool IgnoreSIPrefixForParsing(this UnitDisplay display) => display is UnitDisplay.MetricNoSIPrefixes
                                                                                      or UnitDisplay.UseFormatStrings
                                                                                      or UnitDisplay.UseInverseFormatStrings;

    public static bool IsSI(this UnitDisplay display) => display is UnitDisplay.MetricUseSIPrefixes
                                                                 or UnitDisplay.MetricUseSIPrefixesOnlyOnMultiples
                                                                 or UnitDisplay.MetricUseSIPrefixesOnlyOnSubmultiples
                                                                 or UnitDisplay.MetricSI_Shifted_k
                                                                 or UnitDisplay.MetricSI_Shifted_M
                                                                 or UnitDisplay.MetricSI_Shifted_m
                                                                 or UnitDisplay.MetricSI_Shifted_μ
                                                                 or UnitDisplay.UseFormatStrings
                                                                 or UnitDisplay.UseInverseFormatStrings
                                                                 or UnitDisplay.ImperialWithSIPrefixes;

    private static string FormatImperial<TScalar>(TScalar scalar, string? unit_symbol, string? format, IFormatProvider? format_provider, UnitDisplay display)
        where TScalar : INumber<TScalar>
    {
        string formatted = TScalar.IsNaN(scalar) ? "[NaN]"
                         : TScalar.IsPositiveInfinity(scalar) ? "∞"
                         : TScalar.IsNegativeInfinity(scalar) ? "-∞"
                         : scalar?.ToString(format ?? "N", format_provider ?? DefaultNumberFormat) ?? "0";

        if (string.IsNullOrWhiteSpace(unit_symbol))
            return formatted;
        else if (display is UnitDisplay.PrefixedUnitNotation)
            return $"{unit_symbol} {formatted}";
        else if (display is UnitDisplay.UseFormatStrings or UnitDisplay.UseInverseFormatStrings)
            return string.Format(format_provider, unit_symbol, formatted);
        else
            return $"{formatted} {unit_symbol}";
    }

    public static string Format<TScalar>(TScalar value, string? unit_symbol, string? format, IFormatProvider? format_provider, UnitDisplay display, SIUnitScale scale = SIUnitScale.Base_1000)
        where TScalar : INumber<TScalar>
    {
        unit_symbol = unit_symbol?.Trim();

        if (unit_symbol is null || !display.IsSI())
            return FormatImperial(value, unit_symbol, format, format_provider, display);

        TScalar @base = TScalar.CreateChecked((int)scale);
        bool? inverse_formatted = null;
        bool negative = value < TScalar.Zero;
        int order = -1;

        value = TScalar.Abs(value);

        if (display is UnitDisplay.MetricSI_Shifted_k && unit_symbol is ['k' or 'K', ..string suffixk])
        {
            value *= @base;
            unit_symbol = suffixk;
            display = UnitDisplay.MetricUseSIPrefixes;
        }
        else if (display is UnitDisplay.MetricSI_Shifted_M && unit_symbol is ['M', ..string suffixM])
        {
            value *= @base * @base;
            unit_symbol = suffixM;
            display = UnitDisplay.MetricUseSIPrefixes;
        }
        else if (display is UnitDisplay.MetricSI_Shifted_m && unit_symbol is ['m', .. string suffixm])
        {
            value /= @base;
            unit_symbol = suffixm;
            display = UnitDisplay.MetricUseSIPrefixes;
        }
        else if (display is UnitDisplay.MetricSI_Shifted_μ && unit_symbol is ['μ' or 'u', ..string suffixμ])
        {
            value /= @base * @base;
            unit_symbol = suffixμ;
            display = UnitDisplay.MetricUseSIPrefixes;
        }
        else if (display is UnitDisplay.UseFormatStrings or UnitDisplay.UseInverseFormatStrings)
        {
            inverse_formatted = display is UnitDisplay.UseInverseFormatStrings;
            display = UnitDisplay.MetricUseSIPrefixes;
        }

        bool submultiple = value < TScalar.One;
        IReadOnlyList<string> prefixes = (inverse_formatted ?? false) ^ submultiple ? MetricSIPrefixesSubmultiple : MetricSIPrefixesMultiple;

        if (display is UnitDisplay.MetricUseSIPrefixes or UnitDisplay.ImperialWithSIPrefixes
            || (submultiple ? display is UnitDisplay.MetricUseSIPrefixesOnlyOnSubmultiples
                            : display is UnitDisplay.MetricUseSIPrefixesOnlyOnMultiples))
            while (TScalar.IsFinite(value) && value != TScalar.Zero && (submultiple ? value < TScalar.One : value >= @base) && order < prefixes.Count - 1)
            {
                ++order;

                if (submultiple)
                    value *= @base;
                else
                    value /= @base;
            }

        if (negative)
            value = -value;

        return FormatImperial(
            value,
            (order < 0 ? "" : prefixes[order] + (scale == SIUnitScale.Base_1024 ? "i" : "")) + unit_symbol,
            format,
            format_provider,
            inverse_formatted is null ? display : UnitDisplay.UseFormatStrings
        );
    }

    private static int? GetExponent(string si_prefix) => si_prefix switch
    {
        "q" => -30,
        "r" => -27,
        "y" => -24,
        "z" => -21,
#if SI_PREFIX_IGNORE_CASE
        "a" or "A" => -18,
        "f" or "F" => -15,
#else
        "a" => -18,
        "f" => -15,
#endif
        "p" => -12,
#if SI_PREFIX_IGNORE_CASE
        "n" or "N" => -9,
        "μ" or "u" or "U" => -6,
#else
        "n" => -9,
        "μ" or "u" => -6,
#endif
        "m" => -3,
        "da" => 1,
#if SI_PREFIX_IGNORE_CASE
        "c" or "C" => -2,
        "d" or "D" => -1,
        "h" or "H" => 2,
        "k" or "K" => 3,
#else
        "c" => -2,
        "d" => -1,
        "h" => 2,
        "k" => 3,
#endif
        "M" => 6,
#if SI_PREFIX_IGNORE_CASE
        "G" or "g" => 9,
#else
        "G" => 9,
#endif
        "T" => 12,
        "P" => 15,
#if SI_PREFIX_IGNORE_CASE
        "E" or "e" => 18,
#else
        "E" => 18,
#endif
        "Z" => 21,
        "Y" => 24,
        "R" => 27,
        "Q" => 30,
        _ => null,
    };

    private static string RemoveDiacritics(this string input)
    {
        string normalized = input.Normalize(NormalizationForm.FormD);
        StringBuilder sb = new(normalized.Length);

        foreach (char c in input)
            if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
            {
                bool found = false;

                foreach ((string key, string value) in _DIACRITICS_MAPPING)
                    if (key.Contains(c))
                    {
                        sb.Append(value);
                        found = true;

                        break;
                    }

                if (!found)
                    sb.Append(c);
            }

        return sb.ToString().Normalize(NormalizationForm.FormC);
    }

    private static string NormalizeString(this string input)
    {
        input = new([.. from c in input
                              where !char.IsWhiteSpace(c)
                              where c != '·'
                              select c switch
                              {
                                  '\u05BE' or '\u1806' or '\u2010' or '\u2011' or '\u2012' or '\u2013' or '\u2014' or '\u2015' or
                                  '\u2053' or '\u207B' or '\u208B' or '\u2212' or '\u23AF' or '\u23E4' or '\u2500' or '\u2501' or
                                  '\u2796' or '\u2E3A' or '\u2E3B' or '\uFE58' or '\uFE63' or '\uFF0D' => '-',
                                  '\u02D6' or '\uFE62' or '\uFF0B' or '\u208A' or '\u207A' => '+',
                                  char ch => ch,
                              }]);

        return input.Replace("\U00010110", "-")
                    .Replace("\U000110BE", "-")
        //          .Replace("\U00011052", "-") // BUG, see https://github.com/dotnet/runtime/issues/97544
                    .Replace("π", "pi")
                    .Replace("τ", "tau")
                    .Replace("φ", "phi")
                    .Replace("∞", "infinity")
                    .RemoveDiacritics();
    }

    private static string NormalizeUnitSymbol(this string unit_symbol, bool ignore_si_prefix)
    {
        if (!ignore_si_prefix)
            foreach ((string name, string prefix) in MetricSIMapping)
                unit_symbol = unit_symbol.Replace(name, prefix, StringComparison.OrdinalIgnoreCase);

        foreach ((string key, string value) in _normalization_replacements)
            unit_symbol = unit_symbol.Replace(key, value, StringComparison.OrdinalIgnoreCase);

        unit_symbol = _REGEX_SUBSCRIPT.Replace(unit_symbol, match => new([..match.Value
                                                                                 .Where(c => c != '_')
                                                                                 .OrderBy(c => c)
                                                                                 .Distinct()
                                                                                 .Prepend('_')]));

        return unit_symbol;
    }

    public static bool TryParse<TScalar, TUnit>(string? value, IFormatProvider? provider, [MaybeNullWhen(false), NotNullWhen(true)] out TScalar? scalar)
        where TScalar : INumber<TScalar>
        where TUnit : IUnit
    {
        Type type = typeof(TUnit);

        if (!_cached_alternative_unit_symbols.TryGetValue(type, out string[]? unit_symbols))
        {
            bool ignore_si_prefix = TUnit.UnitDisplay.IgnoreSIPrefixForParsing();
            List<string> symbols = [
                TUnit.UnitSymbol,
                ..TUnit.AlternativeUnitSymbols,
                type.Name,
            ];

            foreach (string alt in symbols.ToArray()/* shallow copy */)
            {
                IEnumerable<string> variants = [];
                int last_index = 0;

                foreach (Match m in _REGEX_WORD_TOKENS.Matches(alt))
                {
                    string prev = alt[last_index..m.Index];
                    string match = m.Value;

                    last_index = m.Index + m.Length;

                    if (match.EndsWith("s", StringComparison.InvariantCultureIgnoreCase))
                        variants = variants.Any() ? variants.Select(v => v + prev + match) : [prev + match];
                    else
                        variants = variants.Any() ? variants.SelectMany(v => new[] { v + prev + match, v + prev + match + 's' })
                                                  : [prev + match, prev + match + 's'];
                }

                if (last_index < alt.Length)
                {
                    string prev = alt[last_index..];

                    variants = variants.Select(v => v + prev).DefaultIfEmpty(prev);
                }

                symbols.AddRange(variants);
            }

            unit_symbols = symbols.Select(s => s.ToLowerInvariant()
                                                .NormalizeString()
                                                .NormalizeUnitSymbol(ignore_si_prefix))
                                  .Distinct()
                                  .OrderByDescending(s => s.Length)
                                  .ToArray();
            _cached_alternative_unit_symbols[type] = unit_symbols;
        }

        return TryParse(value, unit_symbols, TUnit.UnitDisplay, provider, out scalar);
    }

    private static bool TryParse<TScalar>(string? value, IEnumerable<string> unit_symbols, UnitDisplay display, IFormatProvider? provider, [MaybeNullWhen(false), NotNullWhen(true)] out TScalar? scalar)
        where TScalar : INumber<TScalar>
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            scalar = TScalar.Zero;

            return true;
        }
        else if (TScalar.TryParse(value, provider, out scalar))
            return true;

        NumberFormatInfo parser = provider?.GetFormat(typeof(NumberFormatInfo)) as NumberFormatInfo ?? CultureInfo.CurrentCulture.NumberFormat;
        bool ignore_si_prefix = display.IgnoreSIPrefixForParsing();
        SIUnitScale scale = SIUnitScale.Base_1000;
        bool success = false;

        value = value.Replace("'", "")
                     .Replace(parser.CurrencyGroupSeparator, "")
                     .Replace(parser.NumberGroupSeparator, "")
                     .Replace(parser.PercentGroupSeparator, "")
                     .Replace(parser.CurrencyDecimalSeparator, ".")
                     .Replace(parser.NumberDecimalSeparator, ".")
                     .Replace(parser.PercentDecimalSeparator, ".")
                     .NormalizeString()
                     .RemoveDiacritics();

        if (_REGEX_FORMATTED_NUMBER.Match(value) is { Success: true, Groups: { } groups })
        {
            string @const = groups["const"].Value;
            string number = groups["number"].Value;
            bool negative = groups["sign"].Value == "-";
            string unit = groups["unit"].Value;
            int exponent = 0;

            unit = NormalizeUnitSymbol(unit, ignore_si_prefix);

            foreach (string unit_symbol in unit_symbols)
                if (unit.EndsWith(unit_symbol, StringComparison.InvariantCultureIgnoreCase))
                {
                    string consumed_unit = unit[..^unit_symbol.Length].Trim();

                    if (!ignore_si_prefix)
                    {
                        if (consumed_unit.EndsWith("i", StringComparison.InvariantCultureIgnoreCase))
                        {
                            scale = SIUnitScale.Base_1024;
                            consumed_unit = consumed_unit[..^1];
                        }

                        if (consumed_unit.Length >= 1 && GetExponent(consumed_unit) is int exp)
                        {
                            exponent = exp;
                            consumed_unit = "";
                        }
                    }

                    if (success = consumed_unit.Length == 0)
                        break;
                }

            if (success)
            {
                success = TScalar.TryParse(number, new NumberFormatInfo(), out scalar);
                scalar ??= TScalar.Zero;

                if (@const.ToLowerInvariant() switch
                {
                    "[nan]" or "nan" => double.NaN,
                    "pi" => double.Pi,
                    "tau" => double.Tau,
                    "e" => double.E,
                    "zero" => 0,
                    "one" => 1,
                    "phi" => 1.618033988749894848204586834,
                    string s when s.StartsWith("n") && (s.EndsWith("inf") || s.EndsWith("ty")) => double.NegativeInfinity,
                    string s when s.EndsWith("inf") || s.EndsWith("ty") => double.PositiveInfinity,
                    _ => null as double?
                } is double d)
                {
                    scalar = (TScalar)Convert.ChangeType(d, typeof(TScalar));
                    success = true;
                }

                if (success && exponent != 0)
                {
                    double factor;

                    if (scale is SIUnitScale.Base_1024)
                    {
                        if (exponent % 3 == 0)
                            factor = Math.Pow(1024, exponent / 3);
                        else
                            factor = Math.Pow(10.079368399158985318137684858225826804562011717612063840655800897, exponent); // = 1024^(1/3)
                    }
                    else if (scale is SIUnitScale.Base_1000)
                        factor = Math.Pow(10, exponent);
                    else
                        throw new NotImplementedException($"The SI unit scale {scale} is currently not supported.");

                    scalar *= (TScalar)Convert.ChangeType(factor, typeof(TScalar));
                }

                if (negative)
                    scalar = -scalar;
            }
        }

        return success;
    }
}

public abstract record AbstractUnit<TUnit, TBaseUnit, TScalar>(TScalar Value)
    : IAdditionOperators<TUnit, TUnit, TUnit>
    , ISubtractionOperators<TUnit, TUnit, TUnit>
    , IDivisionOperators<TUnit, TUnit, TScalar>
    , IMultiplyOperators<TUnit, TScalar, TUnit>
#if IGNORE_CS0695
    , IMultiplyOperators<TScalar, TUnit, TUnit>
    , IDivisionOperators<TUnit, TScalar, TUnit>
#endif
    , IUnaryNegationOperators<TUnit, TUnit>
    , IUnaryPlusOperators<TUnit, TUnit>
    , IIncrementOperators<TUnit>
    , IDecrementOperators<TUnit>
    , IFormattable
    , IParsable<TUnit>
    where TUnit : AbstractUnit<TUnit, TBaseUnit, TScalar>
                , IUnit<TUnit, TBaseUnit, TScalar>
                , IUnit
    where TBaseUnit : AbstractUnit<TBaseUnit, TBaseUnit, TScalar>
                    , IBaseUnit<TBaseUnit, TScalar>
                    , IUnit
    where TScalar : INumber<TScalar>
{
    private static readonly Func<TScalar, TUnit> _constructor;

    public static bool IsMetric => TUnit.UnitDisplay.IsMetric();

    public static bool IsSI => TUnit.UnitDisplay.IsSI();

    public static bool IsImperial => TUnit.UnitDisplay.IsImperial();

    public static TUnit Zero { get; }

    public static TUnit One { get; }


    static AbstractUnit()
    {
        Type @this = typeof(TUnit);
        bool is_quantity = @this.IsAssignableTo(typeof(IQuantity));
        ConstructorInfo? constructor = @this.GetConstructor([is_quantity ? typeof(TBaseUnit) : typeof(TScalar)]);
        InvalidProgramException ex = new(
            is_quantity ? $"The unit type '{@this}' does not have a constructor with a single parameter of type '{typeof(TScalar)}'."
                        : $"The quantity '{@this}' does not have a constructor with a single parameter of type '{typeof(TBaseUnit)}'."
        );

        if (constructor is null)
            throw ex;

        _constructor = s => constructor.Invoke([is_quantity ? AbstractUnit<TBaseUnit, TBaseUnit, TScalar>.FromScalar(s) : s]) as TUnit ?? throw ex;
        Zero = _constructor(TScalar.Zero);
        One = _constructor(TScalar.One);
    }

    #region TOSTRING / PARSING

    public sealed override string ToString() => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider) => ToString(format, formatProvider, SIUnitScale.Base_1000);

    public string ToString(string? format, IFormatProvider? formatProvider, SIUnitScale scale) => Unit.Format(Value, TUnit.UnitSymbol, format, formatProvider, TUnit.UnitDisplay, scale);

    public static TUnit Parse(string s, IFormatProvider? provider) =>
        TryParse(s, provider, out TUnit? result) ? result : throw new FormatException($"The string '{s}' ({s.Length} char(s)) could not be parsed to a valid instance of {typeof(TUnit)} or {typeof(TScalar)}.");

    public static bool TryParse(string? s, IFormatProvider? provider, [MaybeNullWhen(false), NotNullWhen(true)] out TUnit? result)
    {
        bool success;

        if (Unit.TryParse<TScalar, TUnit>(s, provider, out TScalar? scalar))
            (success, result) = (true, FromScalar(scalar));
        else
            (success, result) = (false, null);

        return success;
    }

    #endregion

    public abstract TBaseUnit ToBaseUnit();

    public static TUnit FromScalar(TScalar value) => _constructor(value);

    #region CASTING / CONVERSION OPERATORS

    public static implicit operator TBaseUnit(AbstractUnit<TUnit, TBaseUnit, TScalar> unit) => unit.ToBaseUnit();

    public static implicit operator AbstractUnit<TUnit, TBaseUnit, TScalar>(TBaseUnit base_unit) => TUnit.FromBaseUnit(base_unit);

#if IMPLICT_SCALAR_TO_UNIT
    public static implicit
#else
    public static explicit
#endif
        operator AbstractUnit<TUnit, TBaseUnit, TScalar>(TScalar value) => FromScalar(value);

    public static implicit operator TUnit(AbstractUnit<TUnit, TBaseUnit, TScalar> unit) => unit as TUnit ?? FromScalar(unit.Value);

    public static explicit operator TScalar(AbstractUnit<TUnit, TBaseUnit, TScalar> unit) => unit.Value;

    public static implicit operator string(AbstractUnit<TUnit, TBaseUnit, TScalar> unit) => unit.ToString();

    public static implicit operator AbstractUnit<TUnit, TBaseUnit, TScalar>(string s) => Parse(s, null);

    #endregion
    #region ARITHMETIC OPERATORS

    public static TUnit operator +(AbstractUnit<TUnit, TBaseUnit, TScalar> left, AbstractUnit<TUnit, TBaseUnit, TScalar> right) => FromScalar(left.Value + right.Value);

    public static TUnit operator -(AbstractUnit<TUnit, TBaseUnit, TScalar> left, AbstractUnit<TUnit, TBaseUnit, TScalar> right) => FromScalar(left.Value - right.Value);

    public static TUnit operator *(AbstractUnit<TUnit, TBaseUnit, TScalar> left, TScalar right) => FromScalar(left.Value * right);

    public static TUnit operator *(TScalar left, AbstractUnit<TUnit, TBaseUnit, TScalar> right) => FromScalar(left * right.Value);

    public static TUnit operator /(AbstractUnit<TUnit, TBaseUnit, TScalar> left, TScalar right) => FromScalar(left.Value / right);

    public static TScalar operator /(AbstractUnit<TUnit, TBaseUnit, TScalar> left, AbstractUnit<TUnit, TBaseUnit, TScalar> right) => left.Value / right.Value;

    public static TUnit operator +(AbstractUnit<TUnit, TBaseUnit, TScalar> value) => value;

    public static TUnit operator -(AbstractUnit<TUnit, TBaseUnit, TScalar> value) => value;

    public static TUnit operator ++(AbstractUnit<TUnit, TBaseUnit, TScalar> value) => value + One;

    public static TUnit operator --(AbstractUnit<TUnit, TBaseUnit, TScalar> value) => value - One;

    static TUnit IAdditionOperators<TUnit, TUnit, TUnit>.operator +(TUnit left, TUnit right) => left + right;

    static TUnit ISubtractionOperators<TUnit, TUnit, TUnit>.operator -(TUnit left, TUnit right) => left - right;

    static TUnit IMultiplyOperators<TUnit, TScalar, TUnit>.operator *(TUnit left, TScalar right) => left * right;
#if IGNORE_CS0695
    static TUnit IMultiplyOperators<TScalar, TUnit, TUnit>.operator *(TScalar left, TUnit right) => left * right;

    static TUnit IDivisionOperators<TUnit, TScalar, TUnit>.operator /(TUnit left, TScalar right) => left / right;
#endif
    static TScalar IDivisionOperators<TUnit, TUnit, TScalar>.operator /(TUnit left, TUnit right) => left / right;

    static TUnit IUnaryPlusOperators<TUnit, TUnit>.operator +(TUnit value) => value;

    static TUnit IUnaryNegationOperators<TUnit, TUnit>.operator -(TUnit value) => value;

    static TUnit IIncrementOperators<TUnit>.operator ++(TUnit value) => ++value;

    static TUnit IDecrementOperators<TUnit>.operator --(TUnit value) => --value;

    #endregion
}

/// <summary>
/// Conversion between unit and base unit:
/// <para/>
/// <c>
///     <see langword="this"/> = (<see langword="base"/> + <see cref="PreScalingOffset"/>) * <see cref="ScalingFactor"/> + <see cref="PostScalingOffset"/>
///     <br/>
///     <see langword="base"/> = (<see langword="this"/> - <see cref="PostScalingOffset"/>) / <see cref="ScalingFactor"/> - <see cref="PreScalingOffset"/>
/// </c>
/// </summary>
public interface IAffineUnit<TScalar>
    where TScalar : INumber<TScalar>
{
    /// <summary>
    /// Scaling factor multiplied with the base unit to get the unit.
    /// </summary>
    public abstract static TScalar ScalingFactor { get; }

    public abstract static TScalar PreScalingOffset { get; }

    public abstract static TScalar PostScalingOffset { get; }
}

public interface ILinearUnit<TScalar>
    : IAffineUnit<TScalar>
    where TScalar : INumber<TScalar>
{
    static TScalar IAffineUnit<TScalar>.PreScalingOffset { get; } = TScalar.Zero;

    static TScalar IAffineUnit<TScalar>.PostScalingOffset { get; } = TScalar.Zero;
}

public interface IArbitraryUnit<TScalar>
    where TScalar : INumber<TScalar>
{
    public static abstract TScalar FromBaseUnit(TScalar value);

    public TScalar ToBaseUnit(TScalar value);
}

internal interface IQuantity;

public interface IQuantity<TQuantity>
    where TQuantity : IQuantity<TQuantity>
{
    public static abstract bool TryParse(string? s, IFormatProvider? provider, [MaybeNullWhen(false), NotNullWhen(true)] out TQuantity? result);
}

public record Quantity<TQuantity, TBaseUnit, TScalar>
    : AbstractUnit<TQuantity, TBaseUnit, TScalar>
    , IUnit<TQuantity, TBaseUnit, TScalar>
    , IUnit
    , IQuantity
    where TQuantity : Quantity<TQuantity, TBaseUnit, TScalar>
                    , IQuantity<TQuantity>
    where TBaseUnit : BaseUnit<TQuantity, TBaseUnit, TScalar>
                    , IBaseUnit<TBaseUnit, TScalar>
                    , IUnit<TBaseUnit, TBaseUnit, TScalar>
                    , IAffineUnit<TScalar>
                    , IUnit
    where TScalar : INumber<TScalar>
{
    public static string UnitSymbol { get; } = TBaseUnit.UnitSymbol;
    public static UnitDisplay UnitDisplay { get; } = TBaseUnit.UnitDisplay;

    public new TBaseUnit Value;


    private Quantity(TScalar value)
        : base(value) => Value = BaseUnit<TQuantity, TBaseUnit, TScalar>.FromScalar(value);

    public Quantity(TBaseUnit value)
        : base(value.Value) => Value = value;

    public sealed override TBaseUnit ToBaseUnit() => Value;


    public static new TQuantity Parse(string s, IFormatProvider? provider) =>
        TryParse(s, provider, out TQuantity? result) ? result : throw new FormatException($"The string '{s}' ({s.Length} char(s)) could not be parsed to a valid instance of {typeof(TQuantity)}.");

    public static new bool TryParse(string? s, IFormatProvider? provider, [MaybeNullWhen(false), NotNullWhen(true)] out TQuantity? result)
    {
        bool success;

        if (TQuantity.TryParse(s, provider, out TQuantity? quantity))
            (success, result) = (true, quantity);
        else if(BaseUnit<TQuantity, TBaseUnit, TScalar>.TryParse(s, provider, out TBaseUnit? @base))
            (success, result) = (true, FromBaseUnit(@base));
        else
            (success, result) = (false, null);

        return success;
    }

    public static TQuantity FromBaseUnit(TBaseUnit base_unit) => throw new NotImplementedException(); // TODO

    public static explicit operator Quantity<TQuantity, TBaseUnit, TScalar>(TScalar value) => new(value);

    public static explicit operator TScalar(Quantity<TQuantity, TBaseUnit, TScalar> quantity) => quantity.Value.Value;

    public static implicit operator Quantity<TQuantity, TBaseUnit, TScalar>(string s) => Parse(s, null);


    public abstract record Unit<TUnit>(TScalar Value)
        : AbstractUnit<TUnit, TBaseUnit, TScalar>(Value)
        where TUnit : Unit<TUnit>
                    , IUnit<TUnit, TBaseUnit, TScalar>
                    , IUnit
    {
        public static implicit operator TQuantity(Unit<TUnit> unit) => new Quantity<TQuantity, TBaseUnit, TScalar>(unit.ToBaseUnit());

        public static implicit operator Unit<TUnit>(Quantity<TQuantity, TBaseUnit, TScalar> quantity) => TUnit.FromBaseUnit(quantity.Value);

        public static implicit operator Unit<TUnit>(string s) => Parse(s, null);
    }

    public abstract record AffineUnit<TUnit>(TScalar Value)
        : Unit<TUnit>(Value)
        where TUnit : AffineUnit<TUnit>
                    , IUnit<TUnit, TBaseUnit, TScalar>
                    , IAffineUnit<TScalar>
                    , IUnit
    {
        public override TBaseUnit ToBaseUnit()
        {
            if (this is TBaseUnit base_unit)
                return base_unit;
            else
            {
                TScalar value = Value;

                value -= TUnit.PostScalingOffset;
                value /= TUnit.ScalingFactor;
                value -= TUnit.PreScalingOffset;

                return BaseUnit<TQuantity, TBaseUnit, TScalar>.FromScalar(value);
            }
        }

        public static TUnit FromBaseUnit(TBaseUnit base_unit)
        {
            if (base_unit is TUnit unit)
                return unit;
            else
            {
                TScalar value = base_unit.Value;

                value += TUnit.PreScalingOffset;
                value *= TUnit.ScalingFactor;
                value += TUnit.PostScalingOffset;

                return (TUnit)value;
            }
        }

        public static implicit operator AffineUnit<TUnit>(string s) => Parse(s, null);
    }

    public abstract record ArbitraryUnit<TUnit>(TScalar Value)
        : Unit<TUnit>(Value)
        where TUnit : ArbitraryUnit<TUnit>
                    , IUnit<TUnit, TBaseUnit, TScalar>
                    , IArbitraryUnit<TScalar>
                    , IUnit
    {
        public abstract TScalar ToBaseUnit(TScalar value);

        public override TBaseUnit ToBaseUnit()
        {
            if (this is TBaseUnit base_unit)
                return base_unit;
            else
                return BaseUnit<TQuantity, TBaseUnit, TScalar>.FromScalar(ToBaseUnit(Value));
        }

        public static TUnit FromBaseUnit(TBaseUnit base_unit)
        {
            if (base_unit is TUnit unit)
                return unit;
            else
                return FromScalar(TUnit.FromBaseUnit(base_unit.Value));
        }

        public static implicit operator ArbitraryUnit<TUnit>(string s) => Parse(s, null);
    }
}

public abstract record BaseUnit<TQuantity, TBaseUnit, TScalar>(TScalar Value)
    : Quantity<TQuantity, TBaseUnit, TScalar>.AffineUnit<TBaseUnit>(Value)
    , IAffineUnit<TScalar>
    , IUnit<TBaseUnit, TBaseUnit, TScalar>
    where TQuantity : Quantity<TQuantity, TBaseUnit, TScalar>
                    , IQuantity<TQuantity>
    where TBaseUnit : BaseUnit<TQuantity, TBaseUnit, TScalar>
                    , IBaseUnit<TBaseUnit, TScalar>
                    , IUnit<TBaseUnit, TBaseUnit, TScalar>
                    , IUnit
                    , IAffineUnit<TScalar>
    where TScalar : INumber<TScalar>
{
    public static TScalar ScalingFactor { get; } = TScalar.One;
    public static TScalar PreScalingOffset { get; } = TScalar.Zero;
    public static TScalar PostScalingOffset { get; } = TScalar.Zero;

    public static implicit operator BaseUnit<TQuantity, TBaseUnit, TScalar>(string s) => Parse(s, null);
}
