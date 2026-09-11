using System;
using SchoolManagement;

class Program
{
    static void Main()
    {

        Student student1 = new Student();
        student1.DisplayName();

        SchoolManagement.Student student2 = new SchoolManagement.Student();
        student2.DisplayName();

    }
}