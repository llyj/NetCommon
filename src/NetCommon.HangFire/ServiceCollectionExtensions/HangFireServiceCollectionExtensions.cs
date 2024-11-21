using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangfire;
using Hangfire.MySql;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCommon.HangFire.Enum;
using NetCommon.HangFire.IoC;

namespace NetCommon.HangFire.ServiceCollectionExtensions
{
    public static class HangFireServiceCollectionExtensions
    {
        /// <summary>
        /// 注册 Hangfire 客户端服务
        /// </summary>
        /// <param name="service"></param>
        /// <param name="jobStorageLocation">Hangfire存储位置</param>
        /// <param name="connectionString">连接字符串</param>
        /// <returns></returns>
        public static IServiceCollection AddHangFireClient(this IServiceCollection service, JobStorageLocation jobStorageLocation, string connectionString)
        {
            service.AddHangfire((provider, config) =>
            {
                config
                    .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
                    .UseSimpleAssemblyNameTypeSerializer()
                    .UseRecommendedSerializerSettings()
                    //.UseFilter(provider.)
                    .UseActivator(new HangfireActivator(provider));

                if (jobStorageLocation == JobStorageLocation.MySQL)
                {
                    config.UseStorage(new MySqlStorage(connectionString, new MySqlStorageOptions()
                    {
                    }));
                }
                else
                {
                    config.UseSqlServerStorage(connectionString, new SqlServerStorageOptions()
                    {
                        //SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                        //QueuePollInterval = TimeSpan.FromMinutes(3)
                    });
                }
            });

            return service;
        }

        /// <summary>
        /// 注册 Hangfire 服务
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        public static IServiceCollection AddHangFireService(this IServiceCollection service)
        {
            service.AddHangfireServer(options =>
            {
                // 任务排程轮询时间间隔
                options.SchedulePollingInterval = TimeSpan.FromMinutes(1);
                // 配置任务并行执行数
                options.WorkerCount = 5;
            });

            return service;
        }

        public static IApplicationBuilder UseHangFire(this IApplicationBuilder app)
        {
            // 添加依赖注入
            //GlobalConfiguration.Configuration.UseActivator(new HangfireActivator(app.ApplicationServices));

            app.UseHangfireDashboard();

            return app;
        }
    }
}