using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.IntService
{
    public interface IOrderSevice:IService<Order>
    {
        Task<Order> GetWithProductByIdAsync(Guid orderId);
        Task<Order> GetWithUserByIdAsync(Guid orderId);
    }
}
