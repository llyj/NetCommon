using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeRedis;

namespace NetCommon.FreeRedis.Config
{
    public class RedisConfig
    {
        /// <summary>
        /// 连接字符串
        /// <para><see href="https://github.com/2881099/FreeRedis?tab=readme-ov-file#-quick-start"></see></para>
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Json序列化配置
        /// </summary>
        public Func<object, object>? JsonSerialize { get; set; }

        /// <summary>
        /// Json反序列化配置
        /// </summary>
        public Func<string, Type, object>? JsonDeserialize { get; set; }
    }
}