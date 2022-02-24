using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IGenericRepository<T>
    {
        Task<T> AddAsyn(T t);
        Task<ICollection<T>> InsertBulkAsync(ICollection<T> tCollection);
        Task<ICollection<T>> BulkInsertOrUpdateAsync(ICollection<T> tCollection);

        Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>> match = null, Pagination pagination = null);
    }
}
