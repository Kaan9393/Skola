using System;

namespace Övning1Switch
{
    class Program
    {

        static void Main(string[] args)
        {
            // Bankomaten
            //◦ Skapa en Console Application som:
            //◦ med hjälp av en switch sats skapar en inmatningsmeny för en bankomat. Alternativen ska vara:[I]nsättning
            //[U]ttag
            //[S]aldo
            //[A]vsluta
            //Lägg till kod för att hantera kontot, utgå ifrån ett konto med noll kr.
            //Saldot ska visa senaste 10 kontohändelser

            Console.WriteLine("Skriv in din PIN");
            int pin = int.Parse(Console.ReadLine());

            int atm = 0;
            string transaction = "";


            while (true)
            {
                Console.WriteLine("\n---------------------------");
                Console.WriteLine("Välkommen till bankomaten ");
                Console.WriteLine("1. Insättning");
                Console.WriteLine("2. Uttag");
                Console.WriteLine("3. Saldo");
                Console.WriteLine("4. Avsluta");
                Console.WriteLine("Välj ett alternativ ovan:\t");

                int inputMeny = int.Parse(Console.ReadLine());      //denna är för valet i menyn

                switch (inputMeny)
                {
                    case 1:
                        Console.Write("Hur mycket vill du sätta in?\t");
                        int a = int.Parse(Console.ReadLine());
                        atm = atm + a;
                        Console.WriteLine($"Ditt nuvarande saldo är: {atm}.");
                        transaction = transaction + " Insättning: " + a + "\n";     // + DateTime.Now - för att få tid o datum
                        break;

                    case 2:
                        Console.Write("Hur mycket pengar vill du ta ut?\t");
                        int b = int.Parse(Console.ReadLine());
                        if (b <= atm)
                        {
                            Console.WriteLine("Uttag slutfört");
                            atm = atm - b;
                            Console.WriteLine($"Ditt nuvarande saldo är: {atm}.");
                            transaction = transaction + "Uttag: " + b + "\n";       // + DateTime.Now - för att få tid o datum

                        }

                        else
                        {
                            Console.WriteLine("Du har inte tillräckligt med pengar");
                        }
                        break;

                    case 3:
                        Console.Write($"\n\nDitt saldo är: {atm}");
                        //Console.Write($"\n\nDe senaste kontohänderlserna:\nInsättning: {händelse}\nUttag: {händelse1} ");
                        Console.WriteLine($"\n\nDe senaste kontohändelserna: \n{transaction} ");
                        break;
                    default:
                        Console.WriteLine("Avslutar, tack!");
                        break;
                   

                }
            }
        }
    }
}
