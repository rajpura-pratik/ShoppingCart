using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
	public class SkuCandDDiscountDecorator : PriceCalculatorDecorator
	{
		int qty = 0;
		public SkuCandDDiscountDecorator(int quantityC, int quantityD, IPriceCalculator pc) : base(pc)
		{
			qty = (quantityC <= quantityD) ? quantityC : quantityD;
		}
		public override decimal CalculatePrice()
		{
			throw new NotImplementedException();
		}
	}
}
