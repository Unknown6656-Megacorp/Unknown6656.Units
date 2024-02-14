using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Photometry;


[KnownBaseUnit<Luminance, CandelaPerSquareMeter, Scalar>]
public partial record CandelaPerSquareMeter(Scalar Value)
    : BaseUnit<Luminance, CandelaPerSquareMeter, Scalar>(Value)
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "cd/m^2";
#else
    public static string UnitSymbol { get; } = "cd/m²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["cd/meter^2", "candela/m^2", "cd*m^-2", "candela*m^-2", "cd*meter^-2", "candela*meter^-2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Luminance, Nit, CandelaPerSquareMeter, Scalar>]
public partial record Nit(Scalar Value)
    : Luminance.AffineUnit<Nit>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "nt";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1;
}

[KnownUnit<Luminance, Stilb, CandelaPerSquareMeter, Scalar>]
public partial record Stilb(Scalar Value)
    : Luminance.AffineUnit<Stilb>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "sb";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e4;
}

[KnownUnit<Luminance, Apostlib, CandelaPerSquareMeter, Scalar>]
public partial record Apostlib(Scalar Value)
    : Luminance.AffineUnit<Apostlib>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "asb";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["blondel"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.3183098861837906715377675267450287240689192914809128974953346881;
}

[KnownUnit<Luminance, Lambert, CandelaPerSquareMeter, Scalar>]
public partial record Lambert(Scalar Value)
    : Luminance.AffineUnit<Lambert>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "L";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["La", "Lb"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3183.098861837907;
}

[KnownUnit<Luminance, FootLambert, CandelaPerSquareMeter, Scalar>]
public partial record FootLambert(Scalar Value)
    : Luminance.AffineUnit<FootLambert>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "fL";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ftL", "ft-L"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.3183098861837906715377675267450287240689192914809128974953346881 * SquareFoot.ScalingFactor;
}

[KnownUnit<Luminance, Skot, CandelaPerSquareMeter, Scalar>]
public partial record Skot(Scalar Value)
    : Luminance.AffineUnit<Skot>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "sk";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-3 * Apostlib.ScalingFactor;
}

[KnownUnit<Luminance, Bril, CandelaPerSquareMeter, Scalar>]
public partial record Bril(Scalar Value)
    : Luminance.AffineUnit<Bril>(Value)
    , ILinearUnit<Scalar>
{
    public static string UnitSymbol { get; } = "br";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-7 * Apostlib.ScalingFactor;
}
