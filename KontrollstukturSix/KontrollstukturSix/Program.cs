using System;

namespace KontrollstukturSix
{
    class Program
    {
        static void Main(string[] args)
        {
            int hemligTal = 27;         //om man vill att hemliga talet ska vara ett random tal så skriver man istället: int hemligTal = new Random() .Next(1,100); "då tar den fram ett nummer mellan 1-100"
            int numberOfGuesses = 0;    // hur många gissningar vi har gjort
            bool guessedCorrect = false;    // ifall vi har gissat rätt
            while (guessedCorrect == false)     // har vi inte gissat rätt körs detta.
            {
                Console.WriteLine("Skriv in ett tal mellan 1 och 100");
                int number = int.Parse(Console.ReadLine());
                if (number < 1 || number > 100)
                {
                    Console.WriteLine("du skrev ett tal större än 100 och mindre än 1");
                    continue;       // om vi har skrivit in ett nr större än 1 elr mindre än 100 då fortsätter programmet att köra
                }
                numberOfGuesses++;      //om vi har giltig nr då vill vi öka numberofguesses med 1 för att den ska räkna hur många ggr vi har gjort försök
                if (number < hemligTal)
                {
                    Console.WriteLine("hemliga talet är större än " + number);
                }

                else if (number == hemligTal)
                {
                    Console.WriteLine("Du gissade rätt efter " + numberOfGuesses + " gissningar med nummber " + number);
                    guessedCorrect = true;
                }
                else
                {
                    Console.WriteLine("det hemliga talet är mindre än " + number);

                }
                Console.ReadKey(true);

            }
        }
    }
}
