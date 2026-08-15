namespace Unknown6656.Units.Relative;


[KnownRelativeUnit<Scalar>(KnownRelativeUnitType.Logarithmic)]
public partial record Bel
{
    public static Scalar Base { get; } = 10;
    public static Scalar PowerFactor { get; } = 1;
    public static Scalar AmplitudeFactor { get; } = 2;
    public static string UnitSymbol { get; } = "B";
}

[KnownRelativeUnit<Scalar>(KnownRelativeUnitType.Logarithmic)]
public partial record Decibel
{
    public static Scalar Base { get; } = 10;
    public static Scalar PowerFactor { get; } = 10;
    public static Scalar AmplitudeFactor { get; } = 20;
    public static string UnitSymbol { get; } = "dB";
}

[KnownRelativeUnit<Scalar>(KnownRelativeUnitType.Logarithmic)]
public partial record Neper
{
    public static Scalar Base { get; } = Scalar.E;
    public static Scalar PowerFactor { get; } = 10;
    public static Scalar AmplitudeFactor { get; } = 20;
    public static string UnitSymbol { get; } = "Np";
}

[KnownRelativeUnit<Scalar>(KnownRelativeUnitType.Logarithmic)]
public partial record Octave
{
    public static Scalar Base { get; } = 2;
    public static Scalar PowerFactor { get; } = 1;
    public static Scalar AmplitudeFactor { get; } = 2;
    public static string UnitSymbol { get; } = "Oct";
}

[KnownRelativeUnit<Scalar>(KnownRelativeUnitType.Logarithmic)]
public partial record Decade
{
    public static Scalar Base { get; } = 10;
    public static Scalar PowerFactor { get; } = 1;
    public static Scalar AmplitudeFactor { get; } = 2;
    public static string UnitSymbol { get; } = "Dec";
}

[KnownRelativeUnit<Scalar>(KnownRelativeUnitType.Logarithmic)]
public partial record Cent
{
    public static Scalar Base { get; } = 2;
    public static Scalar PowerFactor { get; } = .0008333333333333333333333333333333333333333333333333333;
    public static Scalar AmplitudeFactor { get; } = .0016666666666666666666666666666666666666666666666666666;
    public static string UnitSymbol { get; } = "Cent";
}

[KnownRelativeUnit<Scalar>(KnownRelativeUnitType.Logarithmic)]
public partial record Savart
{
    public static Scalar Base { get; } = 2;
    public static Scalar PowerFactor { get; } = 1e-3;
    public static Scalar AmplitudeFactor { get; } = 5e-3;
    public static string UnitSymbol { get; } = "Sav";
}

[KnownRelativeUnit<Scalar>(KnownRelativeUnitType.Logarithmic)]
public partial record AstronomicalMagnitude
{
    public static Scalar Base { get; } = .3981071705534972507702523050877520434876770372973804468652841480602248538694580390740183116073773602535776139555600987359459931;
    public static Scalar PowerFactor { get; } = 1;
    public static Scalar AmplitudeFactor { get; } = 2;
    public static string UnitSymbol { get; } = "AM";
}
