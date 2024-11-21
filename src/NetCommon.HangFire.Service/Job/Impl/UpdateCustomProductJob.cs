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
    public class UpdateCustomProductJob : BaseJob<UpdateCustomProductJob>
    {
        public UpdateCustomProductJob(ILogger<UpdateCustomProductJob> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        public override string JobDescription => "更新首页自定义产品";

        public override async Task ExecuteAsync(IDictionary<string, object>? data = null)
        {
            var updateCustomProductService = _serviceProvider.GetRequiredService<IUpdateCustomProductService>();
            await updateCustomProductService.UpdateCustomProduct();
        }
    }
}