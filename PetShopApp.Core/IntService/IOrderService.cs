using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.IntService
{
    public interface IOrderService : IService<Order>
    {
        Task<Order> GetWithProductByIdAsync(int orderId);
        Task<Order> GetWithUserByIdAsync(int orderId);
    
    }
}
