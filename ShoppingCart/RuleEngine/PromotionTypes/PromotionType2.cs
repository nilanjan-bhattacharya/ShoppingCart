using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public override void OnPromotionApplication(IEnumerable<ShoppingItem> items)
        {
            var s1Count = items.FirstOrDefault(a => a.Item.ID == SkuId1)?.Quantity;
            var s2Count = items.FirstOrDefault(a => a.Item.ID == SkuId2)?.Quantity;

            if(s1Count == null || s2Count == null)
            {
                return ;
            }

            if(s1Count <= s2Count)
            {
                foreach (var item in items)
                {
                   if(item.Item.ID == SkuId1)
                    {
                        item.Quantity = 0;
                        item.TotalPrice = 0;
                    }
                    if (item.Item.ID == SkuId2)
                    {
                        item.Quantity += s1Count.Value;

                        var rem = item.Quantity % 2;
                        var quotient = item.Quantity / 2;

                        item.TotalPrice = (quotient * FixedPrice) + (rem * item.Item.Price);
                    }
                }
            }
            else
            {
                foreach (var item in items)
                {
                    if (item.Item.ID == SkuId2)
                    {
                        item.Quantity = 0;
                        item.TotalPrice = 0;

                    }
                    if (item.Item.ID == SkuId1)
                    {
                        item.Quantity += s2Count.Value;

                        var rem = item.Quantity % 2;
                        var quotient = item.Quantity / 2;

                        item.TotalPrice = (quotient * FixedPrice) + (rem * item.Item.Price);
                    }
                }
            }



        }
    }
}
