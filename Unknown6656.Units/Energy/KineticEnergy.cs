namespace Unknown6656.Units.Energy;


[KnownBaseUnit<KineticEnergy, Joule, Scalar>]
public partial record Joule(Scalar Value)
    : BaseUnit<KineticEnergy, Joule, Scalar>(Value)
{
    public static string UnitSymbol { get; } = "J";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricSI;
}







// TODO:
// (https://en.wikipedia.org/wiki/Luminous_intensity)
// - luminous intensity
//      - cd
// - luminous flux
//      - lm
// - luminous energy
//      - lm·s
// - illuminance
//      - lx
// - luminance
//      - cd/m^2
// - luminous exposure
//      - lx·s
//
// - from cd, lm, lx, cd/m^2, ...
// - from candela, lumen, lux, candela/m^2, ...
