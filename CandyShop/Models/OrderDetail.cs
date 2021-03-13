using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//46.ADIM Creating Order and Order Detail Models
namespace CandyShop.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int CandyId { get; set; }
        public Candy Candy { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Order Order { get; set; }

    }
}
