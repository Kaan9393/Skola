using System;

namespace CheckpointExerciseLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ett årtal: ");

            IsLeapYear();
        }

        private static void IsLeapYear()
        {
            for (int i = 0; i < max; i++)
            {

            }
            CalculateYear();

        }

        private static void CalculateYear()
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < max; i++)
            {

            }

            if ((input % 4 == 0)|| (input % 100 == 0)|| (input % 400 == 0))
            {
                Console.WriteLine($"År {input} är ett skottår (det har 366 dagar)");
            }
            else
                Console.WriteLine($"År {input} är inte ett skottår (det har 365 dagar)");
  
        Console.ReadKey();
        
        }
    }
}
