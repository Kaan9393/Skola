using System;

namespace ConstructorCodeAlong
{
    public class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public int Age { get; set; }

        //Nu ska vi lägga till en Construktor Metod:
        public Car(string model, int year)
        {
            Model = model;
            Year = year;
            Age = DateTime.Now.Year - year;     //Istället för att skriva 2020 använde vi DateTime
        }
    }
}
