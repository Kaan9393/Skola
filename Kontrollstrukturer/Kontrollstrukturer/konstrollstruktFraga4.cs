using System;

namespace Kontrollstrukturer
{
    class Program
    {
        static void Main(string[] args)
        {
            // be användaren skriva in en månad
            // gör om månaden till månadens siffervärde (tex januari blir 1 och dec 12)
            // använd switch

            string månad = Console.ReadLine();
            string månad1 = "januari";
                     

            switch (månad)
            {
                case månad1 :
                        Console.WirteLine("Januari är månad 1");
                    break;

                    

            }
            




            // Ibland kan inte kompilatorn i förväg garantera att en konvertering blir rätt.
            //String number = ”fem”;
            //Int x = number;
            //Detta blir då fel och vi behöver använda parsing
            //String number = ”5”;
            //Int x = int.Parse(number);


              
        }
    }
}