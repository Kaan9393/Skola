using System;

namespace Övning4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();


            Console.WriteLine("Press Enter to roll the Dice");
            Random rnd = new Random();
            int number = rnd.Next(1, 7);
            int i = 0;

            //while (true)
            //{
         

                while (i != number)
                {
                    Console.ReadKey();

                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("Du slog 1:\n[      ]\n[   O  ]\n[      ]\n");
                            break;
                        case 2:
                            Console.WriteLine("Du slog 2:\n[O     ]\n[      ]\n[     O]\n");
                            break;
                        case 3:
                            Console.WriteLine("Du slog 3:\n[O     ]\n[   O  ]\n[     O]\n");
                            break;
                        case 4:
                            Console.WriteLine("Du slog 4:\n[O    O]\n[      ]\n[O    O]\n");
                            break;
                        case 5:
                            Console.WriteLine("Du slog 5:\n[O    O]\n[   O  ]\n[O    O]\n");
                            break;
                        case 6:
                            Console.WriteLine("Du slog 6:\n[O    O]\n[O    O]\n[O    O]\n");
                            break;
                    }

                //}

                Console.ReadKey();
            }

        }
    }
}
