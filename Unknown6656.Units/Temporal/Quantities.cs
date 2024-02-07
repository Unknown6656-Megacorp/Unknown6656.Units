using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Movement;

namespace Unknown6656.Units.Temporal;


[InverseRelationship<Time, Frequency, Second, Hertz, Scalar>]
public partial record Time(Second value)
    : Quantity<Time, Second, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "t";
}

public partial record Frequency(Hertz value)
    : Quantity<Frequency, Hertz, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "f";
#else
    public static string QuantitySymbol { get; } = "𝑓";
#endif

    public Length ComputeWavelength() => ComputeWavelength(Speed.C0);

    public Length ComputeWavelength(Speed wavespeed) => wavespeed / this;
}
