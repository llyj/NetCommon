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
    public class UploadUrlToGoogleIndexApiJob : BaseJob<UploadUrlToGoogleIndexApiJob>
    {
        public UploadUrlToGoogleIndexApiJob(ILogger<UploadUrlToGoogleIndexApiJob> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        public override string JobDescription => "上传链接到 Google 搜索";

        public override async Task ExecuteAsync(IDictionary<string, object>? data = null)
        {
            var googleIndexService = _serviceProvider.GetRequiredService<IGoogleIndexService>();
            await googleIndexService.CommitUrls();
        }
    }
}