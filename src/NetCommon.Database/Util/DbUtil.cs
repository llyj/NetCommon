using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.Database.Util
{
    public static class DbUtil
    {
        private static Dictionary<string, DbType> dbDic = new Dictionary<string, DbType>()
        {
            { "SqlServer", DbType.SqlServer},
            { "Oracle", DbType.Oracle},
            { "MySql", DbType.MySql},
        };

        /// <summary>
        /// 转换类型
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static DbType Type(this string typeName)
        {
            return dbDic.ContainsKey(typeName) ? dbDic[typeName] : DbType.SqlServer;
        }
    }
}