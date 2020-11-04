using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public interface IPriceCalculator
    {
        decimal CalculatePrice();
    }
}
