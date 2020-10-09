using System;

namespace CodeAlongSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)        //loop som inte tar slut
            {
                Console.Write("Ange siffra, swtich: ");
                //string input1 = Console.ReadLine();
                //int caseSwitch1 = int.Parse(input1);
                int caseSwitch1 = int.Parse(Console.ReadLine());    //enklare att skriva såhär än ovan
                switch (caseSwitch1)
                {
                    case 1:
                        Console.WriteLine("Case 1");
                        break;
                    default:
                        break;
                }

                Console.WriteLine("---");

                Console.Write("Ange siffra, swtich: ");
                int caseSwitch2 = int.Parse(Console.ReadLine());
                switch (caseSwitch2)
                {
                    case 1:
                        Console.WriteLine("Case 1");
                        break;
                    case 2:
                    case 3:
                        Console.WriteLine("Case 2 or 3");
                        break;
                    case 4:
                        Console.WriteLine("Case 4");
                        break;
                    default:
                        Console.WriteLine("Default case...");
                        break;
                }

                Console.WriteLine("---");

                Console.Write("Ange namn: ");
                string name = Console.ReadLine().ToLower();

                switch (name)
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

                Console.WriteLine("------------------------------------");

                Console.Write("Ange siffra, TryParse: ");
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
        }
    }
}
