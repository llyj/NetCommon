using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangfire;
using Jak.ScheduledTaskSystem.Service.IService;
using Jak.ScheduledTaskSystem.Service.Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Jak.HangFire.Service.Job.Impl
{
    [AutomaticRetry(Attempts = 3)]
    public abstract class BaseJob<T> : IJob
    {
        private readonly ILogger<T> _logger;
        protected IServiceProvider _serviceProvider;

        /// <summary>
        /// 任务简述
        /// </summary>
        public abstract string JobDescription { get; }

        protected BaseJob(ILogger<T> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider.CreateScope().ServiceProvider;
        }

        public virtual async Task RunJob(IDictionary<string, object>? data = null)
        {
            _logger.LogInformation("{JobName}:{JobDescription} - 任务启动", typeof(T).Name, JobDescription);

            var taskJobService = _serviceProvider.GetRequiredService<ITaskJobService>();
            try
            {
                await taskJobService.BeforeTaskJobRun(typeof(T).Name);

                var stopwatch = new Stopwatch();
                stopwatch.Start();
                await ExecuteAsync().ContinueWith(t =>
                {
                    // 执行完成后更新上次运行时间
                    stopwatch.Stop();
                    if (t.IsFaulted || t.IsCanceled)
                    {
                        throw t.Exception.InnerException;
                    }
                    taskJobService.AfterTaskJobRun(typeof(T).Name);
                });

                _logger.LogInformation("{JobName}:{JobDescription} - 任务执行成功\n [运行耗时] {Elapsed} ms.", typeof(T).Name, JobDescription, stopwatch.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                await taskJobService.TaskJobRunError(typeof(T).Name);
                _logger.LogError(ex, "{JobName}:{JobDescription} - 任务执行出错！", typeof(T).Name, JobDescription);
                throw;
            }
        }

        public abstract Task ExecuteAsync(IDictionary<string, object>? data = null);
    }
}