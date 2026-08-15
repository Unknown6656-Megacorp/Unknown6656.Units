using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using System.Numerics;
using System;

namespace Unknown6656.Units;


public interface IRelativeRatioUnit<TUnit, TScalar>
    : IUnit
    , IParsable<TUnit>
    where TScalar : INumber<TScalar>
    where TUnit : IRelativeRatioUnit<TUnit, TScalar>
{
    public TScalar Power { get; }

    public TScalar Value { get; }


    public static abstract TUnit FromPower(TScalar power);

    public static abstract TUnit FromValue(TScalar value);

    public static abstract bool TryParse([NotNullWhen(true)] string? s, [MaybeNullWhen(false)] out TUnit result);
}

public interface ILogarithmicRelativeRatioUnit<TUnit, TScalar>
    : IRelativeRatioUnit<TUnit, TScalar>
    , IUnit
    where TUnit: ILogarithmicRelativeRatioUnit<TUnit, TScalar>
    where TScalar : INumber<TScalar>
{
    static abstract TScalar Base { get; }
    static abstract TScalar PowerFactor { get; }
    static abstract TScalar AmplitudeFactor { get; }

    public static abstract TUnit FromPowerRatio(TScalar power_ratio);
    public static abstract TUnit FromAmplitudeRatio(TScalar amplitude_ratio);
}

public interface ILinearRelativeRatioUnit<TUnit, TScalar>
    : IRelativeRatioUnit<TUnit, TScalar>
    , IUnit
    where TUnit: ILinearRelativeRatioUnit<TUnit, TScalar>
    where TScalar : INumber<TScalar>
{
    static abstract TScalar Factor { get; }
}

[DebuggerDisplay("{ToDebugString()}")]
public abstract record RelativeRatioUnit<TUnit, TScalar>(TScalar Power)
    : IFormattable
    where TScalar : INumber<TScalar>
    where TUnit : RelativeRatioUnit<TUnit, TScalar>
                , IRelativeRatioUnit<TUnit, TScalar>
{
    private static readonly Func<TScalar, TUnit> _ctor = Unit.GetConstructor<TUnit, TScalar>();

    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;

    public abstract TScalar Value { get; }


    internal string ToDebugString() => $"{this}";

    public sealed override string ToString() => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider) => Unit.Format(Power, TUnit.UnitSymbol, format, formatProvider, UnitDisplay);

    public TOther To<TOther>() where TOther : RelativeRatioUnit<TOther, TScalar>, IRelativeRatioUnit<TOther, TScalar> => TOther.FromValue(Value);

    public static TUnit From<TOther>(TOther unit) where TOther : RelativeRatioUnit<TOther, TScalar>, IRelativeRatioUnit<TOther, TScalar> => TUnit.FromValue(unit.Value);

    public static TUnit Parse(string s) => Parse(s, null);

    public static TUnit Parse(string s, IFormatProvider? provider = null) => TUnit.TryParse(s, provider, out TUnit? result) ? result : throw new FormatException($"Invalid format: {s}");

    public static bool TryParse([NotNullWhen(true)] string? s, [MaybeNullWhen(false)] out TUnit result) => TUnit.TryParse(s, null, out result);

    public static TUnit FromPower(TScalar power) => _ctor(power);

    public static explicit operator RelativeRatioUnit<TUnit, TScalar>(TScalar power) => FromPower(power);

    public static implicit operator RelativeRatioUnit<TUnit, TScalar>(TUnit ratio) => ratio; // TODO: is this needed?

    public static implicit operator TUnit(RelativeRatioUnit<TUnit, TScalar> ratio) => ratio as TUnit ?? TUnit.FromPower(ratio.Power); // TODO: is there a more elegant solution?

    public static implicit operator TScalar(RelativeRatioUnit<TUnit, TScalar> ratio) => ratio.Value;
}

public abstract record LinearRelativeRatioUnit<TUnit, TScalar>(TScalar Power)
    : RelativeRatioUnit<TUnit, TScalar>(Power)
    where TScalar : INumber<TScalar>
    where TUnit : LinearRelativeRatioUnit<TUnit, TScalar>
                , ILinearRelativeRatioUnit<TUnit, TScalar>
{
    public override TScalar Value { get; } = Power * TUnit.Factor;


    public static TUnit FromValue(TScalar value) => TUnit.FromPower(value / TUnit.Factor);

    public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out TUnit result) => throw new NotImplementedException();
}

public abstract record LogarithmicRelativeRatioUnit<TUnit, TScalar>
    : RelativeRatioUnit<TUnit, TScalar>
    where TScalar : INumber<TScalar>
                  , IPowerFunctions<TScalar>
                  , ILogarithmicFunctions<TScalar>
    where TUnit : LogarithmicRelativeRatioUnit<TUnit, TScalar>
                , ILogarithmicRelativeRatioUnit<TUnit, TScalar>
{
    public override TScalar Value { get; }

    [Obsolete($"Use '{nameof(Value)}' instead.")]
    public TScalar PowerRatio => Value;
    public TScalar AmplitudeRatio => TScalar.Pow(TUnit.Base, Power / TUnit.AmplitudeFactor);


    public LogarithmicRelativeRatioUnit(TScalar power)
        : base(power) => Value = TScalar.Pow(TUnit.Base, power / TUnit.PowerFactor);

    public string ToString<Unit>() where Unit : IUnit => ToString<Unit>(null, null);

    public string ToString<Unit>(string? format, IFormatProvider? formatProvider) where Unit : IUnit =>
        $"{Power.ToString(format, formatProvider)} {TUnit.UnitSymbol}{Unit.UnitSymbol.Trim(TUnit.UnitSymbol)}";

    public static TUnit FromValue(TScalar power_ratio) => TUnit.FromPowerRatio(power_ratio);

    public static TUnit FromPowerRatio(TScalar power_ratio) => TUnit.FromPower(TScalar.Log(power_ratio) / TScalar.Log(TUnit.Base) * TUnit.PowerFactor);

    public static TUnit FromAmplitudeRatio(TScalar amplitude_ratio) => TUnit.FromPower(TScalar.Log(amplitude_ratio) / TScalar.Log(TUnit.Base) * TUnit.AmplitudeFactor);

    public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out TUnit result) => throw new NotImplementedException();
}
