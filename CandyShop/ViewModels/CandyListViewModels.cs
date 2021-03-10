using CandyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//10.ADIM Adding View Models
namespace CandyShop.ViewModels
{
    public class CandyListViewModel
    {
        public IEnumerable<Candy> Candies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
