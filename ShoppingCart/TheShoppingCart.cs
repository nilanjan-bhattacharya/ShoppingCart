using ShoppingCart.Models;
using ShoppingCart.RuleEngine;
using System.Collections.Generic;

namespace ShoppingCart
{
    public class TheShoppingCart
    {
        private decimal _finalValue;


        private IEnumerable<ShoppingItem> _cartItems;
        
        public TheShoppingCart(IEnumerable<ShoppingItem> cartItems)
        {
            _cartItems = cartItems;
        }

        public decimal GetBasketValue()
        {
            InitializeCartItems();

            PromotionCalculator promotionCalculator = new PromotionCalculator(_cartItems, PromotionRules.GetPromotions());

            _finalValue = promotionCalculator.ComputeResult();

            return _finalValue;
        }

        private void InitializeCartItems()
        {
            foreach (var item in _cartItems)
            {
                item.TotalPrice = item.Quantity * item.Item.Price;
            }
        }

    }
}
