using System;

namespace MyFirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vad gammal är du?");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            Console.WriteLine($" Du är född {2020 - age}");

        }
    }
}
