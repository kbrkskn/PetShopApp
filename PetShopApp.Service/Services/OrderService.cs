﻿using PetShopApp.Core.IntRepository;
using PetShopApp.Core.IntService;
using PetShopApp.Core.IntUnitOfWork;
using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Service.Services
{
    public class OrderService : Service<Order>, IOrderService
    {
        public OrderService(IUnitOfWork unit, IRepository<Order> repo) : base(unit, repo)
        {
        }

        public async Task<Order> GetWithProductByIdAsync(int orderId)
        {
            return await _unit.Order.GetWithProductByIdAsync(orderId);
        }

        public async Task<Order> GetWithUserByIdAsync(int orderId)
        {
            return await _unit.Order.GetWithUserByIdAsync(orderId);
        }
    }
}
