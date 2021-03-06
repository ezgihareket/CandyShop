using CandyShop.Models;
using CandyShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//36.ADIM  Creating Shopping Cart Controller
namespace CandyShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ICandyRepository _candyRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ICandyRepository candyRepository, ShoppingCart shoppingCart)
        {
            _candyRepository = candyRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        //37.ADIM Adding Candy To The Cart Action
        public RedirectToActionResult AddToShoppingCart(int candyId)
        {
            var selectedCandy = _candyRepository.getAllCandy.FirstOrDefault(c => c.candyId == candyId);
            if (selectedCandy != null)
            {
                _shoppingCart.AddToCart(selectedCandy, 1);
            }
            return RedirectToAction("Index");
        }

        //38.ADIM Removing Candy To The Cart Action
        public RedirectToActionResult RemovingFromShoppingCart(int candyId)
        {
            var selectedCandy = _candyRepository.getAllCandy.FirstOrDefault(c => c.candyId == candyId);
            if (selectedCandy != null)
            {
                _shoppingCart.RemoveFromCart(selectedCandy);
            }
            return RedirectToAction("Index");
        }

        //56.ADIM Clearing The Cart
        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}
