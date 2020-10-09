using System;

namespace UppgiftTvå
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in det första decimaltalet");
            double numberOne = double.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in andra decimaltalet");
            double numberTwo = double.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in tredje decimaltalet");
            double numberThree = double.Parse(Console.ReadLine());

            double sum = (numberOne + numberTwo + numberThree); 

            Console.WriteLine($"Summan av de tre talen är: {Math.Round(sum)}");
            Console.WriteLine($"Medelvärdet av de tre talen är: {Math.Round(sum) / 3}");

            Console.ReadKey();

            // Skapa en console applikation som tar in 3 decimaltal som beräknar och skrivet ut summan
            // samt medelvärdet.
            // extra uppgift. Gör så att de omavndlar decimaltalen till närmaste heltal
        }
    }
}
