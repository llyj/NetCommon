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
    public class RfqStatisticGenerateJob : BaseJob<RfqStatisticGenerateJob>
    {
        public RfqStatisticGenerateJob(ILogger<RfqStatisticGenerateJob> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        public override string JobDescription => "生成询价单统计数据";

        public override async Task ExecuteAsync(IDictionary<string, object>? data = null)
        {
            var rfqStatisticService = _serviceProvider.GetRequiredService<IRfqStatisticService>();
            await rfqStatisticService.GenerateStatisticalDataDaily();
        }
    }
}