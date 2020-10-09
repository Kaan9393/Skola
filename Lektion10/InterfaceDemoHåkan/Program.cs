using System;

namespace InterfaceDemoHåkan
{
    class Program
    {
        static void Main(string[] args)
        {
            //IActivity activity = new Dog();
            //activity.MainActivity();

            //Vi byter ut Dog med Car: *1.

            IActivity activity = new Car();
            activity.MainActivity();
        }
    }

    //Interface ligger i samma nivå som classerna, dvs i namespace.
    //Namnet ska alltid börja med ett ett stort I

    interface IActivity
    {
        //I interface är alla metoder publika. Så man behöver inte skriva public void...
        //Deklarerar en metod
        void MainActivity();
    }

    //För att använda det här interface behöver vi implementera det i en class.
    class Dog : IActivity
    {
        public void MainActivity()
        {
            Console.WriteLine("Barking and eating all day long");   //exempel på hundens aktivitet
        }   //Efter det här kan vi skapa en ny dog i Main programmet.
    }


    //Vi lägger på en till class här nedan *1.
    class Car : IActivity
    {
        public void MainActivity()
        {
            Console.WriteLine("Driving and honking the horn");
        }
    }
}

//Vad används Interface till? .NET använder en mängd av Interface. Vi gör detta för att förstå vad det är.
//Vi kommer inte behöva i stort sätt skapa egna Interface. .NETcore innehåller många som vi kmr dra nytta av