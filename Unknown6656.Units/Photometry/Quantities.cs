using Unknown6656.Units.Energy;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Photometry;


public partial record LuminousIntensity(Candela value)
    : Quantity<LuminousIntensity, Candela, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "Iv";
#else
    public static string QuantitySymbol { get; } = "Iᵥ";
#endif
}

[MultiplicativeRelationship<LuminousFlux, Time, LuminousEnergy, Lumen, Second, LumenSecond, Scalar>]
public partial record LuminousEnergy(LumenSecond value)
    : Quantity<LuminousEnergy, LumenSecond, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "Qv";
#else
    public static string QuantitySymbol { get; } = "Qᵥ";
#endif
}

public partial record LuminousFlux(Lumen value)
    : Quantity<LuminousFlux, Lumen, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "Phi_v";
#else
    public static string QuantitySymbol { get; } = "Φᵥ";
#endif
}

[MultiplicativeRelationship<Luminance, Area, LuminousIntensity, CandelaPerSquareMeter, SquareMeter, Candela, Scalar>]
public partial record Luminance(CandelaPerSquareMeter value)
    : Quantity<Luminance, CandelaPerSquareMeter, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "Lv";
#else
    public static string QuantitySymbol { get; } = "Lᵥ";
#endif

    public static CandelaPerSquareMeter Sun { get; } = new(1.6e9);
    public static FootLambert OpenGateScreenLuminance { get; } = new(16);
}

[MultiplicativeRelationship<Illuminance, Area, LuminousFlux, Lux, SquareMeter, Lumen, Scalar>]
public partial record Illuminance(Lux value)
    : Quantity<Illuminance, Lux, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "Ev";
#else
    public static string QuantitySymbol { get; } = "Eᵥ";
#endif
}

[IdentityRelationship<Illuminance, LuminousExitance, Lux, LumenPerSquareMeter, Scalar>]
[MultiplicativeRelationship<LuminousExitance, Area, LuminousFlux, LumenPerSquareMeter, SquareMeter, Lumen, Scalar>]
public partial record LuminousExitance(LumenPerSquareMeter value)
    : Quantity<LuminousExitance, LumenPerSquareMeter, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "Mv";
#else
    public static string QuantitySymbol { get; } = "Mᵥ";
#endif
}

[MultiplicativeRelationship<Illuminance, Time, LuminousExposure, Lux, Second, LuxSecond, Scalar>]
public partial record LuminousExposure(LuxSecond value)
    : Quantity<LuminousExposure, LuxSecond, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "Hv";
#else
    public static string QuantitySymbol { get; } = "Hᵥ";
#endif
}

[MultiplicativeRelationship<LuminousEnergyDensity, Volume, LuminousEnergy, LumenSecondPerCubicMeter, CubicMeter, LumenSecond, Scalar>]
public partial record LuminousEnergyDensity(LumenSecondPerCubicMeter value)
    : Quantity<LuminousEnergyDensity, LumenSecondPerCubicMeter, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "w";
#else
    public static string QuantitySymbol { get; } = "ωᵥ";
#endif
}

[MultiplicativeRelationship<LuminousEfficacy, Power, LuminousFlux, LumenPerWatt, Watt, Lumen, Scalar>]
public partial record LuminousEfficacy(LumenPerWatt value)
    : Quantity<LuminousEfficacy, LumenPerWatt, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "K";
}


// (https://en.wikipedia.org/wiki/Luminous_intensity)
// TODO:
//  - radiance
//  - luma