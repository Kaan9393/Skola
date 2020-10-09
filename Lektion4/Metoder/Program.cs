using System;

namespace Metoder
{
    class Program
    {
        static int a;
        static int b;
        static int x;
        static int y;

        public static void Main(string[] args)
        {
            Console.WriteLine("ange det första heltalet: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("ange det andra heltalet: ");
            b = int.Parse(Console.ReadLine());

            Addera(a,b);

            //bool temp = IsWeatherNice();

            //if(temp)
            //    Console.WriteLine("grattis vad trevligt");
            //else
            //    Console.WriteLine("å, så tråkigt");

            //Console.WriteLine("nu ska vi köra metoden 'GreetTheWorld()'");
            //GreetTheWorld();
            //GreetTheWorld();
            //GreetTheWorld();
            //Console.WriteLine("nu har vi kört metoden 'GreetTheWorld()'");

            //string message = SayHello();
            //Console.WriteLine(message);
            Console.WriteLine(SayHello());      //denna är exakt samma som ovan
        }

        static void GreetTheWorld()
        {
            Console.WriteLine("Hello scandinavian");
            Console.WriteLine("Hello sweden");
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello universe");
        }

        static string SayHello()
        {
            return "Hello World!";
        }

        static bool IsWeatherNice()
        {
            Console.WriteLine("Är det trevligt väder idag (Ja/Nej): ");
            string reply = Console.ReadLine();
            bool isac = reply.ToLower() == "ja";        //svara man något annat än ja blir det false
            return isac;      //man behöver skriva return värde om man inte har void i metoden.
        }

        static void Addera(int p, int q)
        {
            Console.WriteLine($"summan av {p} och {q} är {p+q} ");
        }
    }
}
