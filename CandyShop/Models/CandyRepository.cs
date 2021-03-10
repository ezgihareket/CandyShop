using CandyShop.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//5.ADIM Adding Candy Repository
namespace CandyShop.Models
{
    public class CandyRepository : ICandyRepository
    {
        //18.ADIM Modifying Candy Repository for Entity Framework
        private readonly AppDbContext _appDbContext;
        public CandyRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Candy> getAllCandy
        {
            get
            {
                return _appDbContext.Candies.Include(c => c.Category);
            }
        }

        public IEnumerable<Candy> getCandyOnSale
        {
            get
            {
                return _appDbContext.Candies.Include(c => c.Category).Where(p => p.isOnSale);
            }
        }

        public Candy getCandyById(int candyId)
        {
            return _appDbContext.Candies.FirstOrDefault(c => c.candyId == candyId);
        }
    }
}
