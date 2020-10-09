using System;

namespace MyClassLibrary
{
    public class Utils          //Glöm inte att göra klassen public i klassbiblioteket så vi kan återanvända dem.
    {
        static Random random = new Random();

        /// <summary>
        /// Returns true with a probability of the percent parameter.
        /// </summary>
        /// <param name="percent">The probability value.</param>
        /// <returns></returns>

        //Vi får lägga in public innan static.
        public static bool ProbabilityTrue(int percent)    //Sannolikhet för att den ska returnera True
        {
            //Slupa ett tal mellan 1 - 100
            int randomNumber = random.Next(1, 100 + 1);     //Om vi skriver 100 kmr den returnera 99, Det är därför vi lägger +1. Vi skriver in 101 för att vi ska visa det. 
            return randomNumber <= percent;

        }
    }
}
