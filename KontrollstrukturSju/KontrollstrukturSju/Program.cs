using System;

namespace KontrollstrukturSju
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 20; i > 1; i--)
            {
                if (i % 2 == 0) Console.WriteLine(i);
            }
            Console.ReadKey(true);
        }
    }
}
