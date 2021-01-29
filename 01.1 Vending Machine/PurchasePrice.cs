using System;
using System.Collections.Generic;
using System.Text;

namespace _01._1_Vending_Machine
{
    class PurchasePrice
    {
        // This constructor sets the purchase price to zero
        public PurchasePrice()
        {
        }
        // This constructor allows a new purchase price to be set by the user
        public PurchasePrice(int initialPrice)
        {
            initialPrice = int.Parse(Console.ReadLine());
        }
        // This property gets and sets the value the purchase price.
        public int Price { get; set; }
    }
}
