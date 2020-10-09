using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addera(1, 2);  // //C# gör automatiskt, a = 1; och b = 2; I Addera koden i nästa steg


            for (int i = 0; i < 10; i++)        //kmr köra 10 ggr
            {
                if (IsOdd(i))       //att inte göra en metod så kunde man skrivit i%2==1 inuti if
                Console.WriteLine($"Talet {i} är ett udda tal ");
                else
                Console.WriteLine($"Talet {i} är ett jämt tal");
                Console.ReadKey();
            }
        }

        //private static void Addera(int a, int b)
        //{
        //    Console.WriteLine($"{a} + {b} = {a + b}");
        //}

        private static bool IsOdd(int i)        // om i är udda = true, om i jämt = false
        {
            bool odd = i % 2 == 1;
            return odd;             // odd är bool värde, metoden ska returnera ett bool värde
        }
    }
}
