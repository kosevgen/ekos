using System;


namespace lesson_1_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\t\t@This program for testing class@");

            Console.WriteLine("\n\n\t\t\t This resalt of first class: \n");
            FirstClass_1 first = new FirstClass_1();
            first.DoFirstClass(26, 23, 15);
            Console.WriteLine("\n\n\t\t\t First class is end");

            //Console.WriteLine("\n\n\n\t\t\t This resalt of class Building: \n");
            //Building_2 office = new Building_2();
            //office.SetFloors(3);
            //office.GetFloorArreaOfTheBuilding();
            //Console.WriteLine("\n\n\t\t\t Class \"Building\" is end");

            Console.WriteLine("\n\n\t\t\t This resalt of Constr_3 class: \n");
            Constr_3 cons = new Constr_3();
            Constr_3 consParam = new Constr_3(120);
            Constr_3 consFullParam = new Constr_3(120, 12, 4, 5);
            Console.WriteLine("\n\t\t\t First constructor cons is\t\t" + cons);
            Console.WriteLine("\n\t\t\t First constructor consParam is\t\t" + consParam);
            Console.WriteLine("\n\t\t\t First constructor consFullParam is\t" + consFullParam);
            Console.WriteLine("\n\n\t\t\t Constr_3 class is end");

            Console.WriteLine("\n\n\t\t\t This resalt of Child class: \n");

            Child Dima = new Child();
            Child Ivan = new Child();
            Dima.skinColor = "European race";
            Dima.toys = Ivan.toys = "EpiToys";
            Dima.height = 80;
            Dima.weight = 24;
            Dima.age = 8;
            Dima.dadyName = "Ivan";
            Dima.dadyLastName = "Ivanov";
            Dima.mamyName = "Ira";
            Dima.mamyLastName = "Ivanova";
            Dima.dadyPhoneNamber = "+380683181995";
            Dima.dadyPhoneNamber = "+380683184977";

            Ivan.skinColor = Dima.skinColor;
            Ivan.height = 98;
            Ivan.weight = 30;
            Ivan.age = 10;
            Ivan.dadyName = "Andry";
            Ivan.dadyLastName = "Pashkov";
            Ivan.mamyName = "Emmy";
            Ivan.mamyLastName = "Pashkova";
            Ivan.dadyPhoneNamber = "+380976554875";
            Ivan.mamyPhoneNumber = "+380976548789";

            

            Console.WriteLine("\t\t\tChild Dima ");
            Console.WriteLine("\t\t\tDima age is " + Dima.age);
            Console.WriteLine("\t\t\tDima height is " + Dima.height);
            Console.WriteLine("\t\t\tDima weight is " + Dima.weight);
            Console.WriteLine("\t\t\tDima dady name is " + Dima.dadyName + " " + Dima.dadyLastName);
            Console.WriteLine("\t\t\tDima mamy name is " + Dima.mamyName + " " + Dima.mamyLastName + "\n\n\n");

            Console.WriteLine("\t\t\tChild Ivan ");
            Console.WriteLine("\t\t\tIvan age is " + Ivan.age);
            Console.WriteLine("\t\t\tIvan height is " + Ivan.height);
            Console.WriteLine("\t\t\tIvan weight is " + Ivan.weight);
            Console.WriteLine("\t\t\tIvan dady name is " + Ivan.dadyName + " " + Ivan.dadyLastName);
            Console.WriteLine("\t\t\tIvan mamy name is " + Ivan.mamyName + " " + Ivan.mamyLastName + "\n\n\n");

            Console.WriteLine("\n\n\t\t\t Child class is end");

            Console.ReadKey();

        }
    }
}
