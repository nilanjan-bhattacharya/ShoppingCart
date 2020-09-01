using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.RuleEngine
{
    // Buy n items of a SKU for a fixed price (3A's for 130)
    public class PromotionType1 : AbstractPromotionType
    {
        public char SkuId { get; set; }
        public int ItemCount { get; set; }
        public decimal FixedPrice { get; set; }

        public PromotionType1(char skuId, int itemCount, decimal fixedPrice)
        {
            this.SkuId = skuId;
            this.ItemCount = itemCount;
            this.FixedPrice = fixedPrice;
        }

        public override void OnPromotionApplication(ICollection<ShoppingItem> items)
        {
            foreach(var item in items)
            {
                if(item.Item.ID == SkuId)
                {
                    var rem = item.Quantity % ItemCount;
                    var quotient = item.Quantity / ItemCount;

                    item.TotalPrice = (quotient * FixedPrice) + (rem * item.Item.Price);
                }
            }
        }
    }
}
