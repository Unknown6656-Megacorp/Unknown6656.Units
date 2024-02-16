using Unknown6656.Units.Electricity;
using Unknown6656.Units.Energy;
using Unknown6656.Units.Matter;
using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Radioactivity;


[MultiplicativeRelationship<RadiationExposure, Mass, Charge, CoulombPerKilogram, Kilogram, Coulomb, Scalar>]
public partial record RadiationExposure(CoulombPerKilogram value)
    : Quantity<RadiationExposure, CoulombPerKilogram, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "X";
}

//[InverseRelationship<Activity, Time, Becquerel, Second, Scalar>]
[IdentityRelationship<Activity, Frequency, Becquerel, Hertz, Scalar>]
public partial record Activity(Becquerel value)
    : Quantity<Activity, Becquerel, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "A";
}

[MultiplicativeRelationship<SpecificActivity, Mass, Activity, BecquerelPerKilogram, Kilogram, Becquerel, Scalar>]
public partial record SpecificActivity(BecquerelPerKilogram value)
    : Quantity<SpecificActivity, BecquerelPerKilogram, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "a";
}

[MultiplicativeRelationship<AbsorbedDose, Mass, KineticEnergy, Gray, Kilogram, Joule, Scalar>]
public partial record AbsorbedDose(Gray value)
    : Quantity<AbsorbedDose, Gray, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "D";
}

[IdentityRelationship<AbsorbedDose, EquivalentDose, Gray, Sievert, Scalar>]
[MultiplicativeRelationship<EquivalentDose, Mass, KineticEnergy, Sievert, Kilogram, Joule, Scalar>]
public partial record EquivalentDose(Sievert value)
    : Quantity<EquivalentDose, Sievert, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "H";
}


// equivalent dose
// kerma https://en.wikipedia.org/wiki/Kerma_(physics)

