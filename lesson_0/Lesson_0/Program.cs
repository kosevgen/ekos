using System;


namespace Lesson_0
{
    class Program
    {
        static void Main()
        {

            Console.Clear();
            Console.Title = "\t\t\tLesson 0";

            Console.WriteLine("\tProgram abaut types\n");

            int a = 100_000;
            decimal b = 10_000_000_998.1233355446M;

            Console.WriteLine("int a = {1} decimal b = {2} ", a, b);

            Console.ReadKey();

        }
    }
}

