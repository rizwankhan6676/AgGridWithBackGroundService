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
        Task<IEnumerable<string>> GetAllServiceProviderName(string serviceProviderName = null, Pagination pagination = null);
        Task<EmergencyConnectivityFund> Update(EmergencyConnectivityFund e);
        Task InsertBulkAsync(IEnumerable<EmergencyConnectivityFund> collection);
        Task BulkInsertOrUpdateAsync(IEnumerable<EmergencyConnectivityFund> collection);
    }
}
