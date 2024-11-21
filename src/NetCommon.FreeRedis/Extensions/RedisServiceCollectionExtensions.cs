using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FreeRedis;
using FreeRedis.Internal;
using Microsoft.Extensions.DependencyInjection;
using NetCommon.FreeRedis.Config;
using NetCommon.Redis;

namespace NetCommon.FreeRedis.Extensions
{
    public static class RedisServiceCollectionExtensions
    {
        /// <summary>
        /// 注册 FreeRedis 服务
        /// </summary>
        /// <param name="service"></param>
        /// <param name="redisConfig"></param>
        /// <returns></returns>
        public static IServiceCollection AddFreeRedis(this IServiceCollection service, RedisConfig redisConfig)
        {
            var redisClient = new RedisClient(redisConfig.ConnectionString);

            if (redisConfig.JsonSerialize is not null)
            {
                redisClient.Serialize = redisConfig.JsonSerialize;
            }

            if (redisConfig.JsonDeserialize is not null)
            {
                redisClient.Deserialize = redisConfig.JsonDeserialize;
            }

            // 注册 Redis客户端
            service.AddSingleton(redisClient);

            // 注册 Redis仓储
            service.AddSingleton<IRedisRepository, RedisRepository>();

            return service;
        }
    }
}