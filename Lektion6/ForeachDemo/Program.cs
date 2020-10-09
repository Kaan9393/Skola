using System;

namespace ForeachDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, -4, 50, 34, 49, 14, 67, 62, 59 };
            //Det ovan är samma sak som numbers[0] = 4; numbers[1] = -4; osv..

            foreach (int item in numbers)   //för varje element (som är item) plocka ut från numbers
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
