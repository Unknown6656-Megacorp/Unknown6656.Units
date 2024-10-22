using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;
using Unknown6656.Units.Energy;

namespace Unknown6656.Units.Kinematics;


[MultiplicativeRelationship<Speed, Time, Length, MeterPerSecond, Second, Meter, Scalar>]
[MultiplicativeRelationship<Length, Frequency, Speed, Meter, Hertz, MeterPerSecond, Scalar>]
public partial record Speed(MeterPerSecond value)
    : Quantity<Speed, MeterPerSecond, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "v";
    public static Speed C0 { get; } = new SpeedOfLightVacuum(1);
}

[MultiplicativeRelationship<Acceleration, Time, Speed, MeterPerSecondSquared, Second, MeterPerSecond, Scalar>]
[MultiplicativeRelationship<Speed, Frequency, Acceleration, MeterPerSecond, Hertz, MeterPerSecondSquared, Scalar>]
public partial record Acceleration(MeterPerSecondSquared value)
    : Quantity<Acceleration, MeterPerSecondSquared, Scalar>(value)
{
    internal const double G0 = 9.80665;

    public static string QuantitySymbol { get; } = "a";
    public static G StandardGravity { get; } = new(G0);
}

[MultiplicativeRelationship<Jerk, Time, Acceleration, MeterPerSecondCubed, Second, MeterPerSecondSquared, Scalar>]
[MultiplicativeRelationship<Acceleration, Frequency, Jerk, MeterPerSecondSquared, Hertz, MeterPerSecondCubed, Scalar>]
public partial record Jerk(MeterPerSecondCubed value)
    : Quantity<Jerk, MeterPerSecondCubed, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "j";
}

[MultiplicativeRelationship<Length, Time, Absement, Meter, Second, MeterSecond, Scalar>]
[MultiplicativeRelationship<Absement, Frequency, Length, MeterSecond, Hertz, Meter, Scalar>]
[MultiplicativeRelationship<Absement, Speed, Area, MeterSecond, MeterPerSecond, SquareMeter, Scalar>]
[MultiplicativeRelationship<Absement, Acceleration, KinematicViscosity, MeterSecond, MeterPerSecondSquared, SquareMeterPerSecond, Scalar>]
public partial record Absement(MeterSecond value)
    : Quantity<Absement, MeterSecond, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "A";
}

[MultiplicativeRelationship<VolumetricFlowRate, Time, Volume, CubicMeterPerSecond, Second, CubicMeter, Scalar>]
[MultiplicativeRelationship<Volume, Frequency, VolumetricFlowRate, CubicMeter, Hertz, CubicMeterPerSecond, Scalar>]
[MultiplicativeRelationship<Area, Speed, VolumetricFlowRate, SquareMeter, MeterPerSecond, CubicMeterPerSecond, Scalar>]
public partial record VolumetricFlowRate(CubicMeterPerSecond value)
    : Quantity<VolumetricFlowRate, CubicMeterPerSecond, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "Q";
}

// TODO : angular momentum
// TODO : angular velocity

//public partial record MomentOfInertia(KilogramSquareMeter value)
//      : Quantity<MomentOfInerta, KilogramSquareMeter, Scalar>(value)
// {
//     public static string QuantitySymbol { get; } = ;
// }

// TODO : mass flux https://en.wikipedia.org/wiki/Mass_flux
// kg / m^2 / s


// Pa*s = J*s / m^3     [todo: verify]
[MultiplicativeRelationship<Pressure, Time, DynamicViscosity, Pascal, Second, PascalSecond, Scalar>]
[MultiplicativeRelationship<VolumetricFlowRate, DynamicViscosity, Torque, CubicMeterPerSecond, PascalSecond, NewtonMeter, Scalar>]
[MultiplicativeRelationship<MassFlowRate, Length, DynamicViscosity, KilogramPerSecond, Meter, PascalSecond, Scalar>]
public partial record DynamicViscosity(PascalSecond value)
    : Quantity<DynamicViscosity, PascalSecond, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "u";
#else
    public static string QuantitySymbol { get; } = "μ";
#endif
}

[MultiplicativeRelationship<KinematicViscosity, Time, Area, SquareMeterPerSecond, Second, SquareMeter, Scalar>]
[MultiplicativeRelationship<KinematicViscosity, Mass, Action, SquareMeterPerSecond, Kilogram, JouleSecond, Scalar>] // TODO : verify this.
[MultiplicativeRelationship<Speed, Length, KinematicViscosity, MeterPerSecond, Meter, SquareMeterPerSecond, Scalar>]
[MultiplicativeRelationship<SpecificEnergy, Time, KinematicViscosity, JoulePerKilogram, Second, SquareMeterPerSecond, Scalar>] // TODO : verify this.
[MultiplicativeRelationship<KinematicViscosity, MassFlowRate, Torque, SquareMeterPerSecond, KilogramPerSecond, NewtonMeter, Scalar>]
[MultiplicativeRelationship<KinematicViscosity, Length, VolumetricFlowRate, SquareMeterPerSecond, Meter, CubicMeterPerSecond, Scalar>]
public partial record KinematicViscosity(SquareMeterPerSecond value)
    : Quantity<KinematicViscosity, SquareMeterPerSecond, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "v";
#else
    public static string QuantitySymbol { get; } = "ν";
#endif
}

[MultiplicativeRelationship<MassFlowRate, Time, Mass, KilogramPerSecond, Second, Kilogram, Scalar>]
public partial record MassFlowRate(KilogramPerSecond value)
    : Quantity<MassFlowRate, KilogramPerSecond, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "m/t";
#else
    public static string QuantitySymbol { get; } = "ṁ";
#endif
}

[MultiplicativeRelationship<Force, Time, Impulse, Newton, Second, NewtonSecond, Scalar>]
public partial record Impulse(NewtonSecond value)
    : Quantity<Impulse, NewtonSecond, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "J";
}

[IdentityRelationship<SpecificImpulse, Time, NewtonSecondPerKilogram, Second, Scalar>(Acceleration.G0)]
[MultiplicativeRelationship<SpecificImpulse, Mass, Impulse, NewtonSecondPerKilogram, Kilogram, NewtonSecond, Scalar>]
[MultiplicativeRelationship<SpecificImpulse, Acceleration, Speed, NewtonSecondPerKilogram, MeterPerSecondSquared, MeterPerSecond, Scalar>(1 / Acceleration.G0)]
public partial record SpecificImpulse(NewtonSecondPerKilogram value)
     : Quantity<SpecificImpulse, NewtonSecondPerKilogram, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "I_sp";

    public static SpecificImpulse AerojetRocketdyneRL10B2 { get; } = (NewtonSecondPerKilogram)465.5d.Second();
    public static SpecificImpulse AerojetRocketdyneRS25_Engine { get; } = (NewtonSecondPerKilogram)453d.Second();
    public static SpecificImpulse AviadvigatelPD14_Engine { get; } = (NewtonSecondPerKilogram)6840d.Second();
    public static SpecificImpulse AviadvigatelPS90A1_Engine { get; } = (NewtonSecondPerKilogram)6050d.Second();
    public static SpecificImpulse AvioP80_Engine { get; } = (NewtonSecondPerKilogram)280d.Second();
    public static SpecificImpulse AvioZefiro23_Engine { get; } = (NewtonSecondPerKilogram)287.5d.Second();
    public static SpecificImpulse AvioZefiro9A_Engine { get; } = (NewtonSecondPerKilogram)295.2d.Second();
    public static SpecificImpulse CFECFE73811_Engine { get; } = (NewtonSecondPerKilogram)5580d.Second();
    public static SpecificImpulse CFMCFM562A2_Engine { get; } = (NewtonSecondPerKilogram)5450d.Second();
    public static SpecificImpulse CFMCFM562B1_Engine { get; } = (NewtonSecondPerKilogram)5540d.Second();
    public static SpecificImpulse CFMCFM562C1_Engine { get; } = (NewtonSecondPerKilogram)5370d.Second();
    public static SpecificImpulse CFMCFM563C1_Engine { get; } = (NewtonSecondPerKilogram)5400d.Second();
    public static SpecificImpulse CFMCFM565A1_Engine { get; } = (NewtonSecondPerKilogram)6040d.Second();
    public static SpecificImpulse CFMCFM565B4_Engine { get; } = (NewtonSecondPerKilogram)6610d.Second();
    public static SpecificImpulse CFMCFM565C2_Engine { get; } = (NewtonSecondPerKilogram)6610d.Second();
    public static SpecificImpulse CFMCFM567B24_Engine { get; } = (NewtonSecondPerKilogram)5740d.Second();
    public static SpecificImpulse CFMLEAP1A_Engine { get; } = (NewtonSecondPerKilogram)7100d.Second();
    public static SpecificImpulse CFMLEAP1B_Engine { get; } = (NewtonSecondPerKilogram)6800d.Second();
    public static SpecificImpulse CFMLEAP1C_Engine { get; } = (NewtonSecondPerKilogram)7100d.Second();
    public static SpecificImpulse EAGP7270_Engine { get; } = (NewtonSecondPerKilogram)12000d.Second();
    public static SpecificImpulse EurojetEJ200_Engine { get; } = (NewtonSecondPerKilogram)4900d.Second();
    public static SpecificImpulse GECF3410A_Engine { get; } = (NewtonSecondPerKilogram)5540d.Second();
    public static SpecificImpulse GECF3410E_Engine { get; } = (NewtonSecondPerKilogram)5600d.Second();
    public static SpecificImpulse GECF343_Engine { get; } = (NewtonSecondPerKilogram)5220d.Second();
    public static SpecificImpulse GECF348C_Engine { get; } = (NewtonSecondPerKilogram)52000d.Second();
    public static SpecificImpulse GECF348E_Engine { get; } = (NewtonSecondPerKilogram)5290d.Second();
    public static SpecificImpulse GECF680C2_Engine { get; } = (NewtonSecondPerKilogram)11700d.Second();
    public static SpecificImpulse GECF680C2B1F_Engine { get; } = (NewtonSecondPerKilogram)5950d.Second();
    public static SpecificImpulse GECF680C2B2_Engine { get; } = (NewtonSecondPerKilogram)6250d.Second();
    public static SpecificImpulse GEF101GE102_Engine { get; } = (NewtonSecondPerKilogram)6410d.Second();
    public static SpecificImpulse GEF110GE129_Engine { get; } = (NewtonSecondPerKilogram)5600d.Second();
    public static SpecificImpulse GEF110GE132_Engine { get; } = (NewtonSecondPerKilogram)5600d.Second();
    public static SpecificImpulse GEF118GE100_Engine { get; } = (NewtonSecondPerKilogram)9600d.Second();
    public static SpecificImpulse GEF118GE101_Engine { get; } = (NewtonSecondPerKilogram)9600d.Second();
    public static SpecificImpulse GEF404GE402_Engine { get; } = (NewtonSecondPerKilogram)2070d.Second();
    public static SpecificImpulse GEF414GE400_Engine { get; } = (NewtonSecondPerKilogram)4970d.Second();
    public static SpecificImpulse GEGE9085B_Engine { get; } = (NewtonSecondPerKilogram)6920d.Second();
    public static SpecificImpulse GEGE9094B_Engine { get; } = (NewtonSecondPerKilogram)12100d.Second();
    public static SpecificImpulse GEGEnx1B70_Engine { get; } = (NewtonSecondPerKilogram)12650d.Second();
    public static SpecificImpulse GEGEnx1B76_Engine { get; } = (NewtonSecondPerKilogram)7030d.Second();
    public static SpecificImpulse GEJ79GE15_Engine { get; } = (NewtonSecondPerKilogram)4240d.Second();
    public static SpecificImpulse GEJ85GE21_Engine { get; } = (NewtonSecondPerKilogram)2900d.Second();
    public static SpecificImpulse GeneralElectricCF650C2_Engine { get; } = (NewtonSecondPerKilogram)5710d.Second();
    public static SpecificImpulse GETF34GE100_Engine { get; } = (NewtonSecondPerKilogram)9700d.Second();
    public static SpecificImpulse HoneywellALF502R5_Engine { get; } = (NewtonSecondPerKilogram)5000d.Second();
    public static SpecificImpulse HoneywellITECF124_Engine { get; } = (NewtonSecondPerKilogram)4440d.Second();
    public static SpecificImpulse HoneywellITECF125_Engine { get; } = (NewtonSecondPerKilogram)4500d.Second();
    public static SpecificImpulse HoneywellTFE73160_Engine { get; } = (NewtonSecondPerKilogram)5300d.Second();
    public static SpecificImpulse IAEV2525D5_Engine { get; } = (NewtonSecondPerKilogram)6270d.Second();
    public static SpecificImpulse IAEV2533A5_Engine { get; } = (NewtonSecondPerKilogram)6270d.Second();
    public static SpecificImpulse IHIF3_Engine { get; } = (NewtonSecondPerKilogram)5140d.Second();
    public static SpecificImpulse J58_Engine { get; } = (NewtonSecondPerKilogram)1895d.Second();
    public static SpecificImpulse KlimovRD33_Engine { get; } = (NewtonSecondPerKilogram)4680d.Second();
    public static SpecificImpulse KuznetsovNK32_Engine { get; } = (NewtonSecondPerKilogram)5000d.Second();
    public static SpecificImpulse KuznetsovNK33_Engine { get; } = (NewtonSecondPerKilogram)331d.Second();
    public static SpecificImpulse LE5B2_Engine { get; } = (NewtonSecondPerKilogram)447d.Second();
    public static SpecificImpulse LE7A_Engine { get; } = (NewtonSecondPerKilogram)438d.Second();
    public static SpecificImpulse LyulkaAL21F3_Engine { get; } = (NewtonSecondPerKilogram)4190d.Second();
    public static SpecificImpulse NPOEnergomashRD171M_Engine { get; } = (NewtonSecondPerKilogram)337d.Second();
    public static SpecificImpulse PowerJetSaM146_Engine { get; } = (NewtonSecondPerKilogram)5720d.Second();
    public static SpecificImpulse ProgressD18T_Engine { get; } = (NewtonSecondPerKilogram)6590d.Second();
    public static SpecificImpulse PW1127GGTF_Engine { get; } = (NewtonSecondPerKilogram)7780d.Second();
    public static SpecificImpulse PWF117PW100_Engine { get; } = (NewtonSecondPerKilogram)10600d.Second();
    public static SpecificImpulse PWF119PW100_Engine { get; } = (NewtonSecondPerKilogram)5900d.Second();
    public static SpecificImpulse PWJ52P408_Engine { get; } = (NewtonSecondPerKilogram)4560d.Second();
    public static SpecificImpulse PWJT8D9_Engine { get; } = (NewtonSecondPerKilogram)4500d.Second();
    public static SpecificImpulse PWPW1400GGTFMC21_Engine { get; } = (NewtonSecondPerKilogram)7100d.Second();
    public static SpecificImpulse PWPW2040_Engine { get; } = (NewtonSecondPerKilogram)6190d.Second();
    public static SpecificImpulse PWPW4098_Engine { get; } = (NewtonSecondPerKilogram)6200d.Second();
    public static SpecificImpulse PWTF33P3_Engine { get; } = (NewtonSecondPerKilogram)6920d.Second();
    public static SpecificImpulse RD843_Engine { get; } = (NewtonSecondPerKilogram)315.5d.Second();
    public static SpecificImpulse RRAE3007H_Engine { get; } = (NewtonSecondPerKilogram)9200d.Second();
    public static SpecificImpulse RRBR710_Engine { get; } = (NewtonSecondPerKilogram)5600d.Second();
    public static SpecificImpulse RRBR715_Engine { get; } = (NewtonSecondPerKilogram)5810d.Second();
    public static SpecificImpulse RRBR725_Engine { get; } = (NewtonSecondPerKilogram)5480d.Second();
    public static SpecificImpulse RRPegasus1161_Engine { get; } = (NewtonSecondPerKilogram)4740d.Second();
    public static SpecificImpulse RRSnecma_Engine { get; } = (NewtonSecondPerKilogram)3010d.Second();
    public static SpecificImpulse RRSpeyRB168_Engine { get; } = (NewtonSecondPerKilogram)5450d.Second();
    public static SpecificImpulse RRTayRB183_Engine { get; } = (NewtonSecondPerKilogram)5220d.Second();
    public static SpecificImpulse RRTrent1000_Engine { get; } = (NewtonSecondPerKilogram)7110d.Second();
    public static SpecificImpulse RRTrent1000C_Engine { get; } = (NewtonSecondPerKilogram)13200d.Second();
    public static SpecificImpulse RRTrent500_Engine { get; } = (NewtonSecondPerKilogram)6640d.Second();
    public static SpecificImpulse RRTrent700_Engine { get; } = (NewtonSecondPerKilogram)6410d.Second();
    public static SpecificImpulse RRTrent7000_Engine { get; } = (NewtonSecondPerKilogram)7110d.Second();
    public static SpecificImpulse RRTrent800_Engine { get; } = (NewtonSecondPerKilogram)6430d.Second();
    public static SpecificImpulse RRTrent900_Engine { get; } = (NewtonSecondPerKilogram)6900d.Second();
    public static SpecificImpulse RRTrent97084_Engine { get; } = (NewtonSecondPerKilogram)12200d.Second();
    public static SpecificImpulse RRTrentXWB97_Engine { get; } = (NewtonSecondPerKilogram)7530d.Second();
    public static SpecificImpulse RRTurbomecaAdour_Engine { get; } = (NewtonSecondPerKilogram)4400d.Second();
    public static SpecificImpulse SaturnAL31F_Engine { get; } = (NewtonSecondPerKilogram)5410d.Second();
    public static SpecificImpulse SaturnAL41F1S_Engine { get; } = (NewtonSecondPerKilogram)4560d.Second();
    public static SpecificImpulse SnecmaAtar08K50_Engine { get; } = (NewtonSecondPerKilogram)3710d.Second();
    public static SpecificImpulse SnecmaAtar09C_Engine { get; } = (NewtonSecondPerKilogram)3560d.Second();
    public static SpecificImpulse SnecmaAtar09K50_Engine { get; } = (NewtonSecondPerKilogram)3670d.Second();
    public static SpecificImpulse SnecmaHM7B_Engine { get; } = (NewtonSecondPerKilogram)444.6d.Second();
    public static SpecificImpulse SnecmaLarzac_Engine { get; } = (NewtonSecondPerKilogram)5030d.Second();
    public static SpecificImpulse SnecmaM53P2_Engine { get; } = (NewtonSecondPerKilogram)4240d.Second();
    public static SpecificImpulse SnecmaM882_Engine { get; } = (NewtonSecondPerKilogram)4600d.Second();
    public static SpecificImpulse SolovievD30F6_Engine { get; } = (NewtonSecondPerKilogram)5030d.Second();
    public static SpecificImpulse SolovievD30KP2_Engine { get; } = (NewtonSecondPerKilogram)5030d.Second();
    public static SpecificImpulse SolovievD30KU154_Engine { get; } = (NewtonSecondPerKilogram)5110d.Second();
    public static SpecificImpulse SpaceXMerlin1D_Engine { get; } = (NewtonSecondPerKilogram)310d.Second();
    public static SpecificImpulse TumanskyR25300_Engine { get; } = (NewtonSecondPerKilogram)3750d.Second();
    public static SpecificImpulse TurboUnionRB199_Engine { get; } = (NewtonSecondPerKilogram)5650d.Second();
    public static SpecificImpulse VolvoRM12_Engine { get; } = (NewtonSecondPerKilogram)4370d.Second();
}

[MultiplicativeRelationship<Mass, Acceleration, Force, Kilogram, MeterPerSecondSquared, Newton, Scalar>]
[MultiplicativeRelationship<MassFlowRate, Speed, Force, KilogramPerSecond, MeterPerSecond, Newton, Scalar>]
public partial record Force(Newton value)
    : Quantity<Force, Newton, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "F";
}

[MultiplicativeRelationship<LinearForceDensity, Length, Force, NewtonPerMeter, Meter, Newton, Scalar>]
public partial record LinearForceDensity(NewtonPerMeter value)
    : Quantity<LinearForceDensity, NewtonPerMeter, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "F/l";
}

[IdentityRelationship<Torque, KineticEnergy, NewtonMeter, Joule, Scalar>]
[MultiplicativeRelationship<Force, Length, Torque, Newton, Meter, NewtonMeter, Scalar>]
[MultiplicativeRelationship<KineticEnergy, Angle, Torque, Joule, Radian, NewtonMeter, Scalar>]
public partial record Torque(NewtonMeter value)
    : Quantity<Torque, NewtonMeter, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "M";
#else
    public static string QuantitySymbol { get; } = "τ";
#endif
}

[IdentityRelationship<LinearEnergyTransfer, Force, JoulePerMeter, Newton, Scalar>]
[MultiplicativeRelationship<LinearEnergyTransfer, Length, KineticEnergy, JoulePerMeter, Meter, Joule, Scalar>]
[MultiplicativeRelationship<Mass, Acceleration, LinearEnergyTransfer, Kilogram, MeterPerSecondSquared, JoulePerMeter, Scalar>]
public partial record LinearEnergyTransfer(JoulePerMeter value)
    : Quantity<LinearEnergyTransfer, JoulePerMeter, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "LET";
}

// TODO : implement all viscosity formulas from https://en.wikipedia.org/wiki/Viscosity
// TODO : surface tension https://en.wikipedia.org/wiki/Surface_tension
// TODO : drag force https://en.wikipedia.org/wiki/Drag_(physics)
// TODO : lift force https://en.wikipedia.org/wiki/Lift_(force)
// TODO : buoyancy https://en.wikipedia.org/wiki/Buoyancy
// TODO : friction https://en.wikipedia.org/wiki/Friction
