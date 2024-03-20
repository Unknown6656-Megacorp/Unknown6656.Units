using System;

namespace Unknown6656.Units.Information;


[KnownBaseUnit<InformationCapacity, Bit, Scalar>]
[KnownAlias<InformationCapacity, Bit, Scalar>("Shannon", "Sh")]
public partial record Bit
{
    public static string UnitSymbol { get; } = "bit";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["unibit", "sniff"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
}

[KnownUnit<InformationCapacity, Byte, Bit, Scalar>(KnownUnitType.Linear)]
[KnownAlias<InformationCapacity, Byte, Bit, Scalar>("Octet", "o", "oct")]
public partial record Byte
{
    public static string UnitSymbol { get; } = "B";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar).125;
}

[KnownUnit<InformationCapacity, Nibble, Bit, Scalar>(KnownUnitType.Linear)]
public partial record Nibble
{
    public static string UnitSymbol { get; } = "nybl";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["nibl", "nybble", "nyble", "nible"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar).25;
}

[KnownUnit<InformationCapacity, Crumb, Bit, Scalar>(KnownUnitType.Linear)]
public partial record Crumb
{
    public static string UnitSymbol { get; } = "crumb";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["dibit", "tidbit", "snort", "nyp"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar).5;
}

[KnownUnit<InformationCapacity, Trit, Bit, Scalar>(KnownUnitType.Linear)]
public partial record Trit
{
    public static string UnitSymbol { get; } = "trit";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["tribit", "triad", "tribble", "triade"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)(1 / Math.Log2(3));
}

[KnownUnit<InformationCapacity, Dit, Bit, Scalar>(KnownUnitType.Linear)]
public partial record Dit
{
    public static string UnitSymbol { get; } = "dit";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["decit", "ban", "hartley", "dec digit", "decimal digit"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)(1 / Math.Log2(10));
}

[KnownUnit<InformationCapacity, Nat, Bit, Scalar>(KnownUnitType.Linear)]
public partial record Nat
{
    public static string UnitSymbol { get; } = "nat";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["nit", "nepit"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricUseSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)(1 / Math.Log2(Math.E));
}

[KnownUnit<InformationCapacity, Word, Bit, Scalar>(KnownUnitType.Linear)]
public partial record Word
{
    public static string UnitSymbol { get; } = "WORD";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar).03125;
}

[KnownUnit<InformationCapacity, DoubleWord, Bit, Scalar>(KnownUnitType.Linear)]
public partial record DoubleWord
{
    public static string UnitSymbol { get; } = "DWORD";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar).015625;
}

[KnownUnit<InformationCapacity, QuadWord, Bit, Scalar>(KnownUnitType.Linear)]
public partial record QuadWord
{
    public static string UnitSymbol { get; } = "QWORD";
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar).0078125;
}

[KnownUnit<InformationCapacity, CDROM, Bit, Scalar>(KnownUnitType.Linear)]
public partial record CDROM
{
    public static string UnitSymbol { get; } = "CD-ROM";
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["compact disk", "cd", "read only CD", "ROM CD", "ro CD", "read only compact disk",
        "compact disk ro", "compact disk ROM", "compact disk read only"
    ];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.MetricNoSIPrefixes;
    public static Scalar ScalingFactor { get; } = (Scalar)1.5384615384615384615384615384615384615384615384615384615384e-9;
}

[KnownUnit<InformationCapacity, FloppyDisk3_5, Bit, Scalar>(KnownUnitType.Linear)]
public partial record FloppyDisk3_5
{
#if USE_PURE_ASCII
    public static string UnitSymbol { get; } = "3.5in floppy";
#else
    public static string UnitSymbol { get; } = "3½\" floppy";
#endif
    static string[] IUnit.AlternativeUnitSymbols { get; } = ["floppy", "floppy 3.5in", "floppy 3.5inch", "floppy 3.5\"", "floppy disk", "floppy diskette", "diskette"];
    public static UnitDisplay UnitDisplay { get; } = UnitDisplay.Imperial;
    public static Scalar ScalingFactor { get; } = (Scalar)6.94444444444444444444444444444444444444444444444444444444e-7;
}
