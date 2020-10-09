using System;
namespace Standard          //Här byter vi ut namespace till Standard
{
    class Animal     //Base class (parent)
    {
        public void AnimalSound()
        {
            Console.WriteLine("Djuret låter.");
        }
    }

    class Pig : Animal      //Derived class (subklass/childklass)
    {
        new public void AnimalSound()       //Vi har ärvt denna animalsound, **Vi skrev new för ??
        {
            Console.WriteLine("The pig says: Oink oink");
        }
    }

    class Dog : Animal      //Derived class (subklass/childklass)
    {
        new public void AnimalSound()
        {
            Console.WriteLine("The dog says: Bark bark");
        }
    }
}
