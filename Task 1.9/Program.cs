using System;

class CoordinateClass
{
    public int X;
    public int Y;
}

struct CoordinateStruct
{
    public int X;
    public int Y;
}

class Program
{
    static void Main()
    {
        // 1. Two integers
        int a = 10;
        int b = a;

        b = 20;

        Console.WriteLine($"Integer a: {a}");
        Console.WriteLine($"Integer b: {b}");

        // a remains 10 because int is a value type.
        // b received its own copy of a.


        // 2. Integer array
        int[] array1 = { 10, 20, 30 };
        int[] array2 = array1;

        array2[0] = 100;

        Console.WriteLine($"Array1[0]: {array1[0]}");
        Console.WriteLine($"Array2[0]: {array2[0]}");

        // Both show 100 because arrays are reference types.
        // array2 and array1 refer to the same array object.


        // 3. Coordinate struct
        CoordinateStruct point1 = new CoordinateStruct();
        point1.X = 10;
        point1.Y = 20;

        CoordinateStruct point2 = point1;

        point2.X = 100;

        Console.WriteLine($"Struct point1.X: {point1.X}");
        Console.WriteLine($"Struct point2.X: {point2.X}");

        // point1.X remains 10 because a struct is a value type.
        // point2 received a separate copy of point1.


        // 4. Coordinate class
        CoordinateClass point3 = new CoordinateClass();
        point3.X = 10;
        point3.Y = 20;

        CoordinateClass point4 = point3;

        point4.X = 100;

        Console.WriteLine($"Class point3.X: {point3.X}");
        Console.WriteLine($"Class point4.X: {point4.X}");

        // Both show 100 because a class is a reference type.
        // point3 and point4 refer to the same object.
    }
}