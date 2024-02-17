namespace Unknown6656.Units.Information;


public partial record InformationCapacity(Bit value)
    : Quantity<InformationCapacity, Bit, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "";
}

// TODO : entropy
// TODO : information density
// TODO : transfer rate