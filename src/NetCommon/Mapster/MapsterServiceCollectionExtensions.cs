using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;

namespace NetCommon.Mapster
{
    public static class MapsterServiceCollectionExtensions
    {
        /// <summary>
        /// 注册 Mapster 服务
        /// </summary>
        /// <param name="services"></param>
        /// <param name="registerAssembly">注册文件所在的程序集</param>
        /// <returns></returns>
        public static IServiceCollection AddMapster(this IServiceCollection services, Assembly[] registerAssembly)
        {
            var typeAdapterConfig = new TypeAdapterConfig();
            typeAdapterConfig.Scan(registerAssembly);

            services.AddSingleton(typeAdapterConfig);
            services.AddSingleton<IMapper, ServiceMapper>();

            return services;
        }
    }
}