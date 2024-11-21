using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.HangFire.Job
{
    public interface IJob
    {
        /// <summary>
        /// 执行任务
        /// </summary>
        /// <returns></returns>
        Task RunJob(IDictionary<string, object>? data = null);

        /// <summary>
        /// 任务具体内容
        /// </summary>
        /// <returns></returns>
        Task ExecuteAsync(IDictionary<string, object>? data = null);
    }
}