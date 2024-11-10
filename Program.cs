using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System;

public class TestingVC
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Testing VC and C# formatting!");

        /* 
          
   C# vs Java notes so far:

       Syntax:

        - PascalCase for types and public/protected members, camelCase for private/internal members, parameters and locals (Java is camelCase for everything except types)
        - Allman style brackets instead of Egyptian style
        - LINQ (Language Integrated Query) = like SQL syntax
        - Console.WriteLine($"Learning {variable}");

       Type System:

        - Value type vs reference type: C# has both (struct vs class) while Java mostly has reference
        - Nullable types: adding ? makes types nullable and compiler forces null checks at compile time (ex: int? nullableNumber = null; string? nullableString = null;)
        - Default values can be assigned directly to properties or in constructor (in Java it's only to primitive fields: 0 for int, false for boolean, null for obj reference)
        - C# can infer types, ex: var name = "Saul Goodman"; var age = 42; var prices = new List<decimal>();
        - Delegates & events: C#'s type-safe approach to callbacks/event handling (ex: public delegate void MessageHandler(string message);) (ex: public event MessageHandler OnMessageReceived;)

       Interface:

        - : is used for inheritance and interface implementations instead of extends/implements in Java
        - C# interfaces commonly start with 'I' (IName), Java often uses -able suffix (Namable)
        - C# interfaces can define properties and default implementations, Java interfaces can define default methods but not properties

       Properties:

        - Auto-implement properties and set defaults which eliminate the need for getter/setter methods (ex: public string Name { get; set; } = "Default";)
      
       Dependency Injection:

        - Private instance variables don't need "this" keyword to assign local variables to them for DI since the compiler can handle it and syntax is _variable = variable; meaning there's no ambiguity in naming like in Java
        - In C# DI is usually configured in ASP.NET Core with common methods such as AddSingleton(one instance), AddScoped(per request), AddTransient(new each time) which is similar to Java's @Singleton, @Scope, @Prototype, and @Bean's
        
       Collections: 

        - Lists: in C# List<Type> is used for List and ArrayList. (ex: List<int> numbers = new List<int> { 1, 2, 3, 4 };)
        - Sets: appear to be the same
        - Maps: C#'s dictionary<Type-Key, Type-Value> is Java's HashMap<Key, Value> (ex: Dictionary<string, int> map = new Dictionary<string, int> { { "apple", 1 }, { "banana", 2 } };

       Async:
        
        - C# uses async and await for asynchronous programming which allow methods to run tasks without blocking
        - Calling async methods in C# requires awaiting the result (ex: string result = await FetchDataAsync();)
        - Example: 
                    async Task<string> FetchDataAsync()
                    {
                        await Task.Delay(1000); // simulates waiting for data
                        return "Data fetched";
                    }

       Metaprogramming:

        - Expression<T>: represents code as data that can be analyzed and modified at runtime (ex: Expression<Func<int, bool>> isEven = x => x % 2 == 0; creates a tree structure which can be inspected, modified, or converted)
            - Useful for converting C# code to SQL, building dynamic queries, and creating code analyzers
        - Reflectable Attributes: metadata tags that can be examined at runtime (ex: [Obsolete("Don't use this")] inspectable via reflection)
            - Allows you to add metadata to the code, check permissions at runtime, build frameworks that can scan code for special markers, and create documentation automatically
        - Non-elided Generics: preserves generic type information at runtime (unlike Java's type erasure) (ex: Type listType = numbers.GetType(); Console.WriteLine(listType.GetGenericArguments()[0]); // Prints "System.Int32" (int's full type name in C#))
            - Allows runtime type checking and dynamic instance creation of generic types
        - Roslyn Extensions: compiler platform enabling custom analyzers and code transformations (can add custom compile-time checks and code fixes)
            - Allows you to create custom compile warnings/errors, auto-fix code issues, enforce coding standards, and generate code during compilation
        - Source Generators: compile-time code generation feature (can auto-generate boilerplate code or create code from external data)
            - Allows you to avoid writing repetitive code and create code based on external data such as JSON, a database schema, etc.)

       Type Aliases:

        - int: System.Int32
        - long: System.Int64
        - double: System.Double
        - string: System.String
        - bool: System.Boolean
        - object: System.Object

        */


    }


}

