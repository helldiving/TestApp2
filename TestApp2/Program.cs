using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System;

public class TestingVC
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Testing VC and C# formatting!");

        /* C# vs Java notes so far:

        - PascalCase for public members/ types, camelCase for parameters/locals (instead of Java's all camelCase except class names)
        - Allman style brackets instead of Egyptian style
        - Private instance variables don't need "this" keyword to assign local variables to them for DI since the compiler can handle it and syntax is _variable = variable; meaning there's no ambiguity in naming like in Java
        - : is used for inheritance and interface implementations instead of extends/implements (Java uses : for foreach)
        - Common lifetime scopes: AddSingleton(one instance), AddScoped(per request), AddTransient(new each time) which is similar to Java's @Bean
        - Properties use { get; set; } syntax instead of explicit getter/setter methods
        - C# can auto-implement properties and set defaults: public string Name { get; set; } = "Default";
        - C# can infer types, ex: var name = "Saul Goodman"; var age = 42; var prices = new List<decimal>();
        - LINQ (Language Integrated Query) = like SQL syntax
        - Null handling, adding ? makes types nullabl and compiler forces null checks. Ex: int? nullableNumber = null; string? nullableString = null;
        - Default values can be assigned directly to properties or in constructor
        - Value type vs reference type: C# has both (struct vs class) while Java mostly has reference
        - Delegates & events(C#'s type-safe approach to callbacks/event handling)

        */


    }


}

