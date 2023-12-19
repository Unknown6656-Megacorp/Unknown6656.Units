#if F16
global using scalar = System.Half;
#elif F32
global using scalar = float;
#elif F64
global using scalar = double;
#elif F128
global using scalar = decimal;
#elif I8
global using scalar = sbyte;
#elif I16
global using scalar = short;
#elif I32
global using scalar = int;
#elif I64
global using scalar = long;
#elif I128
global using scalar = System.Int128;
#else
global using scalar = double;
#endif
