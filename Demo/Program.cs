using System;

using Unknown6656.Units.Electricity;
using Unknown6656.Units.Radioactivity;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Kinematics;
using Unknown6656.Units.Matter;
using Unknown6656.Units.Energy;
using Unknown6656.Units.Thermodynamics;
using Unknown6656.Units;

using System.Diagnostics;


Temperature temp1 = "-14 degrees celsius";
Temperature temp2 = "-14°F";
Temperature temp3 = "14 kelvin";

temp3 *= 10;

Acceleration a = (G)1;
Mass m = "10.75 kg";
Force f = m * a;
Length l = 1d.Meter();
NewtonMeter t = f * l;
Speed s = "1 Mach";
Time tt = s / a;

var time2die = EquivalentDose.HumanLD50_In30Days / DoseRate.FukushimaDaiichi2017;

(var jpk, var gray, var sievert) = Joule.One / (Kilogram)"72 kg";
JoulePerKilogram jpkg = sievert; // <--- why the fuck does that shit throw an stack overflow execption??!?

Debugger.Break();
