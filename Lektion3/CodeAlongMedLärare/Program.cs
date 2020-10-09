using System;

namespace CodeAlongMedLärare
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            // While-loop
            while (x < 3)
            {
                Console.Write($"{x} ");
                x++;
            }

            Console.WriteLine();        //hoppar 1 steg
            Console.WriteLine();        //hoppar 1 steg till

            // Do-While loop
            x = 0;
            do
            {
                Console.Write($"{x} ");
                x++;
            } while (x < 3);

            Console.WriteLine();
            Console.WriteLine();

            do
            {
                Console.Write($"{x} ");
                x++;
            } while (x < 3);

            Console.WriteLine();
            Console.WriteLine();

            Console.Write($"Värdet på x: {x}");
            Console.ReadLine();
        }
    }

}