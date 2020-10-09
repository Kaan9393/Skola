using System;

namespace Loop2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 10; i > 1; i -= 3)     // i minskar med 3
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 10; i++)        //den här kommer att köras 10 gånger
            {
                for (int j = 0; j < 10; j++)       
                {
                    Console.WriteLine($"i = {i} - j = {j}, ");
                }
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
