using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.Extensions.DependencyInjection;

namespace NetCommon.HangFire.IoC
{
    /// <summary>
    /// 配置 HangFire 依赖注入
    /// </summary>
    public class HangfireActivator : JobActivator
    {
        private readonly IServiceProvider _serviceProvider;

        public HangfireActivator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider.CreateScope().ServiceProvider;
        }

        public override object ActivateJob(Type jobType)
        {
            return _serviceProvider.GetRequiredService(jobType);
        }
    }
}