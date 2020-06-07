using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Application.Contracts;
using PromotionEngine.Application.Services;
using PromotionEngine.Domain.Cart;

namespace PromotionEngine.Tests
{
    [TestClass]
    public class CartCalculatorServiceTest
    {
        private ICartCaluclatorService cartCaluclatorService;
        private ICart cart;
        public CartCalculatorServiceTest()
        {
            cartCaluclatorService = new CartCalculatorService();
            cart = new Cart();
        }

        [TestMethod]
        public bool GetProductSetBasedPromotionValueTest()
        {
            var cartItem =  this.cart.Add(new CartItem{productId=1,count=5,PromotionType=Domain.Cart.Promotion.PromotionType.ProductSetBased});
            var value = cartCaluclatorService.GetProductSetBasedPromotionValue(cartItem);
            return Assert.Equals(value, 230);
        }
    }
}
