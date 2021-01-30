using System;
using System.Collections.Generic;

namespace _02._2_CanRack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 02.2
            // Author: Marques, Glauber

            PurchasePrice sodaPrice = new PurchasePrice(30);
            CanRack sodaRack = new CanRack();

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine ");
            Console.Write("Please insert {0} cents: ", sodaPrice.Price);
            int valueInserted = int.Parse(Console.ReadLine());
            Console.WriteLine("You have inserted {0} cents", valueInserted);
            sodaRack.RemoveACanOf("REGULAR");
            Console.WriteLine("Thanks. Here is your soda.");
        }
    }
}
