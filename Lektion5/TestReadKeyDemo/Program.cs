using System;

namespace TestReadKeyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // här går vi genom ReadKey, dvs att det ska hända något när man trycker på en knapp

            ConsoleKeyInfo consoleKey = Console.ReadKey();
            //Vad har användaren tryckt in för knappar?


            //if(consoleKey.Key == ConsoleKey.A)             //denna kan man göra i switch också, lägga in console.key.A osv
            //    Console.WriteLine("Du tryckte på tangenten A");


            
        }
    }
}
