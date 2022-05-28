using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.IntRepository
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> Where(Expression<Func<T, bool>> predicate);

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>>predicate);
        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);
        Task<IQueryable<T>> QListAsync();

        //update ve delete 'i asenkron olarak yazamam

        Task AddAsync(T entity); //TEK TEK ekleme işlemi
        Task AddRangeAsync(IEnumerable<T> entities); //aynı anda hepsini ekleme işlemi

        T Update(T entity);

        //delete işleminin asenkronsuz hali
        void Remove(T entity); //tek tek silme
        void RemoveRange(IEnumerable<T> entities);//beraber silme

        //delete işleminin asenkronlu hali
        Task DeleteAsync(T entity); //tek tek silme

        Task DeleteRangeAsync(IEnumerable<T> entities);

    }
}
