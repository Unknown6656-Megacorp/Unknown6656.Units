using System.Collections.Immutable;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace Unknown6656.Units.Internals;


[Generator(LanguageNames.CSharp)]
public sealed class QuantityDependencyGenerator
    : IIncrementalGenerator
{
    public const string Identifier_DisableEmittingIUnitInterfaces = "Unknown6656.Units.DisableEmittingIUnitInterfaces";
    public const string Identifier_MultiplicativeQuantityRelationship = "Unknown6656.Units.MultiplicativeQuantityRelationship";
    public const string Identifier_InverseQuantityRelationship = "Unknown6656.Units.InverseQuantityRelationship";
    public const string Identifier_KnownBaseUnit = "Unknown6656.Units.KnownBaseUnit";
    public const string Identifier_KnownUnit = "Unknown6656.Units.KnownUnit";
    public static readonly Identifier Identifier_ExtensionClass = "Unknown6656.Units.Unit";


    #region DIAGNOSTIC ERRORS

    private static readonly DiagnosticDescriptor _diagnostic_requires_record = new (
        "U6656_001",
        "The target quantity type must be declared as record",
        "The target quantity type '{0}' must be declared as record",
        "Unknown6656.Units",
        DiagnosticSeverity.Error,
        true
    );
    private static readonly DiagnosticDescriptor _diagnostic_requires_partial = new(
        "U6656_002",
        "The target quantity type must be declared as 'partial'",
        "The target quantity type '{0}' must be declared as 'partial'",
        "Unknown6656.Units",
        DiagnosticSeverity.Error,
        true
    );
    private static readonly DiagnosticDescriptor _diagnostic_requires_quantity_as_attribute_argument = new(
        "U6656_003",
        "The target quantity type must be part of the attribute type arguments",
        "The target quantity type '{0}' must be part of the attribute type arguments",
        "Unknown6656.Units",
        DiagnosticSeverity.Error,
        true
    );
    private static readonly DiagnosticDescriptor _diagnostic_requires_unit_as_attribute_argument = new(
        "U6656_004",
        "The target unit type must be the second generic attribute type argument",
        "The target unit type '{0}' must be the second generic attribute type argument",
        "Unknown6656.Units",
        DiagnosticSeverity.Error,
        true
    );
    private static readonly DiagnosticDescriptor _diagnostic_unable_to_resolve_quantity = new(
        "U6656_005",
        "The quantity type could not be resolved",
        "The quantity type '{0}' could not be resolved",
        "Unknown6656.Units",
        DiagnosticSeverity.Error,
        true
    );
    private static readonly DiagnosticDescriptor _diagnostic_unable_to_resolve_unit = new(
        "U6656_006",
        "The unit type could not be resolved",
        "The unit type '{0}' could not be resolved",
        "Unknown6656.Units",
        DiagnosticSeverity.Error,
        true
    );
    private static readonly DiagnosticDescriptor _diagnostic_unable_to_resolve_symbol = new(
        "U6656_007",
        "The symbol could not be resolved",
        "The symbol '{0}' could not be resolved",
        "Unknown6656.Units",
        DiagnosticSeverity.Error,
        true
    );
    private static readonly DiagnosticDescriptor _diagnostic_quantities_must_be_different = new(
        "U6656_008",
        "The quantity used as operator result must not be one of the operands",
        "The quantity '{0}' used as operator result must not be one of the operands",
        "Unknown6656.Units",
        DiagnosticSeverity.Error,
        true
    );

    #endregion


    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        //Debugger.Launch();

        IncrementalValuesProvider<GenericAttributeClassUsage> quantity_multiplicative_dependencies = FetchTypeDeclarationsByAttribute(context, Identifier_MultiplicativeQuantityRelationship);
        IncrementalValuesProvider<GenericAttributeClassUsage> quantity_inverse_dependencies = FetchTypeDeclarationsByAttribute(context, Identifier_InverseQuantityRelationship);
        IncrementalValuesProvider<GenericAttributeClassUsage> known_base_units = FetchTypeDeclarationsByAttribute(context, Identifier_KnownBaseUnit);
        IncrementalValuesProvider<GenericAttributeClassUsage> known_units = FetchTypeDeclarationsByAttribute(context, Identifier_KnownUnit);
        IncrementalValuesProvider<bool> disable_emitting_iunit_interfaces = context.SyntaxProvider
                                                                                   .CreateSyntaxProvider(
                                                                                       predicate: static (s, _) => s is AttributeListSyntax { Attributes.Count: > 0 },
                                                                                       transform: (ctx, _) => HasDisableEmittingIUnitInterfacesDefined(ctx)
                                                                                   )
                                                                                   .Where(static x => x);

        // which idiot decided to name this stuff "left" and "right"? and not to provide an extension method for combining 3 or more IncrementalValueProvider<>?
        var combined = context.CompilationProvider.Combine(quantity_multiplicative_dependencies.Collect())
                                                  .Combine(quantity_inverse_dependencies.Collect())
                                                  .Select(static (t, _) => (compilation: t.Left.Left, mul_dependencies: t.Left.Right, inv_dependencies: t.Right))
                                                  .Combine(known_base_units.Collect())
                                                  .Select(static (t, _) => (t.Left.compilation, t.Left.mul_dependencies, t.Left.inv_dependencies, base_units: t.Right))
                                                  .Combine(known_units.Collect())
                                                  .Select(static (t, _) => (t.Left.compilation, t.Left.mul_dependencies, t.Left.inv_dependencies, t.Left.base_units, units: t.Right))
                                                  .Combine(disable_emitting_iunit_interfaces.Collect())
                                                  .Select(static (t, _) => (t.Left.compilation, t.Left.mul_dependencies, t.Left.inv_dependencies, t.Left.base_units, t.Left.units, disable: t.Right.Contains(true)));

        context.RegisterSourceOutput(combined, (spc, source) => Execute(
            context,
            spc,
            source.compilation,
            source.mul_dependencies,
            source.inv_dependencies,
            source.base_units,
            source.units,
            source.disable
        ));
    }

    private static IncrementalValuesProvider<GenericAttributeClassUsage> FetchTypeDeclarationsByAttribute(IncrementalGeneratorInitializationContext context, string attribute_name) => context.SyntaxProvider
        .CreateSyntaxProvider(
            predicate: static (s, _) => s is TypeDeclarationSyntax { AttributeLists.Count: > 0 },
            transform: (ctx, _) => GetGenericAttributeClassUsage(ctx, attribute_name)
        )
        .Where(static m => m is not null)!;

    private static bool HasDisableEmittingIUnitInterfacesDefined(GeneratorSyntaxContext context)
    {
        if (context.Node is AttributeListSyntax { Target.Identifier: { } identifier, Attributes: { } attributes } && identifier.IsKind(SyntaxKind.AssemblyKeyword))
            foreach (AttributeSyntax attribute in attributes)
                if (context.SemanticModel.GetSymbolInfo(attribute).Symbol is ISymbol { ContainingType: ITypeSymbol attr_type })
                {
                    string attr_name = attr_type.ToDisplayString();

                    if (attr_name == Identifier_DisableEmittingIUnitInterfaces)
                        return true;
                }

        return false;
    }

    private static GenericAttributeClassUsage? GetGenericAttributeClassUsage(GeneratorSyntaxContext context, string attribute_name)
    {
        if (context.Node is TypeDeclarationSyntax node)
        {
            string @namespace = node.Ancestors().OfType<BaseNamespaceDeclarationSyntax>().FirstOrDefault()?.Name.ToString() ?? "";

            foreach (AttributeListSyntax attributes in node.AttributeLists)
                foreach (AttributeSyntax attribute in attributes.Attributes)
                    if (attribute is { Name: GenericNameSyntax { TypeArgumentList.Arguments: { } raw_generic_arguments } })
                        if (context.SemanticModel.GetSymbolInfo(attribute).Symbol is ISymbol { ContainingType: ITypeSymbol attr_type })
                            if (attr_type.ToDisplayString().StartsWith(attribute_name + "<"))
                            {
                                string[] generic_arguments = raw_generic_arguments.Select(genarg => context.SemanticModel.GetSymbolInfo(genarg).Symbol?.ToDisplayString() ?? genarg.ToString())
                                                                                  .ToArray();

                                return new(context.SemanticModel, @namespace, attribute.GetLocation(), node, generic_arguments, attribute.ArgumentList?.Arguments.ToArray() ?? []);
                            }
        }

        return null;
    }

    private static void Execute(
        IncrementalGeneratorInitializationContext incremental_context,
        SourceProductionContext production_context,
        Compilation compilation,
        ImmutableArray<GenericAttributeClassUsage> quantity_multiplicative_dependencies,
        ImmutableArray<GenericAttributeClassUsage> quantity_inverse_dependencies,
        ImmutableArray<GenericAttributeClassUsage> known_base_units,
        ImmutableArray<GenericAttributeClassUsage> known_units,
        bool disable_emitting_interfaces
    )
#if OLD_CODEBASE
    {
        CancellationToken ct = production_context.CancellationToken;
        StringBuilder sb = new();

        sb.AppendLine($"// THIS FILE IS AUTO-GENERATED BY {nameof(QuantityDependencyGenerator)} ({DateTime.Now}). ALL CHANGES WILL BE LOST!\n");

        Dictionary<string, (List<string> units, string? base_unit)> known_units_dict = [];
        Dictionary<string, string> unit_scalar_mapper = [];

        foreach (GenericAttributeClassUsage usage in known_units)
            if (usage.TargetSymbol?.ToDisplayString() is string target_name)
            {
                if (usage.TargetType is not RecordDeclarationSyntax record)
                    production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_record, usage.AttributeLocation, [target_name]));
                else if (record.Modifiers.IndexOf(SyntaxKind.PartialKeyword) < 0)
                    production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_partial, usage.AttributeLocation, [target_name]));
                else if (usage.GenericAttributeArguments.Length < 2 || usage.GenericAttributeArguments[1].ToString() != target_name)
                    production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_unit_as_attribute_argument, usage.AttributeLocation, [target_name]));
                else
                {
                    string quantity = usage.GenericAttributeArguments[0].ToString();

                    if (!known_units_dict.TryGetValue(quantity, out var entry))
                        entry = ([target_name], null);
                    else
                        entry.units.Add(target_name);

                    known_units_dict[quantity] = entry;
                    unit_scalar_mapper[target_name] = usage.GenericAttributeArguments.Last();
                }
            }

        foreach (GenericAttributeClassUsage usage in known_base_units)
            if (usage.TargetSymbol?.ToDisplayString() is string target_name)
            {
                if (usage.TargetType is not RecordDeclarationSyntax record)
                    production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_record, usage.AttributeLocation, [target_name]));
                else if (record.Modifiers.IndexOf(SyntaxKind.PartialKeyword) < 0)
                    production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_partial, usage.AttributeLocation, [target_name]));
                else if (usage.GenericAttributeArguments.Length < 2 || usage.GenericAttributeArguments[1].ToString() != target_name)
                    production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_unit_as_attribute_argument, usage.AttributeLocation, [target_name]));
                else
                {
                    string quantity = usage.GenericAttributeArguments[0].ToString();

                    if (!known_units_dict.TryGetValue(quantity, out var entry))
                        entry = ([], target_name);
                    else
                        entry.base_unit = target_name;

                    known_units_dict[quantity] = entry;
                    unit_scalar_mapper[target_name] = usage.GenericAttributeArguments.Last();
                }
            }

        foreach (var kvp in known_units_dict)
        {
            List<string> units = [.. kvp.Value.units];

            if (kvp.Value.base_unit is { } base_unit)
                units.Add(base_unit);

            foreach (string unit in units)
            {
                string interfaces = disable_emitting_iunit_interfaces ? "" :
                    $": IUnit, {(unit == kvp.Value.base_unit ? $"IBaseUnit<{unit}, {unit_scalar_mapper[unit]}>" : $"IUnit<{unit}, {kvp.Value.base_unit}, {unit_scalar_mapper[unit]}>")}";

                sb.AppendLine($$""""
                namespace {{GetNamespace(unit)}}
                {
                    partial record {{GetTypeName(unit)}} {{interfaces}}
                    {
                """");

                foreach (string target_unit in units)
                    if (target_unit != unit)
                        sb.AppendLine($$""""
                        public {{target_unit}} {{GetTypeName(target_unit)}} => ({{target_unit}})this;
                """");

                sb.AppendLine($$""""
                    }
                }
                """");
            }

            for (int i = 0; i < units.Count - 1; ++i)
            {
                string unit = units[i];

                sb.AppendLine($$""""
                namespace {{GetNamespace(unit)}}
                {
                    partial record {{GetTypeName(unit)}}
                    {
                        public static implicit operator {{unit}}({{kvp.Key}} unit) => {{unit}}.FromBaseUnit(unit.Value);
                """");

                for (int j = i + 1; j < units.Count; ++j)
                    sb.AppendLine($$"""
                        public static implicit operator {{units[j]}}({{unit}} unit) => {{units[j]}}.FromBaseUnit(unit.ToBaseUnit());
                        public static implicit operator {{unit}}({{units[j]}} unit) => {{unit}}.FromBaseUnit(unit.ToBaseUnit());
                """);

                sb.AppendLine($$""""
                    }
                }
                """");
            }
        }

        foreach (GenericAttributeClassUsage usage in quantity_multiplicative_dependencies)
            if (usage.TargetSymbol?.ToDisplayString() is string target_name)
            {
                if (usage.TargetType is not RecordDeclarationSyntax record)
                    production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_record, usage.AttributeLocation, [target_name]));
                else if (record.Modifiers.IndexOf(SyntaxKind.PartialKeyword) < 0)
                    production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_partial, usage.AttributeLocation, [target_name]));
                else if (!usage.GenericAttributeArguments.Contains(target_name))
                    production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_quantity_as_attribute_argument, usage.AttributeLocation, [target_name]));
                else
                {
                    string? scaling = usage.AttributeArguments.FirstOrDefault()?.ToString();
                    string? invscaling = null;

                    if (scaling is { })
                    {
                        invscaling = $"/ ({scaling})";
                        scaling = $"* ({scaling})";
                    }

                    string t_quantity_in1, t_quantity_in2, t_quantity_out,
                           t_baseunit_in1, t_baseunit_in2, t_baseunit_out,
                           t_scalar;

                    (t_quantity_in1, t_quantity_in2, t_quantity_out, t_baseunit_in1, t_baseunit_in2, t_baseunit_out, t_scalar) = usage.GenericAttributeArguments switch
                    {
                        { Length: 7 } args => (args[0], args[1], args[2], args[3], args[4], args[5], args[6]),
                        { Length: 5 } args => (args[0], args[0], args[1], args[2], args[2], args[3], args[4]),
                    };

                    sb.AppendLine($$""""
                    namespace {{usage.Namespace}}
                    {
                        public partial record {{record.ClassOrStructKeyword}} {{record.Identifier}}{{record.TypeParameterList}}
                        {
                            // TODO
                        }
                    }

                    namespace {{GetNamespace(t_quantity_in1)}}
                    {
                        partial record {{GetTypeName(t_quantity_in1)}}
                        {
                            public static {{t_quantity_out}} operator *({{t_quantity_in1}} first, {{t_quantity_in2}} second) => new(first.Value * second.Value {{scaling}});
                            public static {{t_quantity_in2}} operator /({{t_quantity_out}} first, {{t_quantity_in1}} second) => new(first.Value / second.Value {{invscaling}});
                    """");

                    if (t_quantity_in1 != t_quantity_in2)
                        sb.AppendLine($$""""
                            public static {{t_quantity_out}} operator *({{t_quantity_in2}} first, {{t_quantity_in1}} second) => new(first.Value * second.Value {{scaling}});
                        }
                    }
                    
                    namespace {{GetNamespace(t_quantity_in2)}}
                    {
                        partial record {{GetTypeName(t_quantity_in2)}}
                        {
                            public static {{t_quantity_in1}} operator /({{t_quantity_out}} first, {{t_quantity_in2}} second) => new(first.Value / second.Value {{invscaling}});
                    """");

                    sb.AppendLine($$""""
                        }
                    }
                    
                    namespace {{GetNamespace(t_baseunit_in1)}}
                    {
                        partial record {{GetTypeName(t_baseunit_in1)}}
                        {
                            public static {{t_baseunit_out}} operator *({{t_baseunit_in1}} first, {{t_baseunit_in2}} second) => new(first.Value * second.Value {{scaling}});
                            public static {{t_baseunit_in2}} operator /({{t_baseunit_out}} first, {{t_baseunit_in1}} second) => new(first.Value / second.Value {{invscaling}});
                    """");

                    if (t_baseunit_in1 != t_baseunit_in2)
                        sb.AppendLine($$""""
                            public static {{t_baseunit_out}} operator *({{t_baseunit_in2}} first, {{t_baseunit_in1}} second) => new(first.Value * second.Value {{scaling}});
                        }
                    }
                    
                    namespace {{GetNamespace(t_baseunit_in2)}}
                    {
                        partial record {{GetTypeName(t_baseunit_in2)}}
                        {
                            public static {{t_baseunit_in1}} operator /({{t_baseunit_out}} first, {{t_baseunit_in2}} second) => new(first.Value / second.Value {{invscaling}});
                    """");

                    sb.AppendLine($$""""
                        }
                    }

                    """");

                    // TODO : use known_units to generate mathematical operators
                }
            }

        foreach (GenericAttributeClassUsage usage in quantity_inverse_dependencies)
            if (usage.TargetSymbol?.ToDisplayString() is string target_name)
            {
                if (usage.TargetType is not RecordDeclarationSyntax record)
                    production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_record, usage.AttributeLocation, [target_name]));
                else if (record.Modifiers.IndexOf(SyntaxKind.PartialKeyword) < 0)
                    production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_partial, usage.AttributeLocation, [target_name]));
                else if (!usage.GenericAttributeArguments.Contains(target_name))
                    production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_quantity_as_attribute_argument, usage.AttributeLocation, [target_name]));
                else
                {
                    string? scaling = usage.AttributeArguments.FirstOrDefault()?.ToString();
                    string? invscaling = null;

                    if (scaling is { })
                    {
                        invscaling = $"/ ({scaling})";
                        scaling = $"* ({scaling})";
                    }

                    string t_quantity_1 = usage.GenericAttributeArguments[0],
                           t_quantity_2 = usage.GenericAttributeArguments[1],
                           t_baseunit_1 = usage.GenericAttributeArguments[2],
                           t_baseunit_2 = usage.GenericAttributeArguments[3],
                           t_scalar = usage.GenericAttributeArguments[4];

                    sb.AppendLine($$""""
                    namespace {{GetNamespace(t_quantity_1)}}
                    {
                        partial record {{GetTypeName(t_quantity_1)}}
                        {
                            public static {{t_scalar}} operator *({{t_quantity_1}} first, {{t_quantity_2}} second) => first.Value * second.Value {{scaling}};
                            public static {{t_quantity_2}} operator /({{t_scalar}} first, {{t_quantity_1}} second) => new(first / second.Value {{invscaling}});
                        }
                    }

                    namespace {{GetNamespace(t_quantity_2)}}
                    {
                        partial record {{GetTypeName(t_quantity_2)}}
                        {
                            public static {{t_quantity_1}} operator /({{t_scalar}} first, {{t_quantity_2}} second) => new(first / second.Value {{invscaling}});
                        }
                    }

                    namespace {{GetNamespace(t_baseunit_1)}}
                    {
                        partial record {{GetTypeName(t_baseunit_1)}}
                        {
                            public static {{t_scalar}} operator *({{t_baseunit_1}} first, {{t_baseunit_2}} second) => first.Value * second.Value {{scaling}};
                            public static {{t_baseunit_2}} operator /({{t_scalar}} first, {{t_baseunit_1}} second) => new(first / second.Value {{invscaling}});
                        }
                    }

                    namespace {{GetNamespace(t_baseunit_2)}}
                    {
                        partial record {{GetTypeName(t_baseunit_2)}}
                        {
                            public static {{t_baseunit_1}} operator /({{t_scalar}} first, {{t_baseunit_2}} second) => new(first / second.Value {{invscaling}});
                        }
                    }
                    """");

                    // TODO : use known_units to generate mathematical operators
                }
            }

        sb.AppendLine($$""""
        namespace {{GetNamespace(Identifier_ExtensionClass)}}
        {
            public static partial class {{GetTypeName(Identifier_ExtensionClass)}}
            {
        """");

        foreach (string target_name in from usage in known_units.Concat(known_base_units)
                                       let target_name = usage.TargetSymbol?.ToDisplayString()
                                       where target_name is { }
                                       select target_name)
            sb.AppendLine($"        public static {target_name} {GetTypeName(target_name)}(this {unit_scalar_mapper[target_name]} value) => new(value);");

        sb.AppendLine($$""""
            }
        }
        """");

        production_context.AddSource($"{typeof(QuantityDependencyGenerator)}.g.cs", sb.ToString());
    }
#else
    {
        GenerateInfo(
            incremental_context,
            production_context,
            compilation,
            quantity_multiplicative_dependencies,
            quantity_inverse_dependencies,
            known_base_units,
            known_units,
            out Dictionary<Identifier, QuantityInformation> quantity_infos,
            out Dictionary<Identifier, UnitInformation> unit_infos,
            out List<StaticCreationMethod> static_infos
        );

        GenerateSource(production_context, quantity_infos, unit_infos, static_infos, disable_emitting_interfaces);
    }
#endif

    private static void GenerateInfo(
        IncrementalGeneratorInitializationContext incremental_context,
        SourceProductionContext production_context,
        Compilation compilation,
        ImmutableArray<GenericAttributeClassUsage> quantity_multiplicative_dependencies,
        ImmutableArray<GenericAttributeClassUsage> quantity_inverse_dependencies,
        ImmutableArray<GenericAttributeClassUsage> known_base_units,
        ImmutableArray<GenericAttributeClassUsage> known_units,
        out Dictionary<Identifier, QuantityInformation> quantity_infos,
        out Dictionary<Identifier, UnitInformation> unit_infos,
        out List<StaticCreationMethod> static_infos
    )
    {
        CancellationToken ct = production_context.CancellationToken;
        Dictionary<string, (List<string> units, string? base_unit)> known_units_dict = [];
        Dictionary<string, string> unit_scalar_mapper = [];

        foreach (GenericAttributeClassUsage usage in known_units)
            if (usage.TargetSymbol?.ToDisplayString() is not string target_name)
                production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_unable_to_resolve_symbol, usage.AttributeLocation, [usage.TargetType.Identifier.ToString()]));
            else if (usage.TargetType is not RecordDeclarationSyntax record)
                production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_record, usage.AttributeLocation, [target_name]));
            else if (record.Modifiers.IndexOf(SyntaxKind.PartialKeyword) < 0)
                production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_partial, usage.AttributeLocation, [target_name]));
            else if (usage.GenericAttributeArguments.Length < 2 || usage.GenericAttributeArguments[1].ToString() != target_name)
                production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_unit_as_attribute_argument, usage.AttributeLocation, [target_name]));
            else
            {
                string quantity = usage.GenericAttributeArguments[0].ToString();

                if (!known_units_dict.TryGetValue(quantity, out var entry))
                    entry = ([target_name], null);
                else
                    entry.units.Add(target_name);

                known_units_dict[quantity] = entry;
                unit_scalar_mapper[target_name] = usage.GenericAttributeArguments.Last();
            }

        foreach (GenericAttributeClassUsage usage in known_base_units)
            if (usage.TargetSymbol?.ToDisplayString() is not string target_name)
                production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_unable_to_resolve_symbol, usage.AttributeLocation, [usage.TargetType.Identifier.ToString()]));
            else if (usage.TargetType is not RecordDeclarationSyntax record)
                production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_record, usage.AttributeLocation, [target_name]));
            else if (record.Modifiers.IndexOf(SyntaxKind.PartialKeyword) < 0)
                production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_partial, usage.AttributeLocation, [target_name]));
            else if (usage.GenericAttributeArguments.Length < 2 || usage.GenericAttributeArguments[1].ToString() != target_name)
                production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_unit_as_attribute_argument, usage.AttributeLocation, [target_name]));
            else
            {
                string quantity = usage.GenericAttributeArguments[0].ToString();

                if (!known_units_dict.TryGetValue(quantity, out var entry))
                    entry = ([], target_name);
                else
                    entry.base_unit = target_name;

                known_units_dict[quantity] = entry;
                unit_scalar_mapper[target_name] = usage.GenericAttributeArguments.Last();
            }

        unit_infos = [];
        quantity_infos = [];
        static_infos = [..from usage in known_units.Concat(known_base_units)
                          let target_name = usage.TargetSymbol?.ToDisplayString()
                          where target_name is { }
                          select new StaticCreationMethod(unit_scalar_mapper[target_name], target_name)];

        foreach (var kvp in known_units_dict)
        {
            List<string> units = [.. kvp.Value.units];
            Identifier quantity = kvp.Key;

            if (kvp.Value.base_unit is { } base_unit)
                units.Add(base_unit);
            else
                ; // TODO : report error missing base unit

            foreach (string unit in units)
            {
                List<PropertyInfo> properties = [];

                foreach (string target_unit in units)
                    if (target_unit != unit)
                        properties.Add(new(new Identifier(target_unit).Name, target_unit));

                UnitInformation unit_info = new(unit, unit == kvp.Value.base_unit, unit_scalar_mapper[unit], quantity, kvp.Value.base_unit, properties, [], []);

                unit_infos[unit_info.Name] = unit_info;
            }

            for (int i = 0; i < units.Count - 1; ++i)
            {
                Identifier unit = units[i];
                UnitInformation unit_info = unit_infos[unit];

                for (int j = i + 1; j < units.Count; ++j)
                {
                    unit_info.Casts.Add(new(units[j], unit, true));
                    unit_info.Casts.Add(new(unit, units[j], true));
                }
            }

            quantity_infos[quantity] = new(
                quantity,
                kvp.Value.base_unit,
                [..from i in unit_infos
                   where i.Key != kvp.Value.base_unit
                   where i.Value.Quantity == quantity
                   select i.Key
                ],
                []
            );
        }

        foreach (GenericAttributeClassUsage usage in quantity_multiplicative_dependencies)
            if (usage.TargetSymbol?.ToDisplayString() is not string target_name)
                production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_unable_to_resolve_symbol, usage.AttributeLocation, [usage.TargetType.Identifier.ToString()]));
            else if (usage.TargetType is not RecordDeclarationSyntax record)
                production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_record, usage.AttributeLocation, [target_name]));
            else if (record.Modifiers.IndexOf(SyntaxKind.PartialKeyword) < 0)
                production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_partial, usage.AttributeLocation, [target_name]));
            else if (!usage.GenericAttributeArguments.Contains(target_name))
                production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_quantity_as_attribute_argument, usage.AttributeLocation, [target_name]));
            else
            {
                string? scaling = usage.AttributeArguments.FirstOrDefault()?.ToString();
                (Identifier t_quantity_in1, Identifier t_quantity_in2, Identifier t_quantity_out,
                 Identifier t_baseunit_in1, Identifier t_baseunit_in2, Identifier t_baseunit_out,
                 Identifier t_scalar) = usage.GenericAttributeArguments switch
                {
                    { Length: 7 } args => (args[0], args[1], args[2], args[3], args[4], args[5], args[6]),
                    { Length: 5 } args => (args[0], args[0], args[1], args[2], args[2], args[3], args[4]),
                    _ => ("", "", "", "", "", "", ""),
                };
                bool error = false;

                foreach (Identifier id in new[] { t_quantity_in1 , t_quantity_in2, t_quantity_out })
                    if (!quantity_infos.ContainsKey(id))
                    {
                        production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_unable_to_resolve_quantity, usage.AttributeLocation, [id]));

                        error = true;
                    }

                foreach (Identifier id in new[] { t_baseunit_in1, t_baseunit_in2, t_baseunit_out })
                    if (!unit_infos.ContainsKey(id))
                    {
                        production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_unable_to_resolve_unit, usage.AttributeLocation, [id]));

                        error = true;
                    }

                if (error)
                    continue;

                quantity_infos[t_quantity_in1].BinaryOperators.AddRange([
                    new BinaryOperator(t_quantity_in1, t_quantity_in2, scaling, t_quantity_out, OperatorType.Multiply),
                    new BinaryOperator(t_quantity_out, t_quantity_in1, scaling, t_quantity_in2, OperatorType.Divide),
                ]);

                unit_infos[t_baseunit_in1].BinaryOperators.AddRange([
                    new BinaryOperator(t_baseunit_in1, t_baseunit_in2, scaling, t_baseunit_out, OperatorType.Multiply),
                    new BinaryOperator(t_baseunit_out, t_baseunit_in1, scaling, t_baseunit_in2, OperatorType.Divide),
                ]);

                if (t_quantity_in1 != t_quantity_in2)
                    quantity_infos[t_quantity_in2].BinaryOperators.AddRange([
                        new BinaryOperator(t_quantity_in2, t_quantity_in1, scaling, t_quantity_out, OperatorType.Multiply),
                        new BinaryOperator(t_quantity_out, t_quantity_in2, scaling, t_quantity_in1, OperatorType.Divide),
                    ]);

                if (t_baseunit_in1 != t_baseunit_in2)
                    unit_infos[t_baseunit_in2].BinaryOperators.AddRange([
                        new BinaryOperator(t_baseunit_in2, t_baseunit_in1, scaling, t_baseunit_out, OperatorType.Multiply),
                        new BinaryOperator(t_baseunit_out, t_baseunit_in2, scaling, t_baseunit_in1, OperatorType.Divide),
                    ]);
            }

        foreach (GenericAttributeClassUsage usage in quantity_inverse_dependencies)
            if (usage.TargetSymbol?.ToDisplayString() is not string target_name)
                production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_unable_to_resolve_symbol, usage.AttributeLocation, [usage.TargetType.Identifier.ToString()]));
            else if (usage.TargetType is not RecordDeclarationSyntax record)
                production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_record, usage.AttributeLocation, [target_name]));
            else if (record.Modifiers.IndexOf(SyntaxKind.PartialKeyword) < 0)
                production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_partial, usage.AttributeLocation, [target_name]));
            else if (!usage.GenericAttributeArguments.Contains(target_name))
                production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_quantity_as_attribute_argument, usage.AttributeLocation, [target_name]));
            else if (usage.GenericAttributeArguments[0] == usage.GenericAttributeArguments[1])
                production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_quantities_must_be_different, usage.AttributeLocation, [usage.GenericAttributeArguments[0]]));
            else
            {
                string? scaling = usage.AttributeArguments.FirstOrDefault()?.ToString();
                Identifier t_quantity_1 = usage.GenericAttributeArguments[0],
                           t_quantity_2 = usage.GenericAttributeArguments[1],
                           t_baseunit_1 = usage.GenericAttributeArguments[2],
                           t_baseunit_2 = usage.GenericAttributeArguments[3],
                           t_scalar = usage.GenericAttributeArguments[4];

                quantity_infos[t_quantity_1].BinaryOperators.AddRange([
                    new BinaryOperator(t_quantity_1, t_quantity_2, scaling, t_scalar, OperatorType.Multiply) { IsScalar = (false, false, true) },
                    new BinaryOperator(t_scalar, t_quantity_1, scaling, t_quantity_2, OperatorType.Divide) { IsScalar = (true, false, false) },
                ]);
                quantity_infos[t_quantity_2].BinaryOperators.AddRange([
                    new BinaryOperator(t_scalar, t_quantity_2, scaling, t_quantity_1, OperatorType.Divide) { IsScalar = (true, false, false) },
                ]);
                unit_infos[t_baseunit_1].BinaryOperators.AddRange([
                    new BinaryOperator(t_baseunit_1, t_baseunit_2, scaling, t_scalar, OperatorType.Multiply) { IsScalar = (false, false, true) },
                    new BinaryOperator(t_scalar, t_baseunit_1, scaling, t_baseunit_2, OperatorType.Divide) { IsScalar = (true, false, false) },
                ]);
                unit_infos[t_baseunit_2].BinaryOperators.AddRange([
                    new BinaryOperator(t_scalar, t_baseunit_2, scaling, t_baseunit_1, OperatorType.Divide) { IsScalar = (true, false, false) },
                ]);
            }
    }

    private static void GenerateSource(
        SourceProductionContext production_context,
        Dictionary<Identifier, QuantityInformation> quantity_infos,
        Dictionary<Identifier, UnitInformation> unit_infos,
        List<StaticCreationMethod> static_infos,
        bool disable_emitting_interfaces
    )
    {
        StringBuilder sb = new();

        sb.AppendLine($$"""
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // THIS FILE IS AUTO-GENERATED BY {{nameof(QuantityDependencyGenerator)}} ({{DateTime.Now}}). ALL CHANGES WILL BE LOST! //
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        namespace {{Identifier_ExtensionClass.Namespace}}
        {
            public static partial class {{Identifier_ExtensionClass.Name}}
            {
        """);

        foreach (StaticCreationMethod static_info in static_infos)
            sb.AppendLine($"        public static {static_info.Result} {static_info.Result.Name}(this {static_info.Scalar} value) => new(value);");

        sb.AppendLine($$"""
            }
        }
        """);


        void Append(CastOperator cast)
        {
            sb.AppendLine($"        public static {(cast.Implicit ? "im" : "ex")}plicit operator {cast.Result}({cast.Operand} unit) => {cast.Result}.FromBaseUnit(unit.ToBaseUnit());");
        }

        void AppendOp(BinaryOperator @operator)
        {
            char op = @operator.Type switch
            {
                OperatorType.Multiply => '*',
                OperatorType.Divide => '/',
                _ => '?',
            };
            string? scaling = @operator.ScalingFactor;
            (string name1, string name2) = @operator.Operand1 == @operator.Operand2 ? ("first", "second")
                                                                                    : ('@' + @operator.Operand1.Name, '@' + @operator.Operand2.Name);
            string operand1 = @operator.IsScalar.op1 ? name1 : name1 + ".Value";
            string operand2 = @operator.IsScalar.op2 ? name2 : name2 + ".Value";

            if (scaling is { })
                scaling = $"{op} ({scaling})";

            sb.AppendLine($"        public static {@operator.Result} operator {op}({@operator.Operand1} {name1}, {@operator.Operand2} {name2}) => {(@operator.IsScalar.result ? "" : "new")}({operand1} {op} {operand2} {scaling});");
        }


        foreach (var kvp in quantity_infos)
        {
            Identifier name = kvp.Key;
            QuantityInformation quantity_info = kvp.Value;

            sb.AppendLine($$"""

            namespace {{name.Namespace}}
            {
                public partial record {{name.Name}}
                {
            """);

            //foreach (CastOperator cast in quantity_info.Casts)
            //    Append(cast);

            foreach (BinaryOperator @operator in quantity_info.BinaryOperators)
                AppendOp(@operator);

            sb.AppendLine($$"""
                }
            }
            """);
        }

        foreach (var kvp in unit_infos)
        {
            Identifier name = kvp.Key;
            UnitInformation unit_info = kvp.Value;
            string interfaces = disable_emitting_interfaces ? "" :
                $":\n        IUnit, {(unit_info.IsBaseUnit ? $"IBaseUnit<{name}, {unit_info.Scalar}>" : $"IUnit<{name}, {unit_info.BaseUnit}, {unit_info.Scalar}>")}";

            sb.AppendLine($$"""

            namespace {{name.Namespace}}
            {
                public partial record {{name.Name}} {{interfaces}}
                {
            """);

            foreach (PropertyInfo property in unit_info.Properties)
                sb.AppendLine($"        public {property.Result} {property.Name} => ({property.Result})this;");

            sb.AppendLine($"        public static implicit operator {name}({unit_info.Quantity} quantity) => {name}.FromBaseUnit(quantity.Value);");

            foreach (CastOperator cast in unit_info.Casts)
                Append(cast);

            foreach (BinaryOperator @operator in unit_info.BinaryOperators)
                AppendOp(@operator);

            sb.AppendLine($$"""
                }
            }
            """);
        }

        production_context.AddSource($"{typeof(QuantityDependencyGenerator)}.g.cs", sb.ToString());
    }
}

/*
 * quantity:
 *      - base unit                             unit
 *      - known units                           unit[]
 *      - conversion to each unit               quantity -> unit
 *      - multiplicative relationship           (op mul: quantity * quantity -> quantity)[]
 *                                              (op div: quantity * quantity -> quantity)[]
 *      - inverse relationship                  (op div: scalar * quantity -> quantity)?
 *                                              (op mul: quantity * quantity -> scalar)?
 * unit:
 *      - implicit conversion to quantity       op impl: unit -> quantity
 *      - implicit conversion from quantity     op impl: quantity -> unit
 *      - implicit conversion to other units    (op impl: unit -> unit)[]
 *      - implicit conversion from other units  (op impl: unit <- unit)[]
 *      - multiplicative relationship           (op mul: unit * unit -> unit)[]
 *                                              (op div: unit * unit -> unit)[]
 *      - inverse relationship                  (op div: scalar * unit -> unit)?
 *                                              (op mul: unit * unit -> scalar)?
 * module:
 *      - static extension methods for scalar
 */

public sealed record Identifier(string Namespace, string Name)
{
    public string FullName => string.IsNullOrEmpty(Namespace) ? Name : string.IsNullOrEmpty(Name) ? Namespace : $"{Namespace}.{Name}";


    public Identifier(string? FullName)
        : this(GetNamespace(FullName ?? ""), GetTypeName(FullName ?? ""))
    {
    }

    public override string ToString() => FullName;

    private static string GetNamespace(string identifier) => identifier.LastIndexOf('.') is int i and >= 0 ? identifier.Substring(0, i) : "";

    private static string GetTypeName(string identifier) => identifier.LastIndexOf('.') is int i and >= 0 ? identifier.Substring(i + 1) : identifier;

    public static implicit operator Identifier(string? identifier) => new(identifier);
}

public enum OperatorType
{
    Multiply,
    Divide,
}

public sealed record PropertyInfo(string Name, Identifier Result);

public sealed record CastOperator(Identifier Operand, Identifier Result, bool Implicit = true);

public sealed record StaticCreationMethod(Identifier Scalar, Identifier Result);

public sealed record BinaryOperator(Identifier Operand1, Identifier Operand2, string? ScalingFactor, Identifier Result, OperatorType Type)
{
    public (bool op1, bool op2, bool result) IsScalar { get; set; } = (false, false, false);
}

public sealed record QuantityInformation(
    Identifier Name,
    Identifier BaseUnit,
    List<Identifier> KnownUnits,
    List<BinaryOperator> BinaryOperators //,
    //List<CastOperator> Casts
);

public sealed record UnitInformation(
    Identifier Name,
    bool IsBaseUnit,
    Identifier Scalar,
    Identifier Quantity,
    Identifier BaseUnit,
    List<PropertyInfo> Properties,
    List<BinaryOperator> BinaryOperators,
    List<CastOperator> Casts
);

public sealed record GenericAttributeClassUsage(
    SemanticModel SemanticModel,
    string Namespace,
    Location AttributeLocation,
    TypeDeclarationSyntax TargetType,
    string[] GenericAttributeArguments,
    AttributeArgumentSyntax[] AttributeArguments
)
{
    public INamedTypeSymbol? TargetSymbol { get; } = SemanticModel.GetDeclaredSymbol(TargetType);

    public override string ToString()
    {
        if (AttributeLocation.SourceTree?.ToString() is string source)
            return source.Substring(AttributeLocation.SourceSpan.Start, AttributeLocation.SourceSpan.Length);
        else
            return AttributeLocation.ToString();
    }
}
