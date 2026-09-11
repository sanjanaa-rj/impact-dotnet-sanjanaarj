using System;

class Program
{
    static void Add(dynamic a, dynamic b)
    {
        Console.WriteLine($"Result: {a + b}");
    }

    static void Main()
    {
        // Part 1: var

        var number = 10;

        Console.WriteLine($"var value: {number}");
        Console.WriteLine($"var type: {number.GetType()}");

        // var gets its type at compile time.
        // number is an int and cannot later be assigned a string.

        // Uncomment the next line to see the compile error:
        // number = "Hello";


        // Part 2: dynamic

        dynamic value = "Hello";

        Console.WriteLine();
        Console.WriteLine($"dynamic value: {value}");
        Console.WriteLine($"dynamic type: {value.GetType()}");

        value = 100;

        Console.WriteLine($"dynamic value: {value}");
        Console.WriteLine($"dynamic type: {value.GetType()}");

        value = true;

        Console.WriteLine($"dynamic value: {value}");
        Console.WriteLine($"dynamic type: {value.GetType()}");


        // Part 3: dynamic parameter

        Console.WriteLine();
        Console.WriteLine("Dynamic Add method:");

        Add(10, 20);
        Add("Hello ", "World");
    }
}