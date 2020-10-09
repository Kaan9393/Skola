using System;
using System.Collections.Generic;

namespace TestForeach14Sept
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multidimensional arrays
            CreateGrid();


            Console.ReadKey();
        }

        public static void CreateGrid()
        {
            int width = 5;
            int height = 5;

            int[,] grid = new int[5, 5];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                Console.Write(grid[x,y] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
