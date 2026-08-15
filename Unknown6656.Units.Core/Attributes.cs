using System.Numerics;
using System;

namespace Unknown6656.Units;


[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = true)]
public sealed class DisableEmittingIUnitInterfaces : Attribute;

/// <summary>
/// Defines the following relationship between two quantities:
/// <code>
///     <typeparamref name="TQuantityA"/> * <typeparamref name="TQuantityB"/> = <typeparamref name="TQuantityC"/>
///     <br/>
///     <typeparamref name="TBaseUnitA"/> * <typeparamref name="TBaseUnitB"/> = <typeparamref name="TBaseUnitC"/>
/// </code>
/// If a value is provided for <paramref name="x"/>, the relationship is defined as follows:
/// <code>
///     <typeparamref name="TBaseUnitA"/> * <typeparamref name="TBaseUnitB"/> * <paramref name="x"/> = <typeparamref name="TBaseUnitC"/>
/// </code>
/// <para/>
/// This naturally implies:
/// <code>
///     <typeparamref name="TBaseUnitC"/> / <typeparamref name="TBaseUnitA"/> = <typeparamref name="TBaseUnitB"/> * <paramref name="x"/>
///     <typeparamref name="TBaseUnitC"/> / <typeparamref name="TBaseUnitB"/> = <typeparamref name="TBaseUnitA"/> * <paramref name="x"/>
/// </code>
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
public class MultiplicativeRelationship<TQuantityA, TQuantityB, TQuantityC, TBaseUnitA, TBaseUnitB, TBaseUnitC, TScalar>(TScalar? x = default)
    : Attribute
    where TQuantityA : Quantity<TQuantityA, TBaseUnitA, TScalar>
                     , IQuantity<TQuantityA>
    where TQuantityB : Quantity<TQuantityB, TBaseUnitB, TScalar>
                     , IQuantity<TQuantityB>
    where TQuantityC : Quantity<TQuantityC, TBaseUnitC, TScalar>
                     , IQuantity<TQuantityC>
    where TBaseUnitA : BaseUnit<TQuantityA, TBaseUnitA, TScalar>
                     , IBaseUnit<TBaseUnitA, TScalar>
                     , IUnit
    where TBaseUnitB : BaseUnit<TQuantityB, TBaseUnitB, TScalar>
                     , IBaseUnit<TBaseUnitB, TScalar>
                     , IUnit
    where TBaseUnitC : BaseUnit<TQuantityC, TBaseUnitC, TScalar>
                     , IBaseUnit<TBaseUnitC, TScalar>
                     , IUnit
    where TScalar : INumber<TScalar>;

/// <summary>
/// Defines the following relationship between two quantities:
/// <code>
///     <typeparamref name="TQuantityA"/> ^ 2 = <typeparamref name="TQuantityB"/>
///     <br/>
///     <typeparamref name="TBaseUnitA"/> ^ 2 = <typeparamref name="TBaseUnitB"/>
/// </code>
/// If a value is provided for <paramref name="x"/>, the relationship is defined as follows:
/// <code>
///     <typeparamref name="TBaseUnitA"/> ^ 2 * <paramref name="x"/> = <typeparamref name="TBaseUnitB"/>
/// </code>
/// This naturally implies
/// <code>
///     <typeparamref name="TBaseUnitB"/> / <typeparamref name="TBaseUnitA"/> = <typeparamref name="TBaseUnitA"/> * <paramref name="x"/>
/// </code>
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
#warning TODO: rename to 'QuadraticRelationship' or 'PowerRelationship'
public class MultiplicativeRelationship<TQuantityA, TQuantityB, TBaseUnitA, TBaseUnitB, TScalar>(TScalar? x = default)
    : MultiplicativeRelationship<TQuantityA, TQuantityA, TQuantityB, TBaseUnitA, TBaseUnitA, TBaseUnitB, TScalar>(x)
    where TQuantityA : Quantity<TQuantityA, TBaseUnitA, TScalar>
                     , IQuantity<TQuantityA>
    where TQuantityB : Quantity<TQuantityB, TBaseUnitB, TScalar>
                     , IQuantity<TQuantityB>
    where TBaseUnitA : BaseUnit<TQuantityA, TBaseUnitA, TScalar>
                     , IBaseUnit<TBaseUnitA, TScalar>
                     , IUnit
    where TBaseUnitB : BaseUnit<TQuantityB, TBaseUnitB, TScalar>
                     , IBaseUnit<TBaseUnitB, TScalar>
                     , IUnit
    where TScalar : INumber<TScalar>;

/// <summary>
/// Defines the following relationship between two quantities:
/// <code>
///     1 / <typeparamref name="TQuantityA"/> = <typeparamref name="TQuantityB"/>
///     <br/>
///     1 / <typeparamref name="TBaseUnitA"/> = <typeparamref name="TBaseUnitB"/>
/// </code>
/// If a value is provided for <paramref name="x"/>, the relationship is defined as follows:
/// <code>
///     <paramref name="x"/> / <typeparamref name="TBaseUnitA"/> = <typeparamref name="TBaseUnitB"/>
/// </code>
/// This naturally implies
/// <code>
///     <typeparamref name="TBaseUnitB"/> * <typeparamref name="TBaseUnitA"/> = <paramref name="x"/>
/// </code>
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
public class InverseRelationship<TQuantityA, TQuantityB, TBaseUnitA, TBaseUnitB, TScalar>(TScalar? x = default)
    : MultiplicativeRelationship<TQuantityA, TQuantityA, TQuantityB, TBaseUnitA, TBaseUnitA, TBaseUnitB, TScalar>(x)
    where TQuantityA : Quantity<TQuantityA, TBaseUnitA, TScalar>
                     , IQuantity<TQuantityA>
    where TQuantityB : Quantity<TQuantityB, TBaseUnitB, TScalar>
                     , IQuantity<TQuantityB>
    where TBaseUnitA : BaseUnit<TQuantityA, TBaseUnitA, TScalar>
                     , IBaseUnit<TBaseUnitA, TScalar>
                     , IUnit
    where TBaseUnitB : BaseUnit<TQuantityB, TBaseUnitB, TScalar>
                     , IBaseUnit<TBaseUnitB, TScalar>
                     , IUnit
    where TScalar : INumber<TScalar>;

/// <summary>
/// Defines the following relationship between two quantities:
/// <code>
///     <typeparamref name="TQuantityA"/> = <typeparamref name="TQuantityB"/>
///     <br/>
///     <typeparamref name="TBaseUnitA"/> = <typeparamref name="TBaseUnitB"/>
/// </code>
/// If a value is provided for <paramref name="x"/>, the relationship is defined as follows:
/// <code>
///     <typeparamref name="TBaseUnitA"/> * <paramref name="x"/> = <typeparamref name="TBaseUnitB"/>
/// </code>
/// This naturally implies
/// <code>
///     <typeparamref name="TBaseUnitB"/> / <paramref name="x"/> = <typeparamref name="TBaseUnitA"/>
/// </code>
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
public class IdentityRelationship<TQuantityA, TQuantityB, TBaseUnitA, TBaseUnitB, TScalar>(TScalar? x = default)
    : MultiplicativeRelationship<TQuantityA, TQuantityA, TQuantityB, TBaseUnitA, TBaseUnitA, TBaseUnitB, TScalar>(x)
    where TQuantityA : Quantity<TQuantityA, TBaseUnitA, TScalar>
                     , IQuantity<TQuantityA>
    where TQuantityB : Quantity<TQuantityB, TBaseUnitB, TScalar>
                     , IQuantity<TQuantityB>
    where TBaseUnitA : BaseUnit<TQuantityA, TBaseUnitA, TScalar>
                     , IBaseUnit<TBaseUnitA, TScalar>
                     , IUnit
    where TBaseUnitB : BaseUnit<TQuantityB, TBaseUnitB, TScalar>
                     , IBaseUnit<TBaseUnitB, TScalar>
                     , IUnit
    where TScalar : INumber<TScalar>;


// TODO : multiplicative relationship for non-base units
// TODO : inverse relationship for non-base units


public enum KnownUnitType
{
    Linear,
    Affine,
    Arbitrary,
    //Logarithmic,
    //Exponential,
}

public enum KnownRelativeUnitType
{
    Linear,
    Logarithmic,
}

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
public abstract class UnitAttribute<TScalar> : Attribute where TScalar : INumber<TScalar>;

/// <summary>
/// Indicates to the source generator that this data type represents a known unit of measurement.
/// <br/>
/// You can use this attribute as follows:
/// <code>
///     [<see cref="KnownUnit"/>&lt;Length, Yard, Meter, <see langword="double"/>&gt;]
///     <see langword="public partial record"/> Yard
///     {
///         <see langword="public static string"/> UnitSymbol { <see langword="get"/>; } = "yd";
///         <see langword="public static"/> <see cref="UnitDisplay"/> UnitDisplay { <see langword="get"/>; } = <see cref="UnitDisplay.Imperial"/>;
///         <see langword="public static double"/> ScalingFactor { <see langword="get"/>; } = 1.0936132983377078;
///     }
/// </code>
/// <para/>
/// ------
/// <para/>
/// <b>
///     DO NOT FORGET TO REMOVE THE FOLLOWING TYPE ANNOTATIONS WHEN USING THIS ATTRIBUTE!
/// </b>
/// <code>
///     [<see cref="KnownUnit{TQuantity, TUnit, TBaseUnit, TScalar}"/>]
///     <see langword="public partial record"/> <typeparamref name="TUnit"/> ....
///         : ....
///         , <see cref="IUnit{TUnit, TBaseUnit, TScalar}"/> // &lt;-- this one<br/>
///         , <see cref="IUnit"/>                            // &lt;-- and this one
/// </code>
/// <para/>
/// Alternatively, use the following attribute on the assembly:
/// <code>
///     [<see langword="assembly"/>: <see cref="DisableEmittingIUnitInterfaces"/>]
/// </code>
/// </summary>
public class KnownUnit<TQuantity, TUnit, TBaseUnit, TScalar>(KnownUnitType type)
    : UnitAttribute<TScalar>
    where TQuantity : Quantity<TQuantity, TBaseUnit, TScalar>
                    , IQuantity<TQuantity>
    where TUnit : Quantity<TQuantity, TBaseUnit, TScalar>.Unit<TUnit>
                , IUnit<TUnit, TBaseUnit, TScalar>
                , IUnit
    where TBaseUnit : BaseUnit<TQuantity, TBaseUnit, TScalar>
                    , IBaseUnit<TBaseUnit, TScalar>
                    , IUnit
    where TScalar : INumber<TScalar>
{
    public KnownUnitType UnitType => type;
}

/// <summary>
/// Indicates to the source generator that this data type represents a known base unit of measurement.
/// <br/>
/// You can use this attribute as follows:
/// <code>
///     [<see cref="KnownBaseUnit"/>&lt;Length, Meter, <see langword="double"/>&gt;]
///     <see langword="public partial record"/> Meter
///     {
///         <see langword="public static string"/> UnitSymbol { <see langword="get"/>; } = "m";
///         <see langword="public static"/> <see cref="UnitDisplay"/> UnitDisplay { <see langword="get"/>; } = <see cref="UnitDisplay.MetricUseSIPrefixes"/>;
///     }
/// </code>
/// <para/>
/// ------
/// <para/>
/// <b>
///     DO NOT FORGET TO REMOVE THE FOLLOWING TYPE ANNOTATIONS WHEN USING THIS ATTRIBUTE!
/// </b>
/// <code>
///     [<see cref="KnownBaseUnit{TQuantity, TBaseUnit, TScalar}"/>]
///     <see langword="public partial record"/> <typeparamref name="TBaseUnit"/> ....
///         : ....
///         , <see cref="IBaseUnit{TBaseUnit, TScalar}"/> // &lt;-- this one<br/>
///         , <see cref="IUnit"/>                         // &lt;-- and this one
/// </code>
/// <para/>
/// Alternatively, use the following attribute on the assembly:
/// <code>
///     [<see langword="assembly"/>: <see cref="DisableEmittingIUnitInterfaces"/>]
/// </code>
/// </summary>
public class KnownBaseUnit<TQuantity, TBaseUnit, TScalar>()
    : KnownUnit<TQuantity, TBaseUnit, TBaseUnit, TScalar>(KnownUnitType.Linear)
    where TQuantity : Quantity<TQuantity, TBaseUnit, TScalar>
                    , IQuantity<TQuantity>
    where TBaseUnit : BaseUnit<TQuantity, TBaseUnit, TScalar>
                    , IBaseUnit<TBaseUnit, TScalar>
                    , IUnit
    where TScalar : INumber<TScalar>;

/// <summary>
/// Indicates to the source generator that this data type represents a known relative unit of measurement, e.g. "dB", "%", "ppm", etc.
/// <br/>
/// You can use this attribute as follows:
/// <code>
///     [<see cref="KnownRelativeUnit"/>&lt;Decibel, <see langword="double"/>&gt;]
///     <see langword="public partial record"/> Decibel
///     {
///         <see langword="public static string"/> UnitSymbol { <see langword="get"/>; } = "dB";
///         <see langword="public static double"/> Base { <see langword="get"/>; } = 10;
///         <see langword="public static double"/> PowerFactor { <see langword="get"/>; } = 10;
///         <see langword="public static double"/> AmplitudeFactor { <see langword="get"/>; } = 20;
///     }
/// </code>
/// </summary>
public class KnownRelativeUnit<TScalar>(KnownRelativeUnitType type)
    : UnitAttribute<TScalar>
    where TScalar : INumber<TScalar>
{
    public KnownRelativeUnitType UnitType => type;
}

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
public class KnownAlias<TQuantity, TBaseUnit, TScalar>(string name, string unit_symbol, params string[] alternative_symbols)
    : Attribute
    where TQuantity : Quantity<TQuantity, TBaseUnit, TScalar>
                    , IQuantity<TQuantity>
    where TBaseUnit : BaseUnit<TQuantity, TBaseUnit, TScalar>
                    , IBaseUnit<TBaseUnit, TScalar>
                    , IUnit
    where TScalar : INumber<TScalar>;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
public class KnownAlias<TQuantity, TUnit, TBaseUnit, TScalar>(string name, string unit_symbol, params string[] alternative_symbols)
    : KnownAlias<TQuantity, TBaseUnit, TScalar>(name, unit_symbol, alternative_symbols)
    where TQuantity : Quantity<TQuantity, TBaseUnit, TScalar>
                    , IQuantity<TQuantity>
    where TUnit : Quantity<TQuantity, TBaseUnit, TScalar>.Unit<TUnit>
                , IUnit<TUnit, TBaseUnit, TScalar>
                , IUnit
    where TBaseUnit : BaseUnit<TQuantity, TBaseUnit, TScalar>
                    , IBaseUnit<TBaseUnit, TScalar>
                    , IUnit
    where TScalar : INumber<TScalar>;

//[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
//public class DontEmitProperties : Attribute;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class ForwardToUnits : Attribute;
