using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Movement;

namespace Unknown6656.Units.Temporal;


[InverseRelationship<Time, Frequency, Second, Hertz, Scalar>]
public partial record Time(Second value)
    : Quantity<Time, Second, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "t";
}

// TODO : datetime parsing and datetime conversions

public partial record Frequency(Hertz value)
    : Quantity<Frequency, Hertz, Scalar>(value)
{
#if USE_PURE_ASCII
    public static string QuantitySymbol { get; } = "f";
#else
    public static string QuantitySymbol { get; } = "𝑓";
#endif
    public static BeatsPerMinute MusicTempo_Larghissimo_UpperBound { get; } = new(24);
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_Adagissimo { get; } = (new(24), new(40));
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_Largo { get; } = (new(40), new(66));
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_Larghetto { get; } = (new(44), new(66));
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_Adagio { get; } = (new(44), new(68));
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_Adagietto { get; } = (new(46), new(80));
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_Lento { get; } = (new(52), new(108));
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_Andante { get; } = (new(56), new(108));
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_Andantino { get; } = (new(80), new(108));
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_MarciaModerato { get; } = (new(66), new(80));
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_AndanteModerato { get; } = (new(80), new(108));
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_Moderato { get; } = (new(108), new(120));
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_Allegretto { get; } = (new(112), new(120));
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_AllegroModerato { get; } = (new(116), new(120));
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_Allegro { get; } = (new(120), new(156));
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_MoltoAllegro { get; } = (new(124), new(156));
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_Vivace { get; } = (new(156), new(176));
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_Vivacissimo { get; } = (new(172), new(176));
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_Allegrissimo => MusicTempo_Vivacissimo;
    public static (BeatsPerMinute LowerBound, BeatsPerMinute UpperBound) MusicTempo_Presto { get; } = (new(168), new(200));
    public static BeatsPerMinute MusicTempo_Prestissimo_LowerBound { get; } = new(200);

    public static BeatsPerMinute Tachycardia_LowerBound { get; } = new(100);
    public static BeatsPerMinute Bradycardia_UpperBound { get; } = new(60);


    public Length ComputeWavelength() => ComputeWavelength(Speed.C0);

    public Length ComputeWavelength(Speed wavespeed) => wavespeed / this;
}
