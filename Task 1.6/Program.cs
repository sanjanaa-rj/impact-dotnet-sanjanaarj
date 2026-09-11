using System;

namespace ModuleA
{
    public class Helper
    {
        public static void Greet()
        {
            Console.WriteLine("I'm from Module A");
        }
    }
}

namespace ModuleB
{
    public class Helper
    {
        public static void Greet()
        {
            Console.WriteLine("I'm from Module B");
        }
    }
}

class Program
{
    static void Main()
    {
        ModuleA.Helper.Greet();
        ModuleB.Helper.Greet();
    }
}
