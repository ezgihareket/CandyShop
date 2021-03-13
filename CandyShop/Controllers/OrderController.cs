using CandyShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//48.ADIM Adding Checkout Form and View
namespace CandyShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        //49.ADIM Adding Checkout Action
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            if (_shoppingCart.ShoppingCartItems.Count ==0)
            {
                ModelState.AddModelError("","Your Cart is Empty");

            }
            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }
    }
}
