using System;

namespace CodeAlongENUM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(Week.Onsdag); //Ger Onsdag
            Console.WriteLine((int)Week.Onsdag);    //Ger 2

            Console.WriteLine($"Sundag: {Week.Torsdag} är veckans {(int)Week.Torsdag +1: a dag}");
            Console.WriteLine();
            Console.WriteLine("Veckans alla dagar: ");

            foreach (string w in Enum.GetNames(typeof(Week)))
            {
                Console.WriteLine(w);
            }
            Console.WriteLine();
            Console.WriteLine(Enum.GetName(typeof(Week),4)); //Ger fredag

            Console.ReadKey();
        }
    }

    enum Week
    {
        Måndag,
        // Måndag = 1, //startar index från 1. Man kan tilldela numren själv också.
        // tex Måndag = 33, Tisdag = 43 osv
        Tisdag,
        Onsdag,
        Torsdag,
        Fredag,
        Lördag,
        Söndag
    }
}
