using System;
using System.Collections.Generic;
using System.Text; 
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic
{
    public static class BusinessModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IEmergencyConnectivityFundLogic, EmergencyConnectivityFundLogic>();
        }
    }
}
