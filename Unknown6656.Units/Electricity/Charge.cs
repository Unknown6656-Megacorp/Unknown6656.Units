#if !USE_DIACRITICS
global using AmpèreHour = Unknown6656.Units.Electricity.AmpereHour;
#endif

namespace Unknown6656.Units.Electricity;


[KnownBaseUnit<Charge, Coulomb, Scalar>]
public partial record Coulomb(Scalar Value)
    : BaseUnit<Charge, Coulomb, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "C";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Charge, Franklin, Coulomb, Scalar>]
[KnownAlias<Charge, Franklin, Coulomb, Scalar>("Statcoulomb", "StatC", "esu")]
public partial record Franklin(Scalar Value)
    : Charge.AffineUnit<Franklin>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Fr";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)2.99792457999999998916394890769699222666709715058982848552029e9;
}

[KnownUnit<Charge, AmpèreHour, Coulomb, Scalar>]
#if USE_DIACRITICS
public partial record AmpèreHour(Scalar Value)
#else
public partial record AmpereHour(Scalar Value)
#endif
    : Charge.AffineUnit<AmpèreHour>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "Ah";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ampere h", "ampere hr", "Ahr", "a hour"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)2.777777777777777777777777777777777777777777777777777777777777e-4;
}

[KnownUnit<Charge, ElementaryCharge, Coulomb, Scalar>]
public partial record ElementaryCharge(Scalar Value)
    : Charge.AffineUnit<ElementaryCharge>(Value)
    , ILinearUnit<Scalar>
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "e";
#else
    public static string UnitSymbol { get; } = "e⁻";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["e", "e charge"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)6.24150907446076260777624098093044589988696589617097112152741e18;
}
