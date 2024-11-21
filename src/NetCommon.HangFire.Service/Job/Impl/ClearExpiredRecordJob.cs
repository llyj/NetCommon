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
    public class ClearExpiredRecordJob : BaseJob<ClearExpiredRecordJob>
    {
        public ClearExpiredRecordJob(ILogger<ClearExpiredRecordJob> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        public override string JobDescription => "维护浏览记录";

        public override async Task ExecuteAsync(IDictionary<string, object>? data = null)
        {
            var clearExpiredRecordService = _serviceProvider.GetRequiredService<IClearExpiredRecordService>();
            await clearExpiredRecordService.ClearExpiredRecord();
        }
    }
}