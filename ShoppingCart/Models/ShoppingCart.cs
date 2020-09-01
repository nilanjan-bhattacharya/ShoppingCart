using ShoppingCart.RuleEngine;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Models
{
    public class Basket
    {
        public decimal FinalValue { get; set; }

        private ICollection<ShoppingItem> _cartItems;


        public Basket(ICollection<ShoppingItem>
            cartItems)
        {
            _cartItems = cartItems;

            foreach (var item in _cartItems)
            {
                item.TotalPrice = item.Quantity * item.Item.Price;
            }

            PromotionCalculator promotionCalculator = new PromotionCalculator(_cartItems);

            FinalValue = promotionCalculator.ComputeResult();
        }


    }
}
