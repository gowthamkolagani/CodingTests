﻿using PromotionEngine.Application.Contracts;
using PromotionEngine.Domain.Cart;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace PromotionEngine.Application.Services
{
    public class CartService : ICartService
    {
        private readonly ICart cart;
        public CartService(ICart cart)
        {
            this.cart = cart;
        }
        public bool AdditemToCart(CartItem cartItem)
        {
            try
            {
                this.cart.Add(cartItem);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public double CalculateCartValue(List<CartItem> cartItems)
        {
            double CartValue=0;
            foreach (var item in cartItems)
            {
               switch(item.PromotionType)
                {
                    case Domain.Cart.Promotion.PromotionType.BuyOneGetAnother:
                        throw new NotImplementedException();
                        break;
                    case Domain.Cart.Promotion.PromotionType.DiscountBased:
                        throw new NotImplementedException();
                        break;
                    case Domain.Cart.Promotion.PromotionType.ProductSetBased:

                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            return CartValue;
        }

        public int DeleteItemFromCart(CartItem cartItem)
        {
            throw new NotImplementedException();
        }
    }
}
