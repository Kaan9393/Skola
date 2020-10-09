using System;

namespace ObjektorienteradExempel
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog kalle = new Dog();
            kalle.Name = "Kalle";
            kalle.Age = 2;

            Dog otherDog = new Dog();
            otherDog.Name = "Missy";
            otherDog.Age = 4;

            PrintDogInformation(kalle);
            PrintDogInformation(otherDog);

            Console.ReadKey(true);
        }

        static void PrintDogInformation(Dog dog)
        {

        
            Console.WriteLine("Din hund heter " + dog.Name + "och är " + dog.Age + "år gammal");
            
        }
    }
}
