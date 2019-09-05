using System;

namespace Day2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Adventurer");
            Console.WriteLine("Choose Your Class");
            Console.WriteLine("Fighter Mage Rouge");
            string className = Console.ReadLine();

            Console.WriteLine("Add Character Name");
            string charName = Console.ReadLine();
            Console.WriteLine(className + " " + charName);
        }
    }
}
