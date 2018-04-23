

            using System;
            using Microsoft.CodeAnalysis;
            using Microsoft.CodeAnalysis.CSharp.Syntax;
            using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

            namespace RoslynCodeGenerator
            {
                class Program
                {
                    static void Main(string[] args)
                    {
                        var syntax = CompilationUnit()
                            .WithMembers(
                                SingletonList<MemberDeclarationSyntax>(
                                    NamespaceDeclaration(ParseName("Powerful"))
                                        .WithMembers(
                                            SingletonList<MemberDeclarationSyntax>(
                                                ClassDeclaration("Yeah")
                                                    .WithMembers(
                                                        SingletonList<MemberDeclarationSyntax>(
                                                            MethodDeclaration(ParseTypeName("void"), "PowderedSugar")
                                                                .WithBody(Block())))))));
                        syntax = syntax.NormalizeWhitespace();
                        Console.WriteLine(syntax.ToFullString());
            
                        Console.ReadLine();
                    }
                }
            }


