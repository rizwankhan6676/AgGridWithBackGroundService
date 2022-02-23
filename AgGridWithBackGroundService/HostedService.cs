using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BusinessLogic;
using Domain;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using shopify;

namespace AgGridWithBackGroundService
{
    public class HostedService : IHostedService, IDisposable
    {
        //private readonly IEmergencyConnectivityFundLogic _emergencyConnectivityFundLogic;
        private readonly IServiceProvider _serviceProvider;
        private int executionCount = 0;
        private readonly ILogger<HostedService> _logger;
        private Timer _timer = null!;

        public HostedService(ILogger<HostedService> logger, IServiceProvider serviceProvider)//,
            //IEmergencyConnectivityFundLogic emergencyConnectivityFundLogic)
        {
            //_emergencyConnectivityFundLogic = emergencyConnectivityFundLogic;
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        public Task StartAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Hosted Service running.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromDays(1));

            return Task.CompletedTask;
        }

        private void DoWork(object? state)
        {
            //var count = Interlocked.Increment(ref executionCount);
            //_logger.LogInformation(
            //    "Timed Hosted Service is working. Count: {Count}", count);
            List<EmergencyConnectivityFund> emergencyConnectivityFunds = new List<EmergencyConnectivityFund>();

            for (int i = 0; i != -1; i++)
            {
                var data = new ApiRequest().GetOpenDataAsync(i,5000);
                if (!data.Any())
                    break;
                emergencyConnectivityFunds.AddRange(data.ToList());
            }

            using IServiceScope scope = _serviceProvider.CreateScope();
            IEmergencyConnectivityFundLogic scopedProcessingService =
                scope.ServiceProvider.GetRequiredService<IEmergencyConnectivityFundLogic>();

            scopedProcessingService.AddRangeAsync(emergencyConnectivityFunds);
        }

        public Task StopAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Hosted Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
