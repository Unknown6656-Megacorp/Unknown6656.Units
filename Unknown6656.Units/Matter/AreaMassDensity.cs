﻿using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Matter;


[KnownBaseUnit<AreaMassDensity, KilogramPerSquareMeter, Scalar>]
public partial record KilogramPerSquareMeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "kg/m^2";
#else
    public static string UnitSymbol { get; } = "kg/m²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["kilogram/meter^2", "kilogram/m^2", "kg/meter^2", "kilo/m^2", "kilo/meter^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI_Shifted_k;
}

[KnownUnit<AreaMassDensity, PoundPerSquareInch, KilogramPerSquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record PoundPerSquareInch
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lb/in^2";
#else
    public static string UnitSymbol { get; } = "lb/in²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["pound/inch^2", "pound/in^2", "lbs/inch^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Pound.ScalingFactor / SquareInch.ScalingFactor;
}

[KnownUnit<AreaMassDensity, PoundPerSquareFoot, KilogramPerSquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record PoundPerSquareFoot
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "lb/ft^2";
#else
    public static string UnitSymbol { get; } = "lb/ft²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["pound/foot^2", "pound/ft^2", "lbs/foot^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = Pound.ScalingFactor / SquareFoot.ScalingFactor;
}

[KnownUnit<AreaMassDensity, Grammage, KilogramPerSquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record Grammage
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "gsm";
#else
    public static string UnitSymbol { get; } = "g/m²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["gram/meter^2", "gram/m^2", "g/meter^2", "g/m^2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = Gram.ScalingFactor;
}
