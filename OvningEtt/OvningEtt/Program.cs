using System;

namespace OvningEtt
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slumptal = new Random();
            int tal = slumptal.Next(0, 100);

            Console.WriteLine("Gissa på ett tal mellan 0 - 100");
            int randomNr = int.Parse(Console.ReadLine());

            if (randomNr == tal)
            {
                Console.WriteLine("Rätt");
            }
            else
            {
                Console.WriteLine($"fel, talet är {tal},  gissa igen");
            }

            Console.ReadKey();      
        }

    }

}
