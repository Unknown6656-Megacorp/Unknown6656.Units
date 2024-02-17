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


/// <summary>
/// <b>
///     DO NOT FORGET TO REMOVE THE FOLLOWING TYPE ANNOTATIONS WHEN USING THIS ATTRIBUTE!
/// </b>
/// <code>
///     [<see cref="KnownUnit{TQuantity, TUnit, TBaseUnit, TScalar}"/>]
///     <see langword="public record"/> ....
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
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
public class KnownUnit<TQuantity, TUnit, TBaseUnit, TScalar>
    : Attribute
    where TQuantity : Quantity<TQuantity, TBaseUnit, TScalar>
                    , IQuantity<TQuantity>
    where TUnit : Quantity<TQuantity, TBaseUnit, TScalar>.Unit<TUnit>
                , IUnit<TUnit, TBaseUnit, TScalar>
                , IUnit
    where TBaseUnit : BaseUnit<TQuantity, TBaseUnit, TScalar>
                    , IBaseUnit<TBaseUnit, TScalar>
                    , IUnit
    where TScalar : INumber<TScalar>;

/// <summary>
/// <b>
///     DO NOT FORGET TO REMOVE THE FOLLOWING TYPE ANNOTATIONS WHEN USING THIS ATTRIBUTE!
/// </b>
/// <code>
///     [<see cref="KnownBaseUnit{TQuantity, TBaseUnit, TScalar}"/>]
///     <see langword="public record"/> ....
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
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
public class KnownBaseUnit<TQuantity, TBaseUnit, TScalar>
    : KnownUnit<TQuantity, TBaseUnit, TBaseUnit, TScalar>
    where TQuantity : Quantity<TQuantity, TBaseUnit, TScalar>
                    , IQuantity<TQuantity>
    where TBaseUnit : BaseUnit<TQuantity, TBaseUnit, TScalar>
                    , IBaseUnit<TBaseUnit, TScalar>
                    , IUnit
    where TScalar : INumber<TScalar>;

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
