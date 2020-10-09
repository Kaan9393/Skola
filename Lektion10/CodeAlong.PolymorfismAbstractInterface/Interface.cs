using System;
namespace InterfaceExample
{
    interface IAnimal
    {
        void AnimalSound();                            //alla interfacemetoder är public
    }

    class Pig : IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Grisen säger Nöff nöff");
        }
    }


    //Implement multiple interfaces.

    //Vi deklarerar 2 interface
    interface IFirstInterface
    {
        void MyMethod();
    }

    interface ISecondInterface
    {
        void MyOtherMethod();
    }

    class DemoClass : IFirstInterface, ISecondInterface         //ska inkludera dessa två
    {
        public void MyMethod()
        {
            Console.WriteLine("Inside MyMethod");
        }

        public void MyOtherMethod()
        {
            Console.WriteLine("Iside MyOtherMethod");
        }
    }
}
