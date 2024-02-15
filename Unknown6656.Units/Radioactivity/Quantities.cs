using Unknown6656.Units.Electricity;
using Unknown6656.Units.Matter;

namespace Unknown6656.Units.Radioactivity;


[MultiplicativeRelationship<RadiationExposure, Mass, Charge, Röntgen, Kilogram, Coulomb, Scalar>]
public partial record RadiationExposure(Röntgen value)
    : Quantity<RadiationExposure, Röntgen, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "X";
}


// activity
// specific activity
// absorbed dose
// equivalent dose
// kerma https://en.wikipedia.org/wiki/Kerma_(physics)

