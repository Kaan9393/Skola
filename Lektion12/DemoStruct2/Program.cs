using System;

namespace DemoStruct2
{
    struct PersonStruct
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }
    }

    class Program
    {
        /* static int i; */         //Så kan man också skriva istället för att deklarera default
        /*static PersonStruct ps1;*/

        static void Main(string[] args)
        {
            int i; /* = default; */
            int j = i;
            Console.WriteLine(j);

            PersonStruct ps1; /*default; */
            PersonStruct ps2 = ps1;         //ps2 & ps1 är olika delar i minnet pga struct. De refererar inte till samma minnesvärde.
            Console.WriteLine(ps2);
        }
    }
}
