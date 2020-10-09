using System;

namespace ArrayerFlerDimensionell
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ett Shakcbräda
            // [,], genom att skriva så får man 2 dimensionellt.

            int[,] chessBoard = new int[8, 8];          //vi väljer själva vad som är x och y, den första 8 vill vi ha x. 8 radar 8 kolumner.
            chessBoard[0, 0] = 10;                    //kolumnen högst upp längst till vänter
            chessBoard[7, 7] = 10;

            Console.ReadKey();
        }
    }
}
