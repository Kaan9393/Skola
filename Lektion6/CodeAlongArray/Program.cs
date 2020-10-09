using System;

namespace CodeAlongArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int[] siffror = new int[5];
            siffror[0] = 11;
            siffror[1] = 785;
            siffror[2] = 4;
            siffror[3] = 130470;
            siffror[4] = 19;

            for (int i = 0; i < siffror.Length; i++)
            {
                Console.WriteLine(siffror[i] * 3);
            }

            string[] countDown = new string[6];
            countDown[0] = "Three";
            countDown[1] = "Two";
            countDown[2] = "One";
            countDown[3] = "Go...";

            for (int j = 0; j < countDown.Length; j++)
            {
                Console.WriteLine(countDown[j]);
            }

            string[] saga = new string[6];
            saga[0] = "Det";
            saga[1] = "var";
            saga[2] = "en";
            saga[3] = "gång";
            saga[4] = "en";
            saga[5] = "gubbe";

            for (int j = 0; j < saga.Length; j++)
            {
                Console.Write($"{saga[j]} ");
            }

            Console.WriteLine();        //denna läggs in för att få en radbrytning


                              //  Element:    0         1         2        3
            int[,] siffror2 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };  //object initializer syntax  //TVÅ DIMENSIONELL ARRAY
            Console.WriteLine(siffror2[2,1]);       // skriver ut siffran 6. för 2 är andra gubben i nr 6.

            string[,] tabell = { { "Anna", "Johan", "Esmeralda" }, { "Stockholm", "Göteborg", "Malmö" } };

            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine($"{tabell[0, k]} bor i {tabell[1,k]}");
            }

            int[] numbers = { 9, 5, 6, 1, 2 };
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            Console.ReadKey();


        }
    }
}
