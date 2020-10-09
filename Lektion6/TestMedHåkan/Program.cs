using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Såhär kan man göra på ett vanligt sätt.
            // När vi behöver fler variabler av samma typ kan man skapa en
            // ARRAY!

            //int visbyTemp;
            //int sthlmTemp;
            //int gbgTmp;

            //Console.WriteLine("Ange temp. i Visby: ");
            //visbyTemp = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ange temp. i Stockholm: ");
            //sthlmTemp = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ange temp. i Göteborg: ");
            //gbgTmp = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Medeltemp. : {(visbyTemp + sthlmTemp + gbgTmp) / 3}");

            //Console.ReadKey();



            //HÄR KOMMER ARRAY KODEN
            // Exempel 1:
            //int[] temperaturer = { 11, 12, 13 };

            //for (int i = 0; i < temperaturer.Length; i++)
            //{
            //    Console.WriteLine(temperaturer[i]);
            // }



            //EXEMPEL 2: Det vanliga sättet:
            //int[] temperaturer = new int[3];    //hur många element ska den innehålla? 3 st. Vi skapar 3 hinkar alltså. 0-1-2.
            //temperaturer[0] = 23;       //här lägger vi in något i första hinken
            //temperaturer[1] = 24;
            //temperaturer[2] = -30;

            //int sum = 0;

            //for (int i = 0; i < temperaturer.Length; i++)
            //{
            //    sum = sum + temperaturer[i];
            //}

            //int average = sum / temperaturer.Length;
            //Console.WriteLine($"{average}");

            //Console.ReadKey();



            //ANNAN EXEMPEL: När använder matar in hur många elemens som ska matas användas.

            //Console.Write("Hur många temperaturer ska registreras? ");
            //int numTemperatures = int.Parse(Console.ReadLine());

            //int[] temperatures = new int[numTemperatures];

            //for (int i = 0; i < temperatures.Length; i++)
            //{
            //    Console.WriteLine($"Ange temperatur nr {i + 1}: ");
            //    temperatures[i] = int.Parse(Console.ReadLine());
            //}

            //int sum = 0;
            //for (int i = 0; i < temperatures.Length; i++)   //här summerar vi ihop temperaturerna.
            //{
            //    sum += temperatures[i];
            //}

            //int average = sum / temperatures.Length;
            //Console.WriteLine($"{average}");

            //Console.ReadKey();





            //Skapa en Array av classen** KOLLA OM HÅKANS LIVE VIDEO FRÅN CA 01.50(TIM)
            // Är inte klar med koden. 

            Console.Write("Hur många temperaturer ska registreras? ");
            int numTemperatures = int.Parse(Console.ReadLine());

            Temperature[] temperatures = new Temperature[numTemperatures];

            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine($"Ange ort: ");
                string city = Console.ReadLine();

                Console.WriteLine($"Ange temperatur nr {i + 1}: ");
                int Atemperature = int.Parse(Console.ReadLine());

                Temperature temperature = new Temperature();
                temperature.City = city;
                temperature.Atemperature = numTemperatures;

                numTemperatures[i] = temperature;

            }

            int sum = 0;
            for (int i = 0; i < temperatures.Length; i++)   //här summerar vi ihop temperaturerna.
            {
                sum += temperatures[i];
            }

            int average = sum / temperatures.Length;
            Console.WriteLine($"{average}");

        }
    }
}
