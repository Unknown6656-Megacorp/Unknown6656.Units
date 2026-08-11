namespace Unknown6656.Units.Relative;

// TODO: percent, permille, ppm, ppb, ppt

public record Decibel(Scalar power)
    : RelativeRatioUnit<Decibel, Scalar>(power)
    , IRelativeRatioUnit<Decibel, Scalar>
{
    public static Scalar Base { get; } = 10;
    public static Scalar PowerFactor { get; } = 10;
    public static Scalar AmplitudeFactor { get; } = 20;

    public static string UnitSymbol { get; } = "dB";

    public Neper Neper => To<Neper>();


    public static explicit operator Decibel(Scalar power) => new(power);

    public static implicit operator Scalar(Decibel decibel) => decibel.PowerRatio;

    public static Decibel FromPower(Scalar power) => new(power);
}

public record Neper(Scalar power)
    : RelativeRatioUnit<Neper, Scalar>(power)
    , IRelativeRatioUnit<Neper, Scalar>
{
    public static Scalar Base { get; } = Scalar.E;
    public static Scalar PowerFactor { get; } = 10;
    public static Scalar AmplitudeFactor { get; } = 20;

    public static string UnitSymbol { get; } = "Np";

    public Decibel Decibel => To<Decibel>();


    public static explicit operator Neper(Scalar power) => new(power);

    public static implicit operator Scalar(Neper neper) => neper.PowerRatio;

    public static Neper FromPower(Scalar power) => new(power);
}

public static class RelativeUnits
{
    public static Decibel Decibel(this Scalar value) => new(value);

    public static Neper Neper(this Scalar value) => new(value);
}
