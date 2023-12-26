#if F16
global using scalar = System.Half;
#elif F32
global using scalar = float;
#elif F64
global using scalar = double;
#elif D128
global using scalar = decimal;
#else
global using scalar = double;
#endif
