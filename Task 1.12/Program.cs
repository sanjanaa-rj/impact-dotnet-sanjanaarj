using System;

class Program
{
    static void Main()
    {
        // Part 1: Implicit numeric conversions

        int intValue = 10;
        long longValue = intValue;
        float floatValue = longValue;
        double doubleValue = floatValue;

        Console.WriteLine("Implicit conversions:");
        Console.WriteLine($"int: {intValue}");
        Console.WriteLine($"long: {longValue}");
        Console.WriteLine($"float: {floatValue}");
        Console.WriteLine($"double: {doubleValue}");


        // Part 2: Explicit conversion from double to int

        double decimalValue = 123.75;
        int convertedValue = (int)decimalValue;

        Console.WriteLine();
        Console.WriteLine("Explicit conversion:");
        Console.WriteLine($"double: {decimalValue}");
        Console.WriteLine($"int after casting: {convertedValue}");

        // The decimal part .75 is lost when converting double to int.
        // 123.75 becomes 123.


        // Part 3: is operator

        string text = "123";

        Console.WriteLine();
        Console.WriteLine("Using is:");

        bool isInteger = text is int;

        Console.WriteLine($"Is text an int? {isInteger}");

        // text is a string, so 'is int' returns false.
        // 'is' checks the actual type; it does not convert the value.


        // Part 4: as operator

        object value = "123";

        string? stringValue = value as string;

        Console.WriteLine();
        Console.WriteLine("Using as:");
        Console.WriteLine($"Result of as string: {stringValue}");

        // 'as' attempts a reference-type conversion.
        // Since value actually contains a string, the conversion succeeds.
        // 'as' does not convert a string such as "123" into an int.


        // Part 5: Convert.ToInt32

        int convertedNumber = Convert.ToInt32(text);

        Console.WriteLine();
        Console.WriteLine("Using Convert.ToInt32:");
        Console.WriteLine($"Converted number: {convertedNumber}");

        // Convert.ToInt32 can convert a numeric string into an int.
        // It can throw an exception if the input cannot be converted.


        // Part 6: int.TryParse

        string input = "456";

        bool success = int.TryParse(input, out int parsedNumber);

        Console.WriteLine();
        Console.WriteLine("Using int.TryParse:");
        Console.WriteLine($"Conversion successful: {success}");
        Console.WriteLine($"Parsed number: {parsedNumber}");

        // TryParse returns true when conversion succeeds.
        // It returns false instead of throwing an exception for invalid input.
    }
}