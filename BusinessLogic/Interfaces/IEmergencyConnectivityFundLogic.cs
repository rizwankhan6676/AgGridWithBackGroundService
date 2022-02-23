using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace BusinessLogic
{
    public interface IEmergencyConnectivityFundLogic
    {
        Task<IEnumerable<EmergencyConnectivityFund>> GetAll(Pagination pagination = null);
        Task<EmergencyConnectivityFund> Update(EmergencyConnectivityFund e);
        Task AddRangeAsync(IEnumerable<EmergencyConnectivityFund> collection);
    }
}
