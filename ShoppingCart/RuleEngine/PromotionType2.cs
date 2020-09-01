using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.RuleEngine
{
    // buy SKU 1 & SKU 2 for a fixed price (C + D = 30)
    public class PromotionType2 : AbstractPromotionType
    {
        public char SkuId1 { get; set; }
        public char SkuId2 { get; set; }
        public decimal FixedPrice { get; set; }

        public PromotionType2(char skuId1, char skuId2, decimal fixedPrice)
        {
            this.SkuId1 = skuId1;
            this.SkuId2 = skuId2;
            this.FixedPrice = fixedPrice;
        }

        public override void OnPromotionApplication(ICollection<ShoppingItem> items)
        {
            //throw new NotImplementedException();
        }
    }
}
