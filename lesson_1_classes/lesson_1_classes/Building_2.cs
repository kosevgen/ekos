using System;


namespace lesson_1_classes
{
    class Building_2
    {

        private int floors;

        public void SetFloors(byte enterFloors )
        {

            floors = enterFloors;
            Console.WriteLine(" In building " + floors + " floors");

        }

        public void GetFloorArreaOfTheBuilding()
        {
            double[] floorsArray = new double[floors];
            double floorArreaOfTheBuilding = 0.00;
            for (int i = 0; i < floors; i++) {

                Console.WriteLine("\t\t\t Enter arrea floor #" + (i+1));
                floorsArray[i] = Convert.ToDouble(Console.ReadLine());
                floorArreaOfTheBuilding += floorsArray[i];

            }

            Console.WriteLine("\n\n\n\t\t\t General arrays equal " + floorArreaOfTheBuilding);

        }


    }
}
