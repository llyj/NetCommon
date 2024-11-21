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
    public class UploadPromotionDataJob : BaseJob<UploadPromotionDataJob>
    {
        public UploadPromotionDataJob(ILogger<UploadPromotionDataJob> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        public override string JobDescription => "上传推广数据";

        public override async Task ExecuteAsync(IDictionary<string, object>? data = null)
        {
            var uploadPromotionDataService = _serviceProvider.GetRequiredService<IUploadPromotionDataService>();
            await uploadPromotionDataService.AutoUpload();
        }
    }
}