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
        public async Task AddRangeAsync(IEnumerable<EmergencyConnectivityFund> collecetion) 
        {
          await _emergencyConnectivityFundRepository.AddRangeAsync(collecetion.ToList());
        }

        public Task<IEnumerable<EmergencyConnectivityFund>> GetAll(Pagination pagination = null)
        {
            throw new NotImplementedException();
        }

        public Task<EmergencyConnectivityFund> Update(EmergencyConnectivityFund e)
        {
            throw new NotImplementedException();
        }
    }
}
