using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;
using Domain;

namespace AgGridWithBackGroundService.Controllers
{
    public class EmergencyConnectivityFundController : Controller
    {
        private readonly IEmergencyConnectivityFundLogic _emergencyConnectivityFundLogic;

        public IActionResult Index()
        {
            return View();
        }
        public EmergencyConnectivityFundController(IEmergencyConnectivityFundLogic emergencyConnectivityFundLogic)
        {
            _emergencyConnectivityFundLogic = emergencyConnectivityFundLogic;
        }
        [HttpGet]
        public async Task<IEnumerable<EmergencyConnectivityFund>> GetAll([FromQuery] Pagination pagination = null)
        {
            return await _emergencyConnectivityFundLogic.GetAll(pagination);
        }

        [HttpGet]
        public async Task<IEnumerable<string>> GetAllServiceProviders(string serviceprovidername, [FromQuery] Pagination pagination = null)
        {
            return await _emergencyConnectivityFundLogic.GetAllServiceProviderName(serviceprovidername, pagination);
        }
    }
}
