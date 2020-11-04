using System.Collections.Generic;
using Xunit;
namespace ShoppingCart.Tests
{
    public class CartTest
    {
        private ICart cart;
        public CartTest()
        {
            List<Item> items = new List<Item>()
               {
                new Item{SKU = 'A', Price = 50},
                new Item{SKU = 'B', Price = 30},
                new Item{SKU = 'C', Price = 20},
                new Item{SKU = 'D', Price = 15}
            };
            cart = new Cart(items);
        }

        [Fact]
        public void No_item_scanned_returns_zero()
        {
            IPriceCalculator priceCalculator = (IPriceCalculator)cart;

            cart.Scan("");
            decimal actual = priceCalculator.CalculatePrice();
            Assert.Equal(0, actual);
        }
    }
}
