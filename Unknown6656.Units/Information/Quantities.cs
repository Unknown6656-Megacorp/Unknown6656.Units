using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Matter;
using Unknown6656.Units.Kinematics;
using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Information;


public partial record InformationCapacity(Bit value)
    : Quantity<InformationCapacity, Bit, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "X";
}

[MultiplicativeRelationship<BitRate, Time, InformationCapacity, BitPerSecond, Second, Bit, Scalar>]
public partial record BitRate(BitPerSecond value)
    : Quantity<BitRate, BitPerSecond, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "X/t";
}

[MultiplicativeRelationship<SpecificInformationCapacity, MassFlowRate, BitRate, BitPerKilogram, KilogramPerSecond, BitPerSecond, Scalar>]
[MultiplicativeRelationship<SpecificInformationCapacity, Mass, InformationCapacity, BitPerKilogram, Kilogram, Bit, Scalar>]
public partial record SpecificInformationCapacity(BitPerKilogram value)
    : Quantity<SpecificInformationCapacity, BitPerKilogram, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "X/m";
}

[MultiplicativeRelationship<LinearInformationDensity, Length, InformationCapacity, BitPerMeter, Meter, Bit, Scalar>]
[MultiplicativeRelationship<LinearInformationDensity, Speed, BitRate, BitPerMeter, MeterPerSecond, BitPerSecond, Scalar>]
public partial record LinearInformationDensity(BitPerMeter value)
    : Quantity<LinearInformationDensity, BitPerMeter, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "X/l";
}

[MultiplicativeRelationship<ArealInformationDensity, Area, InformationCapacity, BitPerSquareMeter, SquareMeter, Bit, Scalar>]
[MultiplicativeRelationship<ArealInformationDensity, Length, LinearInformationDensity, BitPerSquareMeter, Meter, BitPerMeter, Scalar>]
[MultiplicativeRelationship<ArealInformationDensity, KinematicViscosity, BitRate, BitPerSquareMeter, SquareMeterPerSecond, BitPerSecond, Scalar>]
public partial record ArealInformationDensity(BitPerSquareMeter value)
    : Quantity<ArealInformationDensity, BitPerSquareMeter, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "X/A";
}

[MultiplicativeRelationship<VolumetricInformationDensity, Volume, InformationCapacity, BitPerCubicMeter, CubicMeter, Bit, Scalar>]
[MultiplicativeRelationship<VolumetricInformationDensity, Area, LinearInformationDensity, BitPerCubicMeter, SquareMeter, BitPerMeter, Scalar>]
[MultiplicativeRelationship<VolumetricInformationDensity, Length, ArealInformationDensity, BitPerCubicMeter, Meter, BitPerSquareMeter, Scalar>]
[MultiplicativeRelationship<VolumetricInformationDensity, VolumetricFlowRate, BitRate, BitPerCubicMeter, CubicMeterPerSecond, BitPerSecond, Scalar>]
public partial record VolumetricInformationDensity(BitPerCubicMeter value)
    : Quantity<VolumetricInformationDensity, BitPerCubicMeter, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "X/V";
}

// TODO : information entropy
// TODO : erlang https://en.wikipedia.org/wiki/Erlang_(unit)