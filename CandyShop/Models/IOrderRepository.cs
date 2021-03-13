using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//47.ADIM Implementing Order Repository
namespace CandyShop.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
