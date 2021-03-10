using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//4.ADIM Adding Category Repository
namespace CandyShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> getAllCategories => new List<Category>
        {
            new Category{categoryId=1, categoryName="Hard Candy", categoryDescription="Awesome"},
            new Category{categoryId=2, categoryName="Chocolate Candy", categoryDescription="greate"},
            new Category{categoryId=3, categoryName="Fruit Candy", categoryDescription="beautifule"},
        };
    }
}
