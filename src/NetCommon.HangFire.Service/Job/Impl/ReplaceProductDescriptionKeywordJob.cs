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
    public class ReplaceProductDescriptionKeywordJob : BaseJob<ReplaceProductDescriptionKeywordJob>
    {
        public ReplaceProductDescriptionKeywordJob(ILogger<ReplaceProductDescriptionKeywordJob> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        public override string JobDescription => "替换产品描述的关键字";

        public override async Task ExecuteAsync(IDictionary<string, object>? data = null)
        {
            var productDescriptionService = _serviceProvider.GetRequiredService<IProductDescriptionService>();

            var dictionary = new Dictionary<string, object>() { { "dateTime", new DateTime(2024, 9, 13) }, { "pageCount", 1000 } };
            var o = dictionary["dateTime"];

            //await productDescriptionService.ReplaceProductDescriptionKeyword();
        }
    }
}