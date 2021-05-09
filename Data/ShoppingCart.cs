using System;
using System.Collections.Generic;

namespace WebShopBlazor.Data
{
    public class ShoppingCart
    {
        public ICollection<Product> Products { get; set; }
    }
}
