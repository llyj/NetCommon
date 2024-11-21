using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using NetCommon.Database.Config;
using NetCommon.Database.Util;
using SqlSugar;

namespace NetCommon.Database.SqlSugar
{
    public static class SqlSugarServiceCollectionExtensions
    {
        /// <summary>
        /// 注册 SqlSugar 服务
        /// </summary>
        /// <param name="service"></param>
        /// <param name="databaseConnections"></param>
        /// <returns></returns>
        public static IServiceCollection AddSqlSugar(this IServiceCollection service, List<DatabaseConnection> databaseConnections)
        {
            service.AddTransient<ISqlSugarClient>(s =>
            {
                var connectionConfigs = databaseConnections.Select(conn => new ConnectionConfig()
                {
                    ConfigId = conn.DbName,
                    DbType = conn.DbType.Type(),
                    ConnectionString = conn.ConnectionString,
                    IsAutoCloseConnection = true
                }).ToList();

                var sqlSugarClient = new SqlSugarClient(connectionConfigs, db =>
                {
                    databaseConnections.ForEach(d =>
                    {
                        db.GetConnection(d.DbName).Aop.OnLogExecuting = (sql, pars) =>
                        {
                            //Console.WriteLine(sql);
                        };
                    });
                });

                return sqlSugarClient;
            });

            return service;
        }
    }
}