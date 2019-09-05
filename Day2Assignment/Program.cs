using System;

namespace Day2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Adventurer");
            Console.WriteLine();

            Console.WriteLine("Choose Your Class:");
            Console.WriteLine("Fighter Mage Rouge");
            string className = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Add Character Name:");
            string charName = Console.ReadLine();

            
            Console.WriteLine();
            Console.WriteLine(charName + " the " + className);
            Console.WriteLine("Enjoy your Journey");
        }
    }
}
