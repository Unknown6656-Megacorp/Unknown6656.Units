using Unknown6656.Units.Electricity;
using Unknown6656.Units.Matter;
using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Radioactivity;


[MultiplicativeRelationship<RadiationExposure, Mass, Charge, CoulombPerKilogram, Kilogram, Coulomb, Scalar>]
public partial record RadiationExposure(CoulombPerKilogram value)
    : Quantity<RadiationExposure, CoulombPerKilogram, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "X";
}

[IdentityRelationship<Activity, Frequency, Becquerel, Hertz, Scalar>]
public partial record Activity(Becquerel value)
    : Quantity<Activity, Becquerel, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "A";
}



// specific activity
// absorbed dose
// equivalent dose
// kerma https://en.wikipedia.org/wiki/Kerma_(physics)

