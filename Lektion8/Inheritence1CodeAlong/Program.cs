using System;
using System.Collections.Generic;

namespace Inheritence1CodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Först gör vi en lista av djur, listan döper vi till zoo
            List<Animal> zoo = new List<Animal>();

            //Vi skapar ugglan och lägger in i listan zoo genom Add.
            Owl owl = new Owl(1,true, 100);         //weight, är nattdjur, wingspan
            zoo.Add(owl);

            //Skapar dolphin, lägger in i zoo
            Dolphin dolphin = new Dolphin(50, false, 200);     //weight, är inte nattdjur, äter 200 fiskar
            zoo.Add(dolphin);

            //Skapar häst, lägger in i zoo
            Horse horse = new Horse(600, false, 20);        //weight, inte nattdjur, äter 20 göd
            zoo.Add(horse);

            //Vi loopar igenom varje djur i vårt zoo
            foreach (Animal anAnimal in zoo)
            {
                Console.WriteLine($"Weight: {anAnimal.Weight}");
                Console.WriteLine($"Nocturnal: {anAnimal.Nocturnal}");
                anAnimal.Move();

                if (anAnimal is Owl)         //*****Att hamna i denna situation ska man försöka undvika. Man ska bara jobba med polymorphism
                {
                    Console.WriteLine($"Wingspan: {((Owl)anAnimal).Wingspan}");
                }

                if (anAnimal is Dolphin)
                {
                    Console.WriteLine($"Fish per day: {((Dolphin)anAnimal).FishPerDay}");
                }

                if (anAnimal is Horse)
                {
                    Console.WriteLine($"Hay per day: {((Horse)anAnimal).HayPerDay}");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }

    //Animal is our base class.
    class Animal
    {
        public int Weight { get; set; }
        public bool Nocturnal { get; set; }


        public virtual void Move()      //detta är polymophism
        {
            Console.WriteLine("blablabla...");
        }
    }
    //Här ärver Owl, Weight och Nocturnal från Animal.
    class Owl : Animal
    {
        public int Wingspan { get; set; }

        //Här skapar vi en Construktor med 3 parametrar, och deklarerar namnen. 
        public Owl(int weight, bool isNocturnal, int wingspan)
        {
            Weight = weight;
            Nocturnal = isNocturnal;
            Wingspan = wingspan;
        }

        public override void Move()
        {
            Console.WriteLine("The Owl flies around in the sky...");
        }
    }

    class Dolphin : Animal
    {
        public int FishPerDay { get; set; }

        //Skapa Construktor i Dolphin
        public Dolphin(int weight, bool isNocturnal, int fishPerDay)
        {
            Weight = weight;
            Nocturnal = isNocturnal;
            FishPerDay = fishPerDay;
        }

        public override void Move()
        {
            Console.WriteLine("The dolphin swims around in the wast ocean.");
        }
    }

    class Horse : Animal
    {
        public int HayPerDay { get; set; }

        //Skapa Construktor i Horse.
        public Horse(int weight, bool isNocturnal, int hayPerDay)
        {
            Weight = weight;
            Nocturnal = isNocturnal;
            HayPerDay = hayPerDay;
        }

        public override void Move()
        {
            Console.WriteLine("The horse walks around in the park.");
        }
    }

}
