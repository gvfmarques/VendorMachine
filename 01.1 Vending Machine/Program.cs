using System;

namespace _01._1_Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 01
            // Author: Marques, Glauber

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine ");
            Console.Write("Please insert 35 cents: ");
            int valueInserted = int.Parse(Console.ReadLine());
            Console.WriteLine("You have inserted {0} cents", valueInserted);
            Console.WriteLine("Thanks. Here is your soda.");
        }
    }
}
