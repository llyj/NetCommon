using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jak.ScheduledTaskSystem.Model.Enum;
using Jak.ScheduledTaskSystem.Service.IService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Jak.HangFire.Service.Job.Impl
{
    public class PushRfqStatsDataToDingtalkWeeklyJob : BaseJob<PushRfqStatsDataToDingtalkWeeklyJob>
    {
        public PushRfqStatsDataToDingtalkWeeklyJob(ILogger<PushRfqStatsDataToDingtalkWeeklyJob> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        public override string JobDescription => "推送每周询价统计数据到钉钉";

        public override async Task ExecuteAsync(IDictionary<string, object>? data = null)
        {
            var rfqStatisticService = _serviceProvider.GetRequiredService<IRfqStatisticService>();
            await rfqStatisticService.PushStatisticDataToDingtalk(StatisticPeriodTypeEnum.Weekly);
        }
    }
}