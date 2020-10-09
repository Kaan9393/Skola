using System;

namespace SkottÅr
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Mata in ett årtal ");
            int årtal = int.Parse(Console.ReadLine());

            //Vi behöver deklarera isLeapyear för att kunna använda den i Main.
            bool leapYear = IsLeapYear(årtal);

            if (leapYear)
            {
                Console.WriteLine($"År {årtal} är ett skottår (det har 366 dagar)");
            }
            if else
                    cw
            else
                Console.WriteLine($"År {årtal} är inte ett skottår (det har 365 dagar)");

            

                Console.ReadKey();
        }

        public static bool IsLeapYear(int årtal)
        {
            if (årtal % 4 == 0)
            {
                return true;
                //Console.WriteLine($"År {årtal} är ett skottår (det har 366 dagar)");
            }
            else if (årtal % 100 == 0)
            {
                return false;
                //Console.WriteLine($"År {årtal} är inte ett skottår (det har 365 dagar)");
            }

            else if (årtal % 400 == 0)
            {
                return true;
                //Console.WriteLine($"År {årtal} är ett skottår (det har 366 dagar)");
            }
            else if (årtal == 0)
            {
                return false;
            }
            else
            {
                return false;
                //Console.WriteLine($"År {årtal} är inte ett skottår (det har 365 dagar)");
            }
        }
    }
}
