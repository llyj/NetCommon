using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCommon.Serilog.Config;
using Serilog;
using Serilog.Sinks.MSSqlServer;

namespace NetCommon.Serilog.Database.Extensions
{
    public static class LoggerConfigurationExtensions
    {
        /// <summary>
        /// 输出日志到数据库
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="logToDatabase"><see cref="LogToDatabase"/></param>
        /// <returns></returns>
        public static LoggerConfiguration UseDatabaseSinks(this LoggerConfiguration configuration, LogToDatabase logToDatabase)
        {
            // MySQL 配置
            if (logToDatabase.DbType == DatabaseType.MySQL)
            {
                return configuration.WriteTo.MySQL(logToDatabase.ConnectionString, logToDatabase.LogTableName);
            }

            // SqlServer 配置
            var columnOptions = new ColumnOptions();

            // 去除部分默认列
            //columnOptions.Store.Remove(StandardColumn.MessageTemplate);
            //columnOptions.Store.Remove(StandardColumn.Properties);

            // 添加列
            columnOptions.AdditionalColumns = new List<SqlColumn>()
            {
                new SqlColumn(){ColumnName = "ClientIP",DataType = SqlDbType.NVarChar,DataLength = -1},
                new SqlColumn(){ColumnName = "Application",DataType = SqlDbType.NVarChar,DataLength = 200},
                new SqlColumn(){ColumnName = "UserAgent",DataType = SqlDbType.NVarChar,DataLength = -1},
                new SqlColumn(){ColumnName = "RequestUrl",DataType = SqlDbType.NVarChar,DataLength = 2000},
                new SqlColumn(){ColumnName = "RequestBody",DataType = SqlDbType.NVarChar,DataLength = -1},
            };

            var connectionString = logToDatabase.ConnectionString;

            return configuration
                    .WriteTo
                    .MSSqlServer(connectionString, new MSSqlServerSinkOptions()
                    {
                        TableName = logToDatabase.LogTableName,
                        AutoCreateSqlTable = true
                    }, columnOptions: columnOptions);

            // 日志根据等级分表存储
            //return configuration
            //        .WriteTo.Logger(logger => logger.Filter.ByIncludingOnly(p => p.Level == LogEventLevel.Information).WriteTo
            //            .MSSqlServer(connectionString, new MSSqlServerSinkOptions()
            //            {
            //                TableName = "InfoLog",
            //                AutoCreateSqlTable = true
            //            }))
            //        .WriteTo.Logger(logger => logger.Filter.ByIncludingOnly(p => p.Level == LogEventLevel.Warning).WriteTo
            //            .MSSqlServer(connectionString, new MSSqlServerSinkOptions()
            //            {
            //                TableName = "WarningLog",
            //                AutoCreateSqlTable = true
            //            }))
            //        .WriteTo.Logger(logger => logger.Filter.ByIncludingOnly(p => p.Level == LogEventLevel.Error).WriteTo
            //            .MSSqlServer(connectionString, new MSSqlServerSinkOptions()
            //            {
            //                TableName = "ErrorLog",
            //                AutoCreateSqlTable = true
            //            }));
        }
    }
}