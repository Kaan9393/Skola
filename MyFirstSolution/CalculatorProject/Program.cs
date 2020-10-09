using System;

namespace CalculatorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange första talet: ");
            string firstNumber = Console.ReadLine();

            Console.Write("Ange andra talet: ");
            string secondNumber = Console.ReadLine();

            // nu vill vi konvertera stringen till heltal:
            int firstNumberInt = int.Parse(firstNumber);
            int secondNumberInt = int.Parse(secondNumber);

            Console.WriteLine($" {firstNumber} + {secondNumber} = {firstNumberInt + secondNumberInt} ");
            Console.WriteLine($" {firstNumber} - {secondNumber} = {firstNumberInt - secondNumberInt} ");
            Console.WriteLine($" {firstNumber} * {secondNumber} = {firstNumberInt * secondNumberInt} ");
            Console.WriteLine($" {firstNumber} / {secondNumber} = {firstNumberInt / secondNumberInt} ");
            Console.WriteLine($" {firstNumber} % {secondNumber} = {firstNumberInt % secondNumberInt} ");

            Console.ReadLine();
        }
    }
}
