﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Immutable;
using System.Text;

namespace AutoGeneratedSystem.Interfaces.Generators
{
    [Generator]
    public class InterfacesIncrementalGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
#if DEBUG
            //System.Diagnostics.Debugger.Launch();
#endif
            // Do a simple filter for enums
            IncrementalValuesProvider<InterfaceDeclarationSyntax> interfacesDeclarations =
                context.SyntaxProvider
                .CreateSyntaxProvider(
                    predicate: static (s, _) => IsSyntaxTargetForGeneration(s), // select enums with attributes
                    transform: static (ctx, _) => GetSemanticTargetForGeneration(ctx)) // sect the enum with the [EnumExtensions] attribute
                .Where(static m => m is not null)!; // filter out attributed enums that we don't care about

            // Combine the selected interfaces with the `Compilation`
            IncrementalValueProvider<(Compilation, ImmutableArray<InterfaceDeclarationSyntax>)>
                compilationAndInterfaces
                = context.CompilationProvider.Combine(interfacesDeclarations.Collect());

            // Generate the source using the compilation and classes
            context.RegisterSourceOutput(compilationAndInterfaces,
                static (spc, source) => Execute(source.Item1, source.Item2, spc));
        }

        private static InterfaceDeclarationSyntax GetSemanticTargetForGeneration(GeneratorSyntaxContext generatorSyntaxContext)
        {
            var interfaceDeclarationSyntax = generatorSyntaxContext.Node as InterfaceDeclarationSyntax;
            return interfaceDeclarationSyntax!;
        }

        private static bool IsSyntaxTargetForGeneration(SyntaxNode syntaxNode)
        {
            if (syntaxNode is InterfaceDeclarationSyntax)
            {
                InterfaceDeclarationSyntax interfaceDeclarationSyntax = (InterfaceDeclarationSyntax)syntaxNode;
                foreach (var singleAttributeList in interfaceDeclarationSyntax.AttributeLists)
                {
                    foreach (var singleAttribute in singleAttributeList.Attributes)
                    {
                        var identifierNameSyntax = (singleAttribute.Name) as IdentifierNameSyntax;
                        string identifierText = identifierNameSyntax!.Identifier.Text;
                        if (identifierText == "ControllerOfEntity")
                            return true;
                    }
                }
            }
            return false;
        }

        static void Execute(Compilation compilation,
            ImmutableArray<InterfaceDeclarationSyntax> interfacesDeclarationSyntax, SourceProductionContext context)
        {
            foreach (var singleInterfaceDeclarationSyntax in interfacesDeclarationSyntax)
            {
                var interfaceName = singleInterfaceDeclarationSyntax.Identifier.Text;
                foreach (var singleAttributeList in singleInterfaceDeclarationSyntax.AttributeLists)
                {
                    foreach (var singleAttribute in singleAttributeList.Attributes)
                    {
                        var identifierNameSyntax = (singleAttribute.Name) as IdentifierNameSyntax;
                        string identifierText = identifierNameSyntax!.Identifier.Text;
                        if (identifierText == "ControllerOfEntity")
                        {
                            var argument = singleAttribute.ArgumentList!.Arguments.Single();
                            var memberAccessExpressionSyntax = argument.Expression as MemberAccessExpressionSyntax;
                            var simpleNameSyntax = memberAccessExpressionSyntax!.Name;
                            var entityName = simpleNameSyntax.Identifier.Text;
                            StringBuilder stringBuilder = new StringBuilder();
                            stringBuilder.AppendLine("using System.Threading.Tasks;");
                            stringBuilder.AppendLine($"using AutoGeneratedSystem.Models.{entityName};");
                            stringBuilder.AppendLine($"public partial interface {interfaceName}");
                            stringBuilder.AppendLine("{");
                            stringBuilder.AppendLine($"Task<Create{entityName}Model> Create{entityName}(Create{entityName}Model create{entityName}Model, CancellationToken cancellationToken);");
                            stringBuilder.AppendLine($"Task<{entityName}Model[]> GetAll{entityName}(CancellationToken cancellationToken);");
                            stringBuilder.AppendLine("}");
                            context.AddSource($"{interfaceName}.g.cs",
                        SourceText.From(stringBuilder.ToString(), Encoding.UTF8));
                        }
                    }
                }
            }
        }
    }
}
