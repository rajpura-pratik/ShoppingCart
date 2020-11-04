using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public interface ICart
    {
        ICart Scan(String SKU);       
        char[] ScannedItems { get; }
    }
}
