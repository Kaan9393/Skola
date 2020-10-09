using System;

namespace Abstract
{                                   //Vi kan inte skapa en instans direkt av abstract class animal. Utan behöver ske genom icke abstrakta klasser.
    abstract class Animal           //Den här har inget med standard classen Animal att göra.
    {
        // Abstract method does not have a body.

        abstract public void AnimalSound();     //då det är abstrac kan vi inte lägga till {} utan avslutar med ;

        //Regular method
        public void Sleep()
        {
            Console.WriteLine("Zzzzz");
        }
    }

    class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Grisen säger: Nöff nöff");
        }
    }
}
