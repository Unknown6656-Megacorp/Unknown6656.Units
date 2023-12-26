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
    public const string Identifier_MultiplicativeQuantityRelationship = "Unknown6656.Units.MultiplicativeQuantityRelationship";
    public const string Identifier_InverseQuantityRelationship = "Unknown6656.Units.InverseQuantityRelationship";
    public const string Identifier_KnownBaseUnit = "Unknown6656.Units.KnownBaseUnit";
    public const string Identifier_KnownUnit = "Unknown6656.Units.KnownUnit";
    public const string Identifier_ExtensionClass = "Unknown6656.Units.Unit";

    #region DIAGNOSTIC ERRORS

    private static readonly DiagnosticDescriptor _diagnostic_requires_record = new (
        "U6656_001",
        "The target quantity type must be declared as record.",
        "The target quantity type '{0}' must be declared as record.",
        "Unknown6656.Units",
        DiagnosticSeverity.Error,
        true
    );
    private static readonly DiagnosticDescriptor _diagnostic_requires_partial = new(
        "U6656_002",
        "The target quantity type must be declared as 'partial'.",
        "The target quantity type '{0}' must be declared as 'partial'.",
        "Unknown6656.Units",
        DiagnosticSeverity.Error,
        true
    );
    private static readonly DiagnosticDescriptor _diagnostic_requires_quantity_as_attribute_argument = new(
        "U6656_003",
        "The target quantity type must be part of the attribute type arguments.",
        "The target quantity type '{0}' must be part of the attribute type arguments.",
        "Unknown6656.Units",
        DiagnosticSeverity.Error,
        true
    );
    private static readonly DiagnosticDescriptor _diagnostic_requires_unit_as_attribute_argument = new(
        "U6656_004",
        "The target unit type must be the second generic attribute type argument.",
        "The target unit type '{0}' must be the second generic attribute type argument.",
        "Unknown6656.Units",
        DiagnosticSeverity.Error,
        true
    );

    #endregion


    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        IncrementalValuesProvider<GenericAttributeClassUsage> quantity_dependencies = FetchTypeDeclarationsByAttribute(context, Identifier_MultiplicativeQuantityRelationship);
        IncrementalValuesProvider<GenericAttributeClassUsage> known_base_units = FetchTypeDeclarationsByAttribute(context, Identifier_KnownBaseUnit);
        IncrementalValuesProvider<GenericAttributeClassUsage> known_units = FetchTypeDeclarationsByAttribute(context, Identifier_KnownUnit);

        // which idiot decided to name this stuff "left" and "right"? and not to provide an extension method for combining 3 or more IncrementalValueProvider<>?
        var combined = context.CompilationProvider.Combine(quantity_dependencies.Collect())
                                                  .Combine(known_base_units.Collect())
                                                  .Select(static (t, _) => (compilation: t.Left.Left, dependencies: t.Left.Right, base_units: t.Right))
                                                  .Combine(known_units.Collect())
                                                  .Select(static (t, _) => (t.Left.compilation, t.Left.dependencies, t.Left.base_units, units: t.Right));

        context.RegisterSourceOutput(combined, (spc, source) => Execute(context, spc, source.compilation, source.dependencies, source.base_units, source.units));
    }

    private static IncrementalValuesProvider<GenericAttributeClassUsage> FetchTypeDeclarationsByAttribute(IncrementalGeneratorInitializationContext context, string attribute_name) => context.SyntaxProvider
        .CreateSyntaxProvider(
            predicate: static (s, _) => s is TypeDeclarationSyntax { AttributeLists.Count: > 0 },
            transform: (ctx, _) => GetGenericAttributeClassUsage(ctx, attribute_name)
        )
        .Where(static m => m is not null)!;

    private static string GetNamespace(string identifier) => identifier.LastIndexOf('.') is int i and >= 0 ? identifier.Substring(0, i) : "";

    private static string GetTypeName(string identifier) => identifier.LastIndexOf('.') is int i and >= 0 ? identifier.Substring(i + 1) : identifier;

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
        ImmutableArray<GenericAttributeClassUsage> quantity_dependencies,
        ImmutableArray<GenericAttributeClassUsage> known_base_units,
        ImmutableArray<GenericAttributeClassUsage> known_units
    )
    {
        CancellationToken ct = production_context.CancellationToken;
        StringBuilder sb = new();

        sb.AppendLine($"""
        // THIS FILE IS AUTO-GENERATED BY {nameof(QuantityDependencyGenerator)} ({DateTime.Now}). ALL CHANGES WILL BE LOST!
        /*
            known units: {string.Join(", ", known_units.Select(u => u.TargetType.Identifier))}
        */
        """);

        Dictionary<string, List<string>> known_units_dict = [];

        foreach (GenericAttributeClassUsage usage in known_units)
            if (usage.SemanticModel.GetDeclaredSymbol(usage.TargetType, ct) is INamedTypeSymbol target_symbol)
            {
                string target_name = target_symbol.ToDisplayString();

                if (usage.TargetType is not RecordDeclarationSyntax record)
                    production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_record, usage.AttributeLocation, [target_name]));
                else if (record.Modifiers.IndexOf(SyntaxKind.PartialKeyword) < 0)
                    production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_partial, usage.AttributeLocation, [target_name]));
                else if (usage.GenericAttributeArguments.Length < 2 || usage.GenericAttributeArguments[1].ToString() != target_name)
                    production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_unit_as_attribute_argument, usage.AttributeLocation, [target_name]));
                else
                {
                    string quantity = usage.GenericAttributeArguments[0].ToString();

                    if (!known_units_dict.TryGetValue(quantity, out List<string>? units))
                        known_units_dict[quantity] = units = [];

                    units.Add(target_name);
                }
            }

        foreach (var kvp in known_units_dict)
            for (int i = 0, l = kvp.Value.Count; i < l - 1; ++i)
            {
                string unit = kvp.Value[i];

                sb.AppendLine($$""""
                namespace {{GetNamespace(unit)}}
                {
                    partial record {{GetTypeName(unit)}}
                    {
                """");

                for (int j = i + 1; j < l; ++j)
                    sb.AppendLine($"        public static implicit operator {kvp.Value[j]}({unit} unit) => {kvp.Value[j]}.FromBaseUnit(unit.ToBaseUnit());");

                sb.AppendLine($"\n        public static implicit operator {unit}({kvp.Key} unit) => {unit}.FromBaseUnit(unit.Value);\n");

                for (int j = i + 1; j < l; ++j)
                    sb.AppendLine($"        public static implicit operator {unit}({kvp.Value[j]} unit) => {unit}.FromBaseUnit(unit.ToBaseUnit());");

                sb.AppendLine($$""""
                    }
                }
                """");
            }

        foreach (GenericAttributeClassUsage usage in quantity_dependencies)
            if (usage.SemanticModel.GetDeclaredSymbol(usage.TargetType, ct) is INamedTypeSymbol target_symbol)
            {
                string target_name = target_symbol.ToDisplayString();

                if (usage.TargetType is not RecordDeclarationSyntax record)
                    production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_record, usage.AttributeLocation, [target_name]));
                else if (record.Modifiers.IndexOf(SyntaxKind.PartialKeyword) < 0)
                    production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_partial, usage.AttributeLocation, [target_name]));
                else if (!usage.GenericAttributeArguments.Contains(target_name))
                    production_context.ReportDiagnostic(Diagnostic.Create(_diagnostic_requires_quantity_as_attribute_argument, usage.AttributeLocation, [target_name]));
                else
                {
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
                            public static {{t_quantity_out}} operator *({{t_quantity_in1}} first, {{t_quantity_in2}} second) => new(first.Value * second.Value);
                            public static {{t_quantity_in2}} operator /({{t_quantity_out}} first, {{t_quantity_in1}} second) => new(first.Value / second.Value);
                    """");

                    if (t_quantity_in1 != t_quantity_in2)
                        sb.AppendLine($$""""
                            public static {{t_quantity_out}} operator *({{t_quantity_in2}} first, {{t_quantity_in1}} second) => new(first.Value * second.Value);
                        }
                    }
                    
                    namespace {{GetNamespace(t_quantity_in2)}}
                    {
                        partial record {{GetTypeName(t_quantity_in2)}}
                        {
                            public static {{t_quantity_in1}} operator /({{t_quantity_out}} first, {{t_quantity_in2}} second) => new(first.Value / second.Value);
                    """");

                    sb.AppendLine($$""""
                        }
                    }
                    
                    namespace {{GetNamespace(t_baseunit_in1)}}
                    {
                        partial record {{GetTypeName(t_baseunit_in1)}}
                        {
                            public static {{t_baseunit_out}} operator *({{t_baseunit_in1}} first, {{t_baseunit_in2}} second) => new(first.Value * second.Value);
                            public static {{t_baseunit_in2}} operator /({{t_baseunit_out}} first, {{t_baseunit_in1}} second) => new(first.Value / second.Value);
                    """");

                    if (t_baseunit_in1 != t_baseunit_in2)
                        sb.AppendLine($$""""
                            public static {{t_baseunit_out}} operator *({{t_baseunit_in2}} first, {{t_baseunit_in1}} second) => new(first.Value * second.Value);
                        }
                    }
                    
                    namespace {{GetNamespace(t_baseunit_in2)}}
                    {
                        partial record {{GetTypeName(t_baseunit_in2)}}
                        {
                            public static {{t_baseunit_in1}} operator /({{t_baseunit_out}} first, {{t_baseunit_in2}} second) => new(first.Value / second.Value);
                    """");

                    sb.AppendLine($$""""
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

        foreach (string target_type in known_units.Concat(known_base_units)
                                                  .Select(u => u.SemanticModel.GetDeclaredSymbol(u.TargetType, ct)?.ToDisplayString())
                                                  .Where(static name => name is { })
                                                  .Distinct() as IEnumerable<string>)
            sb.AppendLine($"        public static {target_type} {GetTypeName(target_type)}(this Scalar /* <-- TODO : fix this shite */ value) => new(value);");

        sb.AppendLine($$""""
            }
        }
        """");

        production_context.AddSource($"{typeof(QuantityDependencyGenerator)}.g.cs", sb.ToString());
    }
}

public sealed record GenericAttributeClassUsage(
    SemanticModel SemanticModel,
    string Namespace,
    Location AttributeLocation,
    TypeDeclarationSyntax TargetType,
    string[] GenericAttributeArguments,
    AttributeArgumentSyntax[] AttributeArguments
);
