using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class EmergencyConnectivityFundLogic : IEmergencyConnectivityFundLogic
    {
        //private ApplicationDbContext _context;
        private readonly IEmergencyConnectivityFundRepository _emergencyConnectivityFundRepository;
        public EmergencyConnectivityFundLogic(IEmergencyConnectivityFundRepository emergencyConnectivityFundRepository) //: base(context)
        {
            //_context = context;
            _emergencyConnectivityFundRepository = emergencyConnectivityFundRepository;
        }
        public async Task InsertBulkAsync(IEnumerable<EmergencyConnectivityFund> collecetion) 
        {
          await _emergencyConnectivityFundRepository.InsertBulkAsync(collecetion.ToList());
        }

        public async Task BulkInsertOrUpdateAsync(IEnumerable<EmergencyConnectivityFund> collecetion) 
        {
          await _emergencyConnectivityFundRepository.BulkInsertOrUpdateAsync(collecetion.ToList());
        }

        public async Task<IEnumerable<EmergencyConnectivityFund>> GetAll(Pagination pagination = null)
        {
            return await _emergencyConnectivityFundRepository.GetAllAsync(null, pagination);
        }
        public async Task<IEnumerable<string>> GetAllServiceProviderName(string serviceProviderName = null, Pagination pagination = null)
        {
            return await _emergencyConnectivityFundRepository.GetAllServiceProviderName(
                e => serviceProviderName == null || e.ServiceProviderName.ToLower() == serviceProviderName.ToLower(), pagination);
        }

        public Task<EmergencyConnectivityFund> Update(EmergencyConnectivityFund e)
        {
            throw new NotImplementedException();
        }
    }
}
