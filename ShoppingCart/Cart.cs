using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
   public class Cart : ICart, IPriceCalculator
    {
        private readonly IEnumerable<Item> items;

        private char[] scannedItems;
        public char[] ScannedItems { get { return scannedItems; } }

        public Cart(List<Item> items)
        {
            this.items = items;
            scannedItems = new char[] { };
        }

        public decimal CalculatePrice()
        {
            throw new NotImplementedException();
        }

        public ICart Scan(string SKU)
        {
            throw new NotImplementedException();
        }
    }
}
