using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangfire;
using Jak.HangFire.Service.Job.Impl;
using Microsoft.Extensions.Hosting;
using NetCommon.Scheduler;

namespace NetCommon.HangFire.Service.HostedService
{
    /// <summary>
    /// 添加定时任务
    /// </summary>
    public class HangFireHostedService : IHostedService
    {
        private readonly RecurringJobManager _jobManager;
        private readonly ISchedulerService _schedulerService;
        private readonly ITaskJobService _taskJobService;

        public HangFireHostedService(RecurringJobManager jobManager, ISchedulerService schedulerService, ITaskJobService taskJobService)
        {
            _jobManager = jobManager;
            _schedulerService = schedulerService;
            _taskJobService = taskJobService;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            //var recurringJobOptions = new RecurringJobOptions()
            //{
            //    // 配置时区为系统时区
            //    TimeZone = TimeZoneInfo.Local
            //};

            var enabledTaskJobList = await _taskJobService.GetEnabledTaskJobList();
            if (!enabledTaskJobList.IsNullOrEmpty())
            {
                foreach (var taskJob in enabledTaskJobList)
                {
                    _ = await _schedulerService.AddOrUpdateJob(taskJob.TaskJobName, taskJob.CronExpression);
                }
            }

            //_jobManager.AddOrUpdate<AutoAnalyseCrawlerJob>(nameof(AutoAnalyseCrawlerJob), x => x.RunJob(), "0/10 * * * ?", recurringJobOptions);
            //_jobManager.AddOrUpdate<ClearExpiredRecordJob>(nameof(ClearExpiredRecordJob), x => x.RunJob(), "0 12 * * ?", recurringJobOptions);
            //_jobManager.AddOrUpdate<CopyCrawlerJob>(nameof(CopyCrawlerJob), x => x.RunJob(), "0 8 * * ?", recurringJobOptions);
            //_jobManager.AddOrUpdate<DisableObsoletePriceJob>(nameof(DisableObsoletePriceJob), x => x.RunJob(), "0 6 * * ?", recurringJobOptions);
            //_jobManager.AddOrUpdate<GeneratePromotionDataJob>(nameof(GeneratePromotionDataJob), x => x.RunJob(), "0 7 * * ?", recurringJobOptions);
            //_jobManager.AddOrUpdate<GenerateSiteMapJob>(nameof(GenerateSiteMapJob), x => x.RunJob(), "0 14 * * ?", recurringJobOptions);
            //_jobManager.AddOrUpdate<PullProductPriceJob>(nameof(PullProductPriceJob), x => x.RunJob(), "0 4 * * ?", recurringJobOptions);
            //_jobManager.AddOrUpdate<UpdateCustomProductJob>(nameof(UpdateCustomProductJob), x => x.RunJob(), "0 14 ? * 7", recurringJobOptions);
            //_jobManager.AddOrUpdate<UploadPromotionDataJob>(nameof(UploadPromotionDataJob), x => x.RunJob(), "0 10 * * ?", recurringJobOptions);
            //_jobManager.AddOrUpdate<UploadUrlToGoogleIndexApiJob>(nameof(UploadUrlToGoogleIndexApiJob), x => x.RunJob(), "0 12 * * ?", recurringJobOptions);
            //_jobManager.AddOrUpdate<UploadUrlToBingSubmissionJob>(nameof(UploadUrlToBingSubmissionJob), x => x.RunJob(), "0 12 * * ?", recurringJobOptions);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
        }
    }
}