using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//2.ADIM Adding Models
namespace CandyShop.Models
{
    public class Category
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string categoryDescription { get; set; }
        public List<Candy> Candies { get; set; }
    }
}
