﻿using Unknown6656.Units.Euclidean;

namespace Unknown6656.Units.Photometry;


[KnownBaseUnit<Luminance, CandelaPerSquareMeter, Scalar>]
[KnownAlias<Luminance, CandelaPerSquareMeter, Scalar>("Nit", "nt")]
public partial record CandelaPerSquareMeter
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "cd/m^2";
#else
    public static string UnitSymbol { get; } = "cd/m²";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["cd/meter^2", "candela/m^2", "cd*m^-2", "candela*m^-2", "cd*meter^-2", "candela*meter^-2"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<Luminance, Stilb, CandelaPerSquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record Stilb
{
    public static string UnitSymbol { get; } = "sb";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e4;
}

[KnownUnit<Luminance, Apostlib, CandelaPerSquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record Apostlib
{
    public static string UnitSymbol { get; } = "asb";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["blondel"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)0.3183098861837906715377675267450287240689192914809128974953346881;
}

[KnownUnit<Luminance, Lambert, CandelaPerSquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record Lambert
{
    public static string UnitSymbol { get; } = "L";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["La", "Lb"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)3183.098861837907;
}

[KnownUnit<Luminance, FootLambert, CandelaPerSquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record FootLambert
{
    public static string UnitSymbol { get; } = "fL";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["ftL", "ft-L"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)0.3183098861837906715377675267450287240689192914809128974953346881 * SquareFoot.ScalingFactor;
}

[KnownUnit<Luminance, Skot, CandelaPerSquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record Skot
{
    public static string UnitSymbol { get; } = "sk";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-3 * Apostlib.ScalingFactor;
}

[KnownUnit<Luminance, Bril, CandelaPerSquareMeter, Scalar>(KnownUnitType.Linear)]
public partial record Bril
{
    public static string UnitSymbol { get; } = "br";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.ImperialWithSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1e-7 * Apostlib.ScalingFactor;
}
