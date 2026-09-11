//#define TRIAL_VERSION

using System;

class Student
{
    #region Fields

    private string name;
    private int age;

    #endregion

    #region Properties

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    #endregion

    #region Constructors

    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    #endregion

    #region Methods

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    #endregion
}

class Program
{
    static void Main()
    {
#if TRIAL_VERSION
        Console.WriteLine("Trial version is running.");
#else
        Console.WriteLine("Full version is running.");
#endif

        Student student = new Student("Sanjanaa", 23);
        student.Display();
    }
}