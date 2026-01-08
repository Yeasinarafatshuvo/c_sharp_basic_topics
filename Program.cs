using System;

namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide the name of the topic to run.");
                Console.WriteLine("Usage: dotnet run [Topic]");
                Console.WriteLine("Example: dotnet run VariableTypes");
                Console.WriteLine("Available Topics: VariableTypes, ControlFlow, Functions, Arrays, ExceptionHandling, Generics, Delegates, LambdaExpression, Events, StringOperations, LinqExample, FileIo, Tuples, NullableTypes");
                return;
            }

            string topic = args[0];

            switch (topic.ToLower())
            {
                case "variabletypes": VariableTypes.Run(); break;
                case "controlflow": ControlFlow.Run(); break;
                case "functions": Functions.Run(); break;
                case "arrays": Arrays.Run(); break;
                case "exceptionhandling": ExceptionHandling.Run(); break;
                case "generics": Generics.Run(); break;
                case "delegates": Delegates.Run(); break;
                case "lambdaexpression": LambdaExpression.Run(); break;
                case "events": Events.Run(); break;
                case "stringoperations": StringOperations.Run(); break;
                case "linqexample": LinqExample.Run(); break;
                case "fileio": FileIo.Run(); break;
                case "tuples": Tuples.Run(); break;
                case "nullabletypes": NullableTypes.Run(); break;
                default:
                    Console.WriteLine($"Topic '{topic}' not found.");
                    break;
            }
        }
    }
}
