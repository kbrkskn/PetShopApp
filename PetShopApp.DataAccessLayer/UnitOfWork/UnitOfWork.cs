using PetShopApp.Core.IntRepository;
using PetShopApp.Core.IntUnitOfWork;
using PetShopApp.DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PetShopDbContext _db;
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private IOrderRepository _orderRepository;
        private ISubCategoryRepository _subCategoryRepository;
        private IUserRepository _userRepository;
        private IProductFeatureRepository _productFeatureRepository;
        private ICommentRepository _commentRepository;
        public UnitOfWork(PetShopDbContext db)
        {
            _db = db;
        }
        public ISubCategoryRepository SubCategory => _subCategoryRepository ??= new SubCategoryRepository(_db);
        public ISubCategoryRepository SubCategoryRepository{get;}

        public ICategoryRepository Category => _categoryRepository ??= new CategoryRepository(_db);
        public ICategoryRepository CategoryRepository {get;}

        public IProductRepository Product => _productRepository ??= new ProductRepository(_db);
        public IProductRepository ProductRepository { get; }

        public IOrderRepository Order => _orderRepository ??= new OrderRepository(_db);
        public IOrderRepository OrderRepository { get; }

        public IUserRepository User => _userRepository ??= new UserRepository(_db);
        public IUserRepository UserRepository { get; }

        public ICommentRepository Comment => _commentRepository ??= new CommentRepository(_db);
        public ICommentRepository CommentRepository { get; }

        public IProductFeatureRepository ProductFeature => _productFeatureRepository ??= new ProductFeatureRepository(_db);

        public void Commit()
        {
            _db.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}

   
