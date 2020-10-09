using System;
using System.Linq;

namespace Lektion3Ovningar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning1();
            //Övning2();
            //Övning4();
            Övning5();
        }

        public static void Övning1()
        {
            Console.WriteLine("Är MFF Sveriges bästa lag?");
            string lag = Console.ReadLine();
            lag = lag.ToLower();            // denna returnerar ny sträg, inte omvandlar den gamla.
            // man kan annars skriva: string lowerCaseName = lag.ToLower();

            if (lag == "ja")
            {
                Console.WriteLine("Helt rätt"); 
            }
            else
            {
                Console.WriteLine("Väldigt Fel");
            }

            Console.ReadKey();
        }

        public static void Övning2()
        {
            //med hjälp av en while loop skriver ut alla tal mellan 1 och 100,
            //och markerar jämna nummer med en hakparentes omkring sig. (1 [2] 3 [4] 5 [6]...)
            //Extra◦Samma som ovan med en ”for-loop” istället.

            int i = 1;
            while (i <= 100)
            {
                
                Console.WriteLine(i);
                i++;

            }

            Console.ReadKey();
        }

        // Gör enconsole-application somskriver ut multiplikationstabellen enligt nedanstående exempel,
        //ändå till 10x10:

        public static void Övning4()
        {
            Console.Clear();
            for (int i = 1; i <= 10; i++)
            {
                for ( int j = 1; j <= 10; j++)      // en for loop inuti en for loop
                {
                    Console.Write($"{i * j} \t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

          // den första loopen körs en gång, sedan går den in i den andra for loopen
          // där inne kommer den köras totalt 10 gånger, och den multiplicerar varje gång
          // Så den första for loopen är den som går neråt, den andra for loopen mot bredden



            
        }

        public static void Övning5()
        {
            // Bish-Bosh listar alla tal mellan 1 och valfritt tal, som ska matas in av användaren.
            // Det ska gå att välja två ytterligare tal, sk Bish och Bosh-tal, även de matas in av användaren.
            // Sedan loopas talen från 1 till det valfria talet igenom.
            // Om talet är jämnt delbart med Bish - talet visas ‘Bish’ istället för talet.
            // Om talet är jämnt delbart med Bosh - talet visas ‘Bosh’ istället för talet.
            // Om talet är jämt delbart med både Bish och Bosh-talet visas ’Bish - Bosh’ istället för talet.

            Console.WriteLine("Skriv in ett tal mellan 2 och 50");
            int tal = int.Parse(Console.ReadLine());
            int i = 1;

            Console.WriteLine("Skriv in ett till tal");
            int bish = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in det andra talet");
            int bosh = int.Parse(Console.ReadLine());

            if (i <= tal)
            {
                i++;
                Console.WriteLine(i);
            }




            Console.ReadKey();
        }
    }
}
