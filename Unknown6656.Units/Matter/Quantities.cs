using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Movement;

namespace Unknown6656.Units.Matter;

public partial record Amount(Mol value) : Quantity<Amount, Mol, Scalar>(value);

public partial record Mass(Kilogram value) : Quantity<Mass, Kilogram, Scalar>(value);


[MultiplicativeQuantityRelationship<MolarMass, Amount, Mass, GramPerMol, Mol, Kilogram, Scalar>((Scalar)1e-3)]
public partial record MolarMass(GramPerMol value) : Quantity<MolarMass, GramPerMol, Scalar>(value);

public partial record VolumetricMassDensity(KilogramsPerCubicMeter value) : Quantity<VolumetricMassDensity, KilogramsPerCubicMeter, Scalar>(value);

[MultiplicativeQuantityRelationship<Force, Area, Pressure, Newton, SquareMeter, Pascal, Scalar>]
[MultiplicativeQuantityRelationship<Volume, Pressure, Torque, CubicMeter, Pascal, NewtonMeter, Scalar>]
public partial record Pressure(Pascal value) : Quantity<Pressure, Pascal, Scalar>(value);
