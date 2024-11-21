using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using EasyBom.DataCenter.HttpApi.Config;
using EasyBom.DataCenter.HttpApi.IApi;
using EasyBom.DataCenter.HttpApi.Provider;
using Microsoft.Extensions.DependencyInjection;

namespace EasyBom.DataCenter.HttpApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 注册所有数据中心接口
        /// </summary>
        /// <param name="services"></param>
        /// <param name="easyBomConfig">数据中心配置</param>
        /// <returns></returns>
        public static IServiceCollection AddAllDataCenterApi(this IServiceCollection services, EasyBomConfig easyBomConfig)
        {
            services.AddEasyBomCommonHttpApi(easyBomConfig);
            services.AddEasyBomHttpApi<IDataCenterPriceApi>(easyBomConfig);
            services.AddEasyBomHttpApi<IDataCenterProductApi>(easyBomConfig);
            services.AddEasyBomHttpApi<IDataCenterSearchPageApi>(easyBomConfig);

            return services;
        }

        /// <summary>
        /// 注册 EasyBom 数据中心接口服务
        /// </summary>
        /// <param name="services"></param>
        /// <param name="easyBomConfig">数据中心配置</param>
        /// <returns></returns>
        public static IServiceCollection AddEasyBomHttpApi<THttpApi>(this IServiceCollection services, EasyBomConfig easyBomConfig) where THttpApi : class
        {
            services.AddHttpApi<THttpApi>().ConfigureHttpApi(options =>
            {
                options.HttpHost = new Uri(easyBomConfig.host);
            });

            services.AddTokenProvider<THttpApi, DataCenterTokenProvider>();

            return services;
        }

        /// <summary>
        /// 注册 EasyBom 数据中心接口公共服务
        /// </summary>
        /// <param name="services"></param>
        /// <param name="easyBomConfig">数据中心配置</param>
        /// <returns></returns>
        public static IServiceCollection AddEasyBomCommonHttpApi(this IServiceCollection services, EasyBomConfig easyBomConfig)
        {
            // 全局配置
            services.AddWebApiClient().ConfigureHttpApi(options =>
            {
                options.UseDefaultUserAgent = false;
                options.JsonSerializeOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                options.JsonDeserializeOptions.PropertyNamingPolicy = null;
                options.KeyValueSerializeOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            });

            services.AddHttpApi<IAuthenticationApi>().ConfigureHttpApi(options =>
            {
                options.HttpHost = new Uri(easyBomConfig.host);
            });

            return services;
        }
    }
}