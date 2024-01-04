#if F16
global using Scalar = System.Half;
#elif F32
global using Scalar = float;
#elif F64
global using Scalar = double;
#elif D128
global using Scalar = decimal;
#else
global using Scalar = double;
#endif

#if USE_DIACRITICS
// TODO
#endif
