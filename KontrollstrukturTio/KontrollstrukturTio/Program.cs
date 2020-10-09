using System;

namespace KontrollstrukturTio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            int number = int.Parse(Console.ReadLine());
            while (number > 2)
            {
                if (number % 2 == 0)    //Jämt tal
                {
                    number /= 2;
                }
                else       // Udda tal
                {
                    number = number * 3 + 1;
                }
                Console.WriteLine(number);

            }
            Console.ReadKey(true);
        }
    }
}
