using System;

namespace DemoEXCEPTION
{
    class Program
    {
        static void Main(string[] args)
        {
            //En kod som skapar undantagsfel:

            Console.Clear();

            /*Console.Write("Vänligen mata in ett tal att dividera med: ");
            int denominator = int.Parse(Console.ReadLine());
            Console.WriteLine($"10 / {denominator} = {10 / denominator}"); */



            //Matar vi in 0, så kommer "Unhandled exception". Skriver vi in Håkan så blir det annan exception.
            //Ett sätt att se de kommande Exception är att man kan hålla musen på Connsole.ReadLine elr int.Parse
            //Ett sätt att hantera det är att använda try catch.

            //------------------------------------------------------------------------------------------------

            //Vi ska undersöka om vi kan undvika dessa Exception fel. Utan try Cactch


            /*Console.Write("Vänligen mata in ett tal att dividera med: ");
            string input = Console.ReadLine();
            int denominator = 0;
            if (input != null)
            {
                denominator = int.Parse(input);
            }
            Console.WriteLine($"10 / {denominator} = {10 / denominator}"); */

            //Det blir jättejobbigt att kontrollera dessa problem.

            //----------------------------------------------------------------------------------------

            //****TRY CATCH, där vi tror kommer bli exception. Så sätter vi dit den:

            /*Console.Write("Vänligen mata in ett tal att dividera med: ");
            try
            {
                string input = Console.ReadLine();
                int denominator = 0;
                denominator = int.Parse(input);
                Console.WriteLine($"10 / {denominator} = {10 / denominator}");
            }
            //Uppstår det något fel i koden try, så kommer den att hoppa till Catch.
            catch
            {
                Console.WriteLine("Ogiltig inmatning eller stort tal");
            }

            //Här kan vi lägga in loop för att användaren ska testa flera gånger.
            //Göra en Do - While: */

            //----------------------------------------------------------------------------------------
            //                          (((((MED LOOP)))))

            /*bool done = false;

            do
            {
                Console.Write("Vänligen mata in ett tal att dividera med: ");

                try
                {
                    string input = Console.ReadLine();
                    int denominator = 0;
                    denominator = int.Parse(input);
                    Console.WriteLine($"10 / {denominator} = {10 / denominator}");
                    done = true;
                }
                catch (DivideByZeroException dbz)
                {
                    Console.WriteLine("Du har försökt dividera med 0");
                }
                catch (FormatException dbz)
                {
                    Console.WriteLine("Du har inte matat in ett heltal");
                }
                catch (OverflowException dbz)
                {
                    Console.WriteLine("För stort heltal");
                }
                catch //*(Exception e) går att lägga in här. Denna lägger vi så i fall längst ner. 
                {
                    //*Console.WriteLine(e.Message); Då kommer specifika meddelanden.
                    Console.WriteLine("Ogiltig inmatning eller stort tal");
                    done = false;
                }

            } while (!done);

            Console.WriteLine("Programmet slut");
            Console.ReadKey(); */

            //Det går även att lägga in flera catch {} under try och inte bara 1. 
            //----------------------------------------------------------------------------------------

        }
    }
}
