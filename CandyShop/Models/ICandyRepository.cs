using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//3.ADIM Adding Interfaces
namespace CandyShop.Models
{
    public interface ICandyRepository
    {
        IEnumerable<Candy> getAllCandy { get; }
        IEnumerable<Candy> getCandyOnSale { get; }
        Candy getCandyById(int candyId);
    }
}
