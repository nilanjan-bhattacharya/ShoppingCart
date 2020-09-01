using ShoppingCart.Models;
using System.Collections.Generic;

namespace ShoppingCart.RuleEngine
{
    /// <summary>
    /// Class to be inherited by all Promotion rules
    /// </summary>
    public abstract class AbstractPromotionType
    {
        public abstract void OnPromotionApplication(IEnumerable<ShoppingItem> items);
    }
}
