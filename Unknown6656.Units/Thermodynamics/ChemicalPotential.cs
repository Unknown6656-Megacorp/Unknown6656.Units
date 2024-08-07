﻿namespace Unknown6656.Units.Thermodynamics;


[KnownBaseUnit<ChemicalPotential, JoulePerMol, Scalar>]
public partial record JoulePerMol
{
    public static string UnitSymbol { get; } = "J/mol";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["joule/mol"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}
