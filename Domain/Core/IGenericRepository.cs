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
        Task<ICollection<T>> AddRangeAsync(ICollection<T> tCollection);

        Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>> match, Pagination pagination = null);
    }
}
