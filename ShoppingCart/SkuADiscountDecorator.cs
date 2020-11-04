using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
	public class SkuADiscountDecorator : PriceCalculatorDecorator
	{
		int qty = 0;
		public SkuADiscountDecorator(int quantity, IPriceCalculator pc) : base(pc)
		{
			qty = quantity;
		}
		public override decimal CalculatePrice()
		{
			decimal total = base.CalculatePrice();
			total = total - ((qty / 3) * 20);
			return total;
		}
	}
}
