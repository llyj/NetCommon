using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.Scheduler
{
    public interface ISchedulerService
    {
        /// <summary>
        /// 添加或更新任务
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="cronExpression"></param>
        /// <returns></returns>
        Task<bool?> AddOrUpdateJob(string jobName, string cronExpression, IDictionary<string, object>? data = null);

        /// <summary>
        /// 运行任务
        /// </summary>
        /// <param name="jobName"></param>
        /// <returns></returns>
        Task<string?> TriggerJob(string jobName);

        /// <summary>
        /// 删除任务，如果存在
        /// </summary>
        /// <param name="jobName"></param>
        /// <returns></returns>
        Task RemoveJobIfExists(string jobName);
    }
}