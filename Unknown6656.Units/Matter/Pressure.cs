﻿namespace Unknown6656.Units.Matter;


[KnownBaseUnit<Pressure, Pascal, Scalar>]
public partial record Pascal(Scalar Value)
    : BaseUnit<Pressure, Pascal, Scalar>(Value)
    , IBaseUnit<Pascal, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Pa";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}

[KnownUnit<Pressure, Atmosphere, Pascal, Scalar>]
public partial record Atmosphere(Scalar Value)
    : Pressure.AffineUnit<Atmosphere>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Atmosphere, Pascal, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "atm";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)9.8692326671601e-6;
}

[KnownUnit<Pressure, Bar, Pascal, Scalar>]
public partial record Bar(Scalar Value)
    : Pressure.AffineUnit<Bar>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Bar, Pascal, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "bar";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-5;
}

[KnownUnit<Pressure, PoundPerSquareInch, Pascal, Scalar>]
public partial record PoundPerSquareInch(Scalar Value)
    : Pressure.AffineUnit<PoundPerSquareInch>(Value)
    , ILinearUnit<Scalar>
    , IUnit<PoundPerSquareInch, Pascal, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "psi";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.00014503773773020923;
}

[KnownUnit<Pressure, Torr, Pascal, Scalar>]
public partial record Torr(Scalar Value)
    : Pressure.AffineUnit<Torr>(Value)
    , ILinearUnit<Scalar>
    , IUnit<Torr, Pascal, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "Torr";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0075006168270417;
}

[KnownUnit<Pressure, KilopoundPerSquareInch, Pascal, Scalar>]
public partial record KilopoundPerSquareInch(Scalar Value)
    : Pressure.AffineUnit<KilopoundPerSquareInch>(Value)
    , ILinearUnit<Scalar>
    , IUnit<KilopoundPerSquareInch, Pascal, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "ksi";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.14503773773020923;
}

[KnownUnit<Pressure, MillimeterMercury, Pascal, Scalar>]
public partial record MillimeterMercury(Scalar Value)
    : Pressure.AffineUnit<MillimeterMercury>(Value)
    , ILinearUnit<Scalar>
    , IUnit<MillimeterMercury, Pascal, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "mmHg";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0075006168270417;
}

[KnownUnit<Pressure, InchMercury, Pascal, Scalar>]
public partial record InchMercury(Scalar Value)
    : Pressure.AffineUnit<InchMercury>(Value)
    , ILinearUnit<Scalar>
    , IUnit<InchMercury, Pascal, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "inHg";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.00029529983071445;
}

[KnownUnit<Pressure, MillimeterWater, Pascal, Scalar>]
public partial record MillimeterWater(Scalar Value)
    : Pressure.AffineUnit<MillimeterWater>(Value)
    , ILinearUnit<Scalar>
    , IUnit<MillimeterWater, Pascal, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "mmH₂O";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)0.10197162129779;
}

[KnownUnit<Pressure, InchWater, Pascal, Scalar>]
public partial record InchWater(Scalar Value)
    : Pressure.AffineUnit<InchWater>(Value)
    , ILinearUnit<Scalar>
    , IUnit<InchWater, Pascal, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "inH₂O";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.0040146307866177;
}

[KnownUnit<Pressure, AtmosphereTechnical, Pascal, Scalar>]
public partial record AtmosphereTechnical(Scalar Value)
    : Pressure.AffineUnit<AtmosphereTechnical>(Value)
    , ILinearUnit<Scalar>
    , IUnit<AtmosphereTechnical, Pascal, Scalar>
    , IUnit
{
    public static string UnitSymbol { get; } = "at";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNonSI;
    public static Scalar ScalingFactor { get; } = (Scalar)9.80665e-6;
}



// TODO:
// - pressure
//      - from Pa, atm, bar, psi, ...
