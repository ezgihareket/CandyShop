using CandyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//27.ADIM Creating Home Controller

namespace CandyShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Candy> CandyOnSale { get; set; }
    }
}
