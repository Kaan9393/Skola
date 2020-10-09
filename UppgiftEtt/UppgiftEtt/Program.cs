using System;

namespace UppgiftEtt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ditt namn: ");
            string name = Console.ReadLine();

            Console.Write("Är du en han eller hon? ");
            string kön = Console.ReadLine();

            Console.Write("Hur gammal är du? ");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);

            Console.Write("Vilken stad bor du i? ");
            string city = Console.ReadLine();


            Console.WriteLine($"Det var en gång en elev som hette {name}");
            Console.WriteLine($"En dag var {kön} ute på promenad i {city} ");
            Console.WriteLine($"Katten frågade: - Vem är du?");
            Console.WriteLine($"Eleven svarade: - Jag heter {name}, och är {age} år gammal");
            Console.WriteLine($"Katten sa: - Du verkar trevlig, och ditt namn, {name}, låter sympatiskt");
            Console.WriteLine($"Katten fortsatte: - Jag är {age - 8} år yngre än dig, men vi kan nog bli vänner");
            Console.WriteLine($"Eleven sa: Låt oss slå följe i {city}");
            Console.WriteLine($"Så var sagan slut!");

            Console.ReadKey();
        }
    }
}
