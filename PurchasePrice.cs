using System;
using System.Collections.Generic;
using System.Text;

namespace _02._2_CanRack
{
    class PurchasePrice
    {
        private int price = 0;

        public PurchasePrice()
        {
            price = 0;
        }

        public PurchasePrice(int initialPrice)
        {
            price = initialPrice;
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
