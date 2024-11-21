using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.Database.Config
{
    /// <summary>
    /// 数据库连接配置
    /// </summary>
    public class DatabaseConnection
    {
        /// <summary>
        /// 数据库名称
        /// </summary>
        public string DbName { get; set; } = string.Empty;

        /// <summary>
        /// 数据库类型
        /// </summary>
        public string DbType { get; set; } = string.Empty;

        /// <summary>
        /// 连接字符串
        /// </summary>
        public string ConnectionString { get; set; } = string.Empty;
    }
}