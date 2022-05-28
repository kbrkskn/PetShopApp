using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.IntRepository
{
    public interface IOrderRepository:IRepository<Order>
    {
        Task<Order> GetWithProductByIdAsync(int orderId);
        Task<Order> GetWithUserByIdAsync(int orderId);
    }
}
