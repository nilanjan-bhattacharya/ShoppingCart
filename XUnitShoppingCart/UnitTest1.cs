using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitShoppingCart
{
    public class UnitTestShoppingCart
    {
        [Fact]
        public void Test1()
        {
            SKU[] skus = {  new SKU {ID = 'A', Price = 50 },
                            new SKU {ID = 'B', Price = 30},
                            new SKU {ID = 'C', Price = 20 },
                            new SKU {ID = 'D', Price = 15}
            };


            var CartItems = new List<ShoppingItem>() {
                new ShoppingItem { Item = skus[0], Quantity = 5 },
                new ShoppingItem { Item = skus[1], Quantity = 5 },
                new ShoppingItem { Item = skus[2], Quantity = 1 }
            };

            Basket sc = new Basket(CartItems);

            Assert.Equal(370, sc.FinalValue);
        }
    }
}
