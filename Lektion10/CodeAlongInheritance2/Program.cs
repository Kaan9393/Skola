using System;

namespace CodeAlongInheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fact f = new Fact(300,"Micke", 150, "OOP Programmering");
            Console.WriteLine($"{f.Pages} pages, written by {f.Author} about {f.Subject}, and the price is {f.Price}");

        }
    }
}
