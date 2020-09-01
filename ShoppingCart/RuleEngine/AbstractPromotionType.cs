using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.RuleEngine
{
    public abstract class AbstractPromotionType
    {
        public abstract void OnPromotionApplication(ICollection<ShoppingItem> items);
    }
}
