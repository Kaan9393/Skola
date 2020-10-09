using System;

namespace CodeAlongMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoText();
            Addera(9, 11);
            int result = Subtrahera(25, 13);
            Console.WriteLine(result);

            Console.WriteLine($"Belopp med moms: {AmountIncludingMoms(100)}");
            Console.ReadKey();
        }

        private static double AmountIncludingMoms(int v)
        {
            return v + AdderarMoms(v);
        }

        private static double AdderarMoms(int v)
        {
            return v * 0.25;
        }

        private static int Subtrahera(int v1, int v2)
        {
            int r = v1 - v2;
            return r;
        }

        private static void Addera(int v1, int v2)
        {
            Console.WriteLine(v1 + v2);
        }
        // För att få en optimal kodning så ska man inte skriva console writeline i metoden ovan utan i Main metoden
        // utan då kan man ändra void till int och skriva tex int sum = v1+v2, och sedan return sum;
        // Det är inte optimalt att ha consolewriteline i metoden för när man ska använda metoden i en annan aplikation så har de kanske inte consolewriteline utan en annan metod att skriva ut texten
        private static void InfoText()
        {
            Console.WriteLine("En text...");
        }
    }
}
