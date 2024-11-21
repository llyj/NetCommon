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
    public class CopyCrawlerJob : BaseJob<CopyCrawlerJob>
    {
        public CopyCrawlerJob(ILogger<CopyCrawlerJob> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        public override string JobDescription => "复制爬虫";

        public override async Task ExecuteAsync(IDictionary<string, object>? data = null)
        {
            var copyCrawlerService = _serviceProvider.GetRequiredService<ICopyCrawlerService>();
            await copyCrawlerService.CopyCrawler();
        }
    }
}