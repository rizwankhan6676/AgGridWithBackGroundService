using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsyn(T t)
        {
            _context.Set<T>().Add(t);
            await _context.SaveChangesAsync();
            return t;
        }

        public async Task<ICollection<T>> AddRangeAsync(ICollection<T> tCollection)
        {
            try
            {
                //await _context.Set<T>().AddRangeAsync(tCollection);
                _context.BulkInsert(tCollection.ToList());
                _context.SaveChanges();
                return tCollection;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
        }

        public async Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>> match, Pagination pagination = null)
        {
            if (pagination != null)
            {
                pagination.totalCount = _context.Set<T>().Where(match).Count();
                return await _context.Set<T>().Where(match).Skip(pagination.skip).Take(pagination.size).ToListAsync();
            }
            return _context.Set<T>().Where(match).ToList();
        }
    }
}
