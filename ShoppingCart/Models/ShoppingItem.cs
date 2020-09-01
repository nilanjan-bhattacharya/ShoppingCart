using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Models
{
    public class ShoppingItem
    {
        public SKU Item { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
