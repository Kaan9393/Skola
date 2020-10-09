using System;
using System.Text;

namespace CodeAlongKlasserOchProperties
{
    public class Program2
    {
        internal static void PersonStory()
        {
            //classes and properties
            Person p1 = new Person();
            p1.Name = "Nisse";
            p1.BirthYear = 1980;
            p1.HasCar = true;
            p1.Age = Person.CalculateAge(p1.BirthYear);

            Console.WriteLine(Person.BuildStory(p1));


            Person p2 = new Person();
            p2.Name = "Anna";
            p2.BirthYear = 2000;
            p2.HasCar = true;
            p2.Age = Person.CalculateAge(p2.BirthYear);

            Console.WriteLine(Person.BuildStory(p2));
        }
    }
}
