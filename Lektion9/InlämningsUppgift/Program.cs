using System;
using System.Collections.Generic;

namespace InlämningsUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista av personer
            List<Person> bibliotekPerson = new List<Person>();

            //Spelplan, colum går ->, rows går neråt

            int rowsY = 25;
            int columX = 100;
            String[,] spelplan = new string[rowsY, columX];

            for (int x = 0; x < columX; x++)
            {
                for (int y = 0; y < rowsY; y++)
                {
                    spelPlan[y, x] = " ";
                }
            }

            //Lista av personer
            for (int t = 0; t < 20; t++)
            {
                bibliotekPerson.Add(new Tjuv(t, t, 1, 1, "T"));
            }

            for (int p = 0; p < 10; p++)
            {
                bibliotekPerson.Add(new Polis(p, p, 6, 6, "P"));
            }

            for (int m = 0; m < 30; m++)
            {
                bibliotekPerson.Add(new Medborgare(m, m, 3, 3, "M"));
            }


            foreach (Person a in bibliotekPerson)
            {
                a.PositionX = a.PositionX + a.DirectionX;
                a.PositionY = a.PositionY + a.DirectionY;

                if (a.PositionX < 0 && a.PositionY < 0)
                {

                }
            }



        }



        class Person
        {
            public int PositionX { get; set; }
            public int PositionY { get; set; }
            public int DirectionX { get; set; }
            public int DirectionY { get; set; }
            public string Label { get; set; }
            //Inventory? 

            public void Move()
            {
                // Denna är för att Position X och Y ska ändras, för det behöver vi plussa DirectionX,Y.
                PositionX = PositionX + DirectionX;
                PositionY = PositionY + DirectionY;

                if (PositionX < 0)
                {
                    PositionX = DirectionX;
                }
                if (PositionY < 0)
                {
                    PositionY = DirectionY;
                }
            }

            public virtual char GetBoardChar()
            {
                return '?';
            }

        }

        class Tjuv : Person
        {
            public Tjuv(int positionX, int positionY, int directionX, int directionY, string label)
            {
                PositionX = positionX;
                PositionY = positionY;
                DirectionX = directionX;
                DirectionY = directionY;
                Label = label;
            }

            public override char GetBoardChar()
            {
                return 'T';
            }

            //gör en metod med STEAL
        }

        class Polis : Person
        {
            public Polis(int positionX, int positionY, int directionX, int directionY, string label)
            {
                PositionX = positionX;
                PositionY = positionY;
                DirectionX = directionX;
                DirectionY = directionY;
                Label = label;
            }

            public override char GetBoardChar()
            {
                return 'P';
            }

            ///Gör en metod med beslagtaget
        }

        class Medborgare : Person
        {
            public Medborgare(int positionX, int positionY, int directionX, int directionY, string label)
            {
                PositionX = positionX;
                PositionY = positionY;
                DirectionX = directionX;
                DirectionY = directionY;
                Label = label;
            }

            public override char GetBoardChar()
            {
                return 'M';
            }

        }
    }
}