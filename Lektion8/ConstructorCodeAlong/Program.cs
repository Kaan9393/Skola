using System;

namespace ConstructorCodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nu skapar vi en ny instans/objekt av Car.
            RunConstructorDemo();

            //Här är ett exempel där man kan skriva med Ternary. När man kan lägga in if och else. 
            //Console.WriteLine($"En {myCar.Model} som är {myCar.Age} år {(myCar.Age < 5 ? "ny" : "gammal")}");
        }

        private static Car RunConstructorDemo()
        {
            Car myCar = new Car("Volvo V70", 2006);
            Console.WriteLine($"En {myCar.Model} som är {myCar.Age} år.");
            return myCar;
        }
    }
}
