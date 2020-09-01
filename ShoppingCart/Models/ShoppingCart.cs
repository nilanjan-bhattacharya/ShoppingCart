using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Models
{
    public class ShoppingCart
    {
        public ICollection<ShoppingItem> CartItems { get; set; }

        public decimal GetTotalPrice()
        {
            throw new NotImplementedException();
        }

    }
}
