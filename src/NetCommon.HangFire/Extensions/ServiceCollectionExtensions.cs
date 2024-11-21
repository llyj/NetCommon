using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using NetCommon.HangFire.Job;

namespace NetCommon.HangFire.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 注册 带 Key 的 Job
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddHangFireJob<T>(this IServiceCollection services) where T : class, IJob
        {
            //var buildServiceProvider = services.BuildServiceProvider();
            //var requiredService = buildServiceProvider.GetRequiredService<T>();
            services.AddKeyedSingleton<IJob, T>(typeof(T).Name);

            return services;
        }
    }
}