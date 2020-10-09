using System;

namespace Övning2Metoder
{
    class Program
    {
        //Skapa en Console Application med tre metoder:
        //... Addera() som tar två heltal och returnerar summan.
        //... Moms() som tar ett tal som inparameter och räknar ut momsen.Anta att moms är 25%.
        //... Moms() som tar ett tal och moms och returnerar resultatet.

        static int x;
        static int y;


        static void Main(string[] args)
        {
            Console.WriteLine("Mata in första talet");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Mata in andra talet");
            int y = int.Parse(Console.ReadLine());

            Addera(x, y);
            Moms1(x);
            Moms2();
        }

        static void Addera(int x, int y)
        {
            Console.WriteLine($"Summan av {x} och {y} är: {x + y}");

            Console.ReadKey();
        }

        static void Moms1(int x)
        {
            Console.WriteLine($"Momsen av {x} är: {x * 0.25}. Momsen är 25%");
            Console.ReadKey();
        }

        static void Moms2()
        {

        }
        

    }
}
