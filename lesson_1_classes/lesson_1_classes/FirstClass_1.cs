using System;


namespace lesson_1_classes
{
    public class FirstClass_1
    {

        byte buildings;
        int floors;
        byte rooms;

        private void WriteCMD(String cmdWrite) {

            Console.WriteLine("\t" + cmdWrite + "\n");

        }

        private void SetBuildings(byte a)
        {

            buildings = a;
            WriteCMD("building = " + a);

        }

        private void SetFloors(int b) {

            floors = b;
            WriteCMD("floors = " + b);

        }

        private void SetRooms(byte c)
        {

            rooms = c;
            WriteCMD("roooms = " + c);

        }

        public void DoFirstClass(byte a, int b, byte c)
        {

            SetBuildings(a);
            SetFloors(b);
            SetRooms(c);

        }


    }
}
