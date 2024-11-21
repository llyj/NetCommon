using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jak.ScheduledTaskSystem.Service.IService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Jak.HangFire.Service.Job.Impl
{
    public class DisableObsoletePriceJob : BaseJob<DisableObsoletePriceJob>
    {
        public override string JobDescription => "清除过期的自定义价格";

        public DisableObsoletePriceJob(ILogger<DisableObsoletePriceJob> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        public override async Task ExecuteAsync(IDictionary<string, object>? data = null)
        {
            var disableObsoletePriceService = _serviceProvider.GetRequiredService<IDisableObsoletePriceService>();
            await disableObsoletePriceService.DisableObsoletePrice();
        }
    }
}