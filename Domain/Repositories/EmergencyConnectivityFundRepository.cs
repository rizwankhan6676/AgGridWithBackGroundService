using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class EmergencyConnectivityFundRepository : GenericRepository<EmergencyConnectivityFund>, IEmergencyConnectivityFundRepository
    {
        private readonly ApplicationDbContext _context;
        public EmergencyConnectivityFundRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<ICollection<string>> GetAllServiceProviderName(
            Expression<Func<EmergencyConnectivityFund, bool>> match = null,
            Pagination pagination = null)
        {
            if (pagination != null && match != null)
            {
                pagination.totalCount = _context.Set<EmergencyConnectivityFund>().Where(match).Count();
                return await _context.Set<EmergencyConnectivityFund>().Where(match).Select(e => e.ServiceProviderName)
                    .Distinct().Skip(pagination.skip).Take(pagination.size).ToListAsync();
            }
            else if (pagination != null)
            {
                pagination.totalCount = _context.Set<EmergencyConnectivityFund>().Count();
                return await _context.Set<EmergencyConnectivityFund>().Select(e => e.ServiceProviderName).Distinct()
                    .Skip(pagination.skip).Take(pagination.size).ToListAsync();
            }

            return await _context.Set<EmergencyConnectivityFund>().Where(match).Select(e => e.ServiceProviderName)
                .Distinct().ToListAsync();
        }
    }
}
