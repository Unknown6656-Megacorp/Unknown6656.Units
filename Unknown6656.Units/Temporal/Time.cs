using System.Diagnostics;

namespace Unknown6656.Units.Temporal;

#pragma warning disable IDE0004 // Remove Unnecessary Cast


[KnownBaseUnit<Time, Second, Scalar>]
public partial record Second
{
    public static string UnitSymbol { get; } = "s";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["sec", "\""];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixesOnlyOnSubmultiples;
}

[KnownUnit<Time, OSTicks, Second, Scalar>(KnownUnitType.Linear)]
public partial record OSTicks
{
    public static string UnitSymbol { get; } = "ticks";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)Stopwatch.Frequency;
}

[KnownUnit<Time, Minute, Second, Scalar>(KnownUnitType.Linear)]
public partial record Minute
{
    public static string UnitSymbol { get; } = "min";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["'"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1 / (Scalar)60;
}

[KnownUnit<Time, Hour, Second, Scalar>(KnownUnitType.Linear)]
public partial record Hour
{
    public static string UnitSymbol { get; } = "h";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["hr", "hou"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)2.7777777777777777777777777777778e-4;
}

#if !D128
[KnownUnit<Time, PlanckTime, Second, Scalar>(KnownUnitType.Linear)]
public partial record PlanckTime
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "tp";
#else
    public static string UnitSymbol { get; } = "tₚ";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.8550948324478e43;
}
#endif

[KnownUnit<Time, StandardDay, Second, Scalar>(KnownUnitType.Linear)]
public partial record StandardDay
{
    public static string UnitSymbol { get; } = "d";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.15740740740740740740740740740740740740740740740740740740741e-5;
}

[KnownUnit<Time, StandardWeek, Second, Scalar>(KnownUnitType.Linear)]
public partial record StandardWeek
{
    public static string UnitSymbol { get; } = "w";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.6534391534391534391534391534391534391534391534391534391534e-6;
}

[KnownUnit<Time, Fortnight, Second, Scalar>(KnownUnitType.Linear)]
public partial record Fortnight
{
    public static string UnitSymbol { get; } = "ftn";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)8.267195767195767195767195767195767195767195767195767195767e-7;
}

[KnownUnit<Time, SolarDay, Second, Scalar>(KnownUnitType.Linear)]
public partial record SolarDay
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "d solar";
#else
    public static string UnitSymbol { get; } = "d☉";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.15740738061556989315810432504388136472496840914424978832755e-5;
}

[KnownUnit<Time, SolarYear, Second, Scalar>(KnownUnitType.Linear)]
public partial record SolarYear
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "y solar";
#else
    public static string UnitSymbol { get; } = "y☉";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3.1688764886054404467120992835579306257576513095006304230054e-8;
}

[KnownUnit<Time, GalacticYear, Second, Scalar>(KnownUnitType.Linear)]
public partial record GalacticYear
{
    public static string UnitSymbol { get; } = "GY";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["galactic y", "galactic yr", "cosmic yr", "cosmic y", "cosmic year"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = SolarYear.ScalingFactor / 2.25e-8;
}

[KnownUnit<Time, SiderialDay, Second, Scalar>(KnownUnitType.Linear)]
public partial record SiderialDay
{
    public static string UnitSymbol { get; } = "d";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.16057629112081378681072358566080138489247666864467552550024e-5;
}

[KnownUnit<Time, SiderialMercuryDay, Second, Scalar>(KnownUnitType.Linear)]
public partial record SiderialMercuryDay
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "d mercury";
#else
    public static string UnitSymbol { get; } = "d☿";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)6.5783587784250882815748064646847387339027560691938089749864e-8;
}

[KnownUnit<Time, SiderialVenusDay, Second, Scalar>(KnownUnitType.Linear)]
public partial record SiderialVenusDay
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "d venus";
#else
    public static string UnitSymbol { get; } = "d♀";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)9.9135538107700848600206201919264017765088428899992069156951e-8;
}

[KnownUnit<Time, SiderialMoonDay, Second, Scalar>(KnownUnitType.Linear)]
public partial record SiderialMoonDay
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "d moon";
#else
    public static string UnitSymbol { get; } = "d☾";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3.9195396892588934355549284292052741326058667670068827116943e-7;
}

[KnownUnit<Time, SiderialMarsDay, Second, Scalar>(KnownUnitType.Linear)]
public partial record SiderialMarsDay
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "d mars";
#else
    public static string UnitSymbol { get; } = "d♂";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.1246063877642825011246063877642825011246063877642825011246e-5;
}

[KnownUnit<Time, MarsDay, Second, Scalar>(KnownUnitType.Linear)]
public partial record MarsDay
{
    public static string UnitSymbol { get; } = "sol";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.12644325542100816671360180230920867361306674176288369473387e-5;
}

[KnownUnit<Time, SiderialCeresDay, Second, Scalar>(KnownUnitType.Linear)]
public partial record SiderialCeresDay
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "d ceres";
#else
    public static string UnitSymbol { get; } = "d⚳";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3.0693677102516881522406384284837323511356660527931246163290e-5;
}

[KnownUnit<Time, SiderialJupiterDay, Second, Scalar>(KnownUnitType.Linear)]
public partial record SiderialJupiterDay
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "d jupiter";
#else
    public static string UnitSymbol { get; } = "d♃";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)2.8058361391694725028058361391694725028058361391694725028058e-5;
}

[KnownUnit<Time, SiderialSaturnDay, Second, Scalar>(KnownUnitType.Linear)]
public partial record SiderialSaturnDay
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "d saturn";
#else
    public static string UnitSymbol { get; } = "d♄";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)2.5960539979231568016614745586708203530633437175493250259605e-5;
}

[KnownUnit<Time, SiderialUranusDay, Second, Scalar>(KnownUnitType.Linear)]
public partial record SiderialUranusDay
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "d uranus"; // hehe
#else
    public static string UnitSymbol { get; } = "d♅";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.6149870801033591731266149870801033591731266149870801033591e-5;
}

[KnownUnit<Time, SiderialNeptuneDay, Second, Scalar>(KnownUnitType.Linear)]
public partial record SiderialNeptuneDay
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "d neptune";
#else
    public static string UnitSymbol { get; } = "d♆";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.7253278122843340234644582470669427191166321601104209799861e-5;
}

[KnownUnit<Time, SiderialPlutoDay, Second, Scalar>(KnownUnitType.Linear)]
public partial record SiderialPlutoDay
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "d pluto";
#else
    public static string UnitSymbol { get; } = "d♇";
#endif
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.8119881133579763716750018119881133579763716750018119881133e-6;
}

[KnownUnit<Time, Shake, Second, Scalar>(KnownUnitType.Linear)]
public partial record Shake
{
    public static string UnitSymbol { get; } = "shake";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e8;
}

[KnownUnit<Time, MicroFortnight, Second, Scalar>(KnownUnitType.Linear)]
public partial record MicroFortnight
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "uftn";
#else
    public static string UnitSymbol { get; } = "μftn";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["μfortnight"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_μ;
    public static Scalar ScalingFactor { get; } = Fortnight.ScalingFactor * 1e6;
}

[KnownUnit<Time, Kermit, Second, Scalar>(KnownUnitType.Linear)]
public partial record Kermit
{
    public static string UnitSymbol { get; } = "kermit";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kermetric time", "kermetric"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = StandardDay.ScalingFactor * 100;
}
