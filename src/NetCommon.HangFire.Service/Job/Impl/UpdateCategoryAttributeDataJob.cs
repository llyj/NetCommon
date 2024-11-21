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
    public class UpdateCategoryAttributeDataJob : BaseJob<UpdateCategoryAttributeDataJob>
    {
        public UpdateCategoryAttributeDataJob(ILogger<UpdateCategoryAttributeDataJob> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        public override string JobDescription => "更新二级分类的属性数据";

        public override async Task ExecuteAsync(IDictionary<string, object>? data = null)
        {
            var categoryService = _serviceProvider.GetRequiredService<ICategoryService>();
            await categoryService.UpdateCategoryAttributeData();
        }
    }
}