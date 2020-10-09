using System;

namespace Övning5._1Fortsättning
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal.AnimalStory();
            Console.ReadLine();

        }
    }

    class Animal
    {
        public string AnimalType { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public int Age { get; set; }
        public int Legs { get; set; }
        public bool Speed { get; set; }


        public static void AnimalStory()
        {
            Animal an1 = new Animal();
            an1.AnimalType = "Dog";
            an1.Name = "Flash";
            an1.BirthYear = 2010;
            an1.Age = Animal.CalculateAge(an1.BirthYear);
            an1.Legs = 4;
            an1.Speed = true;

            Console.WriteLine(Animal.BuildStory(an1));
        }

        public static int CalculateAge(int BirthYear)
        {
            int year = DateTime.Now.Year;
            return year - BirthYear;

        }


        public static string BuildStory(Animal an)
        {
            string story = $"Det var en gång en {an.Name} år gammal {an.AnimalType}. En dag var {an.Name} ute på promenad i skogen och mötte en varg. Vargen bet av ett ben. {an.Name} sprang ";
            if (an.Speed)
            {
                story += $"snabbt med {an.Legs} ben. Så var sagan slut. ";
            }
            else
                story += "långsamt";

            return story;
                            
        }

    }
}
