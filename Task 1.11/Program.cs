using System;

class Program
{
    static double ApplyDiscount(double? discount)
    {
        // If discount is null, use the default discount of 5%.
        double actualDiscount = discount ?? 5.0;

        return actualDiscount;
    }

    static void Main()
    {
        // Part 1: Nullable int

        int? age = null;

        Console.WriteLine($"Has age value: {age.HasValue}");

        age = 21;

        Console.WriteLine($"Has age value: {age.HasValue}");
        Console.WriteLine($"Age: {age.Value}");


        // Part 2: ApplyDiscount using ??

        double? discount1 = null;
        double? discount2 = 10.0;

        double appliedDiscount1 = ApplyDiscount(discount1);
        double appliedDiscount2 = ApplyDiscount(discount2);

        Console.WriteLine($"Discount when null: {appliedDiscount1}%");
        Console.WriteLine($"Discount when value is provided: {appliedDiscount2}%");

        // When discount is null, ?? uses the default 5%.
        // When discount has a value, that value is used instead.
    }
}