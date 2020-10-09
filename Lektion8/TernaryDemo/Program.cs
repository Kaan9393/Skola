using System;

namespace TernaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadKey(true).Key == ConsoleKey.S ? "Sant" : "Falskt" ;

            //Det här nedan kan skrivas som här ovan, som kallas Ternary.

            //if (Console.ReadKey(true).Key == ConsoleKey.S)
            //    s = "Sant";
            //else
            //    s = "Falskt";

            //Detta gör man när man vill skriva mindre text typ. 

            Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
