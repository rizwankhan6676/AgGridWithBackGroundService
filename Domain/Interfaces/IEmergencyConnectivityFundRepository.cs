using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IEmergencyConnectivityFundRepository : IGenericRepository<EmergencyConnectivityFund>
    {
        Task<ICollection<string>> GetAllServiceProviderName(Expression<Func<EmergencyConnectivityFund, bool>> match = null, Pagination pagination = null);

    }
}
