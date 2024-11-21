using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangfire;
using Jak.ScheduledTaskSystem.Service.IService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Jak.HangFire.Service.Job.Impl
{
    public class AutoAnalyseCrawlerJob : BaseJob<AutoAnalyseCrawlerJob>
    {
        public override string JobDescription => "自动分析爬虫";

        public AutoAnalyseCrawlerJob(ILogger<AutoAnalyseCrawlerJob> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        public override async Task ExecuteAsync(IDictionary<string, object>? data = null)
        {
            var autoAnalyseCrawlerService = _serviceProvider.GetRequiredService<IAutoAnalyseCrawlerService>();
            await autoAnalyseCrawlerService.AutoAnalyseCrawler();
        }
    }
}