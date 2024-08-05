#if !USE_DIACRITICS
#endif

namespace Unknown6656.Units.Euclidean;


[KnownBaseUnit<Wavelength, Nanometer, Scalar>]
public partial record Nanometer
{
    public static string UnitSymbol { get; } = "nm";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_n;
}
