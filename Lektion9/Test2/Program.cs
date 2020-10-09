using System;
using System.Collections.Generic;

namespace InlämningsUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Spelplan
            int X = 100;
            int Y = 25;
            String[,] spelPlan = new string[X, Y];


            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 100; y++)
                {
                    spelPlan[y, x] = " ";
                }
            }


            //Tjuv
            List<Tjuv> bibliotekTjuv = new List<Tjuv>();

            for (int t = 0; t < 20; t++)
            {
                 bibliotekTjuv.Add(new Tjuv(t, t, 1, 1, "T"));
            }
            foreach (Person itemTjuv in bibliotekTjuv)
            {
                itemTjuv.Move();
                if (spelPlan[itemTjuv.DirectionX, itemTjuv.DirectionY] == " ")
                {
                    spelPlan[itemTjuv.DirectionX, itemTjuv.DirectionY] = itemTjuv.Token;
                }
                else if (spelPlan[itemTjuv.DirectionX, itemTjuv.DirectionY] == "M" && itemTjuv is Tjuv)
                {
                    spelPlan[itemTjuv.DirectionX, itemTjuv.DirectionY] = "X";
                }
                else if (spelPlan[itemTjuv.DirectionX, itemTjuv.DirectionY] == "T" && itemTjuv is Polis)
                {
                    spelPlan[itemTjuv.DirectionX, itemTjuv.DirectionY] = "X";
                }
            }
            

            //Polis
            List<Polis> bibliotekPolis = new List<Polis>();
            for (int p = 0; p < 10; p++)
            {
                bibliotekPolis.Add(new Polis(p, p, 6, 6, "P"));
            }
            foreach (Person itemPolis in bibliotekPolis)
            {
                itemPolis.Move();
                if (spelPlan[itemPolis.DirectionX, itemPolis.DirectionY] == " ")
                {
                    spelPlan[itemPolis.DirectionX, itemPolis.DirectionY] = itemPolis.Token;
                }
                else if (spelPlan[itemPolis.DirectionX, itemPolis.DirectionY] == "P" && itemPolis is Tjuv)
                {
                    spelPlan[itemPolis.DirectionX, itemPolis.DirectionY] = "X";
                }
            }

            //Medborgare
            List<Medborgare> bibliotekMedborgare = new List<Medborgare>();
            for (int m = 0; m < 30; m++)
            { 
                bibliotekMedborgare.Add(new Medborgare(m, m, 3, 3, "M"));
            }
            foreach (Person itemMed in bibliotekMedborgare)
            {
                itemMed.Move();
                if (spelPlan[itemMed.DirectionX, itemMed.DirectionY] == " ")
                {
                    spelPlan[itemMed.DirectionX, itemMed.DirectionY] = itemMed.Token;
                }
                else if (spelPlan[itemMed.DirectionX, itemMed.DirectionY] == "M" && itemMed is Tjuv)
                {
                    spelPlan[itemMed.DirectionX, itemMed.DirectionY] = "X";
                }
            }

            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 100; y++)
                {
                    Console.Write(spelPlan[y,x]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            


        }



        class Person
        {
            public int PositionX { get; set; }
            public int PositionY { get; set; }
            public int DirectionX { get; set; }
            public int DirectionY { get; set; }
            public string Token { get; set; }
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
            public Tjuv(int positionX, int positionY, int directionX, int directionY, string token)
            {
                PositionX = positionX;
                PositionY = positionY;
                DirectionX = directionX;
                DirectionY = directionY;
                Token = token;
            }

            public override char GetBoardChar()
            {
                return 'T';
            }

            //gör en metod med STEAL
        }

        class Polis : Person
        {
            public Polis(int positionX, int positionY, int directionX, int directionY, string token)
            {
                PositionX = positionX;
                PositionY = positionY;
                DirectionX = directionX;
                DirectionY = directionY;
                Token = token;
            }

            public override char GetBoardChar()
            {
                return 'P';
            }

            ///Gör en metod med beslagtaget
        }

        class Medborgare : Person
        {
            public Medborgare(int positionX, int positionY, int directionX, int directionY, string token)
            {
                PositionX = positionX;
                PositionY = positionY;
                DirectionX = directionX;
                DirectionY = directionY;
                Token = token;
            }

            public override char GetBoardChar()
            {
                return 'M';
            }

        }
    }
}
