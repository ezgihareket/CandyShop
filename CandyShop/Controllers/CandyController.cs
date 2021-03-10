using CandyShop.Models;
using CandyShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//7.ADIM Adding Controllers and Injecting Services
namespace CandyShop.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyRepository _candyRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CandyController(ICandyRepository candyRepository, ICategoryRepository categoryRepository)
        {
            _candyRepository = candyRepository;
            _categoryRepository = categoryRepository;
        }

        //8.ADIM Adding Action Methods
        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Bestellers";
            //return View(_candyRepository.getAllCandy);

            //10.ADIM Adding View Models
            var candyListViewModel = new CandyListViewModel();
            candyListViewModel.Candies = _candyRepository.getAllCandy;
            candyListViewModel.CurrentCategory = "Bestellers";
            return View(candyListViewModel);
        }

        //22.ADIM Adding Details Action
        public IActionResult Details(int id)
        {
            var candy = _candyRepository.getCandyById(id);
            if (candy == null)
            {
                return NotFound();
            }
            return View(candy);
        }
    }
}
