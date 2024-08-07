﻿namespace Unknown6656.Units.Matter;


[KnownBaseUnit<Amount, Mol, Scalar>]
public partial record Mol
{
    public static string UnitSymbol { get; } = "mol";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
