using CandyShop.Models;
using CandyShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//27.ADIM Creating Home Controller
namespace CandyShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICandyRepository _candyRepository;
        public HomeController(ICandyRepository candyRepository)
        {
            _candyRepository = candyRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                CandyOnSale = _candyRepository.getCandyOnSale
            };
            return View(homeViewModel);
        }
    }
}
