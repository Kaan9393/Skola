using System;

namespace AbstractDemoCodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();       //Här blir det kompileringsfel för vi har lagt "abstract" i classen. Då hade vi inte lagt in Cat innan vi skrev det.

            Cat cat = new Cat();
            cat.Eat();
            Console.WriteLine(cat.Age);
        }
    }
    

    //I en abstract class kan man skriva vad som helt som i en vanlig class.
    abstract class Animal   
    {
        public int Age { get; set; }

        abstract public void Eat();       //Eat är abstrakt för vi kan egentligen inte säga hur ett djur äter.
        //{   //När man skapar ett abstract, då får man inte ha något som gör, dvs behöver man ta bort console writeline.
            //Console.WriteLine("Yummy, yummy, gott, gott");
        //}
    }

    class Cat : Animal      //Det här är en konkret class, Katter vet vi hur de äter, och vad de äter. 
    {
        public override void Eat()
        {
            Console.WriteLine("Chewing fish and prawns");
        }
    }
}
