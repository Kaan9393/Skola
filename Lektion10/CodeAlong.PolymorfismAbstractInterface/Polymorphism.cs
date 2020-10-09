using System;
namespace Polymorphism
{

    class Animal     //Base class (parent)
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("Djuret låter.");
        }
    }

    class Pig : Animal      //Derived class (subklass/childklass)
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The pig says: Oink oink");
        }
    }

    class Dog : Animal      //Derived class (subklass/childklass)
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The dog says: Bark bark");
        }
    }
}
