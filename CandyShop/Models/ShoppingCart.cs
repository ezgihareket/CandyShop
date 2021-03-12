using CandyShop.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//30.ADIM Adding Shopping Cart
namespace CandyShop.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> shoppingCartItems { get; set; }

        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("cartId") ?? Guid.NewGuid().ToString();
            session.SetString("cartId", cartId);

            return new ShoppingCart(context)
            {
                ShoppingCartId = cartId
            };
        }

        //31.Adım Adding Item To The Cart

        public void AddToCart(Candy candy,int amount)
        {
            var shoppingCartItem = _appDbContext.shoppingCartItems.SingleOrDefault(s => s.Candy.candyId == candy.candyId && s.shoppingCartId == ShoppingCartId);
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    shoppingCartId = ShoppingCartId,
                    Candy = candy,
                    Amount = amount
                };
                _appDbContext.shoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        //32.ADIM Removing Item From The Cart
        public int RemoveFromCart(Candy candy)
        {
            var shoppingCartItem = _appDbContext.shoppingCartItems.SingleOrDefault(s => s.Candy.candyId == candy.candyId && s.shoppingCartId == ShoppingCartId);

            var localAmount = 0;
            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount >1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.shoppingCartItems.Remove(shoppingCartItem);
                }
            }
            _appDbContext.SaveChanges();
            return localAmount;
        }

        //33.ADIM Getting All Items From The Cart
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return shoppingCartItems ?? (shoppingCartItems = _appDbContext.shoppingCartItems.Where(c => c.shoppingCartId == ShoppingCartId).Include(s => s.Candy).ToList());
        }

        //34.ADIM Clear All Items From The Cart
        public void ClearCart()
        {
            var cartItems = _appDbContext.shoppingCartItems.Where(c => c.shoppingCartId == ShoppingCartId);
            _appDbContext.shoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }

        //35.ADIM Calculating Total Order and Configuring Sessions
        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.shoppingCartItems.Where(c => c.shoppingCartId == ShoppingCartId).Select(c => c.Candy.price*c.Amount).Sum();
            return total;
        }

        
    }
}
