namespace Unknown6656.Units.Matter;

public partial record Amount(Mol value) : Quantity<Amount, Mol, Scalar>(value);

public partial record Mass(Grams value) : Quantity<Mass, Grams, Scalar>(value);

public partial record VolumetricMassDensity(KilogramsPerCubicMeter value) : Quantity<VolumetricMassDensity, KilogramsPerCubicMeter, Scalar>(value);

public partial record Pressure(Pascals value) : Quantity<Pressure, Pascals, Scalar>(value);
