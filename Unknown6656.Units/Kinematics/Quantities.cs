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

[IdentityRelationship<Action, AngularMomentum, JouleSecond, KilogramSquareMeterPerSecond, Scalar>]
[MultiplicativeRelationship<MassFlowRate, Area, AngularMomentum, KilogramPerSecond, SquareMeter, KilogramSquareMeterPerSecond, Scalar>]
[MultiplicativeRelationship<AngularMomentum, Time, MomentOfInertia, KilogramSquareMeterPerSecond, Second, KilogramSquareMeter, Scalar>]
[MultiplicativeRelationship<Mass, KinematicViscosity, AngularMomentum, Kilogram, SquareMeterPerSecond, KilogramSquareMeterPerSecond, Scalar>]
public partial record AngularMomentum(KilogramSquareMeterPerSecond value)
    : Quantity<AngularMomentum, KilogramSquareMeterPerSecond, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "L";

    public static AngularMomentum PlanckConstant => (AngularMomentum)Action.PlanckConstant;
    public static AngularMomentum ReducedPlanckConstant => (AngularMomentum)Action.ReducedPlanckConstant;
}

[MultiplicativeRelationship<Mass, Area, MomentOfInertia, Kilogram, SquareMeter, KilogramSquareMeter, Scalar>]
public partial record MomentOfInertia(KilogramSquareMeter value)
      : Quantity<MomentOfInertia, KilogramSquareMeter, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "I";
}


// (N * s / kg) * (kg * m^2 / s) / m = N * m
// specificimpulse * AngularMomentum / length = torque

// TODO : angular velocity

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

[IdentityRelationship<SpecificImpulse, Speed, NewtonSecondPerKilogram, MeterPerSecond, Scalar>(Acceleration.G0)]
[MultiplicativeRelationship<SpecificImpulse, Mass, Impulse, NewtonSecondPerKilogram, Kilogram, NewtonSecond, Scalar>]
public partial record SpecificImpulse(NewtonSecondPerKilogram value)
     : Quantity<SpecificImpulse, NewtonSecondPerKilogram, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "I_sp";

    public static SpecificImpulse Engine_AerojetRocketdyneRL10B2 { get; } = (NewtonSecondPerKilogram)4565d.MeterPerSecond();
    public static SpecificImpulse Engine_AerojetRocketdyneRS25 { get; } = (NewtonSecondPerKilogram)4440d.MeterPerSecond();
    public static SpecificImpulse Engine_AviadvigatelPD14 { get; } = (NewtonSecondPerKilogram)67100d.MeterPerSecond();
    public static SpecificImpulse Engine_AviadvigatelPS90A1 { get; } = (NewtonSecondPerKilogram)59300d.MeterPerSecond();
    public static SpecificImpulse Engine_AvioP80 { get; } = (NewtonSecondPerKilogram)2700d.MeterPerSecond();
    public static SpecificImpulse Engine_AvioZefiro23 { get; } = (NewtonSecondPerKilogram)2819d.MeterPerSecond();
    public static SpecificImpulse Engine_AvioZefiro9A { get; } = (NewtonSecondPerKilogram)2895d.MeterPerSecond();
    public static SpecificImpulse Engine_CFECFE73811B { get; } = (NewtonSecondPerKilogram)54700d.MeterPerSecond();
    public static SpecificImpulse Engine_CFMCFM562A2 { get; } = (NewtonSecondPerKilogram)53500d.MeterPerSecond();
    public static SpecificImpulse Engine_CFMCFM562B1 { get; } = (NewtonSecondPerKilogram)54300d.MeterPerSecond();
    public static SpecificImpulse Engine_CFMCFM562C1 { get; } = (NewtonSecondPerKilogram)52600d.MeterPerSecond();
    public static SpecificImpulse Engine_CFMCFM563C1 { get; } = (NewtonSecondPerKilogram)52900d.MeterPerSecond();
    public static SpecificImpulse Engine_CFMCFM565A1 { get; } = (NewtonSecondPerKilogram)59200d.MeterPerSecond();
    public static SpecificImpulse Engine_CFMCFM565B4 { get; } = (NewtonSecondPerKilogram)64800d.MeterPerSecond();
    public static SpecificImpulse Engine_CFMCFM565C2 { get; } = (NewtonSecondPerKilogram)64800d.MeterPerSecond();
    public static SpecificImpulse Engine_CFMCFM567B24 { get; } = (NewtonSecondPerKilogram)56300d.MeterPerSecond();
    public static SpecificImpulse Engine_CFMLEAP1A { get; } = (NewtonSecondPerKilogram)69000d.MeterPerSecond();
    public static SpecificImpulse Engine_CFMLEAP1B { get; } = (NewtonSecondPerKilogram)67000d.MeterPerSecond();
    public static SpecificImpulse Engine_CFMLEAP1C { get; } = (NewtonSecondPerKilogram)69000d.MeterPerSecond();
    public static SpecificImpulse Engine_EAGP7270 { get; } = (NewtonSecondPerKilogram)118000d.MeterPerSecond();
    public static SpecificImpulse Engine_EurojetEJ200 { get; } = (NewtonSecondPerKilogram)48000d.MeterPerSecond();
    public static SpecificImpulse Engine_GECF3410A { get; } = (NewtonSecondPerKilogram)54300d.MeterPerSecond();
    public static SpecificImpulse Engine_GECF3410E { get; } = (NewtonSecondPerKilogram)55000d.MeterPerSecond();
    public static SpecificImpulse Engine_GECF343 { get; } = (NewtonSecondPerKilogram)51200d.MeterPerSecond();
    public static SpecificImpulse Engine_GECF348C { get; } = (NewtonSecondPerKilogram)53000d.MeterPerSecond();
    public static SpecificImpulse Engine_GECF348E { get; } = (NewtonSecondPerKilogram)51900d.MeterPerSecond();
    public static SpecificImpulse Engine_GECF680C2 { get; } = (NewtonSecondPerKilogram)115000d.MeterPerSecond();
    public static SpecificImpulse Engine_GECF680C2B1F { get; } = (NewtonSecondPerKilogram)58400d.MeterPerSecond();
    public static SpecificImpulse Engine_GECF680C2B2 { get; } = (NewtonSecondPerKilogram)61300d.MeterPerSecond();
    public static SpecificImpulse Engine_GEF101GE102 { get; } = (NewtonSecondPerKilogram)62800d.MeterPerSecond();
    public static SpecificImpulse Engine_GEF110GE129 { get; } = (NewtonSecondPerKilogram)55000d.MeterPerSecond();
    public static SpecificImpulse Engine_GEF110GE132 { get; } = (NewtonSecondPerKilogram)55000d.MeterPerSecond();
    public static SpecificImpulse Engine_GEF118GE100 { get; } = (NewtonSecondPerKilogram)94000d.MeterPerSecond();
    public static SpecificImpulse Engine_GEF118GE101 { get; } = (NewtonSecondPerKilogram)94000d.MeterPerSecond();
    public static SpecificImpulse Engine_GEF404GE402 { get; } = (NewtonSecondPerKilogram)20300d.MeterPerSecond();
    public static SpecificImpulse Engine_GEF414GE400 { get; } = (NewtonSecondPerKilogram)48800d.MeterPerSecond();
    public static SpecificImpulse Engine_GEGE9085B { get; } = (NewtonSecondPerKilogram)67900d.MeterPerSecond();
    public static SpecificImpulse Engine_GEGE9094B { get; } = (NewtonSecondPerKilogram)118700d.MeterPerSecond();
    public static SpecificImpulse Engine_GEGEnx1B70 { get; } = (NewtonSecondPerKilogram)124100d.MeterPerSecond();
    public static SpecificImpulse Engine_GEGEnx1B76 { get; } = (NewtonSecondPerKilogram)69000d.MeterPerSecond();
    public static SpecificImpulse Engine_GEJ79GE15 { get; } = (NewtonSecondPerKilogram)41500d.MeterPerSecond();
    public static SpecificImpulse Engine_GEJ85GE21 { get; } = (NewtonSecondPerKilogram)28500d.MeterPerSecond();
    public static SpecificImpulse Engine_GeneralElectricCF650C2 { get; } = (NewtonSecondPerKilogram)56000d.MeterPerSecond();
    public static SpecificImpulse Engine_GETF34GE100 { get; } = (NewtonSecondPerKilogram)95000d.MeterPerSecond();
    public static SpecificImpulse Engine_HoneywellALF502R5 { get; } = (NewtonSecondPerKilogram)49000d.MeterPerSecond();
    public static SpecificImpulse Engine_HoneywellITECF124 { get; } = (NewtonSecondPerKilogram)43600d.MeterPerSecond();
    public static SpecificImpulse Engine_HoneywellITECF125 { get; } = (NewtonSecondPerKilogram)44100d.MeterPerSecond();
    public static SpecificImpulse Engine_HoneywellTFE73160 { get; } = (NewtonSecondPerKilogram)52000d.MeterPerSecond();
    public static SpecificImpulse Engine_IAEV2525D5 { get; } = (NewtonSecondPerKilogram)61500d.MeterPerSecond();
    public static SpecificImpulse Engine_IAEV2533A5 { get; } = (NewtonSecondPerKilogram)61500d.MeterPerSecond();
    public static SpecificImpulse Engine_IHIF3 { get; } = (NewtonSecondPerKilogram)50400d.MeterPerSecond();
    public static SpecificImpulse Engine_J58 { get; } = (NewtonSecondPerKilogram)18580d.MeterPerSecond();
    public static SpecificImpulse Engine_KlimovRD33 { get; } = (NewtonSecondPerKilogram)45800d.MeterPerSecond();
    public static SpecificImpulse Engine_KuznetsovNK32 { get; } = (NewtonSecondPerKilogram)49000d.MeterPerSecond();
    public static SpecificImpulse Engine_KuznetsovNK33 { get; } = (NewtonSecondPerKilogram)3250d.MeterPerSecond();
    public static SpecificImpulse Engine_LE5B2 { get; } = (NewtonSecondPerKilogram)4380d.MeterPerSecond();
    public static SpecificImpulse Engine_LE7A { get; } = (NewtonSecondPerKilogram)4300d.MeterPerSecond();
    public static SpecificImpulse Engine_LyulkaAL21F3 { get; } = (NewtonSecondPerKilogram)41100d.MeterPerSecond();
    public static SpecificImpulse Engine_Merlin1D { get; } = (NewtonSecondPerKilogram)3000d.MeterPerSecond();
    public static SpecificImpulse Engine_NPOEnergomashRD171M { get; } = (NewtonSecondPerKilogram)3300d.MeterPerSecond();
    public static SpecificImpulse Engine_PowerJetSaM146 { get; } = (NewtonSecondPerKilogram)56100d.MeterPerSecond();
    public static SpecificImpulse Engine_ProgressD18T { get; } = (NewtonSecondPerKilogram)64700d.MeterPerSecond();
    public static SpecificImpulse Engine_PW1127G { get; } = (NewtonSecondPerKilogram)76300d.MeterPerSecond();
    public static SpecificImpulse Engine_PWF117PW100 { get; } = (NewtonSecondPerKilogram)104000d.MeterPerSecond();
    public static SpecificImpulse Engine_PWF119PW100 { get; } = (NewtonSecondPerKilogram)57900d.MeterPerSecond();
    public static SpecificImpulse Engine_PWJ52P408 { get; } = (NewtonSecondPerKilogram)44700d.MeterPerSecond();
    public static SpecificImpulse Engine_PWJT8D9 { get; } = (NewtonSecondPerKilogram)44100d.MeterPerSecond();
    public static SpecificImpulse Engine_PWPW1400G { get; } = (NewtonSecondPerKilogram)69000d.MeterPerSecond();
    public static SpecificImpulse Engine_PWPW2040 { get; } = (NewtonSecondPerKilogram)60700d.MeterPerSecond();
    public static SpecificImpulse Engine_PWPW4098 { get; } = (NewtonSecondPerKilogram)60800d.MeterPerSecond();
    public static SpecificImpulse Engine_PWTF33P3 { get; } = (NewtonSecondPerKilogram)67900d.MeterPerSecond();
    public static SpecificImpulse Engine_Ramjet { get; } = (NewtonSecondPerKilogram)7800d.MeterPerSecond();
    public static SpecificImpulse Engine_RD843 { get; } = (NewtonSecondPerKilogram)3094d.MeterPerSecond();
    public static SpecificImpulse Engine_RRAE3007H { get; } = (NewtonSecondPerKilogram)91000d.MeterPerSecond();
    public static SpecificImpulse Engine_RRBR710 { get; } = (NewtonSecondPerKilogram)55000d.MeterPerSecond();
    public static SpecificImpulse Engine_RRBR715 { get; } = (NewtonSecondPerKilogram)56900d.MeterPerSecond();
    public static SpecificImpulse Engine_RRBR725 { get; } = (NewtonSecondPerKilogram)53700d.MeterPerSecond();
    public static SpecificImpulse Engine_RRPegasus1161 { get; } = (NewtonSecondPerKilogram)46500d.MeterPerSecond();
    public static SpecificImpulse Engine_RRSnecmaOlympus { get; } = (NewtonSecondPerKilogram)29500d.MeterPerSecond();
    public static SpecificImpulse Engine_RRSpeyRB168 { get; } = (NewtonSecondPerKilogram)53500d.MeterPerSecond();
    public static SpecificImpulse Engine_RRTayRB183 { get; } = (NewtonSecondPerKilogram)51200d.MeterPerSecond();
    public static SpecificImpulse Engine_RRTrent1000 { get; } = (NewtonSecondPerKilogram)69800d.MeterPerSecond();
    public static SpecificImpulse Engine_RRTrent1000C { get; } = (NewtonSecondPerKilogram)129000d.MeterPerSecond();
    public static SpecificImpulse Engine_RRTrent500 { get; } = (NewtonSecondPerKilogram)65100d.MeterPerSecond();
    public static SpecificImpulse Engine_RRTrent700 { get; } = (NewtonSecondPerKilogram)62800d.MeterPerSecond();
    public static SpecificImpulse Engine_RRTrent7000 { get; } = (NewtonSecondPerKilogram)69800d.MeterPerSecond();
    public static SpecificImpulse Engine_RRTrent800 { get; } = (NewtonSecondPerKilogram)63000d.MeterPerSecond();
    public static SpecificImpulse Engine_RRTrent900 { get; } = (NewtonSecondPerKilogram)67600d.MeterPerSecond();
    public static SpecificImpulse Engine_RRTrent97084 { get; } = (NewtonSecondPerKilogram)119700d.MeterPerSecond();
    public static SpecificImpulse Engine_RRTrentXWB97 { get; } = (NewtonSecondPerKilogram)73900d.MeterPerSecond();
    public static SpecificImpulse Engine_RRTurbomecaAdour { get; } = (NewtonSecondPerKilogram)44000d.MeterPerSecond();
    public static SpecificImpulse Engine_SaturnAL31F { get; } = (NewtonSecondPerKilogram)53000d.MeterPerSecond();
    public static SpecificImpulse Engine_SaturnAL41F1S { get; } = (NewtonSecondPerKilogram)44700d.MeterPerSecond();
    public static SpecificImpulse Engine_SnecmaAtar08K50 { get; } = (NewtonSecondPerKilogram)36400d.MeterPerSecond();
    public static SpecificImpulse Engine_SnecmaAtar09C { get; } = (NewtonSecondPerKilogram)35000d.MeterPerSecond();
    public static SpecificImpulse Engine_SnecmaAtar09K50 { get; } = (NewtonSecondPerKilogram)36000d.MeterPerSecond();
    public static SpecificImpulse Engine_SnecmaHM7B { get; } = (NewtonSecondPerKilogram)4360d.MeterPerSecond();
    public static SpecificImpulse Engine_SnecmaLarzac { get; } = (NewtonSecondPerKilogram)49300d.MeterPerSecond();
    public static SpecificImpulse Engine_SnecmaM53P2 { get; } = (NewtonSecondPerKilogram)41500d.MeterPerSecond();
    public static SpecificImpulse Engine_SnecmaM882 { get; } = (NewtonSecondPerKilogram)45100d.MeterPerSecond();
    public static SpecificImpulse Engine_SolovievD30F6 { get; } = (NewtonSecondPerKilogram)49300d.MeterPerSecond();
    public static SpecificImpulse Engine_SolovievD30KP2 { get; } = (NewtonSecondPerKilogram)49400d.MeterPerSecond();
    public static SpecificImpulse Engine_SolovievD30KU154 { get; } = (NewtonSecondPerKilogram)50100d.MeterPerSecond();
    public static SpecificImpulse Engine_TumanskyR25300 { get; } = (NewtonSecondPerKilogram)36700d.MeterPerSecond();
    public static SpecificImpulse Engine_TurboUnionRB199 { get; } = (NewtonSecondPerKilogram)55400d.MeterPerSecond();
    public static SpecificImpulse Engine_VolvoRM12 { get; } = (NewtonSecondPerKilogram)42800d.MeterPerSecond();
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
