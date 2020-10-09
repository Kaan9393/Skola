using System;

namespace KontrollstrukturNio
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal = 65536;

            while (tal > 2)
            {
                Console.WriteLine(tal);
                tal = tal / 2;

            }
        }
    }
}
