using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Energy;

namespace Unknown6656.Units.Thermodynamics;


public partial record Temperature(Kelvin value)
    : Quantity<Temperature, Kelvin, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "T";
    public static Kelvin AbsoluteZero { get; } = new((Scalar)0);
    public static Kelvin AbsoluteHot { get; } = new((Scalar)1.416808338416e32);
}

// HeatFlux = kg * s^-3
// HeatFlux = MassFlow * s^-2
// HeatFlux = MassFlow * Hz^2

// TODO : this thing is usually a multi-dimensional vector
[MultiplicativeRelationship<HeatFlux, Area, Power, WattPerSquareMeter, SquareMeter, Watt, Scalar>]
public partial record HeatFlux(WattPerSquareMeter value)
    : Quantity<HeatFlux, WattPerSquareMeter, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "phi_q";
#else
    public static string QuantitySymbol { get; } = "φq";
#endif
}

public partial record HeatTransferCoefficient
{
    // TODO
}

public partial record ThermalConductivity
{
    // TODO
}
