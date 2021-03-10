using CandyShop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//4.ADIM Adding Category Repository
//19.ADIM Modifying Category Repository for Entity Framework
namespace CandyShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> getAllCategories => _appDbContext.Categories;
    }
}
