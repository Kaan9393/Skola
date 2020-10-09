using System;
using System.Linq; 

namespace ArrayerEtt
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (x == y) Console.Write("#");

                    else
                        Console.Write(".");
                }
                Console.WriteLine("");
            }
        }
    }
}
