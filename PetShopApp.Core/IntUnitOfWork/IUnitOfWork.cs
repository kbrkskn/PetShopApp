using PetShopApp.Core.IntRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.IntUnitOfWork
{
    public interface IUnitOfWork
    {
        ISubCategoryRepository SubCategory { get; }
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
        IOrderRepository Order { get; }
        IUserRepository User { get; }
        ICommentRepository Comment { get; }
        IProductFeatureRepository ProductFeature { get; }
        IDiscountedProductRepository DiscountedProduct { get; }
        Task CommitAsync();
        void Commit();

        
    }
}
