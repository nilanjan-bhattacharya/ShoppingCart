using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.RuleEngine
{
    /// <summary>
    /// The class where Context for the rule engine is set up
    /// </summary>
    class PromotionCalculator : IPromotionCalculator
    {
        private IEnumerable<ShoppingItem> items; // data items in the rule context
        private IEnumerable<AbstractPromotionType> _promotions; // promotion rules which are to be executed

        public PromotionCalculator(IEnumerable<ShoppingItem> items, IEnumerable<AbstractPromotionType> promotions)
        {
            this._promotions = promotions;
            this.items = items;

        }

        public decimal ComputeResult()
        {
            foreach (var p in _promotions)
            {
                p.OnPromotionApplication(items);
            }

            decimal sum = 0;

            foreach (var item in items)
            {
                sum += item.TotalPrice;
            }

            return sum;
        }
    }
}
