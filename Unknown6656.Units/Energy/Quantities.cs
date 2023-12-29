namespace Unknown6656.Units.Energy;


public partial record Temperature(Kelvin value)
    : Quantity<Temperature, Kelvin, Scalar>(value)
{

}

public partial record KineticEnergy(Joule value) : Quantity<KineticEnergy, Joule, Scalar>(value);

