using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
	public class SkuBDiscountDecorator : PriceCalculatorDecorator
	{
		int qty = 0;
		public SkuBDiscountDecorator(int quantity, IPriceCalculator pc) : base(pc)
		{
			qty = quantity;
		}
		public override decimal CalculatePrice()
		{
			decimal total = base.CalculatePrice();
			total = total - ((qty / 2) * 15);
			return total;
		}
	}
}
