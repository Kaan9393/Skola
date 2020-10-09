using System;
using System.Collections.Generic;
using Test4;

namespace InlämningsUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Game currentGame = new Game();
            currentGame.Start();

            Console.Clear();
            

        }
    }

    class Game
    {
        public void Start()
        {

            String[,] grid = {
                {". " , "." ,". " , "." ,". " ,". " , "." ,". " , "." ,". " },
                {". " , "." ,". " , "." ,". " ,". " , "." ,". " , "." ,". " },
                {". " , "." ,". " , "." ,". " ,". " , "." ,". " , "." ,". " },
                {". " , "." ,". " , "." ,". " ,". " , "." ,". " , "." ,". " },
                {". " , "." ,". " , "." ,". " ,". " , "." ,". " , "." ,". " },
                {". " , "." ,". " , "." ,". " ,". " , "." ,". " , "." ,". " },
                {". " , "." ,". " , "." ,". " ,". " , "." ,". " , "." ,". " },
                {". " , "." ,". " , "." ,". " ,". " , "." ,". " , "." ,". " },
                {". " , "." ,". " , "." ,". " ,". " , "." ,". " , "." ,". " },
                {". " , "." ,". " , "." ,". " ,". " , "." ,". " , "." ,". " },
                {". " , "." ,". " , "." ,". " ,". " , "." ,". " , "." ,". " },

            };

            World myWorld = new World(grid);
            myWorld.Draw();


            Console.ReadKey();

            int dx = 0;
            int dy = 1;

            int px = 2;
            int py = 2;

            while (true)
            {
                Console.Clear();

                //rita up spelplanen
                for (int y = 0; y < grid.GetLength(0); y++)
                {
                    for (int x = 0; x < grid.GetLength(1); x++)
                    {
                        if (px == x && py == y)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(" ");
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else
                            Console.WriteLine(grid[y, x]);
                    }
                    Console.WriteLine();

                }
                Console.ReadKey();

                px += dx;
                py += dy;



            }
        }
    }
}
