using System;
using System.Collections.Generic;

namespace PropertiesCodeAlongHåkan
{
    class Program
    {
        static void Main(string[] args)
        {
            // 15 sept Tisdag lektionen.

            bool registerPerson = true;
            List<Person> people = new List<Person>();          //Generera en lista med personer
                
            while (registerPerson)
            {
                Console.Write("Ange namn: ");
                string name = Console.ReadLine();

                if (name == "quit")
                    break;

                Console.Write("Ange ålder: ");
                int age = int.Parse(Console.ReadLine());

                Person person = new Person();
                person.Name = name;
                person.Age = age;

                people.Add(person);           //här adderar vi personen till vår lista
            }

            foreach(Person p in people)
                Console.WriteLine($"{p.Name} {p.Age}");

            Console.ReadKey();
        }
    }

    class Person                //denna ska läggas in i separat class ruta. Han använde det här för att lättare att visa
    {
        public string Name;
        //DEt här är på det sättet som de gör på JAVA.
        //private int Age;


        //public void SetAge(int ageValue)        //med det här löser vi problemet så använder inte matar in ett ogiltigt värde. tex ålder 800
        //{
        //    if (ageValue >= 0 && ageValue <= 110)       //detta kallas validering
        //        Age = ageValue;
        //    else
        //        Age = 0;        //Error handling - skriver någon 1000 så kmr det bli 0.
        //}   // för att komma åt Age så behöver man då anropa SetAge i Main metoden och inte Age. Då vi har angett Age som private


        //public int GetAge()     //denna behövs för att kunna använda det i foreach loopen.
        //{
        //    return Age;
        //}

        private int age;        //litet a

        public int Age          //stort A
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0 && value <= 110)
                    age = value;
                else
                    age = 0;        //Error handling
            }
            
        }
    }
}
