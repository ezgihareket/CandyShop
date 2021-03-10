using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//2.ADIM Adding Models
namespace CandyShop.Models
{
    public class Candy
    {
        public int candyId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string imageUrl { get; set; }
        public string imageThumbnailUrl { get; set; }
        public bool isOnSale { get; set; }
        public bool isInStock { get; set; }
        public int categoryId { get; set; }
        public Category Category { get; set; }
    }
}
