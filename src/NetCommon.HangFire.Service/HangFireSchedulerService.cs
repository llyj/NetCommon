using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Hangfire;
using Jak.HangFire.Service.Job;
using Jak.HangFire.Service.Job.Impl;
using Jak.Scheduler;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Model;

namespace Jak.HangFire.Service
{
    public class HangFireSchedulerService : ISchedulerService
    {
        private readonly ILogger<HangFireSchedulerService> _logger;
        private readonly RecurringJobManager _jobManager;
        private readonly IServiceProvider _serviceProvider;

        public HangFireSchedulerService(RecurringJobManager jobManager, IServiceProvider serviceProvider, ILogger<HangFireSchedulerService> logger)
        {
            _jobManager = jobManager;
            _serviceProvider = serviceProvider.CreateScope().ServiceProvider;
            _logger = logger;
        }

        public async Task<bool?> AddOrUpdateJob(string jobName, string cronExpression, IDictionary<string, object>? data = null)
        {
            try
            {
                var recurringJobOptions = new RecurringJobOptions()
                {
                    TimeZone = TimeZoneInfo.Local
                };

                var jobType = Assembly.GetExecutingAssembly().GetExportedTypes().FirstOrDefault(t => t.Name == jobName);

                var job = _serviceProvider.GetRequiredService(jobType) as IJob;

                _jobManager.AddOrUpdate(jobName, () => job.RunJob(data), cronExpression, recurringJobOptions);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "添加或更新任务失败！");
                return null;
            }
        }

        public async Task<string?> TriggerJob(string jobName)
        {
            return _jobManager.TriggerJob(jobName);
        }

        public async Task RemoveJobIfExists(string jobName)
        {
            _jobManager.RemoveIfExists(jobName);
        }
    }
}