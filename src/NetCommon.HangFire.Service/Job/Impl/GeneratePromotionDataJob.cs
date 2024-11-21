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
    public class GeneratePromotionDataJob : BaseJob<GeneratePromotionDataJob>
    {
        public GeneratePromotionDataJob(ILogger<GeneratePromotionDataJob> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        public override string JobDescription => "生成推广数据";

        public override async Task ExecuteAsync(IDictionary<string, object>? data = null)
        {
            var generatePromotionDataService = _serviceProvider.GetRequiredService<IGeneratePromotionDataService>();
            await generatePromotionDataService.GeneratePromotionData();
        }
    }
}