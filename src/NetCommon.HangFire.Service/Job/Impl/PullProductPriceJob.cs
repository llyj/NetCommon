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
    public class PullProductPriceJob : BaseJob<PullProductPriceJob>
    {
        public PullProductPriceJob(ILogger<PullProductPriceJob> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        public override string JobDescription => "拉取产品价格";

        public override async Task ExecuteAsync(IDictionary<string, object>? data = null)
        {
            var pullProductPriceService = _serviceProvider.GetRequiredService<IPullProductPriceService>();
            await pullProductPriceService.PullProductPrice();
        }
    }
}