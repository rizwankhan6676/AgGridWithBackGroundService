using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class EmergencyConnectivityFundRepository : GenericRepository<EmergencyConnectivityFund>, IEmergencyConnectivityFundRepository
    {
        private readonly ApplicationDbContext _context;
        public EmergencyConnectivityFundRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
