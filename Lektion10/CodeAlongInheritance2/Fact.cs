using System;
namespace CodeAlongInheritance2
{
    public class Fact : Book
    {
        public string Subject;

        //Sättet att anropa basklassens construktor är att skriva " : base() som nedan"
        public Fact(int pages, string author, int price, string subject) :base(pages, author, price)
        {
            Subject = subject;
        }
    }
}
