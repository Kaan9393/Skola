using System;

namespace Övning5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Animal animal1 = new Animal();

            if (animal1.totalLegs == 4)
            {
                animal1.speed = true;
                Console.WriteLine("snabb");

            Console.WriteLine($"Det var en gång en {animal1.age} år gammal, {animal1.type} som hette {animal1.name}.");
            Console.WriteLine($"En dag var {animal1.name} ute på en promenad i skogen, och mötte en stor varg");
            Console.WriteLine($"Vargen bet av ett ben, {animal1.name} sprang {animal1.speed} hem på sina {animal1.totalLegs}. Så var sagan slut");

            Console.ReadKey();

            // Jag vet inte hur jag ska få in "Snabb bool dvs Speed bool" så att den srkiver ut text och inte True i meningen.
        }

        
    }
}
