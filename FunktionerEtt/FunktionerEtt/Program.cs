using System;

namespace FunktionerEtt
{
    class Program
    {
        static double Add(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            double nr = Add(2, 3);
            Console.WriteLine(nr);
        }
    }
}
