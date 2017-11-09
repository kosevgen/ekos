using System;

namespace ConsoleApp1
{
    public class Class1
    {

        public static void Main() {

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Title = "First program!!!";

     
            Console.WriteLine("\tProgram abaut types\n");

            int a = 256;
            int b = 256000000;
            double c = 3.141548778994553332;

            Console.WriteLine(" int a = " + a);
            Console.WriteLine("\n\n\n");
            Console.WriteLine(" int b = " + b);
            Console.WriteLine("\n\n\n");

            Console.WriteLine(" double c = " + c);
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t THE END!!! ");
            Console.ReadKey();


        }

}
}
