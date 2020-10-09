using System;
using System.Collections.Generic;    // för att använda List behöver man detta

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> djur = new List<string>();    //vi skapar en instans av klassen List
            djur.Add("Katt");
            djur.Add("Hund");
            djur.Add("Kanariefågel");

            for (int i = 0; i < djur.Count; i++)
            {
                if (djur[i] == "Hund")
                    djur[i] = "Bulldog";

                Console.WriteLine(djur[i]);
            }

            Console.WriteLine("----");

            foreach (string anAnimal in djur)
            {
                Console.WriteLine(anAnimal);
            }

            Console.ReadKey();
        }
    }
}
