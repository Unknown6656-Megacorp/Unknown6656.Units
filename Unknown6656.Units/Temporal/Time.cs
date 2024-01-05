using System.Diagnostics;

namespace Unknown6656.Units.Temporal;

#pragma warning disable IDE0004 // Remove Unnecessary Cast


[KnownBaseUnit<Time, Second, Scalar>]
public partial record Second(Scalar Value)
    : BaseUnit<Time, Second, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "s";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixesOnlyOnSubmultiples;
}

[KnownUnit<Time, OSTicks, Second, Scalar>]
public partial record OSTicks(Scalar Value)
    : Time.AffineUnit<OSTicks>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "ticks";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)Stopwatch.Frequency;
}

[KnownUnit<Time, Minute, Second, Scalar>]
public partial record Minute(Scalar Value)
    : Time.AffineUnit<Minute>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "min";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1 / (Scalar)60;
}

[KnownUnit<Time, Hour, Second, Scalar>]
public partial record Hour(Scalar Value)
    : Time.AffineUnit<Hour>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "h";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)2.7777777777777777777777777777778e-4;
}

#if !D128
[KnownUnit<Time, PlanckTime, Second, Scalar>]
public partial record PlanckTime(Scalar Value)
    : Time.AffineUnit<PlanckTime>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "tₚ";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.8550948324478e43;
}
#endif

[KnownUnit<Time, StandardDay, Second, Scalar>]
public partial record StandardDay(Scalar Value)
    : Time.AffineUnit<StandardDay>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "d";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.15740740740740740740740740740740740740740740740740740740741e-5;
}

[KnownUnit<Time, StandardWeek, Second, Scalar>]
public partial record StandardWeek(Scalar Value)
    : Time.AffineUnit<StandardWeek>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "d";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.6534391534391534391534391534391534391534391534391534391534e-6;
}

[KnownUnit<Time, Fortnight, Second, Scalar>]
public partial record Fortnight(Scalar Value)
    : Time.AffineUnit<Fortnight>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "d";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)8.267195767195767195767195767195767195767195767195767195767e-7;
}

[KnownUnit<Time, SolarDay, Second, Scalar>]
public partial record SolarDay(Scalar Value)
    : Time.AffineUnit<SolarDay>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "d";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.15740738061556989315810432504388136472496840914424978832755e-5;
}

[KnownUnit<Time, SolarYear, Second, Scalar>]
public partial record SolarYear(Scalar Value)
    : Time.AffineUnit<SolarYear>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "y";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3.1688764886054404467120992835579306257576513095006304230054e-8;
}

[KnownUnit<Time, SiderialDay, Second, Scalar>]
public partial record SiderialDay(Scalar Value)
    : Time.AffineUnit<SiderialDay>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "d";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.16057629112081378681072358566080138489247666864467552550024e-5;
}

[KnownUnit<Time, SiderialMercuryDay, Second, Scalar>]
public partial record SiderialMercuryDay(Scalar Value)
    : Time.AffineUnit<SiderialMercuryDay>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "d☿";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)6.5783587784250882815748064646847387339027560691938089749864e-8;
}

[KnownUnit<Time, SiderialVenusDay, Second, Scalar>]
public partial record SiderialVenusDay(Scalar Value)
    : Time.AffineUnit<SiderialVenusDay>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "d♀";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)9.9135538107700848600206201919264017765088428899992069156951e-8;
}

[KnownUnit<Time, SiderialMoonDay, Second, Scalar>]
public partial record SiderialMoonDay(Scalar Value)
    : Time.AffineUnit<SiderialMoonDay>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "d☾";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3.9195396892588934355549284292052741326058667670068827116943e-7;
}

[KnownUnit<Time, SiderialMarsDay, Second, Scalar>]
public partial record SiderialMarsDay(Scalar Value)
    : Time.AffineUnit<SiderialMarsDay>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "d♂";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.1246063877642825011246063877642825011246063877642825011246e-5;
}

[KnownUnit<Time, SiderialCeresDay, Second, Scalar>]
public partial record SiderialCeresDay(Scalar Value)
    : Time.AffineUnit<SiderialCeresDay>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "d⚳";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3.0693677102516881522406384284837323511356660527931246163290e-5;
}

[KnownUnit<Time, SiderialJupiterDay, Second, Scalar>]
public partial record SiderialJupiterDay(Scalar Value)
    : Time.AffineUnit<SiderialJupiterDay>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "d♃";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)2.8058361391694725028058361391694725028058361391694725028058e-5;
}

[KnownUnit<Time, SiderialSaturnDay, Second, Scalar>]
public partial record SiderialSaturnDay(Scalar Value)
    : Time.AffineUnit<SiderialSaturnDay>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "d♄";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)2.5960539979231568016614745586708203530633437175493250259605e-5;
}

[KnownUnit<Time, SiderialUranusDay, Second, Scalar>]
public partial record SiderialUranusDay(Scalar Value)
    : Time.AffineUnit<SiderialUranusDay>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "d♅";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.6149870801033591731266149870801033591731266149870801033591e-5;
}

[KnownUnit<Time, SiderialNeptuneDay, Second, Scalar>]
public partial record SiderialNeptuneDay(Scalar Value)
    : Time.AffineUnit<SiderialNeptuneDay>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "d♆";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.7253278122843340234644582470669427191166321601104209799861e-5;
}

[KnownUnit<Time, SiderialPlutoDay, Second, Scalar>]
public partial record SiderialPlutoDay(Scalar Value)
    : Time.AffineUnit<SiderialPlutoDay>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "d♇";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.8119881133579763716750018119881133579763716750018119881133e-6;
}


// - Time
//      - datetime
//      - from seconds, minutes, hours, days, weeks, months, years, ...
//      - from ticks, ...
