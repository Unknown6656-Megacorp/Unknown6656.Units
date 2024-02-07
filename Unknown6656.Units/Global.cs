#if USE_PURE_ASCII && USE_DIACRITICS
    #warning The preprocessor flags 'USE_DIACRITICS' and 'USE_PURE_ASCII' are mutually exclusive. 'USE_PURE_ASCII' will take precedence.

    #undef USE_DIACRITICS
#endif

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
