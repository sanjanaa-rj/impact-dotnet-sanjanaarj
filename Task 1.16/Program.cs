using System;

class Student
{
    // const: value must be known at compile time
    public const int MinimumAge = 5;

    // readonly: can be assigned during declaration or constructor
    public readonly string SchoolName;

    private int age;

    public string Name { get; set; }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 5 || value > 100)
            {
                throw new ArgumentException("Age must be between 5 and 100.");
            }

            age = value;
        }
    }

    // Parameterized constructor
    public Student(string name, int age, string schoolName)
    {
        Name = name;
        Age = age;
        SchoolName = schoolName;
    }

    // Constructor chaining
    public Student(string name, int age)
        : this(name, age, "Default School")
    {
    }

    // CalculateGrade with one parameter
    public string CalculateGrade(int marks)
    {
        if (marks >= 90)
            return "A";

        if (marks >= 75)
            return "B";

        if (marks >= 50)
            return "C";

        return "F";
    }

    // Overloaded CalculateGrade with two parameters
    public string CalculateGrade(int marks, int bonusMarks)
    {
        return CalculateGrade(marks + bonusMarks);
    }
}

class Program
{
    static void Main()
    {
        // Constructor chaining uses the second constructor,
        // which calls the three-parameter constructor using : this(...)

        Student student = new Student("Sanjanaa", 21);

        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Age: {student.Age}");
        Console.WriteLine($"School: {student.SchoolName}");

        Console.WriteLine();
        Console.WriteLine($"Grade: {student.CalculateGrade(80)}");
        Console.WriteLine($"Grade with bonus: {student.CalculateGrade(70, 10)}");


        // Validation test

        try
        {
            student.Age = 150;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine();
            Console.WriteLine($"Validation error: {ex.Message}");
        }


        // const cannot be changed
        Console.WriteLine();
        Console.WriteLine($"Minimum age: {Student.MinimumAge}");

        // The following would cause a compile error:
        // Student.MinimumAge = 10;


        // readonly can be read after construction,
        // but cannot be changed outside the constructor.
        Console.WriteLine($"School name: {student.SchoolName}");

        // The following would cause a compile error:
        // student.SchoolName = "Another School";
    }
}
