using System;

namespace UppgiftTre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett numreriskt värde");
            double num = double.Parse(Console.ReadLine());

            double fahrenheit = ((num / 5) * 9) + 32;

            Console.WriteLine($"Talet du skrev omvandlas från Celsius till Fahrenheit: {fahrenheit} ");

            Console.ReadKey();
           
        }
    }
}
