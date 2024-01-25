using System;

using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Movement;
using Unknown6656.Units.Matter;
using Unknown6656.Units;

using System.Diagnostics;


Acceleration a = "1 G";
Mass m = 10.75.Kilogram();
Force f = m * a;
Length l = 1d.Meter();
NewtonMeter t = f * l;
Speed s = "1 Mach";
Time tt = s / a;


Debugger.Break();
