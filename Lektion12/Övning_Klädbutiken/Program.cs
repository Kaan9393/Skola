using System;
using System.Collections.Generic;

namespace Övning_Klädbutiken
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin();
            bool key = true;

            ConsoleKey consoleKey = Console.ReadKey().Key;

            while (key)
            {
                if (consoleKey == ConsoleKey.A)
                {

                }

            }

            Console.ReadKey();
        }

        public static void Admin()
        {
            Plagg plagg = default;

            Console.Write("Tryck 1 för Pants: ");
            Console.Write("Tryck 2 för Shirt: ");
            Console.Write("Tryck 3 för Shoes: ");
            int plaggTyp = int.Parse(Console.ReadLine());
            plagg.Type = (Enum.GetName(typeof(Type), plaggTyp));

            Console.Write("Tryck 1 för Xs: ");
            Console.Write("Tryck 2 för S: ");
            Console.Write("Tryck 3 för M: ");
            int storlek = int.Parse(Console.ReadLine());
            plagg.Size = (Enum.GetName(typeof(Size), storlek));

            Console.Write("Tryck 1 för Blue: ");
            Console.Write("Tryck 2 för Green: ");
            Console.Write("Tryck 3 för Yellow: ");
            int färg = int.Parse(Console.ReadLine());
            plagg.Color = (Enum.GetName(typeof(Color), färg));

            Console.Write("Mata in pris för plagget");
            int pris = int.Parse(Console.ReadLine());
            plagg.Price = pris;


            Console.WriteLine($"{plagg.Type}, {plagg.Size}, {plagg.Color}, {plagg.Price}");


            List<Plagg> butik = new List<Plagg>();
            butik.Add(plagg);

            //Console.WriteLine($"{plagg.Type}, {plagg.Size}, {plagg.Color}, {(int)Enum.Parse(typeof(Price), plagg.Price, true)}");


            //List<Type> type = new List<Type>();

            //Console.Write("Lägg in TYP: Välj 1 för Pants, Välj 2 för Shirt, Välj 3 för Shoes ");
            //string plaggTyp = Console.ReadLine();
            //foreach (Type p in plaggTyp)
            //{
            //    Console.WriteLine(p);
            //}
            //Console.Write("Välj Plagg: ");
            //string plaggTyp = Console.ReadLine();

            //Console.Write("Välj Storlek: ");
            //string storlek = Console.ReadLine();

            //Console.Write("Välj Färg: ");
            //string färg = Console.ReadLine();

            //Console.Write("Välj Pris: ");
            //int pris = int.Parse(Console.ReadLine());

            //List<Plagg> clothes = new List<Plagg>();
        }
    }

    struct Plagg
    {
        public string Type { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        public Plagg(string type, string size, string color, int price)
        {
            Type = type;
            Size = size;
            Color = color;
            Price = price;
        }
    }

    enum Type
    {
        Pants = 1,
        Shirt = 2,
        Shoes = 3,
    }
    enum Size
    {
        Xs = 1,
        S = 2,
        M = 3,
    }
    enum Color
    {
        Blue = 1,
        Green = 2,
        Yellow = 3,
    }
}
