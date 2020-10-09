using System;

namespace CodeAlongSwitchMeny
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                PrintMenu();

                string input = Console.ReadLine();
                Console.WriteLine("----------------------------------");

                switch (input)
                {
                    case "1":
                        AngeSiffra();
                        break;
                    case "2":
                        AngeSiffra2();
                        break;
                    case "3":
                        AngeNamn();
                        break;
                    case "4":
                        AngeSiffra3();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Vad vill du göra: ");
            Console.WriteLine("1. Ange siffra a (1)");
            Console.WriteLine("2. Ange siffra b (2)");
            Console.WriteLine("3. Ange namn (3)");
            Console.WriteLine("4. Ange siffra c (4)");
            Console.WriteLine("5. Avsluta: ");
            Console.Write("-> ");
        }

        private static void AngeSiffra3()
        {
            Console.WriteLine("Ange siffra, TryParse: ");
            string input3 = Console.ReadLine();
            int number;
            bool success = int.TryParse(input3, out number);

            if (success)
            {
                Console.WriteLine($"Converted {input3} to {number}.");
            }
            else
            {
                Console.WriteLine($"Attempted conversion of {input3} failed.");
            }

        }

        private static void AngeNamn()
        {
            Console.WriteLine("Ange namn: ");
            string name = Console.ReadLine();

            switch (name.ToLower())
            {
                case "micke":
                case "håkan":
                    Console.WriteLine("Lärare");
                    break;
                case "christer":
                    Console.WriteLine("Chefen");
                    break;
                default:
                    Console.WriteLine("Elev");
                    break;
            }
        }

        private static void AngeSiffra2()
        {
            Console.Write("Ange siffra, switch: ");
            string input1 = Console.ReadLine();
            int caseSwtich1 = int.Parse(input1);

            switch (caseSwtich1)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Case default");
                    break;
            }
        }

        private static void AngeSiffra()
        {
            Console.Write("Ange siffra, switch: ");
            string input1 = Console.ReadLine();
            int caseSwtich1 = int.Parse(input1);

            switch (caseSwtich1)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Case default");
                    break;
            }
        }
    }
}
