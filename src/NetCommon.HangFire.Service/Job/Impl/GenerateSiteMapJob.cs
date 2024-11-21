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
    public class GenerateSiteMapJob : BaseJob<GenerateSiteMapJob>
    {
        public GenerateSiteMapJob(ILogger<GenerateSiteMapJob> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        public override string JobDescription => "生成站点地图";

        public override async Task ExecuteAsync(IDictionary<string, object>? data = null)
        {
            var generateSiteMapService = _serviceProvider.GetRequiredService<IGenerateSiteMapService>();
            await generateSiteMapService.GenerateSiteMap();
        }
    }
}