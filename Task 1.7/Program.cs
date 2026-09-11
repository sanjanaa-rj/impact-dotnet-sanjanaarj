using System;

class Program
{
    static void Main()
    {

        int studentAge = 23;
        string studentName = "Sanjanaa";
        double studentMarks = 85.5;
        bool isPassed = true;
        int totalSubjects = 5;

        Console.WriteLine(studentAge);
        Console.WriteLine(studentName);
        Console.WriteLine(studentMarks);
        Console.WriteLine(isPassed);
        Console.WriteLine(totalSubjects);

        // int class = 10;   // Compile error

        int @class = 10;
        Console.WriteLine(@class);
    }
}