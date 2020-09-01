using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.RuleEngine
{
    class PromotionCalculator : IPromotionCalculator
    {
        ICollection<ShoppingItem> items;
        private List<AbstractPromotionType> _promotions;

        public PromotionCalculator(ICollection<ShoppingItem> items)
        {
            this._promotions = new List<AbstractPromotionType>();

            this.items = items;

            _promotions.Add(new PromotionType1('A', 3, 130));
            _promotions.Add(new PromotionType1('B', 2, 45));
            _promotions.Add(new PromotionType2('C', 'D', 30));
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
