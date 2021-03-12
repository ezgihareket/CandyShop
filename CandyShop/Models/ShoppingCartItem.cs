using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class ShoppingCartItem
    {
        public int shoppingCartItemId { get; set; }
        public string shoppingCartId { get; set; }
        public int Amount { get; set; }
    }
}
