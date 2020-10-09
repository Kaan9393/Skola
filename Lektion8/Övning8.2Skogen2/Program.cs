using System;
using System.Collections.Generic;

namespace Övning8._2Skogen2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapar en lista av djuren i en lista som heter skog
            List<Djur> skog = new List<Djur>();

            //Lägger in Djuren i listan
            


        }
    }

    class Djur
    {
        public string Typ { get; set; }
        public string Färg { get; set; }
        public int Ålder { get; set; }
    }

    class VildaDjur : Djur
    {
        public int Vikt { get; set; }
        public bool Hastighet { get; set; }
    }

    class HavsDjur : Djur
    {
        public bool SnällaElrFarliga { get; set; }
        public int AntalBen { get; set; }
    }
}
