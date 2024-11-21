using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.Serilog.Config
{
    public class LoggerConfig
    {
        public LogToDatabase? LogToDatabase { get; set; }

        public LogToElasticSearch? LogToElasticSearch { get; set; }
        public bool IsOutputToFile { get; set; }
    }

    /// <summary>
    /// 日志存到ElasticSearch
    /// </summary>
    public class LogToElasticSearch
    {
        /// <summary>
        /// ElasticSearch 主机地址
        /// </summary>
        public string HostUrl { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>

        public string Password { get; set; }

        /// <summary>
        /// 数据流类型
        /// </summary>
        public string DataStreamType { get; set; }

        /// <summary>
        /// 数据流数据集
        /// </summary>

        public string DataStreamDataSet { get; set; }

        /// <summary>
        /// 数据流命名空间
        /// </summary>
        public string DataStreamNameSpace { get; set; }
    }

    public class LogToDatabase
    {
        /// <summary>
        /// 日志表名
        /// </summary>
        public string? LogTableName { get; set; }

        /// <summary>
        /// 数据库类型(SqlServer/MySQL/PostgreSQL)
        /// </summary>
        public DatabaseType DbType { get; set; }

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public string ConnectionString { get; set; }
    }

    public enum DatabaseType
    {
        /// <summary>
        /// SqlServer
        /// </summary>
        [Description("SqlServer")]
        SqlServer = 1,

        /// <summary>
        /// MySQL
        /// </summary>
        [Description("MySQL")]
        MySQL = 2,

        /// <summary>
        /// PostgreSQL
        /// </summary>
        [Description("PostgreSQL")]
        PostgreSQL = 3
    }
}