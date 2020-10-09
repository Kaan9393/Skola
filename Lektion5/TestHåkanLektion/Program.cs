using System;

namespace TestHåkanLektion
{
    class Program
    {
        static void Main(string[] args)
        {
            MinBil.RegNr = "KRJ137";
            MinBil.Tillverkare = "Ford";
            MinBil.TillverkningsÅr = 2010;

            Console.WriteLine($"{MinBil.RegNr} {MinBil.Tillverkare} {MinBil.TillverkningsÅr}");

            DinBil.RegNr = "ABC123";
            DinBil.Tillverkare = "Volvo";
            DinBil.TillverkningsÅr = 2019;

            Console.WriteLine($"{DinBil.RegNr} {DinBil.Tillverkare} {DinBil.TillverkningsÅr}");

            Bil jonasBil = new Bil();       //anledningen till vrf vi måste göra såhär är för det inte finns static i classen Bil. Då kan den användas generellt för alla Bilar.
            jonasBil.RegNr = "XXX999";
            jonasBil.Tillverkare = "Aston Martin";
            jonasBil.TillverkningsÅr = 2020;

            Console.WriteLine($"{jonasBil.RegNr} {jonasBil.Tillverkare} {jonasBil.TillverkningsÅr}");


            Bil kaansBil = new Bil();       // därför behöver vi inte skapa en ny class.
            kaansBil.RegNr = "TRY111";
            kaansBil.Tillverkare = "Porsche";
            kaansBil.TillverkningsÅr = 2021;

            Random random = new Random();   // för att få random måste man ropa på den. när vi skriver random. nu så kommer alternativen upp. skulle man skrivit random. innan man skrev denna text så skulle vi inte fått några förslag. FÖR DEN ÄR INTE STATIC, DÄRFÖR MÅSTE MAN SKRIVA NEW RANDOM();
            random.

            int randomNumber = random.Next(1, 9 + 1);


            Console.ReadKey();

        }
    }
}
