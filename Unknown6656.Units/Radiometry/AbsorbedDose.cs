#if !USE_DIACRITICS
global using RöntgenEquivalentPhysical = Unknown6656.Units.Radioactivity.RoentgenEquivalentPhysical;
#endif

namespace Unknown6656.Units.Radiometry;


[KnownBaseUnit<AbsorbedDose, Gray, Scalar>]
public partial record Gray(Scalar Value)
    : BaseUnit<AbsorbedDose, Gray, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "Gy";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<AbsorbedDose, ErgPerGram, Gray, Scalar>]
public partial record ErgPerGram(Scalar Value)
    : AbsorbedDose.AffineUnit<ErgPerGram>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "erg/g";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e4;
}

[KnownUnit<AbsorbedDose, Rad, Gray, Scalar>]
public partial record Rad(Scalar Value)
    : AbsorbedDose.AffineUnit<Rad>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "rad";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e2;
}

[KnownUnit<AbsorbedDose, RöntgenEquivalentPhysical, Gray, Scalar>]
#if USE_DIACRITICS
public partial record RöntgenEquivalentPhysical(Scalar Value)
#else
public partial record RoentgenEquivalentPhysical(Scalar Value)
#endif
    : AbsorbedDose.AffineUnit<RöntgenEquivalentPhysical>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "rep";
    static string[] IUnit.AlternativeUnitSymbols { get; } = [
        "röntgen equivalent physical", "röntgen eq physical", "röntgen equivalent ph", "röntgen eq ph", "röntgen equivalent phy",
        "röntgen eq phy", "röntgen equivalent phys", "röntgen eq phys"
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)107.526881720430107;
}
