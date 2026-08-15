namespace Unknown6656.Units.Relative;


[KnownRelativeUnit<Scalar>(KnownRelativeUnitType.Linear)]
public partial record Percent
{
    public static double Factor { get; } = .01;
    public static string UnitSymbol { get; } = "%";
}

[KnownRelativeUnit<Scalar>(KnownRelativeUnitType.Linear)]
public partial record Permille
{
    public static double Factor { get; } = .001;
    public static string UnitSymbol { get; } = "‰";
}

[KnownRelativeUnit<Scalar>(KnownRelativeUnitType.Linear)]
public partial record PerMyriad
{
    public static double Factor { get; } = .0001;
    public static string UnitSymbol { get; } = "‱";
}

[KnownRelativeUnit<Scalar>(KnownRelativeUnitType.Linear)]
public partial record PartPerMillion
{
    public static double Factor { get; } = 1e-6;
    public static string UnitSymbol { get; } = "ppm";
}

[KnownRelativeUnit<Scalar>(KnownRelativeUnitType.Linear)]
public partial record PartPerBillion
{
    public static double Factor { get; } = 1e-9;
    public static string UnitSymbol { get; } = "ppb";
}

[KnownRelativeUnit<Scalar>(KnownRelativeUnitType.Linear)]
public partial record PartPerTrillion
{
    public static double Factor { get; } = 1e-12;
    public static string UnitSymbol { get; } = "ppt";
}
