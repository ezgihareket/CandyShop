using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//29.ADIM Adding Shopping Cart Item
namespace CandyShop.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public string ShoppingCartId { get; set; }
        public Candy Candy { get; set; }
        public int Amount { get; set; }
    }
}
