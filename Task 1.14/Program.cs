using System;

class Program
{
    // Returns two named values: Min and Max
    static (int Min, int Max) GetMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number < min)
                min = number;

            if (number > max)
                max = number;
        }

        return (min, max);
    }

    // Returns employee information as a named tuple
    static (string Name, int Age, string Department) GetEmployee()
    {
        return ("Sanjanaa", 21, "Technology Consulting");
    }

    static void Main()
    {
        // Part 1: Named tuple

        int[] numbers = { 10, 5, 25, 3, 15 };

        var result = GetMinMax(numbers);

        Console.WriteLine($"Minimum: {result.Min}");
        Console.WriteLine($"Maximum: {result.Max}");


        // Part 2: Deconstruction

        var (min, max) = GetMinMax(numbers);

        Console.WriteLine();
        Console.WriteLine($"Deconstructed Min: {min}");
        Console.WriteLine($"Deconstructed Max: {max}");


        // Part 3: Employee tuple

        var employee = GetEmployee();

        Console.WriteLine();
        Console.WriteLine($"Employee: {employee.Name}");
        Console.WriteLine($"Age: {employee.Age}");
        Console.WriteLine($"Department: {employee.Department}");


        // Deconstruct employee tuple into separate variables

        var (name, age, department) = GetEmployee();

        Console.WriteLine();
        Console.WriteLine($"Deconstructed Name: {name}");
        Console.WriteLine($"Deconstructed Age: {age}");
        Console.WriteLine($"Deconstructed Department: {department}");
    }
}