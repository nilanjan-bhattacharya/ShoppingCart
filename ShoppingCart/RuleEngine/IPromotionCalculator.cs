using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.RuleEngine
{
    interface IPromotionCalculator
    {
        decimal ComputeResult();
    }
}
