using System;

namespace Lektion4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parse
            Console.WriteLine("mata in ett tal mellan 1 och 5");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine($"du matade in talet; {tal}");
            // skriver man in håkan här så blir det fel i tal.

            // om man skriver in håkan nu så kraschar inte programmet utan skriver ut ogiltig inmatning
            Console.WriteLine("mata in ett tal mellan 1 och 5");
            string tangentbordinmatning = Console.ReadLine();
            int result;
            bool ok = int.TryParse(tangentbordinmatning, out result);

            if (ok)
                Console.WriteLine($"du matade in talet: {result}");
            else
                Console.WriteLine("ogiltig inmatning");
            









            //Console.WriteLine("Mata in ett heltal mellan 1 och 5");
            //int heltal = int.Parse(Console.ReadLine());

            // If-satser

            //if (heltal == 1)
            //    Console.WriteLine("Du matade in siffran 1");
            //else if (heltal == 2)
            //    Console.WriteLine("Du matade in siffran 2");
            //else if (heltal == 3)
            //    Console.WriteLine("Du matade in siffran 3");
            //else if (heltal == 4)
            //    Console.WriteLine("Du matade in siffran 4");
            //else if (heltal == 5)
            //    Console.WriteLine("Du matade in siffran 5");


            // switch-sats, här gör vi om till switch-sats

            //switch (heltal)      // i parenteser skrivar man in vad man vill undersöka
            //{
            //    case 1:         // när heltalet är lika med 1 då kör den denna
            //        Console.WriteLine("Du matade in siffran 1");
            //        break;
            //    case 2:         // när heltal är lika med 2 kör den denna osv
            //        Console.WriteLine("Du matade in siffran 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("Du matade in siffran 3");
            //        break;
            //    case 4:
            //        Console.WriteLine("Du matade in siffran 4");
            //        break;
            //    case 5:
            //        Console.WriteLine("Du matade in siffran 5");
            //        break;
            //    case 6:         // det går även att göra så att 6 och 7 returnerar samma värde genom att lägga de under varandra.
            //    case 7:
            //        Console.WriteLine("Du matade in siffran 6 eller 7");
            //        break;
            //    default:            // vad gör vi om inget av dessa stämmer.
            //        Console.WriteLine("Du matade in ett ogiltigt tal");
            //        break;
            //}

            //Console.WriteLine("Switch är slut här");
            //Console.ReadKey();
        }
    }
}
