using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion4Övning
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;

            int gubbeX = 1;
            int gubbeY = 1;

            // Oändlig loop
            while (true)
            {
                // Varje rad av rutor   
                for (int n = 1; n <= size; n++)
                {
                    // Horisontella linjen i varje rad
                    Console.Write("Tak: ");
                    for (int i = 1; i <= size * 4 + 1; i++) // +1 är till för den högra väggen
                    {
                        Console.Write("x");
                    }
                    Console.WriteLine();

                    // Vertikala linjer

                    // Varje rad av tre tecken
                    for (int m = 1; m <= 3; m++)
                    {
                        Console.Write("Rad: ");

                        // Hela raden
                        for (int j = 1; j <= size * 3 + 1; j += 3) // +1 är till för den högra väggen
                        {
                            // Varje vägg i rutan
                            Console.Write("x");

                            // Varje tecken i varje ruta
                            for (int k = 1; k <= 3; k++)
                            {
                                // Möjlig placering av "gubben"
                                if (k == 2 && m == 2 && j < size * 3 + 1)
                                {

                                    // Console.Write(j/3 + "-" + n);
                                    if (j / 3 == gubbeX && n == gubbeY)
                                    {
                                        Console.Write("?");
                                    }
                                    else
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                        }
                        Console.WriteLine();
                    }
                }
                // Sista Horisontella linjen
                Console.Write("Golv:");
                for (int i = 1; i <= size * 4 + 1; i++)
                {
                    Console.Write("-");
                }

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.KeyChar == 'x')
                {
                    size++;
                }
                if (key.KeyChar == 'z')
                {
                    size--;
                }
                if (key.KeyChar == 'a')
                {
                    gubbeX--;
                }
                if (key.KeyChar == 'd')
                {
                    gubbeX++;
                }
                if (key.KeyChar == 'w')
                {
                    gubbeY--;
                }
                if (key.KeyChar == 's')
                {
                    gubbeY++;
                }


                Console.Clear();
            }

        }
    }
}
