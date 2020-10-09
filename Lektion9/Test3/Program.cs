using System;
using System.Collections.Generic;
using System.Threading;

namespace InlämningsUppgift
{
    class Program
    {
        public static string collide;

        static void Main(string[] args)
        {

            Console.Clear();
            //Lista med Personer
            List<Person> people = new List<Person>();
            Random rnd = new Random();

            //Spelplan
            int X = 100;
            int Y = 25;
            String[,] spelPlan = new string[X, Y];

            while (true)
            {

                for (int x = 0; x < 25; x++)
                {
                    for (int y = 0; y < 100; y++)
                    {
                        spelPlan[y, x] = " ";
                    }
                }

                for (int i = 0; i < 20; i++)
                {
                    people.Add(new Tjuv(rnd.Next(0, 98 + 1), rnd.Next(0, 23 + 1), rnd.Next(-1, 1 + 1), rnd.Next(-1, 1 + 1), "T"));
                    people.Add(new Polis(rnd.Next(0, 98 + 1), rnd.Next(0, 23 + 1), rnd.Next(-1, 1 + 1), rnd.Next(-1, 1 + 1), "P"));
                    people.Add(new Medborgare(rnd.Next(0, 98 + 1), rnd.Next(0, 23 + 1), rnd.Next(-1, 1 + 1), rnd.Next(-1, 1 + 1), "M"));
                }

                foreach (Person a in people)
                {
                    a.PositionX += a.DirectionY;    //Samma som: a.positionX = a.positionx + a.directionY
                    a.PositionY += a.DirectionX;

                    if (a.PositionX == -1 && a.DirectionY == -1)
                    {
                        a.PositionX = 23;
                    }
                    else if (a.PositionX == 25 && a.DirectionY == 1)
                    {
                        a.PositionX = 0;
                    }
                    else if (a.PositionY == -1 && a.DirectionX == -1)
                    {
                        a.PositionY = 98;

                    }
                    else if (a.PositionY == 100 && a.DirectionX == 1)
                    {
                        a.PositionX = 0;
                    }


                    if (spelPlan[a.PositionX, a.PositionY] == " ")
                    {
                        spelPlan[a.PositionX, a.PositionY] = a.Token;
                    }
                    else if (spelPlan[a.PositionX, a.PositionY] == "T" && a is Polis)
                    {
                        spelPlan[a.PositionX, a.PositionY] = "X";
                        collide = "Polis fångar tjuv";
                    }
                    else if (spelPlan[a.PositionX, a.PositionY] == "M" && a is Tjuv)
                    {
                        spelPlan[a.PositionX, a.PositionY] = "X";
                        collide = "Tjuv skäl från medborgare";
                    }


                    for (int x = 0; x < 25; x++)
                    {
                        for (int y = 0; y < 100; y++)
                        {
                            Console.Write(spelPlan[y, x]);
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine(collide);
                    if (collide != " ")
                    {
                        Thread.Sleep(200);
                    }
                }

                
            }


        }



        class Person
        {
            public int PositionX { get; set; }
            public int PositionY { get; set; }
            public int DirectionX { get; set; }
            public int DirectionY { get; set; }
            public string Token { get; set; }
            //Inventory? 

            public void Move()      //Ska jag använda det här?
            {
                // Denna är för att Position X och Y ska ändras, för det behöver vi plussa DirectionX,Y.
                //PositionX = PositionX + DirectionX;
                //PositionY = PositionY + DirectionY;

                //if (PositionX < 0)
                //{
                //    PositionX = DirectionX;
                //}
                //if (PositionY < 0)
                //{
                //    PositionY = DirectionY;
                //}
            }

            //public virtual char GetBoardChar()        //Använda det här?
            //{
            //    return '?';
            //}

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

            //public override char GetBoardChar()
            //{
            //    return 'T';
            //}

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

            //public override char GetBoardChar()
            //{
            //    return 'P';
            //}

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

            //public override char GetBoardChar()
            //{
            //    return 'M';
            //}

        }
    }
}
