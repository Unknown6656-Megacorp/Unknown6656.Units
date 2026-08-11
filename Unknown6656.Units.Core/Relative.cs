using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Unknown6656.Units.Relative;


public interface IRelativeRatioUnit<TUnit, TScalar>
    : IUnit
    where TScalar : INumber<TScalar>
                  , IPowerFunctions<TScalar>
                  , ILogarithmicFunctions<TScalar>
{
    static abstract TScalar Base { get; }
    static abstract TScalar PowerFactor { get; }
    static abstract TScalar AmplitudeFactor { get; }

    public static abstract TUnit FromPower(TScalar power);
    public static abstract TUnit FromPowerRatio(TScalar power_ratio);
    public static abstract TUnit FromAmplitudeRatio(TScalar amplitude_ratio);
}

[DebuggerDisplay("{ToDebugString()}")]
public abstract record RelativeRatioUnit<TScalar>(TScalar Power)
    where TScalar : INumber<TScalar>
{
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;

    public abstract TScalar PowerRatio { get; }
    public abstract TScalar AmplitudeRatio { get; }


    internal virtual string ToDebugString() => $"{Power} (P: {Unit.Format(PowerRatio, null, null, null, UnitDisplay)}, A: {Unit.Format(AmplitudeRatio, null, null, null, UnitDisplay)})";
}

[DebuggerDisplay("{ToDebugString()}")]
public abstract record RelativeRatioUnit<TUnit, TScalar>
    : RelativeRatioUnit<TScalar>
    , IFormattable
    , IParsable<RelativeRatioUnit<TUnit, TScalar>>
    where TScalar : INumber<TScalar>
                  , IPowerFunctions<TScalar>
                  , ILogarithmicFunctions<TScalar>
    where TUnit : RelativeRatioUnit<TUnit, TScalar>
                , IRelativeRatioUnit<TUnit, TScalar>
{
    public override TScalar PowerRatio { get; }
    public override TScalar AmplitudeRatio { get; }


    public RelativeRatioUnit(TScalar power)
        : base(power)
    {
        PowerRatio = TScalar.Pow(TUnit.Base, power / TUnit.PowerFactor);
        AmplitudeRatio = TScalar.Pow(TUnit.Base, power / TUnit.AmplitudeFactor);
    }

    internal override string ToDebugString() => $"{Power} {TUnit.UnitSymbol} (P: {Unit.Format(PowerRatio, null, null, null, UnitDisplay)}, A: {Unit.Format(AmplitudeRatio, null, null, null, UnitDisplay)})";

    public override string ToString() => ToString(null, null);

    public string ToString<Unit>() where Unit : IUnit => ToString<Unit>(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider) => $"{Power.ToString(format, formatProvider)} {TUnit.UnitSymbol}";

    public string ToString<Unit>(string? format, IFormatProvider? formatProvider) where Unit : IUnit =>
        $"{Power.ToString(format, formatProvider)} {TUnit.UnitSymbol}{Unit.UnitSymbol.Trim(TUnit.UnitSymbol)}";

    public TOther To<TOther>() where TOther : RelativeRatioUnit<TOther, TScalar>, IRelativeRatioUnit<TOther, TScalar> => TOther.FromPower(Power);

    public static TUnit From<TOther>(TOther unit) where TOther : RelativeRatioUnit<TOther, TScalar>, IRelativeRatioUnit<TOther, TScalar> => TUnit.FromPower(unit.Power);

    public static TUnit FromPowerRatio(TScalar power_ratio) => TUnit.FromPower(TScalar.Log(power_ratio) / TScalar.Log(TUnit.Base) * TUnit.PowerFactor);

    public static TUnit FromAmplitudeRatio(TScalar amplitude_ratio) => TUnit.FromPower(TScalar.Log(amplitude_ratio) / TScalar.Log(TUnit.Base) * TUnit.AmplitudeFactor);

    public static RelativeRatioUnit<TUnit, TScalar> Parse(string s, IFormatProvider? provider) =>
        TryParse(s, provider, out RelativeRatioUnit<TUnit, TScalar>? result) ? result : throw new FormatException($"Input string '{s}' could not be parsed as '{typeof(RelativeRatioUnit<TUnit, TScalar>)}'.");

    public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out RelativeRatioUnit<TUnit, TScalar> result) => throw new NotImplementedException();

    public static explicit operator RelativeRatioUnit<TUnit, TScalar>(TScalar power) => TUnit.FromPower(power);

    public static implicit operator TScalar(RelativeRatioUnit<TUnit, TScalar> ratio) => ratio.PowerRatio;
}
