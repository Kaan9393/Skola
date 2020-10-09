using System;
using System.Linq;

namespace TestÖvningar
{
    class Program
    {
        // Övningar från w3resource.com. C# foor loop 83 exercises with solution
        static void Main(string[] args)
        {
            //Övning2();
            Övning3();
            //Övning4();
            //Övning5();
        }

        public static void Övning2()
        {
            int sum = 0;

            Console.WriteLine($"The first 10 numbers is:");
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;              //här summerar vi alla tal som loopas för varje gång
                Console.Write($"{i} ");     // här skrivs endast de loopade talen ut
            }
            Console.Write($"\nThe Sum is: {sum}");

            Console.ReadKey();
        }

        public static void Övning3()
        {
            int sum = 0;

            Console.WriteLine("Write a number");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"You choose number {num} ;");
            for (int i = 1; i <= num; i++)
            {
                Console.Write($"{i} ");
                sum = sum + i;
            }
            Console.WriteLine($"\nThe Sum is: {sum} ");
            Console.ReadKey();
        }
    }
    
}
