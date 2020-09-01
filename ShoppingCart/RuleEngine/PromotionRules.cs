using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.RuleEngine
{
    /// <summary>
    /// Add Promotions of specific types defined under PromotionTypes
    /// </summary>
    public static class PromotionRules
    {
        public static IEnumerable<AbstractPromotionType> GetPromotions()
        {
            var promotions = new List<AbstractPromotionType>();

            promotions.Add(new PromotionType1('A', 3, 130));
            promotions.Add(new PromotionType1('B', 2, 45));
            promotions.Add(new PromotionType2('C', 'D', 30));

            return promotions;
        }
    }
}
