using ShoppingCart;
using ShoppingCart.Models;
using System.Collections.Generic;
using Xunit;

namespace XUnitShoppingCart
{
    public class UnitTestShoppingCart
    {
        private SKU[] skus = {  new SKU {ID = 'A', Price = 50 },
                            new SKU {ID = 'B', Price = 30},
                            new SKU {ID = 'C', Price = 20 },
                            new SKU {ID = 'D', Price = 15}
            };

        [Fact]
        public void No_Promotions_Applied()
        {

            var CartItems = new List<ShoppingItem>() {
                new ShoppingItem { Item = skus[0], Quantity = 1 },
                new ShoppingItem { Item = skus[1], Quantity = 1 },
                new ShoppingItem { Item = skus[2], Quantity = 1 }
            };

            TheShoppingCart sc = new TheShoppingCart(CartItems);

            Assert.Equal(100, sc.GetBasketValue());
        }

        [Fact]
        public void Promotion_Type1_Applied()
        {

            var CartItems = new List<ShoppingItem>() {
                new ShoppingItem { Item = skus[0], Quantity = 5 },
                new ShoppingItem { Item = skus[1], Quantity = 5 },
                new ShoppingItem { Item = skus[2], Quantity = 1 }
            };

            TheShoppingCart sc = new TheShoppingCart(CartItems);

            Assert.Equal(370, sc.GetBasketValue());
        }

        [Fact]
        public void Promotion_Type1AndType2_Applied()
        {

            var CartItems = new List<ShoppingItem>() {
                new ShoppingItem { Item = skus[0], Quantity = 3 },
                new ShoppingItem { Item = skus[1], Quantity = 5 },
                new ShoppingItem { Item = skus[2], Quantity = 1 },
                new ShoppingItem { Item = skus[3], Quantity = 1 }
            };

            TheShoppingCart sc = new TheShoppingCart(CartItems);

            Assert.Equal(280, sc.GetBasketValue());
        }
    }
}
