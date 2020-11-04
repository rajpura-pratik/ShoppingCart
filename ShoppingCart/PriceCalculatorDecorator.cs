using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
	public class PriceCalculatorDecorator : IPriceCalculator
	{
		IPriceCalculator priceCalculator;	

		public PriceCalculatorDecorator(IPriceCalculator pc)
		{
			priceCalculator = pc;
		}

		public virtual decimal CalculatePrice()
		{
			return priceCalculator.CalculatePrice();
		}
	}
}
