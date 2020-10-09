using System;

namespace Loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal = 20;

            while (tal > 1)
            {
                Console.WriteLine(tal);

                tal = tal - 2;
            }
        }
    }
}
