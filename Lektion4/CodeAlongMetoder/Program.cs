using System;

namespace CodeAlongMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoText();
            Addera(3, 5);
            Console.ReadKey();
        }

        private static void Addera(int v1, int v2)
        {
            Console.WriteLine($"Summan blir: {v1 + v2}");
        }

        private static void InfoText()
        {
            Console.WriteLine("Nu ska vi summera 3 och 5");
        }
    }
}
