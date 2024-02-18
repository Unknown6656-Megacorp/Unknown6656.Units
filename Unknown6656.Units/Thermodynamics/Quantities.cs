namespace Unknown6656.Units.Thermodynamics;


public partial record Temperature(Kelvin value)
    : Quantity<Temperature, Kelvin, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "T";
    public static Kelvin AbsoluteZero { get; } = new((Scalar)0);
    public static Kelvin AbsoluteHot { get; } = new((Scalar)1.416808338416e32);
}

public partial record HeatFlux
{

}

public partial record HeatTransferCoefficient
{
    // TODO
}

public partial record ThermalConductivity
{
    // TODO
}
