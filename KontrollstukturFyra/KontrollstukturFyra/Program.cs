using System;

namespace KontrollstukturFyra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en månad");

            int omvandla = -1;     //för att se om något blev fel i koden, därför assignar man värdet -1. 
            switch (Console.ReadLine())
            {
                case "januari":
                    omvandla = 1;
                    break;
                case "februari":
                    omvandla = 2;
                    break;
                case "mars":
                    omvandla = 3;
                    break;
                case "april":
                    omvandla = 4;
                    break;
                case "maj":
                    omvandla = 5;
                    break;
                case "juni":
                    omvandla = 6;
                    break;
                case "juli":
                    omvandla = 7;
                    break;
                case "augusti":
                    omvandla = 8;
                    break;
                case "september":
                    omvandla = 9;
                    break;
                case "oktober":
                    omvandla = 10;
                    break;
                case "november":
                    omvandla = 11;
                    break;
                case "december":
                    omvandla = 12;
                    break;
                default:
                    Console.WriteLine("Du skrev in en ogiltig input");
                    break;
            }

            if (omvandla == -1)
            {
                Console.WriteLine("du skrev inte en giltig månad ");
            }
            else
            {
                Console.WriteLine("Du skrev in månad " + omvandla);
            }


            Console.ReadKey(true);
        }
    }
}
