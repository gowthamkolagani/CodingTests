using PromotionEngine.Domain.Cart;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Application.Contracts
{
   public interface ICartCaluclatorService
    {
        double GetProductSetBasedPromotionValue(CartItem cartItem);

        double GetProductvalueIncart(CartItem cartItem);
    }
}
