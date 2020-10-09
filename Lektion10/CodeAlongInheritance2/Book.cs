using System;
namespace CodeAlongInheritance2
{
    public class Book
    {
        //Vi ska inte ha publika klassvariabler. Vi ska egentligen använda propp
        public int Pages;       
        public string Author;
        public int Price;

        //Skulle vi inte ha en construktor här, så skulle Pages,Author,Price vara noll. Därför är det GIVET att man skapar en ctor.

        public Book(int pages, string author, int price)
        {
            Pages = pages;
            Author = author;
            Price = price * 2;      // när priset kommer in dubblar vi priset
        }
    }
}
