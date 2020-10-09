using System;
using System.Collections.Generic;

namespace ListArrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            /* double[] numbers = new double[3];        //Size of the array skrivs i den nya[]
            /The array can hold 3 numbers
            numbers[0] = 12.7;
            numbers[1] = 10.3;
            numbers[2] = 6.11;

            /Istället för att initiera variabler här ovan i varje rad så kan man direkt
            /göra det i den första raden med new double[3]. Som här under:
            double[] numbers = new double[] { 12.7, 10.3, 6.11};
            Det går även att ta bort double i new.


            double results = numbers[0];
            results = results + numbers[1]; //Detta går även att skriva results += numbers[1];
            results = results + numbers[2];
            Console.WriteLine(results);

            /Istället för att skriva det ovan kan man göra en foreach för att minska kodskrivandet och inte skriva dubbelt så mkt.
            double[] numbers = new double[] { 12.7, 10.3, 6.11 };
            double result = 0.0;
            foreach (double number in numbers)
            {
                result += number;
            }
            Console.WriteLine(result);
            */


            // ---------------------------------------------------------------------------

            //double[] numbers = new double [] { 12.7, 10.3, 6.11 };
            //double grades = new List<double>() { 12.7, 10.3, 6.11 };
            //List<double> grades = new List<double>();
            //Nu lägger vi in en ytterligare grade i listan saker i Listan:
            //grades.Add(56.1);

            //Det ovan går att lägga in i listan direkt som nedan:
            //****
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1};
            grades.Add(56.1);

            var result = 0.0;
            foreach (var number in grades)
            {
                result += number;
            }
            //Få ut medelvärdet i detta:
            result = result / grades.Count;     //Count is how many items there is in the list.
            Console.WriteLine($"The average grade is: {result:N1} ");
            //Denna med N1 säger hur många decimaltal vi vill ha i resultatet.


            Console.ReadKey();
        }
    }
}
