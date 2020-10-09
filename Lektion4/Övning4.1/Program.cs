using System;

namespace Övning4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNow = (int)DateTime.Now.DayOfWeek;
            
            for (int i = 0; i < 8; i++)
            {

                    switch (i)
                    {
                        case 1:
                        IfToday(i);
                        Console.WriteLine("Monday");
                            break;
                        case 2:
                        IfToday(i);
                        Console.WriteLine("Tuesday");
                            break;
                        case 3:
                        IfToday(i);
                        Console.WriteLine("Wednesday");
                            break;
                        case 4:
                            IfToday(i);
                            Console.WriteLine("Thursday");
                            break;
                        case 5:
                        IfToday(i);
                        Console.WriteLine("Friday");
                            break;
                        case 6:
                        IfToday(i);
                        Console.WriteLine("Saturday");
                            break;
                        case 7:
                        IfToday(i);
                        Console.WriteLine("Sunday");
                            break;
                    }
                       
                    Console.ReadKey();
            }
           
                 void IfToday(int i)
                {
                    if (i == dayNow)
                    Console.Write("IDAG\t");
                }
        }

    }
}