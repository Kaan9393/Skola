using System;
using MyClassLibrary;

namespace MyGame
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Utils.ProbabilityTrue(50));     //Här deklarerar vi int percent till 50.
                //Lägger vi 50% så kmr hälften tex bli true och hälften false för vi loopar 10 ggr. 
            }
 
            Console.ReadKey();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(ProbabilityTrue(50));     //Här deklarerar vi int percent till 50.
            //    //Lägger vi 50% så kmr hälften tex bli true och hälften false för vi loopar 10 ggr. 
            //}

        }

        //Tex: Vi utvecklar ett spel, vi behöver en metod som berättar om ett procents värde är true elr false
        
    }   
}
