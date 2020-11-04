using System;
using System.Collections.Generic;
using System.Linq;

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
            decimal total = 0;
            total = scannedItems.Sum(i => ItemPrice(i));
            return total;
        }

        private int ItemPrice(char sku)
        {
            return items.Single(p => p.SKU == sku).Price;
        }

        public ICart Scan(string SKU)
        {
            if (!String.IsNullOrEmpty(SKU.ToString()))
            {                
                scannedItems = SKU
                    .ToCharArray()
                    .Where(scannedSKU => items.Any(i => i.SKU == scannedSKU))
                    .ToArray();
            }
            return this;
        }
    }
}
