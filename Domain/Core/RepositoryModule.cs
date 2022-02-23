using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Domain
{
    public static class RepositoryModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IEmergencyConnectivityFundRepository, EmergencyConnectivityFundRepository>();
        }
    }
}
