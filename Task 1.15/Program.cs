using System;

class Order
{
    public string Status { get; set; } = "";
    public double Amount { get; set; }
}

class Program
{
    // Part 1: Type pattern matching

    static void HandleObject(object? value)
    {
        switch (value)
        {
            case int number:
                Console.WriteLine($"Integer: {number}");
                break;

            case string text:
                Console.WriteLine($"String: {text}");
                break;

            case double decimalNumber:
                Console.WriteLine($"Double: {decimalNumber}");
                break;

            case null:
                Console.WriteLine("Null value");
                break;

            default:
                Console.WriteLine("Unknown type");
                break;
        }
    }


    // Part 2: Relational patterns with switch expression

    static string CalculateGrade(int marks)
    {
        return marks switch
        {
            >= 90 => "A",
            >= 75 => "B",
            >= 60 => "C",
            >= 50 => "D",
            _ => "F"
        };
    }


    // Part 3: Property pattern

    static double CalculateDiscount(Order order)
    {
        return order switch
        {
            { Status: "Completed", Amount: >= 1000 } => 10,
            { Status: "Completed", Amount: >= 500 } => 5,
            _ => 0
        };
    }

    static void Main()
    {
        Console.WriteLine("Type pattern:");

        HandleObject(10);
        HandleObject("Hello");
        HandleObject(10.5);
        HandleObject(null);


        Console.WriteLine();
        Console.WriteLine("Grade calculation:");

        Console.WriteLine($"95 marks: {CalculateGrade(95)}");
        Console.WriteLine($"80 marks: {CalculateGrade(80)}");
        Console.WriteLine($"65 marks: {CalculateGrade(65)}");
        Console.WriteLine($"40 marks: {CalculateGrade(40)}");


        Console.WriteLine();
        Console.WriteLine("Property pattern:");

        Order order1 = new Order
        {
            Status = "Completed",
            Amount = 1500
        };

        Order order2 = new Order
        {
            Status = "Completed",
            Amount = 700
        };

        Order order3 = new Order
        {
            Status = "Pending",
            Amount = 1500
        };

        Console.WriteLine($"Order 1 discount: {CalculateDiscount(order1)}%");
        Console.WriteLine($"Order 2 discount: {CalculateDiscount(order2)}%");
        Console.WriteLine($"Order 3 discount: {CalculateDiscount(order3)}%");
    }
}