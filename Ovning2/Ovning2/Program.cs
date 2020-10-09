using System;

namespace Ovning2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mycket pengar har du på kontot?");
            double pengar = double.Parse(Console.ReadLine());
            Console.WriteLine("Vad har du för ränta?");
            double ränta = double.Parse(Console.ReadLine());
            double sum = pengar * ränta; 
            Console.WriteLine("Ditt saldo efter ränta är " + sum);
            Console.ReadKey(true);
        }
    }
}

