using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Kinematics;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Energy;

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

[MultiplicativeRelationship<LuminousIntensity, SolidAngle, LuminousFlux, Candela, Steradian, Lumen, Scalar>]
public partial record LuminousFlux(Lumen value)
    : Quantity<LuminousFlux, Lumen, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "Phi_v";
#else
    public static string QuantitySymbol { get; } = "Φᵥ";
#endif
}

[MultiplicativeRelationship<Luminance, SolidAngle, Illuminance, CandelaPerSquareMeter, Steradian, Lux, Scalar>]
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

    public static Lux MoonlessOvercastNightSky { get; } = new(.0001);
    public static Lux MoonlessClearNightSky { get; } = new(.002);
    public static Lux FullMoonClearNight { get; } = new(.25);
    public static Lux CivilTwilightClearSky { get; } = new(3.4);
    public static Lux DarkOvercastDay { get; } = new(100);
    public static Lux OvercastDay { get; } = new(1000);
    public static Lux SunriseOrSunsetOnClearDay { get; } = new(400);
    public static Lux DirectSunlightOnClearDay { get; } = new(100_000);
    public static Lux FullDaylight { get; } = new(20_000);
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
[MultiplicativeRelationship<LuminousEnergyDensity, VolumetricFlowRate, LuminousFlux, LumenSecondPerCubicMeter, CubicMeterPerSecond, Lumen, Scalar>]
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

    public static LumenPerWatt TungstenLight2800K { get; } = new(15);
    public static LumenPerWatt IdealBlackBody4000K { get; } = new(30);
    public static LumenPerWatt IdealBlackBody7000K { get; } = new(95);
    public static LumenPerWatt IdealWhiteSource5800K { get; } = new(251);
    public static LumenPerWatt Ideal555nmMonochromaticSource { get; } = new(683.002);

    // TODO : add more https://en.wikipedia.org/wiki/Luminous_efficacy
}


// https://en.wikipedia.org/wiki/Luminous_intensity
// https://en.wikipedia.org/wiki/Exposure_(photography)#Photometric_and_radiometric_exposure
// TODO:
//  - luma
//  - radiance
//  - irradiance
//  - radiant flux
//  - radiant energy density
//  - spectral flux
//  - radiant intensity
//  - spectral intensity
//  - spectral radiance
//  - irradiance flux density
//  - spectral irradiance
//  - radiosity
//  - spectral radiosity
//  - radiant exitance
//  - spectral exitance
//  - radiant exposure
//  - spectral exposure