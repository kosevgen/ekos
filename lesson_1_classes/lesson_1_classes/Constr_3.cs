using System;


namespace lesson_1_classes
{
    class Constr_3
    {
        int floors;
        int buildings;
        int rooms;
        int humans;

        public Constr_3()
        {
            floors = 9;
            buildings = 18;
            rooms = 5;
            humans = 4;

        }

        public Constr_3(int build)
        {

            buildings = build;
            floors = 9;
            rooms = 5;
            humans = 4;

        }

        public Constr_3(int build, int floo, int room, int human)
        {
            buildings = build;
            floors = floo;
            rooms = room;
            humans = human;
            
        }

       

    }
}
